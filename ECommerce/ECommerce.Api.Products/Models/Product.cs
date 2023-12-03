﻿namespace ECommerce.Api.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InventoryData { get; set; }  
    }
}
