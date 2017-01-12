namespace AnimalHierarchy
{
    abstract class Animal : ISound
    {
        private readonly string name;
        private readonly int age;
        private readonly Gender sex;

        public Animal(string name, int age, Gender sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        #region Properties

        public string Name
        {
            get
            {
                return this.name;
            }
            
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }
        }


        #endregion


        public abstract void MakeNoise();
        
    }
}
