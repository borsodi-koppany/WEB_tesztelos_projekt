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
        [InlineData("lvl 1", "4")]
        public void SzokincsGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button"));
            

            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[1]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "80")]
        public void IroeszkozGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[2]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[2]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[2]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "2000")]
        public void RimelesGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[3]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[3]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[3]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "20000")]
        public void MondatSzerkezetGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[4]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[4]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[4]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "200000")]
        public void PetofiGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[5]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[5]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[5]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "4")]
        public void BolcseszGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[6]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[6]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[6]/button")).Text);

        }


        [Theory]
        [InlineData("lvl 1", "4000")]
        public void AlkoholGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[7]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[7]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[7]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "400000")]
        public void DrogGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[8]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[8]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[8]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "4")]
        public void KisfaludyGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[9]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[9]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[9]/button")).Text);

        }

        [Theory]
        [InlineData("lvl 1", "4000000")]
        public void NTFGombMukodese(string ujSzint, string upgrademennyi)
        {
            var upgradeBtn = driver.FindElement(By.XPath("/html/body/div/div[3]/div[10]/button"));


            upgradeBtn.Click();
            var szint = driver.FindElement(By.XPath("/html/body/div/div[3]/div[10]/span")).Text;
            Assert.Equal(ujSzint, szint);
            Assert.Equal(upgrademennyi, driver.FindElement(By.XPath("/html/body/div/div[3]/div[10]/button")).Text);

        }
    }
}