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

            Assert.AreEqual("9 12 2024", ds.FindDateOfPreviousDay(10, 12, 2024));
            Assert.AreEqual("29 2 2024", ds.FindDateOfPreviousDay(1, 3, 2024));

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(13, 17, 2024);
            });


            
        }
    }
}