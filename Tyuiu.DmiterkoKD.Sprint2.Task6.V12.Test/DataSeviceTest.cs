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

            Assert.AreEqual("2024 12 9", ds.FindDateOfPreviousDay(2024, 12, 10));
            Assert.AreEqual("2024 7 31", ds.FindDateOfPreviousDay(2024, 8, 1));
            Assert.AreEqual("2023 12 31", ds.FindDateOfPreviousDay(2024, 1, 1));


            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(13, 17, 2024);
            });


            
        }
    }
}