using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace test;
namespace test;

public class ReturnBackToHomePageFromMyListsStepDefinition: Ui
{
    [Given("admin opened admin panel")]
    public void admin_opened_admin_panel()
    {
        Start();
    }

    [When("the admin clicked on the home icon")]
    public void  the_admin_clicked_on_the_home_icon()
    {
        _driver.FindElement(
                By.CssSelector(
                    "#__nuxt > div > section > section > section > main > section > section:nth-child(1) > div > section > div.k-list-header.mb-8 > div > button > span"))
            .Click();
    }

    [When("admin was transferred to the main page of the Kommersant admin panel")]
    public void  admin_was_transferred_to_the_main_page_of_the_kommersant_admin_panel()
    {
        _driver.FindElement(
                By.CssSelector(
                    "#__nuxt > div > section > header > div.icons-wrapper > div.go-back-btn.white-icon.icon-box > span > svg"))
            .Click();
    }

    [Then("check, when you click on the home arrow icon, it takes you to the main page of the Kommersat admin panel")]
    public void  check_when_you_click_on_the_home_arrow_icon_it_takes_you_to_the_main_page_of_the_kommersat_admin_panel()
    {
        Checking();
    }
}