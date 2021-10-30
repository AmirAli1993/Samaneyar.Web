using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Samaneyar.Core.Services.Interface;
using Samaneyar.Core.ViewModels.Shop.ProductCategory;

namespace Samaneyar.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        private readonly IShopService _category;
      
        public List<ProductCategoryViewModel> ProductCategory;
        public SearchCategoryViewModel SearchModel;

        public IndexModel(IShopService category)
        {
            _category = category;
        }

        public void OnGet(SearchCategoryViewModel searchModel)=> ProductCategory = _category.SearchProductCategory(searchModel);
        public IActionResult OnGetCreate()=> Partial("./Create", new CreateCategoryViewModel());
       

        public JsonResult OnPostCreate(CreateCategoryViewModel command)
        {
            var result = _category.CreateProductCategory(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var getDetails = _category.CategoryGetGetDetails(id);
            return Partial("Edit", getDetails);
        }

        public JsonResult OnPostEdit(EditProductCategoryViewModel edit)
        {
            var productCategory = _category.EditProductCategory(edit);
            return new JsonResult(productCategory);
        }

    }
}
