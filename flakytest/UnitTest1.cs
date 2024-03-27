namespace flakytest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();
            Random rand1 = new Random();
            int a = rand1.Next(1, 100);
            Console.WriteLine(a);
            var result = calculator.IsOdd(a);
            Assert.AreEqual(1000, result);

        }
    }    
}
