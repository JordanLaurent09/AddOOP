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

            Task first = Task.Run(() => { Console.WriteLine(Factorial(25));});

            first.Wait();


            // Создаем МАССИВ задач

            Random random = new Random();
            Task[] tasks = new Task[5];

            for(int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => { Console.WriteLine(Factorial(random.Next(10, 17))); });
                    
            }
            Task.WaitAll(tasks);



            Task<int> task = GetResult();
            task.Wait();
            int megaResult = task.Result;
            Console.WriteLine(megaResult);

            Task<int[]> arrTask = GetArrResult();
            //arrTask.Wait();
            int[] megaArray = arrTask.Result;

            for (int i = 0; i < megaArray.Length; i++)
            {
                Console.WriteLine(megaArray[i]);
            }

            // 4
            Task randomOne = Task.Run(() => { RandomNumbers(); });
            Task randomTwo = Task.Run(() => { RandomNumbers(); });
            Task randomThree = Task.Run(() => { RandomNumbers(); });
            Task randomFour = Task.Run(() => { RandomNumbers(); });
            Task randomFive = Task.Run(() => { RandomNumbers(); });

            randomOne.Wait();
            randomTwo.Wait();
            randomThree.Wait();
            randomFour.Wait();
            randomFive.Wait();

        }

        public static Task<int[]> GetArrResult()
        {
            Task<int[]> arrTask = Task.Run(() => { return GetArray(10); });
            return arrTask;
        }

        public static int Factorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            else return number * Factorial(number - 1);
        }

        public static Task<int> GetResult() // Если нужен метод возвращаемого типа, то возвращаемый тип оборачивается в обобщенный Task
        {            
            Task<int> task = Task.Run(() =>
            {
                Task.Delay(2000).Wait();
                return 150;
            });
            return task;
        }

        // 3 Random numbers
        public static void RandomNumbers()
        {
            Random random = new Random();
            int result = random.Next(7, 28);
            Console.WriteLine(result);
        }

        // 4

        

        public static int[] GetArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for(int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 50);
            }
            return new int[length];


        }
    }
}