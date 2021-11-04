using System;

namespace fall2021_exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza[] myPizzas = new Pizza[10];

            PizzaFile pizzaFile = new PizzaFile(myPizzas);
    
            //this is your method for populating the array
            myPizzas = pizzaFile.ReadAllPizzas();
            myPizzas = pizzaFile.AddPizza(); //this is weird and not working
    
            //myPizzas[0].SetPizzaType("Cheese");
            //pizzaFile.WriteAllPizzas();

            PizzaReport pizzaReport = new PizzaReport(myPizzas);
            pizzaReport.PrintAll();
            // System.Console.WriteLine("\n");
            // //pizzaReport.TotalMinutesByPizzaType(); 
            // System.Console.WriteLine("Enter customer name");
            // string custName = Console.ReadLine();
            // int found = pizzaReport.SearchByCustomerName(custName);
            // if (found == 0) {
            //     System.Console.WriteLine("Found the order!");
            // }
            // else {
            //     System.Console.WriteLine("Did not find!");
            // }
        }
    }
}
