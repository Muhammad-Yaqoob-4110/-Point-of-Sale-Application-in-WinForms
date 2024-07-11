using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilingSystemGUI.BL
{
    public class productC_BL
    {
        private string name;
        private float price;
        private float discount;
        private float quantity;

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public float Discount { get => discount; set => discount = value; }
        public float Quantity { get => quantity; set => quantity = value; }

        public productC_BL(string name, float price, float discount)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
        }
        public productC_BL()
        {
        }
    }
}
