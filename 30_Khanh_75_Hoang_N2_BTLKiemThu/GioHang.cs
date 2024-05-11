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
    public class GioHang
    {
        ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
        IWebDriver driver_30_Khanh_75_Hoang;
        public GioHang() {
            chrome.HideCommandPromptWindow = true;
            driver_30_Khanh_75_Hoang = new ChromeDriver(chrome);
        }
        public string ThemMotSanPham_30_Khanh_75_Hoang(string tenSp)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSp);
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(1000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(500);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            // lấy tên sản phẩm trong giỏ hàng
            string ten = driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"cartformpage\"]/div[1]/div/div/div[2]/div[1]/h3/a")).Text;
            driver_30_Khanh_75_Hoang.Quit();
            return ten;       
        }
        public string ThemHaiSanPhamTrungNhau_30_Khanh_75_Hoang(string tenSp)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSp);
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(1000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            Thread.Sleep(2000);


            //click vào icon tìm kiếm lần 2
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSp);
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(500);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(1000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            //ấn nút ok
            Thread.Sleep(2000);
            string thongBao = driver_30_Khanh_75_Hoang.SwitchTo().Alert().Text;
            driver_30_Khanh_75_Hoang.Quit();
            return thongBao;
        }
        public string CapNhatSoLuongSanPham_30_Khanh_75_Hoang(string tenSp,int soLuong)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSp);
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(1000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            //Gửi số lượng là 2
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).Clear();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(soLuong.ToString());
            //nhấn enter
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            string sl;
            sl = driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[3]/div/span/span")).Text;
            driver_30_Khanh_75_Hoang.Quit();
            return sl;
        }
        public string xoaSanPham_30_Khanh_75_Hoang(string tenSp)
        {
            //vào giỏ hàng
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/cart");
            string trangThai = "xóa thất bại";
            //Lấy danh sách sản phẩm trong giỏ
            IReadOnlyCollection<IWebElement> elements_30_Khanh_75_Hoang = driver_30_Khanh_75_Hoang.FindElements(By.ClassName("item"));
            //kiểm tra có sản phẩm trong giỏ không
            int index = 1;
            if (elements_30_Khanh_75_Hoang.Count > 0)
                foreach (IWebElement element_30_Khanh_75_Hoang in elements_30_Khanh_75_Hoang)
                {
                    // kiểm tra có sản phẩm không
                    if (element_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"cartformpage\"]/div[1]/div/div[" + index + "]/div[2]/div[1]/h3/a")).Text == tenSp)
                    {//*[@id="cartformpage"]/div[1]/div/div[2]/div[2]/div[1]/h3/a
                        //nếu có thì xóa
                        element_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"cartformpage\"]/div[1]/div/div[" + index + "]/div[2]/div[2]/div/a")).Click();
                        //*[@id="cartformpage"]/div[1]/div/div[2]/div[2]/div[2]/div/a
                        trangThai = "xóa thành công";
                        return trangThai;
                    }
                    index++;
                }
            driver_30_Khanh_75_Hoang.Quit(); 
            return trangThai;
        }
        public string TinhTongTien_30_Khanh_75_Hoang(string tenSp, int soLuong)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSp);
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(1000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            //Gửi số lượng là 2
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).Clear();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(soLuong.ToString());
            //nhấn enter
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            string tongTien;
            try
            {
                //lấy thông báo tổng tiền
                tongTien = driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"cartformpage\"]/div[2]/div[2]/div[1]/div/div[2]/p/span")).Text;
                tongTien = tongTien.Replace(",", "").Replace("vnđ", "").Trim();
            }
            //nếu không tìm thấy số
            catch (NoSuchElementException)
            {
                //lấy thông báo
                tongTien = driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"layout-cart\"]/div/div/div[2]/div/div/div/p")).Text;
                driver_30_Khanh_75_Hoang.Quit();
                return tongTien;
            }
            driver_30_Khanh_75_Hoang.Quit();
            return tongTien;
        }
        public void ThemSanPham_30_Khanh_75_Hoang(string tenSp)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(tenSp);
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" ");
            Thread.Sleep(1000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(500);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();

        }
        public string XemGioHang_30_Khanh_75_Hoang()
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            Thread.Sleep(2000);
            //click vào icon giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[3]/div")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("linktocheckout")).Click();
            IWebElement container = driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id='layout-cart']/div/div/div[2]"));
            IReadOnlyCollection<IWebElement> aElements = container.FindElements(By.ClassName("product_image"));
            string numberOfATags = aElements.Count.ToString();
            return numberOfATags;
        }
        public void DangNhap_30_Khanh_75_Hoang()
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("vuongminhkhanh29@gmail.com");
            //Ghi mật khẩu
            driver_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("Admin@123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
            Thread.Sleep(2000);
        }
        public void DangXuat_30_Khanh_75_Hoang()
        {
            //vào lại trang https://himevn.com/account 
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account");
            //nhấn nút logout
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"hogwarts-theme\"]/div[8]/div[2]/div/div[1]/div/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);
            //vào lại trang https://himevn.com/account để kiểm tra đã logout chưa
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account");
            Thread.Sleep(3000);
        }

    }
}
