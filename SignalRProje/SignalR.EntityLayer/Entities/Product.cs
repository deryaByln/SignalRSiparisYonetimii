﻿using SignalR.EntityLayer.Entities;

namespace SignalR.EntiyLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }  //her ürünüjn bir kategorisi olucak
        public Category Category { get; set; }  // bire çok olduğu için category türünde bir categori proportisi alıcskaasın
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}