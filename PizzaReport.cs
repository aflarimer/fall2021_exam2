namespace fall2021_exam2
{
    public class PizzaReport
    {
        private Pizza[] myPizzas;
        public PizzaReport(Pizza[] myPizzas)
        {
            this.myPizzas = myPizzas; 
        }
        // public void TotalMinutesByPizzaType()
        // {
        //     double sum = myPlayers[0].GetAverage();
        //     int count = 1;
        //     string currTeam = myPlayers[0].GetTeam();
        //     for (int i = 1; i < Player.GetCount(); i++) {
        //         if (myPlayers[i].GetTeam() == currTeam) {
        //             sum += myPlayers[i].GetAverage();
        //             count++;
        //         }
        //         else {
        //             ProcessBreak(ref currTeam, ref sum, ref count, i);
        //         }
        //     }
        //     ProcessBreak(ref currTeam, ref sum, ref count, 0);
        // }
        // public int SearchByCustomerName(string searchVal) 
        // {
        // //your code for sequential search
        // }

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