using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(4, 16)]
        [DataRow(5, 20)]
        public void CalculateThePerimeterOfSquareTest(int side, int exceptedValue)
        {
            var result = Program.CalculateThePerimeterOfSquare(side);
            Assert.AreEqual(exceptedValue, result);
        }

        [TestMethod()]
        [DataRow(4, 16)]
        [DataRow(5, 25)]
        public void CalculateTheAreaOfSquareTest(double side, double exceptedValue)
        {
            var result = Program.CalculateTheAreaOfSquare(side);
            Assert.AreEqual(exceptedValue, result);
        }

        [TestMethod()]
        [DataRow("12", 3)]
        [DataRow("47", 11)]
        public void SumNumberTest(string number, int exceptedValue)
        {
            var result = Program.SumNumber(number);
            Assert.AreEqual(exceptedValue, result);
        }

        [TestMethod()]
        [DataRow("12", 2)]
        [DataRow("47", 28)]
        public void MultiplyNumberTest(string number, int exceptedValue)
        {
            var result = Program.MultiplyNumber(number);
            Assert.AreEqual(exceptedValue, result);
        }

        [TestMethod()]
        [DataRow("10", "2", true)]
        [DataRow("1", "2", false)]
        public void CheckConditionTest(string value1, string value2, bool expectedValue)
        {
            bool result = Program.CheckCondition(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod()]
        [DataRow("1", "4", "7", 1)]
        [DataRow("100", "98", "300", 98)]
        [DataRow("1000", "500", "499", 499)]
        public void MinNumberTest(string value1, string value2, string value3, int expectedValue)
        {
            int min = Program.MinNumber(value1, value2, value3);
            Assert.AreEqual(expectedValue, min);
        }

        [TestMethod()]
        [DataRow("1", "Понедельник соответствует цифре 1")]
        [DataRow("2", "Вторник соответствует цифре 2")]
        [DataRow("3", "Среда соответствует цифре 3")]
        [DataRow("4", "Четверг соответствует цифре 4")]
        [DataRow("5", "Пятница соответствует цифре 5")]
        [DataRow("6", "Суббота соответствует цифре 6")]
        [DataRow("7", "Воскресенье соответствует цифре 7")]
        [DataRow("S", "Данная цифра S не соответствует дням недели")]
        public void ReturnMessageDayOfWeekTest(string value, string expectedValue)
        {
            string message = Program.ReturnMessageDayOfWeek(value);
            Assert.AreEqual(expectedValue, message);
        }

        [TestMethod()]
        [DataRow(25, "От 1000 до 1100 за 4 месяц(а/ев) при сумме процента 25")]
        [DataRow(17, "От 1000 до 1102 за 6 месяц(а/ев) при сумме процента 17")]
        [DataRow(30, "Слишком большая сумма процента 30")]
        public void FindDepositAndCountMounthsTest(int value, string expectedValue)
        {
            string message = Program.FindDepositAndCountMounths(value);
            Assert.AreEqual(expectedValue, message);
        }

        [TestMethod()]
        [DataRow(1, 1, 1, 0)]
        [DataRow(1, 1, -1, 2)]
        [DataRow(1, 4, 4, 1)]
        [DataRow(3, -2, 1, 0)]

        public void ReturnTheRootsOfTheEquationTest(int value1, int value2, int value3, int expectedValue)
        {

            int countRoots = Program.ReturnTheRootsOfTheEquation(value1, value2, value3);
            Assert.AreEqual(expectedValue, countRoots);
        }

        [TestMethod()]
        [DataRow("4", "5", 18, 20)]
        [DataRow("6", "10", 32, 60)]
        [DataRow("7", "3", 20, 21)]
        public void CalculateThePerimeterAndAreaTest(string value1, string value2, int expectedValue1, int expectedValue2)
        {
            var (perimeter, area) = Program.CalculateThePerimeterAndArea(value1, value2);
            Assert.AreEqual(expectedValue1, perimeter);
            Assert.AreEqual(expectedValue2, area);
        }
    }
}