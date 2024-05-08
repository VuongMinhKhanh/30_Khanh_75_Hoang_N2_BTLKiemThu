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
            string tenSP, expected, actual = "không có";
            tenSP = "Chân váy xếp li";
            expected ="có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc2_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "siadihsabdsh";
            expected = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc3_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "";
            expected = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc4_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "Váy";
            expected = "có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc5_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "Váy+ Đầm";
            expected = "có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc6_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "Váy+ Đầm+ Quần";
            expected = "có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc7_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "@";
            expected = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void tc8_30_Khanh_75_Hoang()
        {
            string tenSP, expected, actual = "không có";
            tenSP = "auishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiuauishduiashduiashdashdiu";
            expected = "không có";
            if (test_30_Khanh_75_Hoang.timKiem(tenSP) == true)
                actual = "có";
            Assert.AreEqual(expected, actual);
        }
    }
}
