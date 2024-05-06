using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
    public partial class Form1_30_Khanh_75_Hoang_N2 : Form
    {
        ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
        IWebDriver driver_30_Khanh_75_Hoang;

        public Form1_30_Khanh_75_Hoang_N2()
        {
            InitializeComponent();
            chrome.HideCommandPromptWindow = true;
            driver_30_Khanh_75_Hoang = new ChromeDriver(chrome);
        }

        private void btn1_tc1_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[last_name]")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form-gender > select")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@gmail.com");

            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("password")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.ClassName("btn-primary")).
            //    Click();
        }

        private void btn1_tc2_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#last_name")).
                SendKeys("");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[phone]")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.TagName("select")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form-gender > select > option:nth-child(2)")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("birth")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("email")).
                SendKeys("vuongminhkhanh29@gmail.com");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='password']")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.ClassName("btn-primary")).
            //    Click();
        }

        private void btn1_tc3_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[8]/div/div[2]/div/div/div[2]/form/div[1]/input")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[gender]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#email")).
                SendKeys("vuongminhkhanh29@gmail.com");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("password")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.CssSelector("input[type='submit']")).
            //    Click();
        }

        private void btn1_tc4_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[last_name]")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@gmail.com");

            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("password")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.XPath("//*[@id=\"create_customer\"]/div[7]/div/input")).
            //    Click();
        }

        private void btn1_tc5_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#last_name")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[phone]")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.TagName("select")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form-gender > select > option:nth-child(2)")).
                Click();
            // không nhập ngày sinh
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("email")).
                SendKeys("vuongminhkhanh29@gmail.com");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='password']")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.ClassName("btn-primary")).
            //    Click();
        }

        private void btn1_tc6_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[8]/div/div[2]/div/div/div[2]/form/div[1]/input")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[gender]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("password")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.CssSelector("input[type='submit']")).
            //    Click();
        }

        private void btn1_tc7_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[last_name]")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[gender]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@gmail.com");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.XPath("//*[@id=\"create_customer\"]/div[7]/div/input")).
            //    Click();
        }

        private void btn1_tc8_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#last_name")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[phone]")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.TagName("select")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form-gender > select > option:nth-child(2)")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("email")).
                SendKeys("vuongminhkhanh29@gmail.com");

            // mật khẩu chỉ có chữ, không có số, chữ hoa, ký tự đặc biệt
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='password']")).
                SendKeys("admin");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.ClassName("btn-primary")).
            //    Click();
        }

        private void btn1_tc9_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[last_name]")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[gender]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29gmail.com");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("password")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.XPath("//*[@id=\"create_customer\"]/div[7]/div/input")).
            //    Click();
        }

        private void btn1_tc10_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#last_name")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[phone]")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.TagName("select")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form-gender > select > option:nth-child(2)")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("email")).
                SendKeys("@vuongminhkhanh29");

            
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='password']")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.ClassName("btn-primary")).
            //    Click();
        }

        private void btn1_tc11_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng nhập")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[last_name]")).
                SendKeys("Khánh Vương");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys("0912345678");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[gender]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys("02/09/2003");

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@");

            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("password")).
                SendKeys("Admin@123");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.XPath("//*[@id=\"create_customer\"]/div[7]/div/input")).
            //    Click();
        }

        private void btn3_tc3_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#nav > nav > ul > li:nth-child(2) > a")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Áo tay bồng cổ nơ")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("add-to-cartProduct")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.PartialLinkText("Thanh toán")).
                Click();
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("billing_address[full_name]")).
                SendKeys("Khánh");
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("checkout_user_email")).
                SendKeys("vuongminhkhanh29@gmail.com");

            // không điền vào số điện thoại
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("billing_address[address1]")).
                SendKeys("Khu dân cư Nhơn Đức");
            // bấm vào Chọn tỉnh/thành
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_province")).
                Click();
            // chọn option Hồ Chí Minh
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"customer_shipping_province\"]/option[2]")).
                Click();
            // chờ trang nạp các Quận/Huyện của Thành phố Hồ Chí Minh
            Thread.Sleep(500);
            // bấm vào chọn Quận/Huyện
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_district")).
                Click();
            // chọn option Huyện Nhà Bè
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[1]/div/div[3]/div/form/div/div/div[4]/div/select/option[6]")).
                Click();
            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form_next_step > button")).
                Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }

        private void btn3_tc2_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // đăng nhập tài khoản
            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.CssSelector("customer[email]")).
            //    SendKeys("vuongminhkhanh29@gmail.com");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.CssSelector("customer[password]")).
            //    SendKeys("Admin@123");

            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Sản phẩm mới")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#collection-body > div > div > div > div > div.filter-here > div.row.row-8.content-product-list.product-list.filter.clearfix > div:nth-child(1) > div > div.product-detail > h3 > a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("add-to-cart")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnProceedCheckout")).
                Click();
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_full_name")).
                SendKeys("Khánh");
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("checkout_user[email]")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // nhập SDT
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"billing_address_phone\"]")).
                SendKeys("0912345678");
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/ html / body / div[3] / div / div[2] / div[2] / div[2] / div[1] / div / div[3] / div / form / div / div / div[2] / div / input")).
                SendKeys("Khu dân cư Nhơn Đức");
            // bấm vào Chọn tỉnh/thành
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#customer_shipping_province")).
                Click();
            // chọn option Hồ Chí Minh
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"customer_shipping_province\"]/option[2]")).
                Click();
            // chờ trang nạp các Quận/Huyện của Thành phố Hồ Chí Minh
            Thread.Sleep(500);
            // bấm vào chọn Quận/Huyện
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_district")).
                Click();
            // chọn option Huyện Nhà Bè
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[1]/div/div[3]/div/form/div/div/div[4]/div/select/option[6]")).
                Click();
            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("step-footer-continue-btn")).
                Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }
        private void btn3_tc1_Click(object sender, EventArgs e)
        {
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.CssSelector("customer[email]")).
            //    SendKeys("vuongminhkhanh29@gmail.com");

            //driver_30_Khanh_75_Hoang.
            //    FindElement(By.CssSelector("customer[password]")).
            //    SendKeys("Admin@123");

            Thread.Sleep(500);

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#header > div > div > div.header-right > div > div > div.header-icon-cart.position-relative > div > div > span")).
                Click();

            Thread.Sleep(500);

            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Thanh toán")).
                Click();
        }

        private void btn3_tc4_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[6]/header/div/div/div[1]/div[1]/div/div/nav/ul/li[2]/a")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"collection-body\"]/div/div/div/div/div[3]/div[1]/div[1]/div/div[2]/h3/a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("add")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnProceedCheckout")).
                Click();
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#billing_address_full_name")).
                SendKeys("Khánh");
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // nhập SDT
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_phone")).
                SendKeys("0912345678");
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_address1")).
                SendKeys("Khu dân cư Nhơn Đức");
            
            // không chọn Tỉnh/thành

            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
            FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[2]/form/button")).
            Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }

        private void btn3_tc5_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");

            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Sản phẩm mới")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#collection-body > div > div > div > div > div.filter-here > div.row.row-8.content-product-list.product-list.filter.clearfix > div:nth-child(1) > div > div.product-detail > h3 > a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("add-to-cart")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnToCart")).
                Click();
            // click dấu + 4 lần để tăng số lượng lên 5
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#cartformpage > div:nth-child(1) > div > div > div.item > div.first > div > div > button.qtyplus.qty-btn")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#cartformpage > div:nth-child(1) > div > div > div.item > div.first > div > div > button.qtyplus.qty-btn")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#cartformpage > div:nth-child(1) > div > div > div.item > div.first > div > div > button.qtyplus.qty-btn")).
                Click();

            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#cartformpage > div:nth-child(1) > div > div > div.item > div.first > div > div > button.qtyplus.qty-btn")).
                Click();
            // chọn Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btncart-checkout")).
                Click();

            // Do không đủ hàng, nên khi nhấn tiếp tục, màn hình vẫn chuyển sang nhập thông tin khách hàng,
            // nhưng giảm xuống số lượng còn tồn lớn nhất
        }

        private void btn3_tc6_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#nav > nav > ul > li:nth-child(2) > a")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Áo tay bồng cổ nơ")).
                Click();
            // chọn size M
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"variant-swatch-0\"]/div[2]/div[2]/label")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("add-to-cartProduct")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.PartialLinkText("Thanh toán")).
                Click();
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("billing_address[full_name]")).
                SendKeys("Khánh");
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("checkout_user_email")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // điền vào số điện thoại
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#billing_address_phone")).
                SendKeys("0912345678");
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("billing_address[address1]")).
                SendKeys("Khu dân cư Nhơn Đức");
            // bấm vào Chọn tỉnh/thành
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_province")).
                Click();
            // chọn option Hồ Chí Minh
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"customer_shipping_province\"]/option[2]")).
                Click();
            // chờ trang nạp các Quận/Huyện của Thành phố Hồ Chí Minh
            Thread.Sleep(500);
            // bấm vào chọn Quận/Huyện
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_district")).
                Click();
            // chọn option Huyện Nhà Bè
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[1]/div/div[3]/div/form/div/div/div[4]/div/select/option[6]")).
                Click();
            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form_next_step > button")).
                Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }

        private void btn3_tc7_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[6]/header/div/div/div[1]/div[1]/div/div/nav/ul/li[2]/a")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"collection-body\"]/div/div/div/div/div[3]/div[1]/div[1]/div/div[2]/h3/a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("add")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnProceedCheckout")).
                Click();
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#billing_address_full_name")).
                SendKeys("Khánh");
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // nhập SDT
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_phone")).
                SendKeys("0912345678");
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_address1")).
                SendKeys("Khu dân cư Nhơn Đức");
            // bấm vào Chọn tỉnh/thành
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_province")).
                Click();
            // chọn option Hồ Chí Minh
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"customer_shipping_province\"]/option[2]")).
                Click();
            // chờ trang nạp các Quận/Huyện của Thành phố Hồ Chí Minh
            Thread.Sleep(500);
            // bấm vào chọn Quận/Huyện
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_district")).
                Click();
            // chọn option Huyện Nhà Bè
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[1]/div/div[3]/div/form/div/div/div[4]/div/select/option[6]")).
                Click();
            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[2]/form/button")).
                Click();
            // chờ tải trang Phương thức thanh toán
            Thread.Sleep(500);
            // chọn Phương thức thanh toán là COD
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("payment_method_id_1003932356")).
                Click();
            // chờ reset sau khi thay đổi Phương thức thanh toán
            Thread.Sleep(500);
            // nhập Mã giảm giá
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[1]/div/div/div/div[2]/form/div/div/div/div/input")).
                SendKeys("happycoupon");
            // bấm Sử dụng
            Thread.Sleep(500);
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[1]/div/div/div/div[2]/form/div/div/div/button")).
                Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }

        private void btn3_tc8_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[6]/header/div/div/div[1]/div[1]/div/div/nav/ul/li[2]/a")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"collection-body\"]/div/div/div/div/div[3]/div[1]/div[1]/div/div[2]/h3/a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("add")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnToCart")).
                Click();
            // bấm Xem thêm
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Xem thêm")).
                Click();
            // chọn Áo thun nhún vai
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"collection-body\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/h3/a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("add")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnProceedCheckout")).
                Click();
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#billing_address_full_name")).
                SendKeys("Khánh");
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // nhập SDT
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_phone")).
                SendKeys("0912345678");
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("billing_address_address1")).
                SendKeys("Khu dân cư Nhơn Đức");
            // bấm vào Chọn tỉnh/thành
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#customer_shipping_province")).
                Click();
            // chọn option Hồ Chí Minh
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"customer_shipping_province\"]/option[2]")).
                Click();
            // chờ trang nạp các Quận/Huyện của Thành phố Hồ Chí Minh
            Thread.Sleep(500);
            // bấm vào chọn Quận/Huyện
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_district")).
                Click();
            // chọn option Huyện Nhà Bè
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[1]/div/div[3]/div/form/div/div/div[4]/div/select/option[6]")).
                Click();
            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[2]/form/button")).
                Click();
            // chờ trang Phương thức thanh toán tải
            Thread.Sleep(500);
            // chọn Phương thức thanh toán là Chuyển khoản ngân hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("payment_method_id_1003932355")).
                Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }

        private void btn3_tc9_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ load trang
            Thread.Sleep(500);
            // bấm Đăng nhập
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[2]/a/span")).
                Click();
            // nhập tài khoản
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_email")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // nhập mật khẩu
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[password]")).
                SendKeys("Admin@123");
            // bấm Đăng nhập
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btn-signin")).
                Click();
            // chờ load về trang chủ
            Thread.Sleep(500);
            // bấm Giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#header > div > div > div.header-right > div > div > div.header-icon-cart.position-relative > div > div > span")).
                Click();
            // chờ trang Giỏ hàng hiện ra
            Thread.Sleep(500);
            // bấm vào Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Thanh toán")).
                Click();

            // do chưa có sản phẩm nào trong giỏ hàng, nên không thể thanh toán
        }

        private void btn3_tc10_Click(object sender, EventArgs e)
        {
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // bấm Đăng nhập
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[2]/a/span")).
                Click();
            // nhập tài khoản
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_email")).
                SendKeys("vuongminhkhanh29@gmail.com");
            // nhập mật khẩu
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[password]")).
                SendKeys("Admin@123");
            // bấm Đăng nhập
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btn-signin")).
                Click();
            // chờ load trang
            Thread.Sleep(500);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Sản phẩm mới")).
                Click();
            // chọn Áo tay bồng cổ nơ
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#collection-body > div > div > div > div > div.filter-here > div.row.row-8.content-product-list.product-list.filter.clearfix > div:nth-child(1) > div > div.product-detail > h3 > a")).
                Click();
            // bấm Thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("add-to-cart")).
                Click();
            // chờ Popup hiện ra
            Thread.Sleep(500);
            // bấm Thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btnProceedCheckout")).
                Click();

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }

        private void btDangNhapThanhCong_75_Hoang_Click(object sender, EventArgs e)
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
        }

        private void btDangNhapTC2_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //Ghi mật khẩu
            driver_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("Admin@123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
        }

        private void btDangNhapTC3_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("vuongminhkhanh29@gmail.com");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
        }

        private void btDangNhapTC4_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
        }

        private void btDangNhapTC5_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("Hoangila2016222@gmail.com");
            //Ghi mật khẩu
            driver_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("Admin@123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
        }

        private void btDangNhapTC6_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("vuongminhkhanh29@gmail.com");
            //Ghi mật khẩu
            driver_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("123123123123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
        }

        private void btDangNhapTC7_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("áhuduahsdu");
            //Ghi mật khẩu
            driver_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("123123123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();

        }

        private void btDangNhapTC8_75_Hoang_Click(object sender, EventArgs e)
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


            //mở web ở trang mới
            IWebDriver driver2_30_Khanh_75_Hoang;
            chrome.HideCommandPromptWindow = true;
            driver2_30_Khanh_75_Hoang = new ChromeDriver(chrome);
            //vào https://himevn.com/account/login
            driver2_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver2_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("vuongminhkhanh29@gmail.com");
            //Ghi mật khẩu
            driver2_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("Admin@123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver2_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
        }

        private void btDangNhapTC9_75_Hoang_Click(object sender, EventArgs e)
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
            Thread.Sleep(3000);
            // Kiểm tra xem có chuyển hướng đến trang chính không
            if (driver_30_Khanh_75_Hoang.Url == "https://himevn.com/account")
            {
                Thread.Sleep(3000);
                //nếu đăng nhập thành công thì chuyển hướng trang khác
                driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://www.google.com/");
                //sau đó chuyển lại về trang https://himevn.com/account
                Thread.Sleep(3000);
                driver_30_Khanh_75_Hoang.Navigate().Back();
            }
        }

        private void btDangNhapTC10_75_Hoang_Click(object sender, EventArgs e)
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
            Thread.Sleep(3000);
            //nhấn nút logout
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"hogwarts-theme\"]/div[8]/div[2]/div/div[1]/div/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);
            if(driver_30_Khanh_75_Hoang.Url == "https://himevn.com/")
            //vào lại trang https://himevn.com/account xem có vào được không
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account");


        }

        private void btGioHangTC1_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
        }

        private void btGioHangTC2_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
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
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            //ấn nút ok
            Thread.Sleep(10000);
            driver_30_Khanh_75_Hoang.SwitchTo().Alert().Accept();
        }

        private void btGioHangTC3_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
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
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys("2");
            //nhấn enter
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);

        }

        private void btGioHangTC4_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
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
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys("1000000");
            //nhấn enter
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        private void btGioHangTC5_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
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
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys("-10");
            //nhấn enter
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"updates_1122386468\"]")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        private void btGioHangTC6_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            Thread.Sleep(1000);
            // bấm vào nút xóa
            driver_30_Khanh_75_Hoang.FindElement(By.CssSelector("#cartformpage > div:nth-child(1) > div > div > div.item > div.last > div > a > img")).Click();  
        }

        private void btGioHangTC9_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            Thread.Sleep(2000);
            //click vào icon giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[3]/div")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("linktocheckout")).Click();
        }

        private void btGioHangTC10_75_Hoang_Click(object sender, EventArgs e)
        {
            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            Thread.Sleep(2000);
            //click vào icon giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[3]/div")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("linktocheckout")).Click();
        }

        private void btGioHangTC11_75_Hoang_Click(object sender, EventArgs e)
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
            Thread.Sleep(3000);


            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            Thread.Sleep(2000);

            //vào lại trang https://himevn.com/account 
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account");
            //nhấn nút logout
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"hogwarts-theme\"]/div[8]/div[2]/div/div[1]/div/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);

            //đăng nhập lại
            //vào https://himevn.com/account/login
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account/login");
            //ghi tài khoản
            driver_30_Khanh_75_Hoang.FindElement(By.Id("customer_email")).SendKeys("vuongminhkhanh29@gmail.com");
            //Ghi mật khẩu
            driver_30_Khanh_75_Hoang.FindElement(By.Name("customer[password]")).SendKeys("Admin@123");
            Thread.Sleep(3000);
            //nhấn nút đăng nhập
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btn-signin")).Click();
            Thread.Sleep(3000);

            //click vào icon giỏ hàng để kiểm tra
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[3]/div")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("linktocheckout")).Click();


        }

        private void btGioHangTC12_75_Hoang_Click(object sender, EventArgs e)
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
            Thread.Sleep(3000);


            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            //click vào icon tìm kiếm
            Thread.Sleep(3000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("svg-icon-search")).Click();
            //Nhập vào thanh tìm kiếm
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys("Chân");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" váy");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" xếp");
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.Id("inputSearchAuto-3")).SendKeys(" li");
            Thread.Sleep(3000);
            //nhấn vào ảnh sản phẩm tìm kiếm
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"ajaxSearchResults-3\"]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(3000);
            //click vào nút thêm vào giỏ hàng
            driver_30_Khanh_75_Hoang.FindElement(By.Name("add")).Click();
            Thread.Sleep(2000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("btnToCart")).Click();
            Thread.Sleep(2000);

            //vào lại trang https://himevn.com/account 
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account");
            //nhấn nút logout
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"hogwarts-theme\"]/div[8]/div[2]/div/div[1]/div/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);
            //vào lại trang https://himevn.com/account để kiểm tra đã logout chưa
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/account");
            Thread.Sleep(3000);

            //vào https://himevn.com/
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            Thread.Sleep(2000);
            //click vào icon giỏ hàng để kiểm tra
            driver_30_Khanh_75_Hoang.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[3]/div")).Click();
            Thread.Sleep(1000);
            driver_30_Khanh_75_Hoang.FindElement(By.ClassName("linktocheckout")).Click();
        }
    }
}
