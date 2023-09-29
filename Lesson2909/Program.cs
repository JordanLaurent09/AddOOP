namespace Lesson2909
{
    class Program
    {
        static void Main(string[] args)
        { 



            // Индексатор
            //ArrayOfStrings arr = new ArrayOfStrings();
            //arr[2] = "Hello"; 
        }
    }



    // Разбор задачи №11 (ДЗ)
    class BaseClass
    {
        public int field;

        public virtual int this[int number]
        {
            get
            {
                int sumCounter = 0;
                int temp = field;

                for(int i = 0; temp >0; i++)
                {
                    field /= 10;
                    sumCounter++;
                }

                int[] arr = new int[sumCounter]; // наполнили цифрами в обратном порядке
                temp = field;

                for(int i = 0; i < temp; i++)
                {
                    arr[i] = temp % 10;
                    field /= 10;
                }

                Array.Reverse(arr); // не забыть подумать

                return arr[number];
            }
        }
    }

    //class ChildClass:BaseClass
    //{
    //    public int field2;

    //    public override int this[int number] 
    //    { 
            
    //    }
    //}



    // Небольшой разбор индексатора
    //class ArrayOfStrings
    //{
    //    private string[] _array = new string[10];

    //    public string this[int index]
    //    {
    //        get
    //        {
    //            return _array[index];
    //        }
    //        set
    //        {
    //            if (index < 0 || index >= _array.Length)
    //            {
    //                throw new IndexOutOfRangeException("Введен неверный индекс");
    //            }
    //            _array[index] = value;
    //        }
    //    }
    //}
}