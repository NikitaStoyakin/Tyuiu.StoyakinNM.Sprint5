using Tyuiu.StoyakinNM.Sprint5.Task0.V13.Lib;
namespace Tyuiu.StoyakinNM.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}