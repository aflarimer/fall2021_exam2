using System;
namespace fall2021_exam2
{
    public class PizzaReport
    {
        private Pizza[] myPizzas;
        public PizzaReport(Pizza[] myPizzas)
        {
            this.myPizzas = myPizzas; 
        }
        public void TotalMinutesByPizzaType()
        {
            double sum = myPizzas[0].GetMinutesToMake();
            int count = 1;
            string currType = myPizzas[0].GetPizzaType();
            for (int i = 1; i < Pizza.GetCount(); i++) {
                if (myPizzas[i].GetPizzaType() == currType) {
                    sum += myPizzas[i].GetMinutesToMake();
                    count++;
                }
                else {
                    ProcessBreak(ref currType, ref sum, ref count, i);
                }
            }
            ProcessBreak(ref currType, ref sum, ref count, 0);
        }
        private void ProcessBreak(ref string currType, ref double sum, ref int count, int i) {
            Console.WriteLine($"The total minutes to cook all {currType} pizzas is {sum} minutes.");
            currType = myPizzas[i].GetPizzaType();
            sum = myPizzas[i].GetMinutesToMake();
            count = 1;
        }
        public int SearchByCustomerName(string searchVal) 
        {
            int foundIndex = -1;
            for(int i = 0; i < Pizza.GetCount(); i++) {
                if (myPizzas[i].GetCustName() == searchVal){
                    foundIndex = 0;
                }
            }
            return foundIndex;
        }

        public void HighLowProfitDay() { //control break with range bonus
            int[] sumArray = new int[7];
            for (int i = 0; i < Pizza.GetCount(); i++) {
                //need to write this
            }
        }

        // public void SortByPizzaType() {
        //     //assume this works!!
        // }

        public void PrintAll(){
            foreach (Pizza pizza in myPizzas) {
                System.Console.WriteLine(pizza.GetCustName());
            }
        }
    }
}