namespace Lesson1310
{
    internal class Program
    {
        public delegate int MaxElementDelegate(int[] array);
        public delegate int[] SortArrayDelegate(int[] array);
        public delegate List<int> EvensArrayDelegate(int[] array);
        public delegate List<DateTime> DateTimeDelegate(List<DateTime> list);
        public delegate string[] LenghtWordsDelegate(string[] words);
        static void Main(string[] args)
        {
            // Продолжение задач с прошлого урока
            // 4.

            MaxElementDelegate max = delegate (int[] array)
            {
                int max = array[0];
                for(int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                return max;
            };
            Console.WriteLine(max(new int[] { 6, 11, 9, 234, 22, 13, 20}));


            // 5.
            SortArrayDelegate sorted = (int[] array) =>
            {
                for(int i = 0; i < array.Length - 1; i++) 
                { 
                    for(int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            };

            int[] arr = new int[] { 6, 11, 9, 234, 22, 13, 20 };

            sorted(arr);

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(  );
            // Задачи с нового урока
            // 1.

            EvensArrayDelegate evens = (int[] array) =>
            {
                List<int> list = new List<int>();
                foreach(int i in array)
                {
                    if(i % 2 == 0)
                    {
                       list.Add(i);
                    }
                }
                return list;
            };

            int[] initialArray = new int[] { 6, 11, 9, 234, 22, 13, 20 };

            List<int> even = evens(initialArray);
            foreach(int item in even)
            {
                Console.Write(item + " ");
            }

            // 2.

            DateTimeDelegate times = (List<DateTime> dates) =>
            {

                for (int i = dates.Count - 1; i >= 0; i--)
                {
                    if (dates[i].Year < 2023) dates.Remove(dates[i]);
                }

                return dates;
            };

            List<DateTime> time = new List<DateTime>() { 
                new DateTime(2005, 2, 23), 
                new DateTime(2034, 12, 11), 
                new DateTime(2007, 9, 8)
            };


            times(time);

            foreach (DateTime item in time)
            {
                Console.WriteLine(item.Year);
            }

            // 3.

            LenghtWordsDelegate lenghtWords = (string[] words) =>
            {
                int newLength = 0;

                string[] fiveMoreWords;

                foreach (string word in words)
                {
                    if (word.Length >= 5) newLength++;
                }

                fiveMoreWords = new string[newLength];

                newLength = 0;

                foreach (string word in words)
                {
                    if (word.Length >= 5)
                    {
                        fiveMoreWords[newLength] = word;
                        newLength++;
                    }
                }

                return fiveMoreWords;
            };

        }
    }
}