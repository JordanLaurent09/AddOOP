namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            List<int> numbers = new List<int>(4) {43, 23, 11, 20 };

            numbers.Add(13);
            numbers.Add(21);


            List<int[]> arrays = new List<int[]>(3) {new int[3] {1,2,3}, new int[3] {4,5,6} };
            arrays.Add(new int[3] { 7, 8, 9 });

            List<(int, string)> corteges = new List<(int, string)>(3) { (23, "dog"), (22, "cat"), (24, "summer") };
            corteges.Add((27, "house"));





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
}