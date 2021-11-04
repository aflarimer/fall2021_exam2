using System;

namespace fall2021_exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza[] myPizzas = new Pizza[50];

            PizzaFile pizzaFile = new PizzaFile(myPizzas);
    
            //this is your method for populating the array
            myPizzas = pizzaFile.ReadAllPizzas();
            myPizzas = pizzaFile.AddPizza(); //this is weird and not working
        

            PizzaReport pizzaReport = new PizzaReport(myPizzas);
            pizzaReport.PrintAll();
 
        }
    }
}
