namespace _03.AnimalHierarchy.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(age, name, AnimalSex.female)
        {

        }

        public override void Sound()
        {
            System.Console.WriteLine("Mew, mew, mew");
        }
    }
}
