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
            Assert.Equal("Íróeszköz", driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/h4")).Text);
        }

        //[Theory]
        //[InlineData("1", "lvl 1", "4")]
        //[InlineData("2", "lvl 1", "80")]
        //[InlineData("3", "lvl 1", "2000")]
        //[InlineData("4", "lvl 1", "20000")]
        //[InlineData("5", "lvl 1", "200000")]
        //[InlineData("6", "lvl 1", "4")]
        //[InlineData("7", "lvl 1", "4000")]
        //[InlineData("8", "lvl 1", "400000")]
        //[InlineData("9", "lvl 1", "4")]
        //[InlineData("10", "lvl 1", "4000000")]
        //public void GombokTesztelése(string divId, string ujszint, string upgradeMennyi)
        //{
        //    var upgradeBtn = driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{divId}]/button"));
        //    upgradeBtn.Click();
        //    var szint = driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{divId}]/span")).Text;
        //    Assert.Equal(ujszint, szint);
        //    Assert.Equal(upgradeMennyi, driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{divId}]/button")).Text);
        //}
        [Fact]
        public void SzavakNovekedese()
        {
            var currency = driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text;
            var upgradeButton = driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button"));
            upgradeButton.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.True(int.Parse(currency) < int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text));

        }

        [Fact]
        public void ElsoGombTesztelese()
        {
            var upgradeButton = driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button"));
            //var eredetiValue = driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).GetDomAttribute(attributeName: "value");
            upgradeButton.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/span")).Text;
            Assert.Equal("lvl 1", szint);
            Assert.Equal("0", driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text);
            Assert.Equal("4", driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).GetDomAttribute(attributeName: "value"));
            Assert.Equal("kolto koltofejlesztve", driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]")).GetDomAttribute(attributeName: "class"));
        }
        [Fact]
        public void MasodikgombTesztelese()
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[2]/button"));
            while(int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text) <= int.Parse(upgradeBtn.GetDomAttribute(attributeName: "value")))
            {
                driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).Click();
            }
            var currency = int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text);
            upgradeBtn.Click();
            Assert.Equal("80", upgradeBtn.GetDomAttribute(attributeName: "value"));
            Assert.Equal("lvl 1", driver.FindElement(By.XPath("/html/body/div/div[3]/div[2]/span")).Text);
            Assert.Equal("szokincs", driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]")).GetDomAttribute(attributeName: "class"));
            Assert.Equal("4", driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text);

        }

        [Theory]
        //[InlineData("2", "20")]
        [InlineData("3", "500", "2000", "rimeles")]
        [InlineData("4", "5000", "20000", "mondatszerk")]
        [InlineData("5", "50000", "200000", "petofi")]
        //[InlineData("6", "200000", "800000")]
        //[InlineData("7", "1000000", "4000000")]
        //[InlineData("8", "100000000", "400000000")]
        //[InlineData("9", "1000000000", "4000000000")]
        //[InlineData("10", "10000000000000", "40000000000000")]
        public void TobbiGombTesztelese(string id, string cost, string upgradeMennyi, string kep)
        {
            var upgradeBtn = driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{id}]/button"));
            var elozoGomb = driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{int.Parse(id) - 1}]/button"));
            driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).Click();
            //do
            //{
            //    driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).Click();
            //    if (int.Parse(elozoGomb.GetDomAttribute(attributeName: "value")) > int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text)){
            //        elozoGomb.Click();
            //    }
            //} while (int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text) <= int.Parse(cost));
            while (int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text) <= int.Parse(elozoGomb.GetDomAttribute(attributeName: "value")))
            {
                driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).Click();
                //if (int.Parse(elozoGomb.GetDomAttribute(attributeName: "value")) > int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text))
                //{
                //    elozoGomb.Click();
                //}
            }
            while(int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text) <= int.Parse(cost))
            {
                elozoGomb.Click();
            }
            var currency = int.Parse(driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text);
            upgradeBtn.Click();
            Assert.Equal("lvl 1", driver.FindElement(By.XPath($"/html/body/div/div[3]/div[{id}]/span")).Text);
            Assert.Equal((currency - int.Parse(cost)).ToString(), driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]/span")).Text);
            Assert.Equal(upgradeMennyi, upgradeBtn.GetDomAttribute(attributeName: "value"));
            Assert.Equal(kep, driver.FindElement(By.XPath($"/html/body/div/div[2]/div/div[{id}]")).GetDomAttribute(attributeName: "class"));
        }
    }
}