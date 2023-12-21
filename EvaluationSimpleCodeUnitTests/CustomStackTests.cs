using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class CustomStackTests
    {
        private CustomStack _customStack;

        [TestInitialize]
        public void Init()
        {
            _customStack = new CustomStack();
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(5)]
        public void Count_ReturnsCorrectCount(int numberOfElements)
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                _customStack.Push(i);
            }

            int result = _customStack.Count();

            Assert.AreEqual(numberOfElements, result);
        }

        [TestMethod]
        [DataRow(42, 1)]
        public void Push_IncreasesCount(int value, int expectedCount)
        {
            _customStack.Push(value);

            Assert.AreEqual(expectedCount, _customStack.Count());
        }

        [TestMethod]
        public void Pop_FromEmptyStack_ThrowsException()
        {
            Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => _customStack.Pop());
        }

        [TestMethod]
        [DataRow(42, 99)]
        public void Pop_FromNonEmptyStack_ReturnsLastPushedValue(int valueOne, int valueTwo)
        {
            _customStack.Push(valueOne);
            _customStack.Push(valueTwo);

            int result = _customStack.Pop();

            Assert.AreEqual(valueTwo, result);
        }

        [TestMethod]
        [DataRow(42, 99)]
        public void Pop_DecreasesCount(int valueOne, int valueTwo)
        {
            _customStack.Push(valueOne);
            _customStack.Push(valueTwo);
            _customStack.Pop();

            Assert.AreEqual(1, _customStack.Count());
        }
    }
}