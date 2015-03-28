namespace _01.School.People
{
    using System;

    public class Student : Person, IComment
    {
        private int iD;

        public Student(string firstName, string lastName, int iD) 
            : base(firstName, lastName)
        {
            this.ID = iD;
        }

        public int ID
        {
            get
            {
                return this.iD;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ID number should not be negative");
                }

                this.iD = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, ID: {2}", FirstName, LastName, ID);
        }
    }
}
