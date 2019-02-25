using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using System.Reflection;

namespace Framework
{
	public enum Drivers
	{
		Chrome,
		Firefox,
		IE,
		Edge
	}

	public static class Browser
	{
		private static IWebDriver _webDriver;
		private static string _url = "https://covercheck.vwfsinsuranceportal.co.uk";
		public static ISearchContext Driver { get { return _webDriver; } }   

        internal static IWebDriver GetDriver(Drivers driver)
		{
			switch (driver)
			{
				case Drivers.Chrome:
                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
				    var relativePath = @"..\...\bin\Debug";           																																					   // var relativePath = @".\Drivers";
					var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath)); ;
					return new ChromeDriver(chromeDriverPath);


				case Drivers.Edge:
					//to do

				case Drivers.IE:
					//to do

				case Drivers.Firefox:
					return new FirefoxDriver();
				default:
					throw new NotImplementedException("I do not know the driver that you supplied.");
			}

		}
        public static IJavaScriptExecutor Scripts(this IWebDriver _webDriver)
        {
            return (IJavaScriptExecutor)_webDriver;
        }

        public static object ExecuteJavaScript(string script)
        {
            return _webDriver.Scripts().ExecuteScript(script);         
        }

        public static void Go_To(string _url)
		{	
				_webDriver.Navigate().GoToUrl(_url);
			
		}

		public static void Initialise()
		{
			_webDriver = GetDriver(Drivers.Chrome);
			Go_To(_url);
		}

		public static void Close()
		{
			_webDriver.Close();
		}

		public static void Quit()
		{
			_webDriver.Quit();
		}

		public static void Wait(int milliseconds)
		{
			Thread.Sleep(milliseconds);
		}

		public static void Click(string xpath)
		{
			_webDriver.FindElement(By.XPath(xpath)).Click();
			Browser.Wait(2000);
		}

		public static void ClickAndSendValue(string xpath, string value)
		{
			_webDriver.FindElement(By.XPath(xpath)).SendKeys(value);
			Browser.Wait(2000);
		}

		public static string readTextFromField(string xpath)
		{
			var element = _webDriver.FindElement(By.XPath(xpath));
            Browser.Wait(2000);
            string value = element.Text;
            Browser.Wait(2000);
            return value;
			
		}

	}
}
