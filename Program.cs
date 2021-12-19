using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Text;


namespace WebScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my c# scraper.");
            Console.Write("What scraper do you want to use(youtube, indeed, twitch): ");
            string? choice = Console.ReadLine();
            string? makefolder = @"D:\New folder";
            System.IO.Directory.CreateDirectory(makefolder);

            switch (choice)
            {
                case "youtube":
                    List<string> list = new List<string>();
                    string strFilePath = @"D:\New folder\YTdata.csv";
                    string strSeperator = ",";
                    StringBuilder csvoutput = new StringBuilder();

                    IWebDriver driver = new ChromeDriver();
                    //go to website
                    driver.Url = "https://www.youtube.com";

                    System.Threading.Thread.Sleep(2000);
                    //accept popup
                    driver.FindElement(By.XPath("/html/body/ytd-app/ytd-consent-bump-v2-lightbox/tp-yt-paper-dialog/div[4]/div[2]/div[5]/div[2]/ytd-button-renderer[2]/a/tp-yt-paper-button/yt-formatted-string")).Click();

                    System.Threading.Thread.Sleep(2000);

                    Console.Write("What do you want to scrape on youtube: ");

                    string? word = Console.ReadLine();
                    //fill in searchbar
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/form/div[1]/div[1]/input")).SendKeys(word);
                    //click search button
                    driver.FindElement(By.XPath("//*[@id='search-icon-legacy']/yt-icon")).Click();

                    System.Threading.Thread.Sleep(2000);
                    //get information of first yt video
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[1]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    driver.Navigate().Back();
                    //get information of second yt video
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[2]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    driver.Navigate().Back();

                    //''
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[3]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    driver.Navigate().Back();
                    //''
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[4]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
                    driver.Navigate().Back();
                    //''
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[5]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
                    System.Threading.Thread.Sleep(1000);
                    list.Add(driver.Url);
                    list.Add(driver.Title);
                    list.Add(driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[9]/div[2]/ytd-video-secondary-info-renderer/div/div/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a")).Text.Trim());
                    list.Add(driver.FindElement(By.XPath("//*[@id='count']/ytd-video-view-count-renderer/span[1]")).Text.Trim());
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
                case "indeed":
                    List<string> list2 = new List<string>();
                    string strFilePath2 = @"D:\New folder\INDEEDdata.csv";
                    string strSeperator2 = ",";
                    StringBuilder csvoutput2 = new StringBuilder();
                    IWebDriver driver2 = new ChromeDriver();
                    IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver2;
                    //go to website
                    driver2.Url = "https://be.indeed.com/advanced_search";

                    System.Threading.Thread.Sleep(3000);
                    //fill in searchbar
                    Console.Write("What functions do you want to search: ");
                    string? function = Console.ReadLine();
                    Console.Write("What location do you want to search at: ");
                    string? location = Console.ReadLine();

                    System.Threading.Thread.Sleep(3000);
                    //input
                    driver2.FindElement(By.CssSelector("#as_and")).SendKeys(function);
                    driver2.FindElement(By.CssSelector("#where")).SendKeys(location);

                    //advance search
                    System.Threading.Thread.Sleep(2000);
                    IWebElement dropdownlist = driver2.FindElement(By.XPath("/html/body/div[2]/form/fieldset[2]/div[2]/div[2]/select"));
                    SelectElement element = new SelectElement(dropdownlist);
                    element.SelectByIndex(3);
                    System.Threading.Thread.Sleep(2000);

                    //search button
                    driver2.FindElement(By.XPath("/html/body/div[2]/form/button")).Click();


                    //popup
                    //driver2.FindElement(By.XPath("/html/body/div[5]/div[1]/button")).Click();
                    System.Threading.Thread.Sleep(2000);
                    //job information
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[1]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[1]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[1]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[2]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[3]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[3]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[3]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[4]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[5]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[5]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[5]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[6]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[7]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[8]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[9]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[10]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[11]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[12]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[13]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
                    js2.ExecuteScript("arguments[0].scrollIntoView();", driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")));
                    driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[1]/h2/span")).Click();
                    System.Threading.Thread.Sleep(2000);
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/span")).Text.Trim());
                    list2.Add(driver2.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td/table/tbody/tr/td[1]/div[5]/div/a[14]/div[1]/div/div[1]/div/table[1]/tbody/tr/td/div[2]/pre/div")).Text.Trim());
                    list2.Add(driver2.Url);

                    System.Threading.Thread.Sleep(2000);
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
                case "twitch":
                    List<string> list3 = new List<string>();
                    string strFilePath3 = @"D:\New folder\TWITCHdata.csv";
                    string strSeperator3 = ",";
                    StringBuilder csvoutput3 = new StringBuilder();
                    IWebDriver driver3 = new ChromeDriver();
                    IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver3;
                    //go to website
                    driver3.Url = "https://www.twitch.tv";

                    System.Threading.Thread.Sleep(4000);
                    //searchbar
                    Console.Write("What game category do you want to search: ");
                    string? game = Console.ReadLine();

                    //input
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/nav/div/div[2]/div/div/div/div/div[1]/div/div/div/input")).SendKeys(game);
                    System.Threading.Thread.Sleep(2000);
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/nav/div/div[2]/div/div/div/div/div[2]/div/div[2]/div/div[1]/div/div/a/div")).Click();
                    System.Threading.Thread.Sleep(2000);

                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[2]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();

                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[3]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();


                    js3.ExecuteScript("arguments[0].scrollIntoView();", driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[4]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")));

                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[4]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();

                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[5]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();

                    js3.ExecuteScript("arguments[0].scrollIntoView();", driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[6]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")));
                    driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div/div/div/div[4]/div[2]/div[1]/div[1]/div[6]/div/div/div/article/div[2]/div[5]/a/div/div[1]/img")).Click();
                    System.Threading.Thread.Sleep(4000);
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/a/h1")).Text.Trim());
                    list3.Add(driver3.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/main/div[2]/div[3]/div/div/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div[1]/div/p")).Text.Trim());
                    driver3.Navigate().Back();
                    //Close driver
                    driver3.Close();
                    //information in csv file
                    foreach (var item in list3)
                    {
                        csvoutput3.AppendLine(string.Join(strSeperator3, item));
                    }
                    // Create and write the csv file
                    File.WriteAllText(strFilePath3, csvoutput3.ToString());

                    break;
            }
        }
    }
}