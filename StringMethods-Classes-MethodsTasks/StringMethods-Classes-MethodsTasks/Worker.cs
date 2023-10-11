using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods_Classes_MethodsTasks
{
    public class Worker
    {
        private double _experience;

        public string Surname { get; set; }
        public string Name { get; set; }
        public string WorkerCode { get; set; }
        public double Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0)
                {
                    _experience = value;
                }
            }
        }

        public Worker(string name, string surname, double exper)
        {
            this.Name = name;
            this.Surname = surname;
            this.WorkerCode = char.ToUpper(name[0]) + "" + char.ToUpper(surname[0]);
            this.Experience = exper;
        }
    }
}
