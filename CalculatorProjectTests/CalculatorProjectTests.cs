
using CalculatorProject;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {

        public TestContext? TestContext { get; set; }
        [TestMethod]
        public void CalcProjectAddtest()
        {

            int x = Convert.ToInt32(TestContext.Properties["ValueX"]);
            int y = Convert.ToInt32(TestContext.Properties["ValueY"]);


            Calculator c = new Calculator();
            int result = c.Add(x, y);
            int control = x + y;
            Assert.AreEqual(control, result); 
        }
    }
}