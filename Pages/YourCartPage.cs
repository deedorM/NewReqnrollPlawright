using Microsoft.Playwright;

namespace NewReqnrollPlawright.Pages
{
    public class YourCartPage
    {
        IPage _page;
        public YourCartPage(IPage page)
        {
            _page = page;
        }
    }
}