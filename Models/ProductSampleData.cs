using System.Collections.Immutable;

namespace Demo.Models
{
    public class ProductSampleData
    {
        List<Product> products;

        public ProductSampleData()
        {
            products = new List<Product>();
            products.Add(new Product { Name = "Nature 1", Description = "this is pc about the life", ID = 1, Price = 100, Image = "pexels-joshua-135018.jpg" });
            products.Add(new Product { Name = "Nature 2", Description = "this is pc about the life", ID = 2, Price = 120, Image = "pexels-katja-592077.jpg" });
            products.Add(new Product { Name = "Nature 3", Description = "this is pc about the life", ID = 3, Price = 130, Image = "pexels-irina-iriser-1090972.jpg" });
            products.Add(new Product { Name = "Nature 4", Description = "this is pc about the life", ID = 4, Price = 140, Image = "pexels-irina-iriser-1408221.jpg" });
        }
        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            return products.FirstOrDefault(p=>p.ID==id);
            
        }

    }
}
