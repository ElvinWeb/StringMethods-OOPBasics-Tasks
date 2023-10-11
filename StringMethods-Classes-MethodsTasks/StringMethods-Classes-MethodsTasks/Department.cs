using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace StringMethods_Classes_MethodsTasks
{
    public class Department
    {

        public string Name { get; set; }

        public Worker[] workers = Array.Empty<Worker>();

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers, workers.Length + 1);
            workers[^1] = worker;

        }
        public void ShowAllWorkers()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"name: {worker.Name}; surname: {worker.Surname}; experience: {worker.Experience}; code:{worker.WorkerCode}");
            }
        }

        public Worker SearchWorker(string name)
        {
            foreach (Worker worker in workers)
            {
                if (name.ToLower() == worker.Name.ToLower())
                {
                    return worker;
                }

            }
            return null;
        }
    }
}
