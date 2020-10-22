using System;

namespace Prov
{
    public class Book
    {
        public int price= 10; 
        static string name;
        static int rarity= 0; 
        static string category; 
        static int actualValue=0; 
        bool cursed= false; 
        static Random generator= new Random();

        public Book()
        {
            actualValue =generator.Next(10,101);
            rarity = generator.Next(11);
        }
        public void PrintInfo()
        {
            Console.WriteLine(Book.name);
            Console.WriteLine(Book.rarity);
            Console.WriteLine(Book.category);
            Console.WriteLine(price);
            
        }
        //Fixing the following 4 once the other class is created and working
        public int Evaluate(float truePrice)
        {
            price= actualValue*rarity;
            truePrice = (float) (generator.NextDouble() * 1.5);  
        }
        public string GetCategory()
        {
            string[] categoryArray{"Old book", "Treasure map", "Scroll"};
            category= categoryArray[generator.Next(4)]; 
        }
        public string GetName()
        {

        }
        public bool IsCursed()
        {
            
        }


    }

}
