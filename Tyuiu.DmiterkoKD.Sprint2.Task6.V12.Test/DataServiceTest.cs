using Tyuiu.DmiterkoKD.Sprint2.Task6.V12.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task6.V12.Test
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

            Assert.AreEqual("09.12.2024", ds.FindDateOfPreviousDay(2024, 12, 10));
            Assert.AreEqual("31.07.2024", ds.FindDateOfPreviousDay(2024, 8, 1));
            Assert.AreEqual("31.12.2023", ds.FindDateOfPreviousDay(2024, 1, 1));
        }
    }
}