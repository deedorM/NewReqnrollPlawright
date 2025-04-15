using Microsoft.Playwright;
using NewReqnrollPlawright.Pages;
using Reqnroll.BoDi;

namespace NewReqnrollPlawright.StepDefinitions
{
    [Binding]
    public sealed class SauceDemoStepDefinitions
    {
        IPage _page;
        LoginPage _loginPage;
        ProductsPage _productsPage; 
        public SauceDemoStepDefinitions(IObjectContainer container)
        {
            _page = container.Resolve<IPage>();
            _loginPage = container.Resolve<LoginPage>();
            _productsPage = container.Resolve<ProductsPage>();
        }

        [Given("I am on Saucedemo Page")]
        public async Task GivenIAmOnSaucedemoPage()
        {
            await _page.GotoAsync("https://www.saucedemo.com/");
        }

        [When("I enter username and password")]
        public async Task WhenIEnterUsernameAndPassword()
        {
            await _loginPage.EnterLoginDetails();
        }

        [Then("I am logged in")]
        public async Task ThenIAmLoggedIn()
        {
           await _productsPage.isPageTitleDisplayed();
           //await _page.PauseAsync();  
           await _productsPage.enterProductsToCart();
           Task.Delay(4000).Wait();
        }
    }
}