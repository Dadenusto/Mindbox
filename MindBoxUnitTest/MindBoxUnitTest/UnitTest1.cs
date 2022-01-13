using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest;
using System;

namespace MindBoxUnitTest
{
    [TestClass]
    public class TestCircle // ������������ ���������� 
    {
        [TestMethod]
        public void TestSquareCircle1()// ���� 1
        {
            double r = 10;//������
            double expected = Math.PI * Math.Pow(r, 2);//��������� �������
            Assert.AreEqual(expected, Circle.square(r));//��������
        }
        [TestMethod]
        public void TestSquareCircle2()// ���� 2
        {
            double r = 2.5;
            double expected = Math.PI * Math.Pow(r, 2);
            Assert.AreEqual(expected, Circle.square(r));
        }
    }
    [TestClass]
    public class TestSquareTriangle // ������������ ������� ������������  
    {
        [TestMethod]
        public void TestSquareTriangle1()// ���� ������� 1
        {
            // ������
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;//��������� �������
            Assert.AreEqual(expected, Triangle.square(a, b, c));//��������
        }
        [TestMethod]
        public void TestSquareTriangle2()// ���� ������� 2
        {
            double a = 10;
            double b = 10;
            double c = 8;
            double expected = 0.5 * Math.Sqrt(Math.Pow(a, 2) - Math.Pow(c / 2, 2)) * 8;//������� ����� ������� ��� ���������������
            Assert.AreEqual(expected, Triangle.square(a, b, c));
        }
        [TestMethod]
        public void TestSquareTriangle3()// ���� ������� 3
        {
            double a = 5;
            double b = 12;
            double c = 13;
            double expected = 0.5 * a * b;//������� ����� ������� ��� ��������������
            Assert.AreEqual(expected, Triangle.square(a, b, c));
        }
        [TestMethod]
        public void TestSquareTriangle4()// ���� ������� 4
        {
            double a = 1.75;
            double b = 1.5;
            double c = 2;
            double expected = 1.2708226604743087;
            Assert.AreEqual(expected, Triangle.square(a, b, c));
        }
    }
    [TestClass]
    public class TestRightTriangle // ������������ �������������� ������������  
    {
        [TestMethod]
        public void TestRightTriangle1()// ���� �������������� 1
        {
            double a = 5;
            double b = 12;
            double c = 13;
            bool expected = true;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle2()// ���� �������������� 2
        {
            double a = 5;
            double b = 12;
            double c = 13;
            bool expected = true;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle3()// ���� �������������� 4
        {
            double a = 10;
            double b = Math.Sqrt(84);
            double c = 4;
            bool expected = true;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle4()// ���� �������������� 4
        {
            // �������� � ������� ��������
            double a = 0;
            double b = 12;
            double c = 13;
            bool expected = false;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle5()// ���� �������������� 5
        {
            // �������� ��������
            double a = 14;
            double b = 15;
            double c = 13;
            bool expected = false;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
    }
}
