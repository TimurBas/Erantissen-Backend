using Erantissen_Backend.Domain.Entities;

namespace Erantissen_Backend.App.Factories
{
    public class ProductFactory
    {
        public static Product CreateProduct(string title,
                                            string description, 
                                            decimal price, 
                                            int quantity, 
                                            string imageUrl, 
                                            Subcategory subcategory)
        {
            var product = new Product(title, price, description, quantity, imageUrl)
            {
                Subcategory = subcategory
            };
            return product;
        }
    }
}
