using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V122.IndexedDB;
using OpenQA.Selenium.DevTools.V85.IndexedDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Keys = OpenQA.Selenium.Keys;

namespace _30_Khanh_75_Hoang_N2_BTLKiemThu
{
    public class TimKiem
    {
        ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
        IWebDriver driver_30_Khanh_75_Hoang;
        public TimKiem() {
            chrome.HideCommandPromptWindow = true;
            driver_30_Khanh_75_Hoang = new ChromeDriver(chrome);
        }
        public bool timKiem(string tenSP_30_Khanh_75_Hoang)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSP_30_Khanh_75_Hoang);
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            if(driver_30_Khanh_75_Hoang.FindElements(By.ClassName("col-lg-3")).Count>0)
            {
                driver_30_Khanh_75_Hoang.Quit();
                return true;
            }
            driver_30_Khanh_75_Hoang.Quit();
            return false;
        }
        public bool chiuTai_30_Khanh_75_Hoang(string tenSP_30_Khanh_75_Hoang)
        {
            //vào https://himevn.com/search?type=product
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/search?type=product");
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            for (int i = 0; i < 15; i++)
            {
                driver_30_Khanh_75_Hoang.FindElement(By.ClassName("search_box")).SendKeys(tenSP_30_Khanh_75_Hoang);
                Thread.Sleep(400);
            }

            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("search_box")).SendKeys(Keys.Enter);
            if(driver_30_Khanh_75_Hoang.FindElement(By.ClassName("error-code")) != null && driver_30_Khanh_75_Hoang.FindElement(By.ClassName("error-code")).Text.Contains("414"))
            return false;
            return true;
        }
    }
}
