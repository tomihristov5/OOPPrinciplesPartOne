namespace _01.School
{
    using System;

    public class Disciplines : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines(string disciplineName, int numberOfLecures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLecures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string DisciplineName 
        { 
            get
            {
                return this.disciplineName;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The discipline should have a name!");
                }

                this.disciplineName = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("The lectures shoud be betweek 0 and 60");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("The exercises shoud be betweek 0 and 60");
                }

                this.numberOfExercises = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Discipline name: {0}, Lectures: {1}, Exercises: {2}", DisciplineName, NumberOfLectures, NumberOfExercises);
        }
    }
}
