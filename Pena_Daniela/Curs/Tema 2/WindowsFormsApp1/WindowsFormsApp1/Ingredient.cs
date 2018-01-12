using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ingredient
    {
        public Ingredient(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }

        public float getPrice()
        {
            return price;
        }
        public Ingredient() { }

        private string name;
        private float price;
    }
}
