using System.ComponentModel.DataAnnotations;

namespace Lesson1110
{

    // Ключевое слово Where - позволяет определять, какие типы данных можно использовать в обобщенном классе
    // конструкция where T
    internal class Program
    {
        static void Main(string[] args)
        {

            // Работа с ограничениями обобщений

            Automobiles sportCar = new Automobiles(120);
            Automobiles car = new Automobiles(60);

            Trains passengerTrain = new Trains(80, 6);
            Trains freightTrain = new Trains(60, 30);

            Transport<object>[] mc = new Transport<object>[5]
            {
                new Transport<object>(sportCar),
                new Transport<object>(car),
                new Transport<object>(passengerTrain),
                new Transport<object>(freightTrain),
                new Transport<object>(new Plane(600, 3400))
            };

            



            // Работа обобщенных классов
            GeneralClass<string> general = new GeneralClass<string>()
            {

                GeneralFieldOne = "Привет",
                GeneralFieldTwo = "Друг"
            };

            ChildClass child = new ChildClass();
            child.GeneralFieldOne = 23;
            child.GeneralFieldTwo = 21;

            Car[] cars = new Car[3];

            Car speedrunner = new Car(250, "Гоночная машина");
            Car truck = new Car(100, "Грузовик");
            Car childCar = new Car(5, "Машина для детей");

            cars[0] = speedrunner; cars[1] = truck; cars[2] = childCar;

            foreach (Car item in cars)
            {

                GetInfo(item);
            }
        }

        private static void GetInfo<T>(T info) where T : Transport
        {
            Console.WriteLine($"Скорость транспортного средства: {info.Speed}, а его тип : {info.CarType}");
        }
    }


    struct Plane
    {
        public int Speed { get; set; }
        public int MaxFlying { get; set; }

        public Plane (int speed, int maxFlying)
        {
            Speed = speed;
            MaxFlying = maxFlying;
        }
    }


    // Ограничение обобщений на класс (обычный, не базовый)

    class Automobiles
    {
        public int MaxSpeed { get; set; }

        public Automobiles(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }
    }


    class Trains
    {

        public int MaxSpeed { get; set; }
        public int CarriageQuantity { get; set; }

        public Trains(int maxSpeed,  int carriageQuantity)
        {
            MaxSpeed = maxSpeed;
            CarriageQuantity = carriageQuantity;
        }


    }


    class Transport<T> where T : class
    {
        public T SomeTransport { get; set; }

        public Transport(T someTransport)
        {
            SomeTransport = someTransport;
        }
    }


    // Ограничение на базовый класс

    class Transport
    {
        public double Speed { get; set; }
        public string CarType { get; set; }

        public Transport(double speed, string type)
        {
            Speed = speed;
            CarType = type;

        }
    }

    class Car : Transport
    {
        public Car(double speed, string type) : base(speed, type)
        {

        }
    }




    // Доп. разбор обобщенных классов
    class GeneralClass<T> // Обобщенный класс
    {
        public T GeneralFieldOne { get; set; }
        public T GeneralFieldTwo { get; set; }
    }

    class ChildClass : GeneralClass<int>
    {

    }
}