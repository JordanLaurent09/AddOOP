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

            Thread first = new(new ParameterizedThreadStart(Printer));
            Thread second = new(Printer);
            Thread third = new(message => { Console.WriteLine(message);});

            first.Start("Привет");
            second.Start("Привет");
            third.Start("Привет");

            one.Start(15);
            two.Start("Привет");
            three.Start(new Car("Cougar", "sedan", 160));
            four.Start(new int[] { 4, 2, 34, 11, 20, 21});


            CustomArray myArr = new CustomArray(5);
            myArr[0] = 5.5;

            Thread firstThread = new(Displayer);
            Thread secondThread = new(Displayer);
            Thread thirdThread = new(Displayer);

            firstThread.Start(myArr);
            secondThread.Start("Удача");
            thirdThread.Start(new int[] { 4, 5, 6, 7, 2, 4, 5, 6, 7, 4 });


        }



        public static void Displayer(object? obj)
        {
            if(obj is CustomArray)
            {               
                CustomArray array = (CustomArray)obj;

                for(int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            else if(obj is string)
            {
                string line = (string) obj;
                Console.WriteLine(line);
            }
            else if(obj is int[])
            {
                int[] array = (int[])obj;
                int sum = 0;
                foreach(int i in array)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
        }


        public static void Printer(object? obj)
        {
            if (obj is not string)
            {

            }
            Console.WriteLine(obj);
        }

        public static void CountToCentury(object? obj)
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

    class CustomArray
    {
        private double[] _data;

        public int Length
        {
            get
            {
                return _data.Length;
            }
        }

        public double this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }

        public CustomArray(int length) 
        {
            _data = new double[length];
        }
    }
}