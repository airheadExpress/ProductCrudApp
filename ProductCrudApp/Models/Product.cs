using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudApp.Models
{
    public class Product
    {
        public  int productId {  get; set; }
        public string productName { get; set; }
        public int quantityInStock {  get; set; }
        public int price { get; set; }
    }
}
