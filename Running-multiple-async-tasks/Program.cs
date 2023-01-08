namespace Running_multiple_async_tasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.WriteLine("Before");


            //var task1 = TestEvent(1);
            //var task2 = TestSecondEvent(2);

            //var ttt = await Task.WaitAll(task1, task2);


            //List<Task> TaskList = new List<Task>();
            //for (int i = 1; i<5; i++)
            //{
            //    var LastTask = new Task(TestEvent(i));
            //    LastTask.Start();
            //    TaskList.Add(LastTask);
            //}

            //Task.WaitAll(TaskList.ToArray());

            var tasks = new Task[] {
            Task.Factory.StartNew(() => {
                TestEvent(1);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(2);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(3);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(4);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(5);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(6);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(7);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(8);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(9);
                }, TaskCreationOptions.LongRunning),
                Task.Factory.StartNew(() => {
                    TestEvent(10);
                }, TaskCreationOptions.LongRunning)
            };

            Task.WaitAll(tasks);



            Console.WriteLine("After");


        }

        public static void TestEvent(int taskNum)
        {
            for (int i = 0; i < 1000000000; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine("Task num: " + taskNum + " Count: " + i);
                }
            }


        }

        //public static async Task TestSecondEvent(int taskNum)
        //{
        //    for (int i = 0; i < 100000000; i++)
        //    {
        //        if (i % 1000 == 0)
        //        {
        //            Console.WriteLine("Task num: " + taskNum + " Count: " + i);
        //        }
        //    }


        //}
    }
}