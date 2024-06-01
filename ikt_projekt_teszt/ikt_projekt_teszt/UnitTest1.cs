using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ikt_projekt_teszt
{
    public class UnitTest1: IDisposable
    {

        private readonly ChromeDriver driver;
        

        public void Dispose()
        {
            driver.Quit();
        }

        public UnitTest1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://borsodi-koppany.github.io/WEB_tesztelos_projekt/");
        }

        [Fact]
        public void OldalBetoltott()
        {
            Assert.Equal("szókincs", driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/h4")).Text);
        }

        [Theory]
        [InlineData("1", "lvl 1", "4")]
        [InlineData("2", "lvl 1", "80")]
        [InlineData("3", "lvl 1", "2000")]
        [InlineData("4", "lvl 1", "20000")]
        [InlineData("5", "lvl 1", "200000")]
        [InlineData("6", "lvl 1", "4")]
        [InlineData("7", "lvl 1", "4000")]
        [InlineData("8", "lvl 1", "400000")]
        [InlineData("9", "lvl 1", "4")]
        [InlineData("10", "lvl 1", "4000000")]
        public void GombokTesztelése(string divId, string ujszint, string upgradeMennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{divId}]/button"));
            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{divId}]/span")).Text;
            Assert.Equal(ujszint, szint);
            Assert.Equal(upgradeMennyi, driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{divId}]/button")).Text);
        }
    }
}