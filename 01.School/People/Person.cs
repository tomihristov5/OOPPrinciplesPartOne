namespace _01.School.People
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Everyone must have first name!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Everyone must have last name!");
                }
            }
        }
    }
}
