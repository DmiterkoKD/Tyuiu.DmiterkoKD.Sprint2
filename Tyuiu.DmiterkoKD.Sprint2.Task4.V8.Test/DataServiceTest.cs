using Tyuiu.DmiterkoKD.Sprint2.Task4.V8.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task4.V8.Test
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
            double x = 6;
            double y = -4;
            double res = ds.Calculate(x, y);
            double wait = 15712.007;
            Assert.AreEqual(res, wait);
        }
        [Test]
        public void Test2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 14;
            Assert.AreEqual(res, wait);
        }
    }
}