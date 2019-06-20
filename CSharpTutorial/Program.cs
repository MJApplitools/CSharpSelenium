using System;
using System.Collections.Generic;
using System.Drawing;
using Applitools.Selenium;
using OpenQA.Selenium.Chrome;


namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            var eyes = new Eyes();
            eyes.ForceFullPageScreenshot = true;
            eyes.ApiKey = Environment.GetEnvironmentVariable("APPLITOOLS_API_KEY");
            try
            {
                //Dictionary<string, string> testinfo = getTestInfoForPart(args); 
                eyes.Open(driver, "C# Demo", "Login Window", new Size(600, 800));
                driver.Url = "https://demo.applitools.com";
                eyes.CheckWindow("Login window test");
                eyes.Close();
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                driver.Quit();
                eyes.AbortIfNotClosed(); 
            }
        }
    }
}
