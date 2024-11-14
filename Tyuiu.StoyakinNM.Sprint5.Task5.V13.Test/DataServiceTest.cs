using Tyuiu.StoyakinNM.Sprint5.Task5.V13.Lib;
namespace Tyuiu.StoyakinNM.Sprint5.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V13.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}