namespace _01.School
{
    using System;
    using System.Collections.Generic;

    class NewSchool
    {
        private List<ClassOfStudents> allStudentClasses;
        private string schoolName;

        public NewSchool(string schoolName)
        {
            this.SchoolName = schoolName;
            this.allStudentClasses = new List<ClassOfStudents>();
        }

        public List<ClassOfStudents> AllStudentClasses
        {
            get
            {
                return this.allStudentClasses;
            }
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The school must have a name!");
                }

                this.schoolName = value;
            }
        }

        public void AddClasses(ClassOfStudents newClass)
        {
            this.allStudentClasses.Add(newClass);
        }

        public void RemoveClasses(ClassOfStudents oldClass)
        {
            this.allStudentClasses.Remove(oldClass);
        }

        public override string ToString()
        {
            return this.schoolName;
        }
    }
}
