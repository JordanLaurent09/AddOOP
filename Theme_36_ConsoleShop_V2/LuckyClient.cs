namespace Theme_36_ConsoleShop_V2
{
    public class LuckyClient : Client
    {
        public LuckyClient(string name, int age, decimal balance) : base(name, age, balance * 3)
        {
        }
    }
}
