using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind;
using KendoJSGrid.Models;
using AutoMapper;
using System.Data.Entity;

namespace KendoJSGrid.Services
{
    public class CatalogServices : ICatalogService
    {

        // Category Transactions

        // Read
        public IEnumerable<CategoryViewModel> getCategories()
        {
            using (var context = new NORTHWNDEntities())
            {             
                IList<Category> result = context.Categories.ToList();
                IList<CategoryViewModel> list = Mapper.Map<IList<Category>, IList<CategoryViewModel>>(result);
                return list.ToList();
            }
        }

        // Create
        public IEnumerable<CategoryViewModel> AddCategory(IEnumerable<CategoryViewModel> categories)
        {
            var result = new List<Category>();

            using (var context = new NORTHWNDEntities())
            {
                foreach (var categoryViewModel in categories)
                {
                    Category category = new Category();
                    Mapper.Map(categoryViewModel, category);

                    result.Add(category);

                    context.Categories.Add(category);
                }

                context.SaveChanges();

                return result.Select(p => new CategoryViewModel
                {
                    CategoryID = p.CategoryID,
                    CategoryName = p.CategoryName,
                    Description = p.Description
                }).ToList();
            }
        }

        // Update
        public void UpdateCategory(IEnumerable<CategoryViewModel> categories)
        {
            using (var context = new NORTHWNDEntities())
            {
                foreach (var categoryViewModel in categories)
                {
                    Category category = new Category();
                    Mapper.Map(categoryViewModel, category);

                    context.Categories.Attach(category);
                    context.Entry(category).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        // Delete
        public void RemoveCategory(IEnumerable<CategoryViewModel> categories)
        {
            using (var context = new NORTHWNDEntities())
            {
                foreach (var categoryViewModel in categories)
                {
                    Category category = new Category();
                    Mapper.Map(categoryViewModel, category);

                    context.Categories.Attach(category);
                    context.Categories.Remove(category);
                }

                context.SaveChanges();
            }
        }


        // Supplier Transactions

        // Read
        public IEnumerable<SupplierViewModel> getSuppliers()
        {
            using (var context = new NORTHWNDEntities())
            {
                IList<Supplier> result = context.Suppliers.ToList();
                IList<SupplierViewModel> list = Mapper.Map<IList<Supplier>, IList<SupplierViewModel>>(result);
                return list.ToList();
            }
        }

        // Create
        public SupplierViewModel AddSupplier(SupplierViewModel supplierVM)
        {
            using (var context = new NORTHWNDEntities())
            {
                Supplier supplier = new Supplier();
                Mapper.Map(supplierVM, supplier);

                context.Suppliers.Add(supplier);
                context.SaveChanges();
                return supplierVM;
            }
        }

        // Update
        public SupplierViewModel UpdateSupplier(SupplierViewModel supplierVM)
        {
            using (var context = new NORTHWNDEntities())
            {
                Supplier supplier = new Supplier();
                Mapper.Map(supplierVM, supplier);

                context.Entry(supplier).State = EntityState.Modified;
                context.SaveChanges();
                return supplierVM;
            }
        }

        // Get Supplier
        public SupplierViewModel getSupplier(int id)
        {
            using (var context = new NORTHWNDEntities())
            {
                Supplier supplier = context.Suppliers.Find(id);
                SupplierViewModel viewid = Mapper.Map<Supplier, SupplierViewModel>(supplier);
                return viewid;
            }
        }


        // Product Transactions

        // Read
        public IEnumerable<ProductViewModel> getProducts()
        {
            using (var context = new NORTHWNDEntities())
            {
                IList<Product> result = context.Products.ToList();
                IList<ProductViewModel> list = Mapper.Map<IList<Product>, IList<ProductViewModel>>(result);
                return list.ToList();
            }
        }

        // Create
        public ProductViewModel AddProduct(ProductViewModel productVM)
        {
            using (var context = new NORTHWNDEntities())
            {
                Product product = new Product();
                Mapper.Map(productVM, product);

                context.Products.Add(product);
                context.SaveChanges();
                return productVM;
            }
        }

        // Update
        public ProductViewModel UpdateProduct(ProductViewModel productVM)
        {
            using (var context = new NORTHWNDEntities())
            {
                Product product = new Product();
                Mapper.Map(productVM, product);

                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
                return productVM;
            }
        }

        // Delete
        public void DeleteProduct(int id)
        {
            using (var context = new NORTHWNDEntities())
            {
                Product product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }


    }
}