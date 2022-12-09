namespace Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

[TestFixture]
public class Tests
{
    public IWebDriver driver;
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
        driver = new ChromeDriver();
        driver.Manage().Window.Minimize();
        Thread.Sleep(TimeSpan.FromSeconds(3));
        Console.WriteLine("Chrome Browser launched succefully");
        Console.WriteLine();      
        Console.WriteLine("Second set of changes for commit");  
        Console.WriteLine("Third set of changes from respository");
        Assert.Fail();
    }

    [TearDown]
    public void tearDown()
    {
        driver.Close();
        Console.WriteLine("Chrome Browser closed succefully");
    }
}
