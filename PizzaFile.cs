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
                int cost = int.Parse(data[4]);
                Pizza temp = new Pizza(data[0],data[1],data[2],minutes,cost);
                myPizzas[Pizza.GetCount()] = temp;
                Pizza.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
            return myPizzas;
        }
        // public void WriteAllPizzas()  //question 3 //need to talk about this cause append mode
        // {
        //     //your code here
        // }
        public Pizza[] AddPizza(){ //question 2 //return pizza array?
            System.Console.WriteLine("Enter the customer name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the pizza type");
            string type = Console.ReadLine();
            System.Console.WriteLine("Enter the Size");
            string size = Console.ReadLine();
            System.Console.WriteLine("Enter the minutes");
            int minutes = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the cost");
            int cost = int.Parse(Console.ReadLine());

            Pizza.IncCount();//either or with the + 1

            Pizza temp = new Pizza(name, type, size, minutes, cost);
            myPizzas[Pizza.GetCount()] = temp;
            return myPizzas;
        }

    }
}