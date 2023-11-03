using System.Threading.Channels;

namespace TasksFurtherWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Task one = Task.Run(() => { Console.WriteLine("This is the first"); });
            
            Task two = Task.Run(() => { Console.WriteLine("This is the second"); });
            
            Task three = Task.Run(() => { Console.WriteLine("This is the three"); });
            one.Wait();
            two.Wait();
            three.Wait();

            // 2

            Task first = Task.Run(() => { Console.WriteLine(Factorial(23));});

            first.Wait();


            // Создаем МАССИВ задач

            Random random = new Random();
            Task[] tasks = new Task[5];

            for(int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => { Console.WriteLine(Factorial(random.Next(10, 17))); });
                    
            }
            Task.WaitAll(tasks);
        }

        public static int Factorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}