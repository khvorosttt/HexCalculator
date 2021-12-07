using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCalculator
{
    class Vector
    {
        Hex[] numbers;
        public Vector()
        {
            numbers = new Hex[7];
        }
        public Vector(int n)
        {
            numbers = new Hex[n];
        }

        public Hex this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }

        public int Length()
        {
            return numbers.Length;
        }
    }
}
