using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeManager
{
    class Recipe : ICloneable
    {
        public int Identifier { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        
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
            foreach (var item in Ingredients)
            {
                listOfIngredients += item + "\n";
            }
            
            return "Recipe id: " + Identifier + "\nRecipe name: " + Name + "\nIngredients:\n" + listOfIngredients;
        }

        public object Clone()
        {
            
            Recipe r = (Recipe)this.MemberwiseClone();
            return r;
        }

        public Recipe Deepcopy()
        {
            List<string> copiedIngredients = new List<string>();
            foreach (var item in Ingredients)
            {
                copiedIngredients.Add(item);
            }
            
            
            Recipe deepcopiedRecipe = new Recipe(this.Identifier, this.Name, copiedIngredients);
            return deepcopiedRecipe;
        }
    }

    
}
