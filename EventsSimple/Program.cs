namespace EventsSimple
{
    
    internal class Program
    {
        public delegate void MyDelegateForEvent(string message);
        public static event MyDelegateForEvent MyEvent;
        static void Main(string[] args)
        {
            int[] numbers = new int[5] {1,2,3,4,5};
           
            MyEvent += (message) => { Console.WriteLine(message); };

            foreach(int item in numbers)
            {
                if(item % 2 == 0)
                {
                    MyEvent?.Invoke("Четное");                    
                }
            }
        }
    }
    
}