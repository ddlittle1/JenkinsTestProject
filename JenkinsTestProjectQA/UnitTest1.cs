namespace JenkinsTestProjectQA
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello, World! from Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JenkinsTestApp.ConsoleApp.Main();
                var result=sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
            
        }
    }
}