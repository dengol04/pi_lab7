using lab7;
namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Math.Abs(Program.findDistanceBetweenPoints(0, 0, 0, 1) - 1) < double.Epsilon);
            Assert.IsTrue(Math.Abs(Program.findDistanceBetweenPoints(0, 0, 0, -2) - 2) < double.Epsilon);
            Assert.IsTrue(Math.Abs(Program.findDistanceBetweenPoints(0, 3, 4, 0) - 5) < double.Epsilon);
        }
    }
}