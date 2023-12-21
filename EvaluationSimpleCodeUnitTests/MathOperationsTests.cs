using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(3, 2, 5)]
        public void Add_WithTwoNumbers_ReturnsAddition(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(5, 2, 2.5f)]
        [DataRow(1, 1, 1)]
        [DataRow(55, 5, 11)]
        public void Divide_WithTwoNumbers_ReturnsDivision(int numberOne, int numberTwo, float expectedResult)
        {
            var result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Divide_WithSecondNumberAsZero_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(10, 0));
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void GetOddNumbers_WithNegativeLimit_ThrowsArgumentException(int limit)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetOddNumbers(limit));
        }
    }
}
