using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pizza
    {
        private string name;
        private float price;
        List<Ingredient> ingredients = new List<Ingredient>();

        public Pizza()
        {

        }

        public Pizza(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public Pizza(string name, float price, List<Ingredient> ingredients)
        {
            this.name = name;
            this.price = price;
            this.ingredients = ingredients;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public void addToPrice(float p)
        {
            price += p;
        }

        public string ingredientsToString()
        {
            string text = "";

            foreach (var ingr in ingredients)
            {
                text += ingr.getName() + " ";
            }

            return text;
        }


        public List<Ingredient> getIngredients()
        {
            return ingredients;
        }

        public void setIngredients(List<Ingredient> list)
        {
            ingredients.AddRange(list);
        }

        public void addIngredient(Ingredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }

        public void removeIngredient(Ingredient ingredient)
        {
            this.ingredients.Remove(ingredient);
        }

        public override string ToString()
        {
            return price.ToString() + "   " + name;
        }
    }
}
