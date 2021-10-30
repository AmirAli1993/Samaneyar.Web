using Samaneyar.Core.ViewModels.Shop.ProductCategory;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Samaneyar.Core.ViewModels.Shop.Product
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureTitle { get; set; }
        public string PictureAlt { get; set; }
        public string Description1 { get; set; }
        public string Video1 { get; set; }
        public string Keywords { get; set; }
        public string Video2 { get; set; }
        public string VideoTitle { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public long CategoryId { get; set; }
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}