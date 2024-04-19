using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace test;

public class WorkingWithSearchSearchInFoundOnTheRightNextToTheSearchStepDefinition: Ui
{
    [Given("the admin opened admin panel")]
    public void the_admin_opened_admin_panel()
    {
        Start();
    }

    [When("the admin clicked on the Lists button next to the search")]
    public void  the_admin_clicked_on_the_lists_button_next_to_the_search()
    {
        _driver.FindElement(
                By
                    .CssSelector(
                        "#__nuxt > div > section > section > section > main > section > section:nth-child(1) > div > section > div.k-list-header.mb-8 > div > button > span"))
            .Click();
    }

    [When("admin went to the main page of the Kommersant admin panel")]
    public void  admin_went_to_the_main_page_of_the_kommersant_admin_panel()
    {
        _driver.FindElement(
                By
                    .XPath("//*[@id=\"__nuxt\"]/div/section/header/div[3]/span"))
            .Click();
    }

    [Then("check, clicked on the Lists button next to the search and went to the main page of the Kommersant admin panel")]
    public void  check_clicked_on_the_lists_button_next_to_the_search_and_went_to_the_main_page_of_the_kommersant_admin_panel()
    {
        Checking();
    }
    
}