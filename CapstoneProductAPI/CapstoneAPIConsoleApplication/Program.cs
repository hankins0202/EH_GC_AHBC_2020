using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace CapstoneAPIConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
                var responseTask = httpClient.GetAsync("product");
                responseTask.Wait(50000);

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Product[]>();
                    readTask.Wait();

                    var products = readTask.Result;

                    foreach (var product in products)
                    {
                        Console.WriteLine(product.ProductName);
                    }
                }
            }

            //var response = httpClient.GetAsync("Product").GetAwaiter().GetResult();
            //var productViewJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            //var productView = JsonSerializer.Deserialize<List<string>>(productViewJson);
            //foreach (var product in productViewJson)
            //{
            //    Console.WriteLine(product);
            //}
        }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
