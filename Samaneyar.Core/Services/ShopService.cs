using System.Collections.Generic;
using System.IO;
using System.Linq;
using Samaneyar.Core.Application;
using Samaneyar.Core.Services.Interface;
using Samaneyar.Core.ViewModels.Shop.Product;
using Samaneyar.Core.ViewModels.Shop.ProductCategory;
using Samaneyar.DataLayer;
using Samaneyar.DataLayer.ApplicationDomain;
using Samaneyar.DataLayer.Shop.ProductAgg;
using Samaneyar.DataLayer.Shop.ProductCategory;

namespace Samaneyar.Core.Services
{
   public class ShopService:IShopService
    {
        private readonly SamaneyarContext _context;
        private readonly IFileUploader _fileUploader;

        public ShopService(SamaneyarContext context, IFileUploader fileUploader)
        {
            _context = context;
            _fileUploader = fileUploader;
        }
        public OperationResult CreateProduct(CreateProductViewModel command)
        {
            var operation = new OperationResult();

         

            var product = new Product(command.Name, command.Title, command.Picture, command.PictureTitle,
                command.PictureAlt, command.Description1, command.Video1, command.Keywords, command.Video2,
                command.VideoTitle, command.Description2, command.Description3, command.Slug.Slugify(), command.MetaDescription);

            if (product.Name == command.Name) return operation.Faild(ApplicationMessage.Duplicated);

            _context.Products.Add(product);
            _context.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult EditProduct(EditProductViewModel command)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> SearchProduct(ProductSearchModel searchModel)
        {
            var query= _context.Products.Select(x => new ProductViewModel
            {
                Name = x.Name,
                Picture = x.Picture,
                Id=x.Id,
               
                CreationDate = x.CreationDate.ToFarsi(),
            }).ToList();

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name == searchModel.Name).ToList();

            if (searchModel.CategoryId != 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId).ToList();

            return query;
        }

        public EditProductViewModel GetDetailsProduct(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductCategoryViewModel> SelectProductCategory()
        {
            return _context.ProductCategories.Select(x => new ProductCategoryViewModel()
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }

        public OperationResult CreateProductCategory(CreateCategoryViewModel command)
        {
            var operation = new OperationResult();

            var productCategory = new ProductCategory(command.Name, command.Description, command.Picture,
                command.PictureTitle, command.PictureAlt, command.Keywords, command.MetaDescription, command.Slug);
            if (productCategory.Name == command.Name) return operation.Faild(ApplicationMessage.Duplicated);

            _context.ProductCategories.Add(productCategory);
            _context.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult EditProductCategory(EditProductCategoryViewModel command)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductCategoryViewModel> SearchProductCategory(SearchCategoryViewModel searchModel)
        {
            var query = _context.Products.Select(x => new ProductCategoryViewModel
            {
                Name = x.Name,
                Picture = x.Picture,
                Id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
            }).ToList();

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name == searchModel.Name).ToList();

            return query;
        }

        public EditProductCategoryViewModel CategoryGetGetDetails(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
