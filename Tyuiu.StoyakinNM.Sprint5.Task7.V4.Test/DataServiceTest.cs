using Tyuiu.StoyakinNM.Sprint5.Task7.V4.Lib;
namespace Tyuiu.StoyakinNM.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V4.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}