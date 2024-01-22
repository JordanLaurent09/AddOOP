namespace Theme_36_ConsoleShop_V2
{
    public class Program
    {       
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.Start(shop.Goods);
        }       
    }
}