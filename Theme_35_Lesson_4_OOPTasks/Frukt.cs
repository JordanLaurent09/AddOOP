namespace Theme_35_Lesson_4_OOPTasks
{
    public class Frukt:IFruitlikeness
    {
        public double SugarQuantity { get; set; }

        public decimal Price { get; set; }

        public Frukt(double sugar, decimal price)
        {
            SugarQuantity = sugar;
            Price = price;
        }
    }
}
