namespace fall2021_exam2
{
    public class Pizza
    {
        private string customerName;
        private string pizzaType; 
        private string size; 
        private int minutesToMake;
        private int salesPrice; 
        private int costToMake;
        private static int count;
        public Pizza(string customerName, string pizzaType, string size, int minutesToMake, int salesPrice, int costToMake, int profit) {
            this.customerName = customerName;
            this.pizzaType = pizzaType;
            this.size = size;
            this.minutesToMake = minutesToMake;
            this.salePrice = salePrice;
            this.costToMake = costToMake;
            this.profit = profit;
        }
        public string GetCustName() {
            return customerName;
        }
        public void SetCustName(string customerName) {
            this.customerName = customerName;
        }

        public string GetPizzaType() {
            return pizzaType;
        }

        public void SetPizzaType(string pizzaType) {
            this.pizzaType = pizzaType;
        }
        public string GetSize() {
            return size;
        }
        public void SetSize(string size) {
            this.size = size; 
        }
        public int GetMinutesToMake()
        {
            return minutesToMake;
        }
        public void SetMinutesToMake(int minutesToMake)
        {
            this.minutesToMake = minutesToMake; 
        }
        public int GetSalePrice()
        {
            return salePrice;
        }
        public void SetSalePrice(int salePrice)
        {
            this.salePrice = salePrice; 
        }

        public void GetCostToMake() {
            return costToMake;
        }

        public int SetCostToMake(int costToMake) {
            this.costToMake = costToMake;
        }
        public static int GetProfit() {
            return profit;
        }
        public static void SetProfit(int profit) {
            this.profit = profit;
        }
        public static int GetCount() {
            return count;
        }
        public static void SetCount(int count) {
            Pizza.count = count;
        }
        public static void IncCount() {
            count++; 
        }
        public int CompareTo(Pizza myPizza) {
            return customerName.CompareTo(myPizza.GetCustName());
        }

        public override string ToString() {
            return customerName + "\t\t" + pizzaType + "\t\t" + size + "\t\t" + minutesToMake + "\t\t" + salePrice + "\t\t" + costToMake;
        }

        public string Delimited() {
            return customerName + "#" + pizzaType + "#" + size + "#" + minutesToMake + "#" + salePrice + "#" + costToMake;
        }
    }
}