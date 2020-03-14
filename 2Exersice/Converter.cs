using System;
using System.Collections.Generic;
using System.Text;

namespace _2Exersice
{
    class Converter
    {
        private double rub, usd, eur;

        public Converter(double rub, double usd, double eur)
        {
            this.usd = usd;
            this.rub = rub;
            this.eur = eur;
        }

        public void ToUsd(double uahSum)
        {
            Console.WriteLine(uahSum / usd);
        }
        public void ToEur(double uahSum)
        {
            Console.WriteLine(uahSum / eur);
        }
        public void ToRub(double uahSum)
        {
            Console.WriteLine(uahSum / rub);
        }
        public void inUsd(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }
        public void inEur(double eurSum)
        {
            Console.WriteLine(eurSum * eur);
        }
        public void inRub(double rubSum)
        {
            Console.WriteLine(rubSum * rub);
        }
    }
}
