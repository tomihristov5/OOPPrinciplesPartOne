namespace _03.AnimalHierarchy.Animals
{
    public class Tomcats : Cat
    {
        public Tomcats(string name, int age)
            : base(age, name, AnimalSex.male)
        {

        }

        public override void Sound()
        {
            System.Console.WriteLine("Mewwwww");
        }
    }
}
