using GraphQLBeginner.Interfaces;
using GraphQLBeginner.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLBeginner.Services
{
     
    public class ProductService : IProduct 
    {
        private static List<Product> products = new List<Product>()
        {
            new Product() { Id = 0, Name="Coffee",  Price=10},
            new Product() { Id = 1, Name="Tea",  Price=20},
            new Product() { Id = 2, Name="Cold Drinks",  Price=30}
        };
        
        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products.ToList();
        }

        public Product GetProductById(int id)
        {
            return products.Find(x => x.Id == id);
            //return (products[id] as Product);
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
        }
    }
}
