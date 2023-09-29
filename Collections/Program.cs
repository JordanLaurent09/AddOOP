namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // HashSet (Множество - упорядоченный набор уникальных элементов)

            //HashSet<int> newHash = new HashSet<int>();

            //for(int i = 0; i < 10; i++)
            //{
            //    int numb = random.Next(1, 6);
            //    Console.Write(numb);
            //    newHash.Add(numb);
            //}

            //newHash.Add(1);
            //newHash.Add(1);
            //newHash.Add(4);
            //newHash.Add(1);
            //newHash.Add(4);
            //newHash.Add(1);
            //newHash.Add(25);

            //newHash.Remove(25);

            //foreach(int item in newHash)
            //{
            //    Console.WriteLine(item);
            //}


            // SortedSet - сортированное множество

            //SortedSet<int> newHash = new SortedSet<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    int numb = random.Next(1, 6);
            //    Console.Write(numb);
            //    newHash.Add(numb);
            //}

            //foreach (int item in newHash)
            //{
            //    Console.WriteLine(item);
            //}

            // Коллекция Dictionary

            //Dictionary<int, string> newDict = new Dictionary<int, string>();

            //newDict[1] = "one";
            //newDict[20] = "second";
            //newDict[54] = "three";

            //bool isKeyExists = newDict.ContainsKey(4);
            //bool isValueExists = newDict.ContainsValue("second");


            //Console.WriteLine(newDict["second"]);

            //foreach (var item in newDict)
            //{

            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}


            // Коллекция Queue (очередь, принцип FIFO)

            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Value1");
            //queue.Enqueue("Value2");
            //queue.Enqueue("Value3");
            //queue.Enqueue("Value4");
            //queue.Enqueue("Value5");

            //Console.WriteLine(queue.Count);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            // Коллекция Stack (принцип LIFO)

            //Stack<int> intsStack = new Stack<int>();

            //intsStack.Push(10);
            //intsStack.Push(20);
            //intsStack.Push(30);
            //intsStack.Push(40);
            //intsStack.Push(50);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(intsStack.Pop());
            //}

            // Stack.Count - количество элементов
            // Stack.Push(element) - ввод данных в стек
            // Stack.Pop() - берет верхний элемент






            //SomeClass[] someClass = new SomeClass[]
            //{
            //    new SomeClass(10),
            //    new SomeClass(20),
            //    new SomeClass(30)
            //};


            //foreach (var item in someClass)
            //{
            //    Console.WriteLine(item.Number);
            //}




            //List<int> numbers = new List<int>(4) {43, 23, 11, 20 };

            //numbers.Add(13);
            //numbers.Add(21);


            //List<int[]> arrays = new List<int[]>(3) {new int[3] {1,2,3}, new int[3] {4,5,6} };
            //arrays.Add(new int[3] { 7, 8, 9 });

            //List<(int, string)> tuples = new List<(int, string)>(3) { (23, "dog"), (22, "cat"), (24, "summer") };
            //tuples.Add((27, "house"));



            // Массив - упорядоченный статический ограниченный набор элементов

            // Список - НЕОГРАНИЧЕННЫЙ НАБОР ЭЛЕМЕНТОВ




            //List<object> objects = new List<object>();

            //object[] obj;

            //objects.Add(10);
            //objects.Add('g');
            //objects.Add("jlkl");
            //objects.Add((short)24);
            //objects.Add(new Object());

            //obj = objects.ToArray();


            //int[]numbers = new int[10];

            //for(int i = 0; i < 10; i++)
            //{
            //    numbers[i] = (random.Next(0, 28));              
            //}

            //foreach(int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}

        }
    }

    class SomeClass
    {
        public int Number { get; set; }

        public SomeClass(int value)
        {
            Number = value;
        }
    }
}