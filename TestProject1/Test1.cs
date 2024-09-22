using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class Test1
    {
        private PasswordValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [TestMethod]
        public void TestPasswordScore1()
        {
            string password = "Password123";
            int result = validator.ValidatePassword(password);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestPasswordScore2()
        {
            string password = "Password";
            int result = validator.ValidatePassword(password);


            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestPasswordScore3()
        {
            string password = "password";
            int result = validator.ValidatePassword(password);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestPasswordScore4()
        {
            string password = "Password.";
            int result = validator.ValidatePassword(password);

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void TestPasswordScore5()
        {
            string password = "P@ssw0rd";
            int result = validator.ValidatePassword(password);

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestPasswordScore0()
        {
            string password = "pass";
            int result = validator.ValidatePassword(password);

            Assert.AreEqual(result, 0);
        }
    }

}

