using Tyuiu.StoyakinNM.Sprint5.Task1.V29.Lib;
namespace Tyuiu.StoyakinNM.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}