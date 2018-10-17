using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {

            KeyValuePairAndListExample();
            ComplexDemo();
            MathNetDemo();           

            Console.Read();
        }

        static void ComplexDemo()
        {
            Complex z1 = 0.1 + 2.0 * Complex.ImaginaryOne;
            Console.WriteLine(z1);

            int N = 1000;
            int numRev = 4;
            for (int k = 0; k < N; ++k)
            {
                Complex z = Complex.FromPolarCoordinates(5, 2 * numRev * k * Math.PI / N);
                Console.WriteLine("z: {0} Im(ln(z)): {1}", z, Complex.Log(z).Imaginary);
            }
        }

        static void MathNetDemo()
        {
            DenseMatrix matA = new DenseMatrix(2);
            Console.WriteLine(2 * matA);
        }

        static void KeyValuePairAndListExample()
        {
            string key = "sigma";
            double value = 0.1;
            KeyValuePair<string, double> keyValuePair1
            = new KeyValuePair<string, double>(key, value);
            KeyValuePair<string, double> keyValuePair2
            = new KeyValuePair<string, double>("alpha", 0.25);

            LinkedList<KeyValuePair<string, double>> keyValuePairList = new LinkedList<KeyValuePair<string, double>>();
            keyValuePairList.AddLast(keyValuePair1);
            keyValuePairList.AddLast(keyValuePair2);

            foreach (var param in keyValuePairList)
            {
                Console.WriteLine(param);
            }
        }
    }
}
