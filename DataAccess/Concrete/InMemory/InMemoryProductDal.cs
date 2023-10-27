using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
  public  class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Kitap",UnitPrice=15,UnitsInStock=10} ,
                new Product{CategoryId=2,ProductId=2,ProductName="Bardak",UnitPrice=500,UnitsInStock=100},
                new Product{CategoryId=3,ProductId=3,ProductName="Bilgisayar",UnitPrice=1500,UnitsInStock=32},
                new Product{CategoryId=4,ProductId=1,ProductName="Kalem",UnitPrice=150,UnitsInStock=45},
                new Product{CategoryId=5,ProductId=2,ProductName="Masa",UnitPrice=600,UnitsInStock=25},
                new Product{CategoryId=6,ProductId=3,ProductName="Fare",UnitPrice=400,UnitsInStock=20}
            };


        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product ProductToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(ProductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.ProductId = product.ProductId;
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
