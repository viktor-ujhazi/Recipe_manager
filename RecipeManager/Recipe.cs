using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeManager
{
    class Recipe : ICloneable
    {
        public int identifier;
        public string name;
        public List<string> ingredients;

        public int Identifier
        {
            get{ return identifier;}
            set{ identifier = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        
        public Recipe()
        {

        }
        
        public Recipe(int identifier, string name, List<string> ingredients)
        {
            Identifier = identifier;
            Name = name;
            Ingredients = ingredients;
        }

        
        override public string ToString()
        {
            string listOfIngredients = "";
            foreach (var item in ingredients)
            {
                listOfIngredients += item + "\n";
            }
            
            return "Recipe id: " + identifier + "\nRecipe name: " + name + "\nIngredients:\n" + listOfIngredients;
        }

        public object Clone()
        {
            //Recipe r = new Recipe();
            //r.Identifier = identifier;
            //r.Name = name;
            //r.Ingredients = ingredients;
            Recipe r = (Recipe)this.MemberwiseClone();
            return r;
        }
    }

    
}
