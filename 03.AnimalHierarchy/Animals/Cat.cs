namespace _03.AnimalHierarchy.Animals
{
    public class Cat : Animal
    {
        public Cat(int age, string name, AnimalSex sex)
            : base(age, name, sex)
        {

        }

        public override void Sound()
        {
            System.Console.WriteLine("Miau");
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} and is {2} years old!", this.Name, this.Sex, this.Age);
        }
    }
}
