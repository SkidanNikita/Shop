using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopWPF.Classes
{
    public class Power_Supply 
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ModelName { get; set; }
        public double Price { get; set; }
    }
}
