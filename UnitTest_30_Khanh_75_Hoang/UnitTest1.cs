using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.SqlServer.Server;
using System.Threading;

namespace UnitTest_30_Khanh_75_Hoang
{
    [TestClass]
    public class UnitTest1
    {
        // khởi tạo giá trị chrome và IWebDriver
        ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
        IWebDriver driver_30_Khanh_75_Hoang;

        public TestContext TestContext_Register { get; set; }
        //lấy giá trị từ file Data_Register_30_Khanh_75_Hoang.csv

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  @".\Data_30_Khanh_75_Hoang\Data_Register_30_Khanh_75_Hoang.csv", "Data_Register_30_Khanh_75_Hoang#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestMethod_AccountRegister_30_Khanh_75_Hoang()
        {
            string fullName = TestContext_Register.DataRow[2].ToString();
            string phoneNumber = TestContext_Register.DataRow[3].ToString();
            string gender = TestContext_Register.DataRow[4].ToString();
            string dob = TestContext_Register.DataRow[5].ToString();
            string email = TestContext_Register.DataRow[6].ToString();
            string password = TestContext_Register.DataRow[7].ToString();
            string result = TestContext_Register.DataRow[8].ToString();
            // tắng màn hình cmd
            chrome.HideCommandPromptWindow = true;
            // sau khi 1 trang chrome khác hiện lên, phải tắt trang cũ để tránh đầy RAM, dẫn đến không click() được
            driver_30_Khanh_75_Hoang = new ChromeDriver(chrome);
            // Thiết lập thời gian load trang lên 2 phút để tránh xảy ra lỗi
            driver_30_Khanh_75_Hoang.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            // chờ nạp chrome
            Thread.Sleep(2000);
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ nạp web
            Thread.Sleep(2000);
            // bấm vào nút đăng nhập - thỉnh thoảng nút đăng nhập này không thể bấm bằng LinkText nên dùng XPath cho chắc
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"header\"]/div/div/div[4]/div/div/div[2]/a")).
                Click();
            // bấm vào nút đăng ký
            driver_30_Khanh_75_Hoang.
                FindElement(By.LinkText("Đăng ký")).
                Click();
            // nhập vào họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[last_name]")).
                SendKeys(fullName);
            // nhập số điện thoại
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("phone")).
                SendKeys(phoneNumber);
            // chọn vào ô chọn giới tính
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form-gender > select")).
                Click();
            // chọn giới tính
            if (gender != "") // nếu trường giá trị giới tính khác rỗng - tức không chọn giới tính
            {
                if (gender == "Nam")
                {
                    driver_30_Khanh_75_Hoang.
                        FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[2]")).
                        Click();
                }
                else
                {
                    driver_30_Khanh_75_Hoang.
                        FindElement(By.XPath("//*[@id=\"form-gender\"]/select/option[3]")).
                        Click();
                }
            }

            // nhập ngày sinh
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("customer[birthday]")).
                SendKeys(dob);
            // nhập email
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("input[type='email']")).
                SendKeys(email);
            // nhập mật khẩu
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("password")).
                SendKeys(password);
            // nhấn nút đăng ký
            driver_30_Khanh_75_Hoang.
                FindElement(By.ClassName("btn-primary")).
                Click();
            // chờ chuyển trang
            Thread.Sleep(20000);
            // lấy giá trị "Đăng ký thành công" của trang đăng ký thành công
            IWebElement successfulRegisterNotif = driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"hogwarts-theme\"]/div[8]/div/div[1]/p"));
            // Kiểm tra có vào trang đăng ký thành công được hay không
            Assert.AreEqual("Đăng ký thành công", successfulRegisterNotif.Text, result);
        }

        public TestContext TestContext_Purchase { get; set; }
        // lấy giá trị từ file Data_Purchase_30_Khanh_75_Hoang.csv
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //         @".\Data_30_Khanh_75_Hoang\Data_Purchase_30_Khanh_75_Hoang.csv", "Data_Purchase_30_Khanh_75_Hoang#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestMethod_Purchase_30_Khanh_75_Hoang()
        {
            //string productName = TestContext_Purchase.DataRow[2].ToString();
            //string fullName = TestContext_Purchase.DataRow[3].ToString();
            //string email = TestContext_Purchase.DataRow[4].ToString();
            //string phoneNumber = TestContext_Purchase.DataRow[5].ToString();
            //string address = TestContext_Purchase.DataRow[6].ToString();
            //string city = TestContext_Purchase.DataRow[7].ToString();
            //string province = TestContext_Purchase.DataRow[8].ToString();
            //string size = TestContext_Purchase.DataRow[9].ToString();
            //string temp_qty = TestContext_Purchase.DataRow[10].ToString();
            //Mua 1 sản phẩm,"Áo tay bồng có nơ","Khánh","vuongminhkhanh29@gmail.com","0912345678","Khu dân cư Nhơn Đức","Hồ Chí Minh","Huyện Nhà Bè","","","","",PASS
            //3,Mua 1 sản phẩm thiếu SĐT người nhận,"Áo tay bồng có nơ","Khánh","vuongminhkhanh29@gmail.com","","Khu dân cư Nhơn Đức","Hồ Chí Minh","Huyện Nhà Bè","","","","",FAIL
            //6,Mua 1 sản phẩm với size M,"Áo tay bồng có nơ","Khánh","vuongminhkhanh29@gmail.com","0912345678","Khu dân cư Nhơn Đức","Hồ Chí Minh","Huyện Nhà Bè","M","","","",PASS
            //7,Mua 1 sản phẩm với mã giảm giá sai,"Áo tay bồng có nơ","Khánh","vuongminhkhanh29@gmail.com","0912345678","Khu dân cư Nhơn Đức","Hồ Chí Minh","Huyện Nhà Bè","","","COD","happycoupon",FAIL
            //8,Mua 2 sản phẩm khác nhau,"Áo tay bồng có nơ, Áo thun nhún vai","Khánh","vuongminhkhanh29@gmail.com","0912345678","Khu dân cư Nhơn Đức","Hồ Chí Minh","Huyện Nhà Bè","","","Internet banking","",PASS
            string productName = "Áo tay bồng có nơ, Áo thun nhún vai";
            string fullName = "Khánh";
            string email = "vuongminhkhanh29@gmail.com";
            string phoneNumber = "0912345678";
            string address = "Khu dân cư Nhơn Đức";
            string city = "Hồ Chí Minh";
            string province = "Huyện Nhà Bè";
            string size = "";
            string temp_qty = "";

            int qty;
            if (temp_qty == "")
                qty = 1; // nếu trường số lượng là rỗng, thì gán bằng 1 như giá trị mặc định
            else
                qty = int.Parse(temp_qty);
            string paymentMethod = "Internet banking";
            string coupon = "";
            string result = "PASS";

            // tắng màn hình cmd
            chrome.HideCommandPromptWindow = true;
            // sau khi 1 trang chrome khác hiện lên, phải tắt trang cũ để tránh đầy RAM, dẫn đến không click() được
            driver_30_Khanh_75_Hoang = new ChromeDriver(chrome);
            // Thiết lập thời gian load trang lên 2 phút để tránh xảy ra lỗi
            driver_30_Khanh_75_Hoang.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            // chờ nạp chrome
            Thread.Sleep(2000);
            // vào trang himevn.com
            driver_30_Khanh_75_Hoang.Navigate().GoToUrl("https://himevn.com/");
            // chờ nạp web
            Thread.Sleep(2000);
            // click vào Sản phẩm mới
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#nav > nav > ul > li:nth-child(2) > a")).
                Click();
            // kiểm tra nếu không có sản phẩm nào được mua
            Thread.Sleep(2000);
            if (productName == "")
            {
                // chờ nạp trang
                Thread.Sleep(500);
                // bấm vào nút Giỏ hàng
                driver_30_Khanh_75_Hoang.
                    FindElement(By.CssSelector("#header > div > div > div.header-right > div > div > div.header-icon-cart.position-relative > div > div > span")).
                    Click();
                // chờ trang giỏ hàng popup hiện ra
                Thread.Sleep(500);
                // bấm thanh toán
                driver_30_Khanh_75_Hoang.
                    FindElement(By.LinkText("Thanh toán")).
                    Click();
                // kiểm tra giỏ hàng có trống hay không
                IWebElement emptyCartNotif = driver_30_Khanh_75_Hoang.
                    FindElement(By.XPath("//*[@id=\"layout-cart\"]/div/div/div[2]/div/div/div/p"));
                Console.WriteLine(emptyCartNotif.Text);
                Assert.IsFalse((emptyCartNotif.Text == "Giỏ hàng của bạn đang trống"), "Giỏ hàng của bạn đang trống");
            }

            // kiểm tra có mua 2 sản phẩm khác nhau hay không
            if (productName.Contains(","))
            {
                // tách chuỗi thành mảng 2 sản phẩm
                string[] products = productName.Split(',');
                // chọn Áo tay bồng cổ nơ
                driver_30_Khanh_75_Hoang.
                    FindElement(By.XPath("//*[@id=\"collection-body\"]/div/div/div/div/div[3]/div[1]/div[8]/div/div[2]/h3/a")).
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
                    FindElement(By.LinkText(products[1].Trim())).
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
            }
            else // nếu chỉ có một sản phẩm
            {
                // chọn sản phẩm
                driver_30_Khanh_75_Hoang.
                    FindElement(By.XPath("//*[@id=\"collection-body\"]/div/div/div/div/div[3]/div[1]/div[8]/div/div[2]/h3/a")).
                    Click();
                // chọn size - không dùng biến vì có nhiều loại size mà size lại không dùng link text để chọn được
                if (size != "") // chỉ lấy biến size để kiểm tra null
                {
                    driver_30_Khanh_75_Hoang.
                    FindElement(By.XPath("//*[@id=\"variant-swatch-0\"]/div[2]/div[2]/label")).
                    Click();
                }
                // bấm Thêm vào giỏ hàng
                driver_30_Khanh_75_Hoang.
                    FindElement(By.ClassName("add-to-cartProduct")).
                    Click();
                // chờ Popup hiện ra
                Thread.Sleep(500);
                // nếu có chọn số lượng sản phẩm
                if (qty > 1)
                {
                    // bấm Giỏ hàng
                    driver_30_Khanh_75_Hoang.
                        FindElement(By.ClassName("btnToCart")).
                        Click();

                    for (int i = 2; i <= qty; i++)
                    {
                        // click tăng số lượng
                        driver_30_Khanh_75_Hoang.
                        FindElement(By.CssSelector("#cartformpage > div:nth-child(1) > div > div > div.item > div.first > div > div > button.qtyplus.qty-btn")).
                        Click();
                    }
                    // chọn Thanh toán
                    driver_30_Khanh_75_Hoang.
                        FindElement(By.ClassName("btncart-checkout")).
                        Click();
                    // kiểm tra nếu số lượng tồn kho không đủ
                    IWebElement outOfStockNotif = driver_30_Khanh_75_Hoang.
                        FindElement(By.XPath("/html/body/div[2]/div/div[1]/h2"));
                    Console.WriteLine(outOfStockNotif.Text);
                    if (outOfStockNotif.Text == "Vấn đề tồn kho")
                    {

                        // lấy số lượng tồn kho để so sánh
                        // lấy chuỗi hiện thị không đủ tồn kho - VD: 5 → 1
                        IWebElement inStock = driver_30_Khanh_75_Hoang.
                            FindElement(By.XPath("/html/body/div[2]/div/div[2]/table/tbody/tr/td[2]/span"));
                        int instockNumber = int.Parse(inStock.Text.Split('→')[1].Trim());
                        Console.WriteLine($"instockNumber: {instockNumber}");

                        // Assert.AreSame cũng tương tự với Assert.AreEqual khi so sánh 2 đối tượng với nha
                        Assert.AreSame(qty, instockNumber, $"Mua {qty} nhưng chỉ tồn kho {instockNumber} - {result}");
                    }

                }
                else // nếu không tăng số lượng
                {
                    // bấm Thanh toán
                    driver_30_Khanh_75_Hoang.
                        FindElement(By.PartialLinkText("Thanh toán")).
                        Click();
                }
            }
            // nhập Họ tên
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("billing_address[full_name]")).
                SendKeys(fullName);
            // nhập Email
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("checkout_user_email")).
                SendKeys(email);
            // nhập SDT
            driver_30_Khanh_75_Hoang.
                FindElement(By.XPath("//*[@id=\"billing_address_phone\"]")).
                SendKeys(phoneNumber);
            // nhập Địa chỉ
            driver_30_Khanh_75_Hoang.
                FindElement(By.Name("billing_address[address1]")).
                SendKeys(address);
            // bấm vào Chọn tỉnh/thành
            driver_30_Khanh_75_Hoang.
                FindElement(By.Id("customer_shipping_province")).
                Click();
            // chọn option Hồ Chí Minh - không nhập biến city để tiết kiệm thời gian
            if (city != "") // chỉ lấy biến city kiểm tra null
            {
                driver_30_Khanh_75_Hoang.
                    FindElement(By.XPath("//*[@id=\"customer_shipping_province\"]/option[2]")).
                    Click();
                // chờ trang nạp các Quận/Huyện của Thành phố Hồ Chí Minh
                Thread.Sleep(500);
                // bấm vào chọn Quận/Huyện
                driver_30_Khanh_75_Hoang.
                    FindElement(By.Id("customer_shipping_district")).
                    Click();
                // chọn option Huyện Nhà Bè - không nhập biến province để tiết kiệm thời gian
                if (province != "") // chỉ lấy biến province kiểm tra null
                {
                    driver_30_Khanh_75_Hoang.
                    FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[2]/div[1]/div/div[3]/div/form/div/div/div[4]/div/select/option[6]")).
                    Click();
                }
            }
            Thread.Sleep(5000);
            // bấm vào Tiếp tục đến phương thức thanh toán
            driver_30_Khanh_75_Hoang.
                FindElement(By.CssSelector("#form_next_step > button")).
                Click();
            // kiểm tra nếu form điền thông tin có thiếu số điện thoại hoặc Tỉnh/Thành
            // lấy nguồn trang về để kiểm tra text
            Thread.Sleep(5000);
            var source = driver_30_Khanh_75_Hoang.PageSource;
            Console.WriteLine(source);
            // kiểm tra nếu form thông tin Số điện thoại không được trống hay Vui lòng chọn tỉnh thành
            Assert.IsTrue(!(source.Contains("Số điện thoại không được trống") || source.Contains("Vui lòng chọn tỉnh thành")),
                "Thiếu số điện thoại hoặc Tỉnh/Thành");

            // chờ tải trang Phương thức thanh toán
            Thread.Sleep(5000);
            // chọn Phương thức thanh toán là COD
            if (paymentMethod != "")
            {
                if (paymentMethod == "COD")
                {
                    driver_30_Khanh_75_Hoang.
                    FindElement(By.Id("payment_method_id_1003932356")).
                    Click();
                }
                else if (paymentMethod == "Internet banking")
                {
                    driver_30_Khanh_75_Hoang.
                    FindElement(By.Id("payment_method_id_1003932355")).
                    Click();
                }
                // else còn lại là mặc định chuyển khoản ví điện tử
            }
            if (coupon != "")
            {
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
                // kiểm tra nếu form điền thông tin có thiếu số điện thoại hoặc Tỉnh/Thành
                // lấy nguồn trang về để kiểm tra text
                source = driver_30_Khanh_75_Hoang.PageSource;
                // kiểm tra nếu form thông tin Số điện thoại không được trống hay Vui lòng chọn tỉnh thành
                Assert.IsTrue(source.Contains("Không tìm thấy mã giảm giá"),
                    "Sai mã giảm giá");
            }

            // Do không nhấn nút "Hoàn tất đơn hàng" nên chỉ dừng tại đây
        }
    }
}
