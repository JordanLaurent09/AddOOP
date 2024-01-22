namespace Theme_36_ConsoleShop_V2
{
    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Balance { get; set; }
        public decimal WastedMoney { get; set; }

        public Client(string name, int age, decimal balance)
        {
            Name = name;
            Age = age;
            Balance = balance;
            WastedMoney = 0m;
        }
    }
}
