using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Samaneyar.Core.Services.Interface;
using Samaneyar.Core.ViewModels.Shop.Product;

namespace Samaneyar.Areas.Administration.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {
        public List<ProductViewModel> Products { get; set; }
        public ProductSearchModel SearchModel { get; set; }
        public SelectList SelectProductCategory;

        private readonly IShopService _shop;

        public IndexModel(IShopService shop)
        {
            _shop = shop;
        }
        public void OnGet(ProductSearchModel searchModel)
        {
            SelectProductCategory = new SelectList(_shop.SelectProductCategory(), "Id", "Name");
            Products = _shop.SearchProduct(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductViewModel { Categories = _shop.SelectProductCategory() };

            return Partial("./Create", command);
        }


        public JsonResult OnPostCreate(CreateProductViewModel command)
        {
            var result = _shop.CreateProduct(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var getDetails = _shop.GetDetailsProduct(id);
            getDetails.Categories = _shop.SelectProductCategory();
            return Partial("Edit", getDetails);
        }

        public JsonResult OnPostEdit(EditProductViewModel edit)
        {
            var productCategory = _shop.EditProduct(edit);
            return new JsonResult(productCategory);
        }
    }
}
