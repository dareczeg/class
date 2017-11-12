using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Równianiekwadratowe
{
    class Klasa
    {
        double aa, be, ce, delta, x1, x2, wynik1, wynik2;
        public void UstawDlugosc(double a)
        {
            aa = a;
        }
        public void UstawSzerokosc(double b)
        {
            be = b;
        }
        public void UstawWysokosc(double c)
        {
            ce = c;
        }
        public double calculateDelta() {
            delta = Math.Pow(be, 2) - 4 * aa * ce;
            return delta;
        }
        public double calculateX1() {
            x1 = -be + Math.Sqrt(delta);
            wynik1 = x1 / 2;
            return wynik1;
        }
        public double calculateX2()
        {
            x2 = -be - Math.Sqrt(delta);
            wynik2 = x2 / 2;
            return wynik2;
        }

    }
}
