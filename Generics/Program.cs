namespace Generics
{



    // Обобщения
    // * с методами
    // * с классами


    internal class Program
    {
        static void Main(string[] args)
        {
            Operations<int> operations = new Operations<int>();
            Console.WriteLine(operations.Foo(25));
            Console.WriteLine(operations.GetMax(20, 24));


            IntegerCalculator integerCalculator = new IntegerCalculator();
            Console.WriteLine(integerCalculator.Sum(20, 30));

            integerCalculator.SomeFoo<string, int>("Hello", 21);

            
        }
    }



    public abstract class Calculator<T> // Типов в угловвых скобках можно указывать сколько угодно
    {
        public abstract T Sum(T firstVal, T secondVal);

        public abstract T Substract(T firstVal, T secondVal);

    }


    public class IntegerCalculator : Calculator<int> 
    {
        

        public override int Sum(int firstVal, int secondVal)
        {
            return firstVal + secondVal;
        }

        public override int Substract(int firstVal, int secondVal)
        {
            return firstVal - secondVal;
        }

        public void SomeFoo<TFirstVal, TSecondVal>(TFirstVal firstValue, TSecondVal secondValue)
        {
            TFirstVal someParam = firstValue;
            TSecondVal anotherParam = secondValue;

            Console.WriteLine(someParam);
            Console.WriteLine(anotherParam);

        }
       
    }


    class Operations<T>
    {
        public T ?Property { get; set; }


        public T Foo<T>(T first)  // T - обобщение, которое принимает тот тип данных, который ему передан
        {
            return first;
        }

        public T GetMax<T>(T first, T second)
        {
            return Comparer<T>.Default.Compare(first, second) > 0 ? first : second;
        }
    }
}