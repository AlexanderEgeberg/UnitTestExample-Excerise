using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUnitTest
{
    /// <summary>
    /// Inherit the Person class
    /// </summary>
    public class NewStudent : Person, INewStudent
    {

        /// <summary>
        /// Assign instance field
        /// the Person instance fields are inherited
        /// </summary>
        private int _semester;

        /// <summary>
        ///  Construct a Student with the Person parameters, then the Student paramenter
        ///  The base is the Person class
        /// </summary>
        /// <param name="semester"></param>
        public NewStudent(string name, string address, Genders gender, int semester) : base(name, address, gender)
        {
            // Check person.cs for constuction & checks of the other properties
            CheckSemester(semester);
            _semester = semester;
        }

        /// <summary>
        /// get & set properties that run checks when setting value
        /// </summary>

        public int Semester
        {
            get { return _semester; }
            set { CheckSemester(value); _semester = value; }
        }

        private static void CheckSemester(int semester)
        {
            if (semester > 8 || semester < 1)
            {
                throw new ArgumentOutOfRangeException("semester", semester, "semester must be between 1 or 8");
            }
        }

        public override string ToString()
        {
            return string.Format($"Student name {Name}, semester {Semester}, address {Address}, gender {Gender}");
        }
        public string Speak()
        {
            return string.Format($"My name is {Name}, I'm on my {Semester} semester. I live at {Address}");
        }
    }
}
