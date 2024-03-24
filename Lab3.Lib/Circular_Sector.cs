using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Lib
{
    public class Circular_Sector
    {
        ///Площадь кругового сектора
        ///S = P/360 * r^2 * alfa
        ///Для формулы необходимо знать диаметр/радиус и центральный угол
        public static double Calc(double r, double alfa)
        {
            if (r < 0)
            {
                throw new Exception("Радиус должен быть задан положительным числом");

            }
            if (alfa < 0)
            {
                throw new Exception("Угол должен быть задан положительным числом");
            }
            double S = (Math.PI / 360) * (r*r) * alfa;  ///формула
            return S;
        }
    }
}
