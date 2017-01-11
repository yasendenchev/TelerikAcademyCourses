using StudentsAndWorkers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public abstract class Human : IHuman
    {
        private  string fName;
        private  string lName;

        public Human(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public string FName
        {
            get
            {
                return this.fName;
            }
        }

        public string LName
        {
            get
            {
                return this.LName;
            }
        }
    }
}
