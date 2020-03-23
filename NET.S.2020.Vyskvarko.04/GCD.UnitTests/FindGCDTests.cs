using System;
using NUnit.Framework;

namespace GCD.UnitTests
{
    [TestFixture]
    public class FindGCDTests
    {
        #region EuclideanGCDTests
        [TestCase(64, 48, 16)]
        [TestCase(-231, -140, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 0, 5)]
        [TestCase(0, 15, 15)]
        [TestCase(-5, int.MaxValue, 1)]
        [TestCase(476, int.MaxValue, 1)]
        public void EuclideanGCDVariousValueCheckThem(int firstNumber, int secondNumber, int expected)
        {
            var result = GCD.FindGCD.EuclideanGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, result);
        }

        [TestCase(int.MinValue, int.MaxValue)]
        [TestCase(int.MinValue, 0)]
        [TestCase(int.MinValue, 255)]
        public void EuclideanGCDOverflowExpectedException(int firstNumber, int secondNumber)
        {
            var ex = Assert.Catch<Exception>(() => GCD.FindGCD.EuclideanGCD(firstNumber, secondNumber));

            StringAssert.Contains("Number is biggest Int.", ex.Message);
        }
        #endregion

        #region BinaryGCD
        [TestCase(64, 48, 16)]
        [TestCase(-231, -140, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 0, 5)]
        [TestCase(0, 15, 15)]
        [TestCase(-5, int.MaxValue, 1)]
        [TestCase(476, int.MaxValue, 1)]
        public void BinaryGCDVariousValueCheckThem(int firstNumber, int secondNumber, int expected)
        {
            var result = GCD.FindGCD.BinaryGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, result);
        }

        [TestCase(int.MinValue, int.MaxValue)]
        [TestCase(int.MinValue, 0)]
        [TestCase(int.MinValue, 255)]
        public void BinaryGCDOverflowExpectedException(int firstNumber, int secondNumber)
        {
            var ex = Assert.Catch<Exception>(() => GCD.FindGCD.BinaryGCD(firstNumber, secondNumber));

            StringAssert.Contains("Number is biggest Int.", ex.Message);
        }
        #endregion

        #region FindEuclideanGCD
        [TestCase(9, -585, 81, -189)]
        [TestCase(6, 78, 294, 570, 36)]
        [TestCase(16, 48, 64)]
        [TestCase(0, 0, 0, 0, 0, 0, 0, 0)]
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue)]
        public void FindEuclideanGCDVariousValueCheckThem(int expected, params int[] numbers)
        {
            var result = GCD.FindGCD.FindEuclideanGCD(out long time, numbers);

            Assert.AreEqual(expected, result);
        }

        [TestCase(int.MinValue, int.MinValue, int.MinValue)]
        public void FindEuclidGCDOverflowExpectedException(params int[] numbers)
        {
            var ex = Assert.Catch<Exception>(() => GCD.FindGCD.FindEuclideanGCD(out long time, numbers));

            StringAssert.Contains("Number is biggest Int.", ex.Message);
        }

        [TestCase(0)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void FindEuclidGCDValuesLessThanTwoExpectedException(params int[] numbers)
        {
            var ex = Assert.Catch<Exception>(() => GCD.FindGCD.FindEuclideanGCD(out long time, numbers));

            StringAssert.Contains("Values ​​less than two.", ex.Message);
        }
        #endregion

        #region FindBinaryGCD
        [TestCase(9, -585, 81, -189)]
        [TestCase(6, 78, 294, 570, 36)]
        [TestCase(16, 48, 64)]
        [TestCase(0, 0, 0, 0, 0, 0, 0, 0)]
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue)]
        public void FindBinaryGCDVariousValueCheckThem(int expected, params int[] numbers)
        {
            var result = GCD.FindGCD.FindBinaryGCD(out long time, numbers);

            Assert.AreEqual(expected, result);
        }

        [TestCase(int.MinValue, int.MinValue, int.MinValue)]
        public void FindBinaryGCDOverflowExpectedException(params int[] numbers)
        {
            var ex = Assert.Catch<Exception>(() => GCD.FindGCD.FindBinaryGCD(out long time, numbers));

            StringAssert.Contains("Number is biggest Int.", ex.Message);
        }

        [TestCase(0)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void FindBinaryGCDValuesLessThanTwoExpectedException(params int[] numbers)
        {
            var ex = Assert.Catch<Exception>(() => GCD.FindGCD.FindBinaryGCD(out long time, numbers));

            StringAssert.Contains("Values ​​less than two.", ex.Message);
        }
        #endregion

    }
}
