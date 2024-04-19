using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace test;

public class Ui
{
    protected IWebDriver _driver;
    private readonly double _durationOfMillis = 700;
    protected readonly int _millis = 1000;
    private readonly string _url = "your_URl";
    
    protected readonly ScenarioContext _scenarioContext;
    
    private string _e = "Problems... See your autotest";

    public string word = "test";

    protected void Start()
    {
        _driver = new ChromeDriver();
        _driver.Navigate().GoToUrl(_url);
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(_durationOfMillis);

        var elementBtnAdvance = _driver.FindElement(By.CssSelector(".button > span:nth-child(1)"));
        elementBtnAdvance.Click();

        var elementBtnException = _driver.FindElement(By.CssSelector("#loginName"));
        elementBtnException.SendKeys("email");

        var elementBtnNext = _driver.FindElement(By.CssSelector("#submit-button"));
        elementBtnNext.Click();

        var elementPass = _driver.FindElement(By.CssSelector("#password"));
        elementPass.SendKeys("pass");

        var elementBtnNextToo = _driver.FindElement(By.CssSelector("#submit-button"));
        elementBtnNextToo.Click();
    }

    protected void Checking()
    {
        if ((_driver != null) | _driver.Equals(_url))
        {
            Console.WriteLine("Test is success");
            _driver.Quit();
        }
        else
        {
            Console.WriteLine("Test is failed");
            throw new Exception(_e);
        }
    }
}