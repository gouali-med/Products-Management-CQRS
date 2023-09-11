using System;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? BarCode { get; set; }
        public byte[]? Picture { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category? Categorie { get; set; }
      
    }

}
