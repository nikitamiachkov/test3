using Class;

namespace TestProject1
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
            int x = 10;
            int y = 20;
            int ex = 30;

            Class1 class1 = new Class1();

            int itevt = class1.Sum(x, y);

            Assert.AreEqual(ex, itevt);

        }
    }
}