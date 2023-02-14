using System;
using System.Collections.Generic;
using System.Text;

namespace Zelencuchi.Model
{
    public class LewaZaKG
    {
        private double n;
        private double m;
        private int kgN;
        private int kgM;

        public double N
        {
            get { return this.n; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("greshna cena");
                }
                    this.n = value;
            }
        }
        public double M
        {
            get { return this.m; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("greshna cena");
                }
                    this.m = value;
            }
        }
        public int KgN
        {
            get { return this.kgN; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("greshni kg");
                }
                    this.kgN = value;
            }
        }
        public int KgM
        {
            get { return this.kgM; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("greshni kg");
                }
                    this.kgM = value;
            }
        }
        public LewaZaKG(double n, double m, int KgN, int KgM)
        {
            N = n;
            M = m;
            KgN = kgN;
            KgM = kgM;
        }
        public LewaZaKG():this(0, 0, 0, 0) { }
        public double TurningEuro()
        {
            double totalPrice = N*KgN + M*KgM;
            return totalPrice;
        }
    }
}
