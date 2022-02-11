using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtiliaNet.OtiliaNet_ENT
{
    public class Product_ENT
    {   
        // This properties will be privatised
        public int idProduct { get; } = 1;
        public string nameProduct { get; set; }
        public string descProduct { get; set; }
    }
}
