using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OperatorsOverloading_Indexers
{
    public class ComplexNumber
    {
       public int real;
       public int imaginary;
        public ComplexNumber(int c1, int c2)
        {
            real = c1;
            imaginary = c2;
        }
        public ComplexNumber(string c1)
        {
           // real = c1;
            
        }
        public override string ToString()
        {
            return string.Format("\n{0} - real \n{1} - imaginary", real, imaginary);
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            int newreal = c1.real + c2.real;
            int newimaginary = c1.imaginary + c2.imaginary;
            return new ComplexNumber(newreal, newimaginary);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            int newreal = c1.real - c2.real;
            int newimaginary = c1.imaginary - c2.imaginary;
            return new ComplexNumber(newreal, newimaginary);
        }
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return (c1.real == c2.real && c1.imaginary == c2.imaginary) ;
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return (c1.real != c2.real && c1.imaginary != c2.imaginary);
        }

        public static bool operator <(ComplexNumber c1, ComplexNumber c2)
        {
            return (c1.real < c2.real && c1.imaginary < c2.imaginary);
        }
        public static bool operator >(ComplexNumber c1, ComplexNumber c2)
        {
            return (c1.real > c2.real && c1.imaginary > c2.imaginary);
        }

        //public static explicit operator ComplexNumber(string s)
        //{
        //   
        //}

        //public static implicit operator string(ComplexNumber s1)
        //{
        // 
        //}


    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber x = new ComplexNumber(11, 5);
            ComplexNumber y = new ComplexNumber(11, 5);
            ComplexNumber z = new ComplexNumber("dw");
            Console.WriteLine(x != y);
            Console.Write(x > y);
            //string f = Console.ReadLine();
            //Console.Write(z.ToString());
            Console.WriteLine(x);

        }
    }
}
