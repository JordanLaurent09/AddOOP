namespace Lesson0111
{

    // Потоки с параметрами
    // Ключевое слово is позволяет узнавать тип object
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread one = new Thread(CountToCentury);
            Thread two = new Thread(CountToCentury);
            Thread three = new Thread(CountToCentury);
            Thread four = new Thread(CountToCentury);

            Thread first = new Thread(new ParameterizedThreadStart(Printer));
            Thread second = new Thread(Printer);
            Thread third = new Thread(message => { Console.WriteLine(message);});

            first.Start("Привет");
            second.Start("Привет");
            third.Start("Привет");

            one.Start(15);
            two.Start("Привет");
            three.Start(new Car("Cougar", "sedan", 160));
            four.Start(new int[] { 4, 2, 34, 11, 20, 21});


        }

        public static void Printer(object obj)
        {
            Console.WriteLine(obj);
        }

        public static void CountToCentury(object obj)
        {
           if(obj is int[])
           {
                foreach(int item in (int[])obj)
                {
                    Console.WriteLine(item);
                }
           }
           else if(obj is Car) 
           {
                Car car = (Car)obj;
                Console.WriteLine($"Название: {car.CarName}, Тип: {car.CarType}, Скорость: {car.Speed}");
           }
           else
           {
                Console.WriteLine(obj);
           }
        }



    }

    class Car
    {
        public Car(string carName, string carType, double speed)
        {
            CarName = carName;
            CarType = carType;
            Speed = speed;
        }

        public string CarName { get; set; }
        public string CarType { get; set; }
        public double Speed { get; set; }

    }
}