using System;
using System.Collections.Generic;

namespace Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public byte[]? Picture { get; set; }
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }

}
