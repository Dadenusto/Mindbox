using System;

namespace MindboxTest
{
    // Площадь окружности
    public static class Circle // cстатичный класс, тк не создаем объектов этого класса
    {
        public static double square(double a)//площадь
        {
            return Math.PI * a * a;
        }
    }

    // Площадь и проверка прямоугольного треугольника
    public static class Triangle
    {
        public static double square(double a, double b, double c)//площадь
        {
            double p = (a + b + c) / 2;// полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));//формула Герона
        }
        public static bool checkRightTriangle(double a, double b, double c)//проверка прямоугольного
        {
            //если все стороны не равны 0
            if (a * b * c != 0) {
                //ищем предполагаемую гипотенузу
                if (a > b && a > c)
                {
                    return (a * a == b * b + c * c);//проверяем по тео Пифагора
                }
                else if (b > a && b > c)
                {
                    return (b * b == a * a + c * c);
                }
                else if (c > a && c > b)
                {
                    return (c * c == a * a + b * b);
                }
                // если гипотенуза не найдена
                else
                {
                    return false;
                }
            }
            //если хотябы 1 сторона равна 0
            else
            {
                return false;
            }
        }
    }
}
