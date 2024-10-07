using Tyuiu.DmiterkoKD.Sprint2.Task2.V23.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task2.V23.Test
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
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}