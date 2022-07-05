using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        // Валидация логина и пароля
        [TestMethod]
        public void Validation1()
        {
            string login = "Petrenko1994";
            string password = "Q123wer";
            bool expected = true;
            bool actual = Test.Unit.LoginPasswordCheck(login, password);
            Assert.AreEqual(expected, actual);
        }

        public void Validation2()
        {
            string login = "Petrenko199";
            string password = "Q123wer";
            bool expected = false;
            bool actual = Test.Unit.LoginPasswordCheck(login, password);
            Assert.AreEqual(expected, actual);
        }

        public void Validation3()
        {
            string login = "Petrenko1994";
            string password = "Q123we";
            bool expected = false;
            bool actual = Test.Unit.LoginPasswordCheck(login, password);
            Assert.AreEqual(expected, actual);
        }

        public void Validation4()
        {
            string login = "";
            string password = "Q123we";
            bool expected = false;
            bool actual = Test.Unit.LoginPasswordCheck(login, password);
            Assert.AreEqual(expected, actual);
        }

        public void Validation5()
        {
            string login = "Petrenko1994";
            string password = "";
            bool expected = false;
            bool actual = Test.Unit.LoginPasswordCheck(login, password);
            Assert.AreEqual(expected, actual);
        }

        public void Validation6()
        {
            string login = "";
            string password = "";
            bool expected = false;
            bool actual = Test.Unit.LoginPasswordCheck(login, password);
            Assert.AreEqual(expected, actual);
        }
    }
}
