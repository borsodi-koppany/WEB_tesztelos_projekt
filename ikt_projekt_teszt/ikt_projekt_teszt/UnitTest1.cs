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
            Assert.Equal("Szavak: 0", driver.FindElement(By.XPath("/html/body/div/div[1]/h1[1]")).Text);
        }
    }
}