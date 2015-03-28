namespace _03.AnimalHierarchy.Animals
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private AnimalSex sex;

        public Animal(int age, string name, AnimalSex sex)
        {
            this.Age = age;
            this.Name = name;
            this.sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("If you want your animal to be alive, enter possitive age!");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All animals must have a name!");
                }
                this.name = value;
            }
        }

        public AnimalSex Sex
        {
            get
            {
                return sex;
            }
        }

        public abstract void Sound();
    }
}
