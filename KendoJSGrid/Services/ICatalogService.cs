using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoJSGrid.Models;

namespace KendoJSGrid.Services
{
    public interface ICatalogService
    {
        // Categories
        IEnumerable<CategoryViewModel> getCategories();
        IEnumerable<CategoryViewModel> AddCategory(IEnumerable<CategoryViewModel> categories);
        void UpdateCategory(IEnumerable<CategoryViewModel> categories);
        void RemoveCategory(IEnumerable<CategoryViewModel> categories);

        // Suppliers
        IEnumerable<SupplierViewModel> getSuppliers();
        SupplierViewModel AddSupplier(SupplierViewModel supplierVM);
        SupplierViewModel UpdateSupplier(SupplierViewModel supplierVM);
        SupplierViewModel getSupplier(int id);

        // Products
        IEnumerable<ProductViewModel> getProducts();
        ProductViewModel AddProduct(ProductViewModel productVM);
        ProductViewModel UpdateProduct(ProductViewModel productVM);
        void DeleteProduct(int id);
    }
}
