using Tyuiu.DmiterkoKD.Sprint2.Task5.V2.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task5.V2.Test
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

            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Зима", ds.FindMonthSeason(2));
            Assert.AreEqual("Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));
            Assert.AreEqual("Весна", ds.FindMonthSeason(5));
            Assert.AreEqual("Лето", ds.FindMonthSeason(6));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Лето", ds.FindMonthSeason(8));
            Assert.AreEqual("Осень", ds.FindMonthSeason(9));
            Assert.AreEqual("Осень", ds.FindMonthSeason(10));
            Assert.AreEqual("Осень", ds.FindMonthSeason(11));
            Assert.AreEqual("Зима", ds.FindMonthSeason(12));

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindMonthSeason(-1);
            });


            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindMonthSeason(13);
            });
        }
    }
}