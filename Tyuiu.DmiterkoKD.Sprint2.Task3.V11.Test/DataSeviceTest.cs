using Tyuiu.DmiterkoKD.Sprint2.Task3.V11.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task3.V11.Test
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
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 2.585;
            Assert.AreEqual(res, wait);
        }
        [Test]
        public void Test2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }
        [Test]
        public void Test3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.64;
            Assert.AreEqual(res, wait);
        }
        [Test]
        public void Test4()
        {
            DataService ds = new DataService();
            double x = -16;
            double res = ds.Calculate(x);
            double wait = -175.938;
            Assert.AreEqual(res, wait);
        }
    }
}