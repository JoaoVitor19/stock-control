﻿namespace Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal InitialPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public string ImagePath { get; set; }
        public int StockQuantity { get; set; }
    }
}
