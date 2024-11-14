using Tyuiu.StoyakinNM.Sprint5.Task6.V16.Lib;
namespace Tyuiu.StoyakinNM.Sprint5.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V16.txt");

            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V16.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}