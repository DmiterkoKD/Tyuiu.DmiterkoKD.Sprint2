using Tyuiu.DmiterkoKD.Sprint2.Task0.V25.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task0.V25.Test
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
            int x = 205;
            int y = 159;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, false, false, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}