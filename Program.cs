using System;

namespace fall2021_exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza[] myPizzas = new Pizza[50];
            PizzaFile PizzaFile = new PizzaFile(myPizzas);
            myPizzas = PizzaFile.ReadAllPizzas();
            PizzaUtilities PizzaUtil = new PizzaUtilities(myPizzas);
            PizzaReport PizzaReport = new PizzaReport(myPizzas);

            //Read Pizza data from a file and populate array PizzaFile.ReadAllPizzas();

            //Sort the Pizzas by Crust
            PizzaUtil.SortByCrust(); //You can assume this sort works even though you can't see the code

            //Produce the MinLengthByGenre Report
            PizzaReport.MinSizeByCrust();

            //Produce the AvgCost Report 
            PizzaReport.AvgCost();

            //Produce the CombinedCost Report 
            PizzaReport.CombinedCost();
            
            //Sort the Pizzas by name
            PizzaUtil.SortByName();     
        }
    }
}
