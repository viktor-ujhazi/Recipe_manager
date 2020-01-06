using System;
using System.Collections.Generic;

namespace RecipeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ing1 = new List<string> 
            { "ingredient 1_1",
              "ingredient 1_2" };
            ing1.Add("ingredient 1_3");
            ing1.Add("ingredient 1_4");
            Recipe r1 = new Recipe(1, "1. recipe", ing1);
            Console.WriteLine(r1);

            List<string> ing2 = new List<string> 
            { "ingredient 2_1", "ingredient 2_2" };
            Recipe r2 = new Recipe(2, "2. recipe", ing2);
            Console.WriteLine(r2);

            List<string> ing3 = new List<string> 
            { "ingredient 3_1", "ingredient 3_2" };
            Recipe r3 = new Recipe(3, "3. recipe", ing3);
            Console.WriteLine(r3);

            List<string> ing4 = new List<string> 
            { "ingredient 4_1", "ingredient 4_2" };
            Recipe r4 = new Recipe(4, "4. recipe", ing4);
            Console.WriteLine(r4);

            List<string> ing5 = new List<string> 
            { "ingredient 5_1", "ingredient 5_2" };
            Recipe r5 = new Recipe(5, "5. recipe", ing5);
            Console.WriteLine(r5);

            Recipe r6 = (Recipe)r1.Clone();
            Recipe r7 = (Recipe)r2.Clone();
            Recipe r8 = (Recipe)r3.Clone();
            
            r6.name = "r6";
            r6.ingredients.Add("ingredient 6_1");
            r6.ingredients.Remove("ingredient 1_1");
            r7.name = "r7";
            r8.name = "r8";

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);

            Console.WriteLine(r6);
            Console.WriteLine(r7);
            Console.WriteLine(r8);
            
        }
    }
}
