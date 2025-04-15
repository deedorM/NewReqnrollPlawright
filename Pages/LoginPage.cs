using Microsoft.Playwright;

namespace NewReqnrollPlawright.Pages
{
    public class LoginPage
    {
        IPage _page;
        public LoginPage(IPage page)
        {
            _page = page;
        }

        ILocator userName => _page.Locator("[data-test=\"username\"]");
        ILocator password => _page.Locator("[data-test=\"password\"]");
        ILocator loginBtn => _page.Locator("[data-test=\"login-button\"]");

        public async Task EnterLoginDetails()
        {
            await userName.FillAsync("standard_user");
            await password.FillAsync("secret_sauce");
            await loginBtn.ClickAsync();
        }
    }
}
