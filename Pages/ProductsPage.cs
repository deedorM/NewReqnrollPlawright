using Microsoft.Playwright;
using NUnit.Framework;

namespace NewReqnrollPlawright.Pages
{
    public class ProductsPage
    {
        IPage _page;
        public ProductsPage(IPage page)
        {
            _page = page;
        }

        ILocator title => _page.Locator("[data-test=\"title\"]");
        ILocator backpack => _page.Locator ("[data-test=\"add-to-cart-sauce-labs-backpack\"]");
        ILocator allathething => _page.Locator ("[data-test=\"add-to-cart-test\\.allthethings\\(\\)-t-shirt-\\(red\\)\"]");
        ILocator inventory => _page.Locator("[data-test=\"inventory-list\"]");
       // ILocator bolt => _page.Locator("[data-test=\"add-to-cart-sauce-labs-bolt-t-shirt\"]");

        public async Task isPageTitleDisplayed()
        {
           Assert.That(await title.TextContentAsync(), Is.EqualTo("Products"));
        }

        public async Task enterProductsToCart()
        {
            await backpack.ClickAsync();
            await allathething.ClickAsync();
            await inventory.ClickAsync();
        }
    }
}
