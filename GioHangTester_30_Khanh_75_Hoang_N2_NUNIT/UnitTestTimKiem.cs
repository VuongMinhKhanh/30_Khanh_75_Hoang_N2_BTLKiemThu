using _30_Khanh_75_Hoang_N2_BTLKiemThu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GioHangTester_30_Khanh_75_Hoang_N2_NUNIT
{
    [TestClass]
    public class UnitTestTimKiem
    {
        public TestContext TestContext { get; set; }
        TimKiem test_30_Khanh_75_Hoang;
        [TestInitialize] // thiết lập dữ liệu dùng chung cho TC
        public void SetUp()
        {
            test_30_Khanh_75_Hoang = new TimKiem();
        }

        [TestMethod]
        public void tc1_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "Chân váy xếp li";
            expected_30_Khanh_75_Hoang ="có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc2_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "siadihsabdsh";
            expected_30_Khanh_75_Hoang = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc3_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "";
            expected_30_Khanh_75_Hoang = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc4_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "Váy";
            expected_30_Khanh_75_Hoang = "có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc5_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "Váy+ Đầm";
            expected_30_Khanh_75_Hoang = "có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc6_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "Váy+ Đầm+ Quần";
            expected_30_Khanh_75_Hoang = "có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc7_30_Khanh_75_Hoang()
        {
            string tenSP_30_Khanh_75_Hoang, expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang = "không có";
            tenSP_30_Khanh_75_Hoang = "@";
            expected_30_Khanh_75_Hoang = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP_30_Khanh_75_Hoang) == true)
                actual_30_Khanh_75_Hoang = "có";
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
        [TestMethod]
        public void tc8_30_Khanh_75_Hoang()
        {
            bool expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang;
            string tenSP_30_Khanh_75_Hoang = "auishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdauishduiashduiashdashdiuauishduiashduiashdashd";
            expected_30_Khanh_75_Hoang = true;
            actual_30_Khanh_75_Hoang = test_30_Khanh_75_Hoang.chiuTai_30_Khanh_75_Hoang(tenSP_30_Khanh_75_Hoang);
            Assert.AreEqual(expected_30_Khanh_75_Hoang, actual_30_Khanh_75_Hoang);
        }
    }
}
