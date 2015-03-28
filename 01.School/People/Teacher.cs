namespace _01.School.People
{
    using System.Collections.Generic;

    public class Teacher : Person, IComment
    {
        private List<Disciplines> disciplinesSet;

        public Teacher(string firstName, string lastName, List<Disciplines> disciplinesSet)
            : base(firstName, lastName)
        {
            this.disciplinesSet = new List<Disciplines>();
        }

        public List<Disciplines> DisciplinesSet
        {
            get
            {
                return new List<Disciplines>(this.disciplinesSet);
            }
        }

        public string Comment { get; set; }

        public void AddDisciplines(Disciplines discipline)
        {
            this.disciplinesSet.Add(discipline);
        }

        public void RemoveDisciplines(Disciplines discipline)
        {
            this.disciplinesSet.Remove(discipline);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
