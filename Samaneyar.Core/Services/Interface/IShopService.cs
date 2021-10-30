using System.Collections.Generic;
using Samaneyar.Core.ViewModels.Shop.Product;
using Samaneyar.Core.ViewModels.Shop.ProductCategory;
using Samaneyar.DataLayer.ApplicationDomain;

namespace Samaneyar.Core.Services.Interface
{
    public interface IShopService
    {
        #region Product

        OperationResult CreateProduct(CreateProductViewModel command);
        OperationResult EditProduct(EditProductViewModel command);
        List<ProductViewModel> SearchProduct(ProductSearchModel searchModel);
        EditProductViewModel GetDetailsProduct(long id);
        List<ProductCategoryViewModel> SelectProductCategory();

        #endregion

        #region Product Category

        OperationResult CreateProductCategory(CreateCategoryViewModel command);
        OperationResult EditProductCategory(EditProductCategoryViewModel command);
        List<ProductCategoryViewModel> SearchProductCategory(SearchCategoryViewModel searchModel);
        EditProductCategoryViewModel CategoryGetGetDetails(long id);

        #endregion

    }
}
