using System.Data.Common;
using System.Drawing;
using System.Numerics;

namespace Lesson22_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Перегрузка операций
            // Ключевое слово - operator



            //SomeClass someClass = new SomeClass();
            //someClass.firstValue = -40;
            //Second second = new Second();
            //second.someValue = 25;
            //Console.WriteLine(someClass > second);
            //someClass.secondValue = 30;
            //Console.WriteLine(someClass + someClass);

            //Matrix mat1 = new Matrix();
            //mat1.matrixOne = new int[3, 3]
            //{
            //    {1,2,3 },
            //    {4,5,6 },
            //    {7,8,9 }
            //};
            //mat1.matrixTwo = new int[3, 3]
            //{
            //    {1,2,3 },
            //    {4,5,6 },
            //    {7,8,9 }
            //};

            //int[,] array = +mat1;

            //for(int y = 0; y < array.GetLength(0); y++)
            //{
            //    for(int x = 0; x < array.GetLength(1); x++) 
            //    {
            //        Console.Write($"{array[y,x]} ");
            //    }
            //    Console.WriteLine();
            //}

            // Работа с абстрактным классом

            //Client client = new Client("Alice", 500);
            //Employee employee = new Employee("Freddy", "Director");
            //client.Display();
            //employee.Display();

            Rectangle rectangle = new Rectangle(20, 34);
            Triangle triangle = new Triangle(45, 120);
            Console.WriteLine(rectangle.Square());
            Console.WriteLine(triangle.Square());



        }
    }

    class SomeClass
    {
        public int firstValue;
        //public int secondValue;

        //public static int  operator +(SomeClass firstParam, SomeClass secondParam)
        //{
        //    return firstParam.firstValue + secondParam.secondValue;
        //}

        public static bool operator >(SomeClass first, Second second)
        {
            if(first.firstValue < 0)
            {
                Console.WriteLine("Число меньше нуля");
                return false;
            }
            return first.firstValue > second.someValue;
        }

        public static bool operator <(SomeClass first, Second second)
        {
            return first.firstValue < second.someValue;
        }
    }
    class Second
    {
        public int someValue;
    }


    // Задача с матрицей

    class Matrix
    {
        

        public int[,] matrixOne = new int[3,3];
        public int[,] matrixTwo = new int[3,3];

        

        public static int[,] operator +(Matrix matrixOne)
        {
            //int[,] sumMatrix = new int[matrixOne.matrixOne.Length, matrixTwo.matrixTwo.Length];

            //for(int j = 0; j < matrixOne.matrixOne.Length; j++)
            //{
            //    for (int i = 0; i < matrixTwo.matrixTwo.Length; i++)
            //    {
            //        sumMatrix[j, i] = 
            //    }
            //}
            int[,] sumMatrix = new int[3, 3];
            for(int row = 0; row < sumMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < sumMatrix.GetLength(1); column++)
                {
                    sumMatrix[row, column] = matrixOne.matrixOne[row, column] + matrixOne.matrixTwo[row, column];
                }
            }

            return sumMatrix;
        }       
    }

    // Создание абстрактного класса Person, общего для Client и Employee
    // Замена класса Person на класс Figures


    abstract class Figure
    {
        private string _name;

        public string Name { get; set; }

        public abstract double Area2 { get; }

        public Figure(string name)
        {
            _name = name;
        }

        public abstract double Area();

        public virtual void Print()
        {
            Console.WriteLine("Имя фигуры: " + _name);
        } 
    }

    class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _h;

        public Triangle(string name, double a, double b, double c):base(name)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        public void SetABC(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public string GetABC()
        {
            return $"Сторона а равна {_a}, сторона в равна {_b}, а сторона с равна{_c}";
        }


    }

    //abstract class Figures
    //{
    //    public int Basement { get; set; }
    //    public Figures(int basement)
    //    {
    //        Basement = basement;
    //    }

    //    // Абстрактный метод не нуждается в реализации; он может быть переопределен в классах-наследниках
    //    public abstract double Square();
        
    //}

    //class Rectangle : Figures
    //{
    //    public int Size { get; set; }

    //    public Rectangle(int basement, int size):base(basement)
    //    {
    //        Size = size;
    //    }

    //    public override double Square()
    //    {
    //        return Size * Basement;
    //    }
    //}

    //class Triangle : Figures
    //{
    //    public int Height { get; set; }

    //    public Triangle(int basement, int height):base(basement)
    //    {
    //        Height = height;
    //    }
    //    public override double Square()
    //    {
    //        throw new NotImplementedException();

    //    }

    //}

    
}