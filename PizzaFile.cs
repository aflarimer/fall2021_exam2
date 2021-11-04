using System;
using System.IO;
namespace fall2021_exam2

{
    public class PizzaFile
    {
        private Pizza[] myPizzas;
        
        public PizzaFile(Pizza[] myPizzas)
        {
            this.myPizzas = myPizzas; 
        }
        public Pizza[] ReadAllPizzas() //question 1
        {
            StreamReader inFile = new StreamReader("pizzas.txt");
            string line = inFile.ReadLine();
            Pizza.SetCount(0);
            while(line != null) {
                string[] data = line.Split('#');
                int minutes = int.Parse(data[3]);
                int salePrice = int.Parse(data[4]);
                int costToMake = int.Parse(data[5]);
                int profit = salePrice - costToMake;
                Pizza temp = new Pizza(data[0],data[1],data[2],minutes,salesPrice,costToMake, profit);
                myPizzas[Pizza.GetCount()] = temp;
                Pizza.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
            return myPizzas;
        }
        public void WriteAllPizzas()  //question 3
        {
            StreamWriter outFile = new StreamWriter("pizzas.txt");
            for(int i = 0; i < Pizza.GetCount(); i++) {
                outFile.WriteLine(myPizzas[i].Delimited());
            }
            outFile.Close();
        }
        public Pizza[] AddPizza(){ //question 2
            System.Console.WriteLine("Enter the customer name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the pizza type");
            string type = Console.ReadLine();
            System.Console.WriteLine("Enter the Size");
            string size = Console.ReadLine();
            System.Console.WriteLine("Enter the minutes");
            int minutes = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the sales price");
            int salePrice = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the cost to make");
            int costToMake = int.Parse(Console.ReadLine());
            int profit = salePrice - costToMake; //had to calc profit since its in the constructor

            Pizza temp = new Pizza(name, type, size, minutes, salePrice, costToMake, profit);
            myPizzas[Pizza.GetCount()] = temp; 
            return myPizzas;
        }

    }
}