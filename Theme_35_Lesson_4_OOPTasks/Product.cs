namespace Theme_35_Lesson_4_OOPTasks
{
    public  class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public  string Seller { get; set; }

        public Product()
        {

        }

        public Product(string name, decimal price, string seller)
        {
            Name = name;
            Price = price;
            Seller = seller;
        }
    }
}
