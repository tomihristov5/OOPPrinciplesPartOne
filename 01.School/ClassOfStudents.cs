namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using _01.School.People;

    public class ClassOfStudents : IComment
    {
        private string textID;
        private List<Student> studentSet;
        private List<Teacher> teacherSet;

        public ClassOfStudents(string textID)
        {
            this.TextID = textID;
            this.studentSet = new List<Student>();
            this.teacherSet = new List<Teacher>();
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The class must have a unique text identifier!");
                }

                this.textID = value;
            }
        }

        public List<Student> StudentSet
        {
            get
            {
                return this.studentSet;
            }
        }

        public List<Teacher> TeacherSet
        {
            get
            {
                return this.teacherSet;
            }
        }

        public string Comment { get; set; }

        public void AddTeachers(Teacher teacher)
        {
            this.teacherSet.Add(teacher);
        }

        public void AddStudents(Student student)
        {
            this.studentSet.Add(student);
        }

        public override string ToString()
        {
            return this.TextID;
        }
    }
}
