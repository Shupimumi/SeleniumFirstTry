using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SeleniumFirstTry
{
	[CollectionDefinition("Non-Parallel Collection", DisableParallelization = true)]
	public class FirstTestedClass
	{
		private void Authorize(IWebDriver driver)
		{
			//driver.FindElement("in")
		}



		[Fact]
		[Trait("Category", "Smoke")]
		public void FirstTest()
		{
			using (IWebDriver driver = new ChromeDriver())
			{
				//this.Authorize(driver);
				driver.Navigate().GoToUrl("https://yandex.ru/");
				var searchInput = driver.FindElement(By.XPath("//*[@id='text']"));
				searchInput.SendKeys("google");
				searchInput.SendKeys(Keys.Enter);
				var divs = driver.FindElements(By.TagName("div"));

				Assert.Equal("https://yandex.ru/search/?lr=194&text=google", driver.Url);
			}
		}

		[Fact]
		[Trait("Category", "Smoke")]
		public void FirstTest1()
		{
			using (IWebDriver driver = new ChromeDriver())
			{
				//this.Authorize(driver);
				driver.Navigate().GoToUrl("https://yandex.ru/");
				var searchInput = driver.FindElement(By.XPath("//*[@id='text']"));
				searchInput.SendKeys("google");
				searchInput.SendKeys(Keys.Enter);
				var divs = driver.FindElements(By.TagName("div"));

				Assert.Equal("https://yandex.ru/search/?lr=194&text=google", driver.Url);
			}
		}
	}
	[CollectionDefinition("Non-Parallel Collection")]
	public class FirstTestedClass1
	{
		private void Authorize(IWebDriver driver)
		{
			//driver.FindElement("in")
		}



		[Fact]
		[Trait("Category", "Smoke")]
		public void FirstTest()
		{
			using (IWebDriver driver = new ChromeDriver())
			{
				//this.Authorize(driver);
				driver.Navigate().GoToUrl("https://yandex.ru/");
				var searchInput = driver.FindElement(By.XPath("//*[@id='text']"));
				searchInput.SendKeys("google");
				searchInput.SendKeys(Keys.Enter);
				var divs = driver.FindElements(By.TagName("div"));

				Assert.Equal("https://yandex.ru/search/?lr=194&text=google", driver.Url);
			}
		}

		[Fact]
		[Trait("Category", "Smoke")]
		public async void FirstTest1()
		{
			using (IWebDriver driver = new ChromeDriver())
			{
				//this.Authorize(driver);
				driver.Navigate().GoToUrl("https://yandex.ru/");
				var searchInput = driver.FindElement(By.XPath("//*[@id='text']"));
				searchInput.SendKeys("google");
				searchInput.SendKeys(Keys.Enter);
				var divs = driver.FindElements(By.TagName("div"));
				await Task.Delay(500);
				Assert.Equal("https://yandex.ru/search/?lr=194&text=google", driver.Url);
			}
		}
	}
}
