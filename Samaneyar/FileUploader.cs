using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Samaneyar.Core.Application;

namespace Samaneyar
{
    public interface IFileUploader
    {
        string Upload(IFormFile file, string path);
    }

    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string Upload(IFormFile file, string path)
        {
            if (file == null) return "";
            var pathDirectory = $"{_webHostEnvironment.WebRootPath}//FileUploader//{path}";
            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);


            var fileName = $"{DateTime.Now.ToFileName()}-{file.FileName}";
            var filePath = $"{pathDirectory}//{fileName}";

            using var stream = System.IO.File.Create(filePath);
            file.CopyTo(stream);

            return $"{path}/{fileName}";


        }
    }
}
