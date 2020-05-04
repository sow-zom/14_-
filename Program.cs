using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OperatorsOverloading_Indexers
{
    public class PersonComplexNumber
    {
       public int real;
       public int imaginary;
        public PersonComplexNumber(int c1, int c2)
        {
            real = c1;
            imaginary = c2;
        }
        public override string ToString()
        {
            return string.Format("{0} - real \n {1} - imaginary", real, imaginary);
        }
        public static PersonComplexNumber operator +(PersonComplexNumber c1, PersonComplexNumber c2)
        {
            int newreal = c1.real + c2.real;
            int newimaginary = c1.imaginary + c2.imaginary;
            return new PersonComplexNumber(newreal, newimaginary);
        }

        public static PersonComplexNumber operator -(PersonComplexNumber c1, PersonComplexNumber c2)
        {
            int newreal = c1.real - c2.real;
            int newimaginary = c1.imaginary - c2.imaginary;
            return new PersonComplexNumber(newreal, newimaginary);
        }
        public static bool operator ==(PersonComplexNumber c1, PersonComplexNumber c2)
        {
            return (c1.real == c2.real &&
                    c1.imaginary == c2.imaginary) ;
        }

        public static bool operator !=(PersonComplexNumber c1, PersonComplexNumber c2)
        {
            return (c1.real != c2.real && c1.imaginary != c2.imaginary);
        }

        public static bool operator <(PersonComplexNumber c1, PersonComplexNumber c2)
        {
            return (c1.real < c2.real && c1.imaginary < c2.imaginary);
        }
        public static bool operator >(PersonComplexNumber c1, PersonComplexNumber c2)
        {
            return (c1.real > c2.real && c1.imaginary > c2.imaginary);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonComplexNumber x = new PersonComplexNumber(11, 5);
            PersonComplexNumber y = new PersonComplexNumber(11, 5);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            //string f = Console.ReadLine();
        }
    }
}
