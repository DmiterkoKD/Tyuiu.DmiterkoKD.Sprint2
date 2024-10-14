using Tyuiu.DmiterkoKD.Sprint2.Task7.V14.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task7.V14.Test
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
            double y = 0.3;
            double x = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}