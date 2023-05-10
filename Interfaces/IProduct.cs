using GraphQLBeginner.Models;

namespace GraphQLBeginner.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(int id,Product product);
        void DeleteProduct(int id);

    }
}
