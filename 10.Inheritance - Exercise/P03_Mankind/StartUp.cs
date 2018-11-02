using System;

namespace P03_Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var studentInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var workerInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                Worker worker = new Worker(workerInfo[0], workerInfo[1], 
                                    decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
