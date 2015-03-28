namespace _02.StudentsAndWorkers.People
{
    using System;

    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        private double moneyPerHour;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The worker should have a positive week salary!");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours cannot be negative!");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            moneyPerHour = weekSalary / 5 * workHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} has {2} week salary and works {3} hours per day",
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
