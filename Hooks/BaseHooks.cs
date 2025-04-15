using Microsoft.Playwright;
using Reqnroll.BoDi;

namespace NewReqnrollPlawright.Hooks
{
    [Binding]
    public sealed class BaseHooks
    {
        IPlaywright _playwright;
        IBrowser _browser;
        IPage _page;
        IObjectContainer _objectContainer;
        public BaseHooks(IObjectContainer container)
        {
            _objectContainer = container;    
        }

        [BeforeScenario()]
        public async Task BeforeScenarioWithTag()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new()
            {
                Channel = "chrome",
                Headless = false,
                SlowMo = 500,
            });

            _page = await _browser.NewPageAsync();
            _objectContainer.RegisterInstanceAs(_page);
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _page.CloseAsync();
        }
    }
}