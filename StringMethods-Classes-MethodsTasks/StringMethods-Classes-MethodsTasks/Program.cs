namespace StringMethods_Classes_MethodsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            string workerName1 = "  Elvin ";
            string workerSurname1 = "  Sarkarov  ";
            Worker worker1 = new Worker(workerName1.Trim(),workerSurname1.Trim(), 2.5);

            Worker worker2 = new Worker("Emin", "Karimli", 3.5);
            Worker worker3 = new Worker("Kamil", "Quliyev", 1.5);

            department.AddWorker(worker1);
            department.AddWorker(worker2);
            department.AddWorker(worker3);
            department.ShowAllWorkers();

            Console.Write("Axtaris ucun ad daxil edin:");
            string workerName = Console.ReadLine();

            if (department.SearchWorker(workerName) != null)
            {
                Console.WriteLine(department.SearchWorker(workerName).Name);
            }
            else 
            {
                Console.WriteLine("bele bir isci adi yoxdur");
            }
           

        }
    }
}