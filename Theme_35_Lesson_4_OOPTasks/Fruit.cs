
namespace Theme_35_Lesson_4_OOPTasks
{
    public class Fruit: Product
    {
        public double SugarAmount { get; set; }

        public Fruit()
        {

        }

        public Fruit(string name, decimal price, string seller, double sugar):base(name, price, seller)
        {
            SugarAmount = sugar;
        }
    }
}
