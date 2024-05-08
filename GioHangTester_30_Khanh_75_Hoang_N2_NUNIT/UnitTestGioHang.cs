using _30_Khanh_75_Hoang_N2_BTLKiemThu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace GioHangTester_30_Khanh_75_Hoang_N2_NUNIT
{
    [TestClass]
    public class UnitTestGioHang
    {
        public TestContext TestContext { get; set; }
        _30_Khanh_75_Hoang_N2_BTLKiemThu.GioHang test_30_Khanh_75_Hoang;
        [TestInitialize] // thiết lập dữ liệu dùng chung cho TC
        public void SetUp()
        {
            test_30_Khanh_75_Hoang = new _30_Khanh_75_Hoang_N2_BTLKiemThu.GioHang();
        }
        [TestMethod]// TC1: tenSP="Chân váy xếp li" kq = "Chân váy xếp li"
        public void Test_Them_SP_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "Chân váy xếp li";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.ThemMotSanPham_30_Khanh_75_Hoang(tenSP);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC2: tenSP="Chân váy xếp li" kq = "Sản phẩm bạn vừa mua đã vượt quá tồn kho"
        public void Test_Them_SP_Trung_Nhau_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "Sản phẩm bạn vừa mua đã vượt quá tồn kho";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.ThemHaiSanPhamTrungNhau_30_Khanh_75_Hoang(tenSP);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC3: tenSP="Chân váy xếp li" soLuong =2 kq = 2
        public void Test_Cap_Nhat_So_Luong_SP()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            int soLuong = 2;
            expected_30_Khanh_75_Hoang = "2";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.CapNhatSoLuongSanPham_30_Khanh_75_Hoang(tenSP, soLuong);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC4: tenSP="Chân váy xếp li" soLuong =1000000 kq = 1000000
        public void Test_Cap_Nhat_So_Luong_SPLon_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            int soLuong = 1000000;
            expected_30_Khanh_75_Hoang = "1000000";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.CapNhatSoLuongSanPham_30_Khanh_75_Hoang(tenSP, soLuong);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC5: tenSP="Chân váy xếp li" soLuong = -10 kq = 1
        public void Test_Cap_Nhat_So_Luong_Am_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            int soLuong = -10;
            expected_30_Khanh_75_Hoang = "1";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.CapNhatSoLuongSanPham_30_Khanh_75_Hoang(tenSP, soLuong);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC6: tenSP="Chân váy xếp li" kq = Giỏ hàng của bạn đang trống
        public void Test_xoa_san_pham_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "Giỏ hàng của bạn đang trống";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.xoaSanPham_30_Khanh_75_Hoang(tenSP);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC7: tenSP="Chân váy xếp li" soLuong = 0 kq = Giỏ hàng của bạn đang trống
        public void Test_Cap_Nhat_So_Luong_bang0_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            int soLuong = 0;
            expected_30_Khanh_75_Hoang = "0";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.CapNhatSoLuongSanPham_30_Khanh_75_Hoang(tenSP, soLuong);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC8: tenSP="Chân váy xếp li" soLuong = 1 kq = 499000
        public void Test_Tinh_Tong_Tien_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            int soLuong = 1;
            expected_30_Khanh_75_Hoang = "499000";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.TinhTongTien_30_Khanh_75_Hoang(tenSP, soLuong);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC9: tenSP="Chân váy xếp li" soLuong = 1000000 kq = 499000000000
        public void Test_Tinh_Tong_Tien_Khi_So_Luong_Lon_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            int soLuong = 1000000;
            expected_30_Khanh_75_Hoang = "499000000000";
            string tenSP = "Chân váy xếp li";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.TinhTongTien_30_Khanh_75_Hoang(tenSP, soLuong);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC10: kq=0
        public void Test_Xem_gio_hang_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "0";
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.XemGioHang_30_Khanh_75_Hoang();
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC11: tenSP="Chân váy xếp li" soLuong = 1 kq = 1
        public void Test_Xem_Hang_Khi_ThemSP_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "1";
            string tenSP = "Chân váy xếp li";
            test_30_Khanh_75_Hoang.ThemSanPham_30_Khanh_75_Hoang(tenSP);
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.XemGioHang_30_Khanh_75_Hoang().ToString();
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC12: tenSP="Chân váy xếp li" soLuong = 1 kq = 1
        public void Test_Xem_SP_Khi_Thoat_web_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "1";
            string tenSP = "Chân váy xếp li";
            //đăng nhập
            test_30_Khanh_75_Hoang.DangNhap_30_Khanh_75_Hoang();
            //Thêm sản phẩm
            test_30_Khanh_75_Hoang.ThemSanPham_30_Khanh_75_Hoang(tenSP);
            //Đăng xuất
            test_30_Khanh_75_Hoang.DangXuat_30_Khanh_75_Hoang();
            //đăng nhập lại
            test_30_Khanh_75_Hoang.DangNhap_30_Khanh_75_Hoang();
            //xem lại giỏ hàng
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.XemGioHang_30_Khanh_75_Hoang();
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]// TC13: tenSP="Chân váy xếp li" soLuong = 1 kq = 0
        public void Test_Xem_Hang_Khi_Dang_Xuat_30_Khanh_75_Hoang()
        {
            string expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            expected_30_Khanh_75_Hoang = "0";
            string tenSP = "Chân váy xếp li";
            //đăng nhập
            test_30_Khanh_75_Hoang.DangNhap_30_Khanh_75_Hoang();
            //Thêm sản phẩm
            test_30_Khanh_75_Hoang.ThemSanPham_30_Khanh_75_Hoang(tenSP);
            //Đăng xuất
            test_30_Khanh_75_Hoang.DangXuat_30_Khanh_75_Hoang();
            //xem lại giỏ hàng
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.XemGioHang_30_Khanh_75_Hoang();
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
    }
}

