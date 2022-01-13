using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest;
using System;

namespace MindBoxUnitTest
{
    [TestClass]
    public class TestCircle // “естирование окружности 
    {
        [TestMethod]
        public void TestSquareCircle1()// тест 1
        {
            double r = 10;//радиус
            double expected = Math.PI * Math.Pow(r, 2);//ожидаема€ площадь
            Assert.AreEqual(expected, Circle.square(r));//проверка
        }
        [TestMethod]
        public void TestSquareCircle2()// тест 2
        {
            double r = 2.5;
            double expected = Math.PI * Math.Pow(r, 2);
            Assert.AreEqual(expected, Circle.square(r));
        }
    }
    [TestClass]
    public class TestSquareTriangle // “естирование площади треугольника  
    {
        [TestMethod]
        public void TestSquareTriangle1()// тест площади 1
        {
            // длинны
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;//ожидаема€ площадь
            Assert.AreEqual(expected, Triangle.square(a, b, c));//проверка
        }
        [TestMethod]
        public void TestSquareTriangle2()// тест площади 2
        {
            double a = 10;
            double b = 10;
            double c = 8;
            double expected = 0.5 * Math.Sqrt(Math.Pow(a, 2) - Math.Pow(c / 2, 2)) * 8;//площадь через формулу дл€ равнобедренного
            Assert.AreEqual(expected, Triangle.square(a, b, c));
        }
        [TestMethod]
        public void TestSquareTriangle3()// тест площади 3
        {
            double a = 5;
            double b = 12;
            double c = 13;
            double expected = 0.5 * a * b;//площадь через формулу дл€ пр€моугольного
            Assert.AreEqual(expected, Triangle.square(a, b, c));
        }
        [TestMethod]
        public void TestSquareTriangle4()// тест площади 4
        {
            double a = 1.75;
            double b = 1.5;
            double c = 2;
            double expected = 1.2708226604743087;
            Assert.AreEqual(expected, Triangle.square(a, b, c));
        }
    }
    [TestClass]
    public class TestRightTriangle // “естирование пр€моугольного треугольника  
    {
        [TestMethod]
        public void TestRightTriangle1()// тест пр€моугольного 1
        {
            double a = 5;
            double b = 12;
            double c = 13;
            bool expected = true;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle2()// тест пр€моугольного 2
        {
            double a = 5;
            double b = 12;
            double c = 13;
            bool expected = true;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle3()// тест пр€моугольного 4
        {
            double a = 10;
            double b = Math.Sqrt(84);
            double c = 4;
            bool expected = true;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle4()// тест пр€моугольного 4
        {
            // проверка с нулевой стороной
            double a = 0;
            double b = 12;
            double c = 13;
            bool expected = false;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
        [TestMethod]
        public void TestRightTriangle5()// тест пр€моугольного 5
        {
            // проверка обычного
            double a = 14;
            double b = 15;
            double c = 13;
            bool expected = false;
            Assert.AreEqual(expected, Triangle.checkRightTriangle(a, b, c));
        }
    }
}
