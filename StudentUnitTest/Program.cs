using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NewStudent student = new NewStudent("Alex", "Vesttoften 8", Person.Genders.Male, 3);
            student.Speak();
        }
    }
}
