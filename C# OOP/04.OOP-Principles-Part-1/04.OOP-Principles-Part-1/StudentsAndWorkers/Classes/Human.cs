using StudentsAndWorkers.Contracts;

namespace StudentsAndWorkers
{
    public abstract class Human : IHuman
    {
        private readonly string fName;
        private readonly string lName;

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
                return this.lName;
            }
        }
    }
}
