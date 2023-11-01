namespace Lesson0111ThreadingContinue
{
    // Lock - старый способ
    // Mutex - предоставляет доступ к синхронизации потоков
    // Semaphore - самый удобный, надо пользоваться почаще
    // Monitor - методы Enter и Exit, в которые передается метод, упакованный в объект типа ПОТОК (Thread) 
    // эти сущности позволяют обеспечивать синхронизацию потоков
    class Program
    {

        public static object queue = new object();
        public static Mutex mutex = new Mutex();
        public static Semaphore semaphore = new Semaphore(1,2);
        public static int data = 0;

        static void Main(string[] args)
        {
            Thread one = new Thread(DataEncreaser);
            Thread two = new Thread(DataEncreaser);

            one.Start();
            two.Start();

            one.Join();
            two.Join();

            Console.WriteLine(data);
        }

        public static void DataEncreaser()
        {
            //for(int i = 0; i < 100000; i++)
            //{
                // 1. lock
                //lock (queue)
                //{
                //    data++;
                //}

                //  2. Monitor

                //Monitor.Enter(queue);

                //try
                //{
                //    data++;
                //}
                //finally
                //{
                //    Monitor.Exit(queue);
                //}

                // 3. Mutex

                //mutex.WaitOne();
                //data++;
                //mutex.ReleaseMutex();


                // 4. Semaphore

                semaphore.WaitOne();

                try
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        data++;
                    }
                }
                finally
                {
                    semaphore.Release();
                }
            //}
        }
    }
}