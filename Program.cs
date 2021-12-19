using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace WebScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to my c# scraper.");
            //Scraper question
            Console.Write("What scraper do you want to use(youtube, indeed, twitch): ");
            string? choice = Console.ReadLine();
            //Making the folder in C:\
            string? makefolder = @"C:\New folder";
            System.IO.Directory.CreateDirectory(makefolder);

            switch (choice)
            {
                //Begin Youtube
                case "youtube":
                    //Make list
                    List<string> list = new List<string>();
                    //Define path for CSV file
                    string strFilePath = @"C:\New folder\YTdata.csv";
                    //Define the seperator
                    string strSeperator = ",";
                    //CSV Information String
                    StringBuilder csvoutput = new StringBuilder();
                    //Define Webdriver
                    IWebDriver driver = new ChromeDriver();
                    //go to website
                    driver.Url = "https://www.youtube.com";
                    //Sleep
                    System.Threading.Thread.Sleep(2000);
                    //accept popup
                    driver.FindElement(By.XPath("/html/body/ytd-app/ytd-consent-bump-v2-lightbox/tp-yt-paper-dialog/div[4]/div[2]/div[5]/div[2]/ytd-button-renderer[2]/a/tp-yt-paper-button/yt-formatted-string")).Click();
                    //Sleep
                    System.Threading.Thread.Sleep(2000);
                    //Information question
                    Console.Write("What do you want to scrape on youtube: ");
                    //Read question answer
                    string? word = Console.ReadLine();
                    //fill in searchbar
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/form/div[1]/div[1]/input")).SendKeys(word);
                    //click search button
                    driver.FindElement(By.XPath("//*[@id='search-icon-legacy']/yt-icon")).Click();
                    //Sleep
                    System.Threading.Thread.Sleep(2000);
                    //get information of first yt video
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[1]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    //Go to previous page
                    driver.Navigate().Back();
                    //get information of second yt video
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[2]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    //Go to previous page
                    driver.Navigate().Back();

                    //''
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[3]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    //''
                    driver.Navigate().Back();
                    //''
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[4]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    //''
                    driver.Navigate().Back();
                    //''
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[5]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    //''
                    driver.Navigate().Back();
                    //Close driver
                    driver.Close();
                    //information in csv file
                    foreach (var item in list)
                    {
                        csvoutput.AppendLine(string.Join(strSeperator, item));
                    }
                    // Create and write the csv file
                    File.WriteAllText(strFilePath, csvoutput.ToString());
                    break;
                    //Begin Indeed
                case "indeed":
                    //Make list
                    List<string> list2 = new List<string>();
                    //Define path for CSV file
                    string strFilePath2 = @"C:\New folder\INDEEDdata.csv";
                    //Define the seperator
                    string strSeperator2 = ",";
                    //CSV Information String
                    StringBuilder csvoutput2 = new StringBuilder();
                    //Define Webdriver
                    IWebDriver driver2 = new ChromeDriver();
                    //Define JavaScriptExecutor to scroll
                    IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver2;
                    //go to website
                    driver2.Url = "https://be.indeed.com/advanced_search";
                    //sleep
                    System.Threading.Thread.Sleep(3000);
                    //Ask search information
                    Console.Write("What functions do you want to search: ");
                    //Read search information
                    string? function = Console.ReadLine();
                    //Ask location information
                    Console.Write("What location do you want to search at: ");
                    //read location information
                    string? location = Console.ReadLine();
                    //sleep
                    System.Threading.Thread.Sleep(3000);
                    //Fill in the information
                    driver2.FindElement(By.CssSelector("#as_and")).SendKeys(function);
                    driver2.FindElement(By.CssSelector("#where")).SendKeys(location);
                    //sleep
                    System.Threading.Thread.Sleep(2000);
                    //Dropdownlist
                    IWebElement dropdownlist = driver2.FindElement(By.XPath("/html/body/div[2]/form/fieldset[2]/div[2]/div[2]/select"));
                    SelectElement element = new SelectElement(dropdownlist);
                    element.SelectByIndex(3);
                    //sleep
                    System.Threading.Thread.Sleep(2000);
                    //Click search button
                    driver2.FindElement(By.XPath("/html/body/div[2]/form/button")).Click();
                    //sleep
                    System.Threading.Thread.Sleep(2000);
                    //job information
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[1]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[1]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[1]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[3]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[3]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[3]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[5]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[5]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[5]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //job information
                    System.Threading.Thread.Sleep(2000);
                    //Scroll to element by XPath
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[15]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[15]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[15]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[15]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);
                    //information in csv file
                    foreach (var item in list2)
                    {
                        csvoutput2.AppendLine(string.Join(strSeperator2, item));
                    }
                    // Create and write the csv file
                    File.WriteAllText(strFilePath2, csvoutput2.ToString());
                    //close driver
                    driver2.Close();
                    break;
                    //Begin Twitch
                case "twitch":
                    //Define lsit
                    List<string> list3 = new List<string>();
                    //Define path for CSV file
                    string strFilePath3 = @"C:\New folder\TWITCHdata.csv";
                    //Define seperator
                    string strSeperator3 = ",";
                    //CSV Information String
                    StringBuilder csvoutput3 = new StringBuilder();
                    //Define webdriver
                    IWebDriver driver3 = new ChromeDriver();
                    //Define JavaScriptExecutor to scroll
                    IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver3;
                    //go to website
                    driver3.Url = "https://www.twitch.tv";
                    //sleep
                    System.Threading.Thread.Sleep(4000);
                    //Ask information
                    Console.Write("What game category do you want to search: ");
                    //Read information
                    string? game = Console.ReadLine();
                    //input information
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/nav/div/div[2]/div/div/div/div/div[1]/div/div/div/input")).SendKeys(game);
                    System.Threading.Thread.Sleep(2000);
                    //Search button
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/nav/div/div[2]/div/div/div/div/div[2]/div/div[2]/div/div[1]/div/div/a/div")).Click();
                    System.Threading.Thread.Sleep(2000);
                    //Get information
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[2]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();
                    //Get information
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[3]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();
                    //Get information + scroll to XPATH
                    js3.ExecuteScript("arguments[0].scrollIntoView();", driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[4]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")));
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[4]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();
                    //Get information
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[5]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();
                    //Get information + scroll to XPATH
                    js3.ExecuteScript("arguments[0].scrollIntoView();", driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[6]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")));
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[6]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();
                    //information in csv file
                    foreach (var item in list3)
                    {
                        csvoutput3.AppendLine(string.Join(strSeperator3, item));
                    }
                    // Create and write the csv file
                    File.WriteAllText(strFilePath3, csvoutput3.ToString());
                    //Close driver
                    driver3.Close();
                    break;
            }
        }
    }
}