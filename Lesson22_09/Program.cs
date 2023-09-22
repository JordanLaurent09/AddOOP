using System.Data.Common;
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

            Matrix mat1 = new Matrix();
            mat1.matrixOne = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            mat1.matrixTwo = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            int[,] array = +mat1;
            
            for(int y = 0; y < array.GetLength(0); y++)
            {
                for(int x = 0; x < array.GetLength(1); x++) 
                {
                    Console.Write($"{array[y,x]} ");
                }
                Console.WriteLine();
            }
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
}