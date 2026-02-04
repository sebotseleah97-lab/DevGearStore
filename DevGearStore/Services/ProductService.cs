using DevGearStore.Models;

namespace DevGearStore.Services
{
    public static class ProductService
    {
        public static List<Product> Products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Developer Laptop",
                Category = "Laptop",
                Price = 15000,
                Image = "/images/laptop.jpg"
            },
            new Product
            {
                Id = 2,
                Name = "Mechanical Keyboard",
                Category = "Keyboard",
                Price = 1200,
                Image = "/images/keyboard.jpg"
            },
            new Product
            {
                Id = 3,
                Name = "Wireless Mouse",
                Category = "Mouse",
                Price = 600,
                Image = "/images/mouse.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "Developer Headset",
                Category = "Headset",
                Price = 900,
                Image = "/images/headset.jpg"
            },
            new Product
            {
                Id = 5,
                Name = "External SSD 1TB",
                Category = "Storage",
                Price = 1800,
                Image = "/images/ssd.jpg"
            }
        };
    }
}
