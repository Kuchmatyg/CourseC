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

    }
}