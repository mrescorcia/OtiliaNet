using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtiliaNet.OtiliaNet_ENT
{
    public class Product_ENT
    {
        private string NameProduct;
        private string DescProduct;

        public int idProduct {
            get => 1;
        }
        public string nameProduct 
        { 
            get => NameProduct;
            set => NameProduct = value; 
        }
        public string descProduct 
        {
            get => DescProduct;  
            set => DescProduct = value;
        }
    }
}
