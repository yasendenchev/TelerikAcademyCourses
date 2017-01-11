using StudentsAndWorkers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human, IHuman, IWorker
    {
        private int weekSalary;
        private int workHoursPerDay;
        

        public Worker(string fName, string lName, int weekSalary, int workHoursPerDay) : base(fName, lName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                this.workHoursPerDay = value;
            }
        }


        public double MoneyPerHour()
        {
            double result = this.weekSalary / (5 * this.workHoursPerDay);

            return result;
        }
    }
}
