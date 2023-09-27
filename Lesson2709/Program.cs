using System.Drawing;
using System.Runtime.InteropServices;

namespace Lesson2709
{
    class Program
    {

        // Методы расширения. Анонимные типы. Кортежи
        static void Main(string[] args)
        {   // Работа с методами расширения 

            //SomeClass sc = new SomeClass();
            //sc.ShowSomeValue();
            //int value = sc.GetSomeValue();
            //Console.WriteLine(value);

            // Работа с var
            var values1 = new Values1(); // var стал типа Values1
            Color color = values1.eyeColor;
            var values2 = new Values2();
            var values3 = new Values3();


            // Работа с кортежами
            (int, int, string) tuple = (50, 100, "Tommy");

            Console.WriteLine(tuple.Item1);
            Console.WriteLine( tuple.Item3);

            List<(string, int, double)> students = new List<(string, int, double)>
            {
                ("Шуцкий Максим", 22, 98.5),
                ("Лубенец Александр", 35, 87.9),
                ("Пак Виктор", 23, 20.1)
            };

            Console.WriteLine(GetMeanMark(students));
            Console.WriteLine(GetMeanAge(students));

            // Методы расширения самостоятельная
            CharSeeker charSeeker = new CharSeeker();
            charSeeker.text = "ПРОГРАММИРОВАНИЕ.ТУПЛЮ КАК СЛОН";
            int position = charSeeker.charPosition('Р');
            Console.WriteLine(position);
        }
        // Метод с самым высоким баллом
        public static string GetMeanMark(List<(string, int, double)> students)
        {
            double max = 0;
            string name = "";

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Item3 > max)
                {
                    max = students[i].Item3;
                    name = students[i].Item1;
                }
            }

            return name;
        }

        // Средний возраст 

        public static int GetMeanAge(List<(string, int, double)> students)
        {
            int age = 0;
            for(int i = 0; i < students.Count; i++)
            {
                age += students[i].Item2;
            }
            return age / students.Count;
        }
    }

    // 





    // Работа с var
    // 1. Обязательная инициализация переменной
    // 2. var ориентируется на то, что справа
    // 3. После инициализации var принимает данный ему тип
    // var - не ключевое слово, а тип данных
    // 4. var - только для одного значения переменной, массивы и т.д. не пройдут


    class Values1
    {
        public string name;
        public int age;
        public Color eyeColor = Color.Red;
        public char sex;

    }

    class Values2
    {
        public string name;
        public int age;
        public Color eyeColor;
        public char sex;

    }

    class Values3
    {
        public string name;
        public int age;
        public Color eyeColor;
        public char sex;

    }

    // 1. Метод расширения создается только в статическом классе
    // 2. Для указания на текущий класс используется this, после запятой можно подставить некий доп.параметр если есть необходимость
    // 3. Сигнатура переменной должна совпадать с сигнатурой поля
    class SomeClass // Класс, использующий методы расширения
    {
        public int someValue = 15;

        public int GetSomeValue()
        {
            //return someValue;
            return someValue.GetValue(); // С использованием метода расширения
        }

        public void ShowSomeValue()
        {
            // Console.WriteLine( someValue );
            someValue.Show(); // С использованием метода расширения
        }
    }

    // Статический класс с методами расширения
    public static class Shower
    {
        public static void Show(this int someValue)
        {
            Console.WriteLine(someValue);
        }

        public static int GetValue(this int someValue)
        {
            return someValue;
        }
    }
    // Два класса по самостоятельной работе с методами расширения
    class CharSeeker
    {
        public string text;

        public int charPosition(char val)
        {
               
            return text.PointSearcher(val);
        }
    }

    public static class CharAdding
    {
        public static int PointSearcher(this string text, char symbol)
        {
            int position = -1;
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == symbol)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }

}