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
            HashtableDemo();
            ComplexDemo();
            MathNetDemo();           

            Console.Read();
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

        static void HashtableDemo()
        {
            Hashtable hash = new Hashtable();
            //Notice that hashtable doesn't enforce coherent types - see Dictionary 
            hash.Add(1, "One");
            hash.Add("Key2", 2);

            bool boolean = hash.ContainsKey(1);
            boolean = hash.ContainsKey(2);
            boolean = hash.ContainsValue(2);

            int value2 = (int)hash["Key2"];

            string wrongKey = "WrongKey";

            //Notice that Hashtable doesn't throw an exception when key doesn't exist
            object test = hash[wrongKey];
        }

        static void MathNetDemo()
        {
            DenseMatrix matA = new DenseMatrix(2);
            Console.WriteLine(2 * matA);
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
    }
}
