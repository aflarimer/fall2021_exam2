namespace fall2021_exam2
{
    public class Pizza
    {
        private string name; 
        private int size; 
        private string crust; 
        private int cost; 
        private static int count;
        public Pizza()
        {
        }
        public Pizza(string name, int size, string crust, int cost) {
            this.name = name; 
            this.size = size; 
            this.crust = crust; 
            this.cost = cost;
        }
        public string GetName() {
            return name;
        }
        public void SetName(string name) {
            this.name = name;
        }
        public int GetSize() {
            return size;
        }
        public void SetSize(int size) {
            this.size = size; 
        }
        public string GetCrust()
        {
            return crust;
        }
        public void SetCrust(string crust)
        {
            this.crust = crust; 
        }
        public int GetCost()
        {
            return cost;
        }
        public void SetCost(int cost)
        {
        this.cost = cost; }
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
            return name.CompareTo(myPizza.GetName());
        }

        public override string ToString() {
            return name + "\t" + size + "\t" + crust + "\t" + cost;
        }
    }
}