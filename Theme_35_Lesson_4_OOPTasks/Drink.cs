namespace Theme_35_Lesson_4_OOPTasks
{
    public class Drink:Product
    {
        public bool IsGas { get; set; }


        public Drink()
        {

        }

        public Drink(string name, decimal price, string seller, bool isGas) : base(name, price, seller)
        {
            IsGas = isGas;
        }
    }
}
