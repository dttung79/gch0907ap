using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class Fraction
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set 
            { 
                if (value == 0)
                {
                    throw new DivideByZeroException();
                }
                denominator = value; 
            }
        }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", Numerator, Denominator);
        }

        public Fraction Add(Fraction other)
        {
            // TODO
            // calculate a new fraction f which is sum of this and other
            // for example this = 1/2, other = 1/3, return f = 5/6
        }
    }
}