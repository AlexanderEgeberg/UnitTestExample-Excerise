using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentUnitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUnitTest.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student _student;

        [TestInitialize]
        public void BeforeTest()
        {
            _student = new Student("Alex", "Vesttoften", 3, Student.Genders.Male);
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("Alex", _student.Name);

            try
            {
                _student.Name = "A";
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("name must be at least 2 characters", ex.Message);
            }
        }

        [TestMethod()]
        public void AddressTest()
        {
            Assert.AreEqual("Vesttoften", _student.Address);
            _student.Address = "Sydtoften";
            Assert.AreEqual("Sydtoften", _student.Address);
 
            /*
             * Should be the exact same as the AddressNullTest
            try
            {
                _student.Address = null;
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
            }

            */
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddressNullTest()
        {
            _student.Address = null;
        }

        [TestMethod()]
        public void SemesterTest()
        {
            Assert.AreEqual(3, _student.Semester, 0.0001);
            _student.Semester = 4;
            Assert.AreEqual(4, _student.Semester, 0.0001);

            Assert.AreEqual("Alex", _student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SemesterTestException()
        {
            _student.Semester = 10;
        }

        [TestMethod()]
        public void GenderTest()
        {
            Assert.AreEqual(Student.Genders.Male, _student.Gender);
        }
    }
}