using Microsoft.AspNetCore.Mvc;
using WebApp69.Models;
namespace WebApp69.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            var Product1 = new Models.Product
            {
                Id = 01,
                Name = "Potato Lay",
                Price = 20.00m,
                Quantity = 100
            };
            var Product2 = new Models.Product
            {
                Id = 02,
                Name = "Coca Cola",
                Price = 30.00m,
                Quantity = 200
            };
            var Product3 = new Models.Product
            {
                Id = 03,
                Name = "Pepsi",
                Price = 25.00m,
                Quantity = 150
            };
            var Product4 = new Models.Product
            {
                Id = 04,
                Name = "Fanta",
                Price = 15.00m,
                Quantity = 250
            };
            var Product5 = new Models.Product
            {
                Id = 05,
                Name = "Sprite",
                Price = 18.00m,
                Quantity = 300
            };
            var Product6 = new Models.Product
            {
                Id = 06,
                Name = "Lays",
                Price = 22.00m,
                Quantity = 120
            };
            var Product7 = new Models.Product
            {
                Id = 07,
                Name = "Oreo",
                Price = 202.00m,
                Quantity = 100
            };
            var Product8 = new Models.Product
            {
                Id = 08,
                Name = "KitKat",
                Price = 202.00m,
                Quantity = 100
            };
            var Product9 = new Models.Product
            {
                Id = 09,
                Name = "M&M's",
                Price = 202.00m,
                Quantity = 100
            };      

            //var Product = new List<Models.Product> { Product1, Product2, Product3, Product4, Product5, Product6, Product7 };
            var products = new List<Models.Product>();
            products.Add(Product1);
            products.Add(Product2);
            products.Add(Product3);
            products.Add(Product4);
            products.Add(Product5);
            products.Add(Product6);
            products.Add(Product7);
            products.Add(Product8);
            products.Add(Product9);


            //return View(Product);
            //var products = new List<Product>();
            //for (int i = 1; i <= 20; i++)
            //{
            //    products.Add(new Product { Id = i, Name = $"Product {i}", Price = 100 * i, Quantity = i });
            //}

            // 2. กำหนดขนาดของ Pagination
            int pageSize = 3; // ต้องการแสดงหน้าละกี่รายการ (เช่น 5 รายการต่อหน้า)
            int totalItems = products.Count;
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // 3. ใช้ LINQ Skip และ Take เพื่อดึงข้อมูลเฉพาะหน้าที่ต้องการ
            var pagedProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // 4. ส่งข้อมูลสำหรับการทำปุ่ม Pagination ไปที่ View
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(pagedProducts);
        }
    }
    
}
