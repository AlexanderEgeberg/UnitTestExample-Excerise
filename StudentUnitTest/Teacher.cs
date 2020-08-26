using System;

namespace StudentUnitTest
{
    public class Teacher
    {

        /// <summary>
        /// Assign instance fields
        /// </summary>
        private string _name;
        private string _address;
        private int _salary;
        public enum Genders
        {
            Male = 0,
            Female = 1
        };
        private Genders _gender;

        /// <summary>
        ///  Constructor that checks param that they're following the assigned rules
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="salary"></param>
        /// <param name="gender"></param>
        public Teacher(string name, string address, int salary, Genders gender)
        {
            CheckNameCharacters(name);
            CheckAddress(address);
            CheckSalary(salary);
            CheckGender(gender);
            Name = name;
            Address = address;
            Salary = salary;
            Gender = gender;
        }

        /// <summary>
        /// get & set properties that run checks when setting value
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { CheckNameCharacters(value); _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { CheckAddress(value); _address = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { CheckSalary(value); _salary = value; }
        }

        public Genders Gender
        {
            get { return _gender; }
            set { CheckGender(value); _gender = value; }
        }
        /// <summary>
        /// Checks the name param that the length is more at least 2 characters
        /// </summary>
        /// <param name="name"></param>
        private static void CheckNameCharacters(string name)
        {
            if (name.Length <= 1)
            {
                throw new ArgumentException("name must be at least 2 characters");
            }
        }

        /// <summary>
        /// Checks that the address param is not null
        /// </summary>
        /// <param name="address"></param>
        private static void CheckAddress(string address)
        {
            if (address == null)
            {
                // throw new ArgumentException("Address cannot be null");
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Checks that the salary param is at least 1 and not more than 8
        /// </summary>
        /// <param name="salary"></param>
        private static void CheckSalary(int salary)
        {
            if (salary <= 0)
            {
                throw new ArgumentOutOfRangeException("salary", salary, "salary must be above 0 ");
            }
        }

        /// <summary>
        /// Check that the gender is either male or female.
        /// the Gender Enum only has a male or female option, this checks if the enum is the Gender Enum
        /// If it's not it fails, if it is then it succeeds as the only available genders are male or female
        /// </summary>
        /// <param name="gender"></param>
        private static void CheckGender(Genders gender)
        {
            if (!Enum.IsDefined(typeof(Genders), gender))
            {
                throw new ArgumentException("gender must be either male or female");
            }
        }

        public override string ToString()
        {
            return string.Format($"Student {Name}, salary {Salary}, address {Address}, gender {Gender}");
        }

    }
}
