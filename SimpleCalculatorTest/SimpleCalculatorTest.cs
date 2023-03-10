using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        [TestMethod]
        public void EmptyStringReturnZero()
        {
            Assert.AreEqual(0, SimpleCalculatorClass.Calc(""));
        }

        [TestMethod]
        public void SingleNumberReturnTheValue()
        {
            string number = "13";
            Assert.IsTrue(SimpleCalculatorClass.Calc(number) == int.Parse(number));
        }

        [TestMethod]
        public void TwoNumbersCommaDelimitedReturnTheSum()
        {
            string numbers = "2,2";
            int a = int.Parse(numbers.Split(",")[0]);
            int b = int.Parse(numbers.Split(",")[1]);

            Assert.IsTrue(SimpleCalculatorClass.Calc(numbers) == a + b);
        }

        [TestMethod]
        public void TwoNumbersNewlineDelimitedReturnTheSum()
        {
            string numbers = "2\n2";
            int a = int.Parse(numbers.Split("\n")[0]);
            int b = int.Parse(numbers.Split("\n")[1]);

            Assert.IsTrue(SimpleCalculatorClass.Calc(numbers) == a + b);
        }

        [TestMethod]
        public void ThreeOrMoreNumbersReturnTheSum()
        {
            string numbers = "1,2,3,4";
            int a = int.Parse(numbers.Split(",")[0]);
            int b = int.Parse(numbers.Split(",")[1]);
            int c = int.Parse(numbers.Split(",")[2]);
            int d = int.Parse(numbers.Split(",")[3]);

            Assert.IsTrue(SimpleCalculatorClass.Calc(numbers) == a + b + c + d);
        }

        [TestMethod]
        public void NegativeNumbersThrowAnException()
        {
            Assert.ThrowsException<Exception>(() => SimpleCalculatorClass.Calc("-1,1,1"));
        }

        [TestMethod]
        public void NumbersGreaterThan1000AreIgnored()
        {
            string numbers = "1,2,1000,4";
            int a = int.Parse(numbers.Split(",")[0]);
            int b = int.Parse(numbers.Split(",")[1]);
            int c = int.Parse(numbers.Split(",")[2]);
            int d = int.Parse(numbers.Split(",")[3]);

            Assert.IsTrue(SimpleCalculatorClass.Calc(numbers) == a + b + d);
        }
    }
}