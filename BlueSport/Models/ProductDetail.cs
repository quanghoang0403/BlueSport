using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class ProductDetail
    {
        public string id { get; set; }
        public string productId { get; set; }
        public Dictionary<string, string> detail { get; set; }
        public Product product { get; set; }
    }
}
