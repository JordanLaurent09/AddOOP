namespace DelegatesProject
{
    class Program
    {

        // 1. Модификатор доступа
        // 2. Ключевое слово delegate
        // 3. Тип возвращаемого значения
        // 4. Имя делегата
        // 5. Параметры

        static void Main(string[] args)
        {
            ArythmDelegate arythmDelegate = Sum;
            arythmDelegate += Substract;
            arythmDelegate += Mult;
            arythmDelegate += Divide;
            Console.WriteLine(arythmDelegate(5,6));
            arythmDelegate.Invoke(10, 5);
            // Метод invoke() позволяет избегать ошибок компилятора при наличии значения null
            // Проверка на null происходит с помощью .?
        }

        public static int Sum(int firstNumber, int secondNumber)
        {
            Console.WriteLine( firstNumber + secondNumber );
            return firstNumber + secondNumber;
        }

        public static int Substract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
            return firstNumber - secondNumber; 
        }

        public static int Mult(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
            return firstNumber * secondNumber;
        }

        public static int Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
            if (secondNumber == 0) return 0;
            return firstNumber / secondNumber;
        }

        public delegate void MyDelegate();
        public delegate int ArythmDelegate(int firstNumber, int secondName); 
    }
}