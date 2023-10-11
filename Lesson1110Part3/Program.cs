using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Lesson1110Part3
{

    // Анонимные функции подразделяются на:
    // 1. Анонимные типы
    // 2. Анонимные методы
    // 3. 
    internal class Program
    {

        delegate void MyDelegate(int x);

        delegate void MyDelegate<T>(T value);

        delegate void MyDelegat(int[] arr);

        delegate int MyDeleggate(int x, int y);

        delegate bool MyBoolDelegate(int x);


        static void Main(string[] args)
        {

            // Первый способ работы с анонимными функциями (анонимный метод)    
            // В делегате создается анонимный метод 
            MyDelegate print = delegate (int x)
            {
                Console.WriteLine(x);
            };

            print(42);

            // Второй способ работы - лямбда-выражения (это тоже как анонимные методы)

            Action<int> printing = x => Console.WriteLine(x);

            printing(42);


            MyDelegat array = x => { Console.WriteLine(x.GetType()); };

            array += x => { Console.WriteLine(x.Max()); };
            array += x => { Console.WriteLine(x.Min()); };
            array(new int[] { 1, 2, 3, 4, 5 });


            // 1.
            MyDeleggate multiplication = delegate (int x, int y)
            {
                return x * y;
            };

            int result = multiplication(20, 20);

            Console.WriteLine(result);

            // 2.

            MyBoolDelegate isTrue = delegate (int x)
            {
                if (x % 2 == 0) return true;
                return false;
            };

            Console.WriteLine(isTrue(22));




        }
    }
}