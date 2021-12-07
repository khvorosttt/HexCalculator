using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCalculator
{
    class Hex
    {
        private string _hex;
        int _label;
        static char[] Numbers = {'0','1','2','3','4','5', '6','7','8','9','A','B','C','D','E','F'};
        public string hex
        {
            get { return _hex; }
            set { hex = value; }
        }
        public int label
        {
            get { return _label; }
            set { _label = value; }
        }
        public Hex(string _hex)
        {
            _hex = _hex.ToUpper();
            char[] elements =_hex.ToCharArray();
            label = elements[0].Equals('-') ? 1 : 0;
            for(int i = label; i < elements.Length; i++)
            {
                if(Array.IndexOf(Numbers, elements[i]) == -1&& elements[i] != '.')
                {
                    throw new Exception();
                }
            }
            this._hex = label==1?_hex.ToUpper().Remove(0,1): _hex.ToUpper();
        }
        public static Hex operator +(Hex h1, Hex h2)
        {
            double a,b,c;
            a =h1.label==1?-ConvertNumber(h1.hex): ConvertNumber(h1.hex);
            b =h2.label==1?-ConvertNumber(h2.hex): ConvertNumber(h2.hex);
            c = a + b;
            return new Hex(ConvertHex(c));
        }
        public static Hex operator -(Hex h1, Hex h2)
        {
            double a, b, c;
            a = h1.label == 1 ? -ConvertNumber(h1.hex) : ConvertNumber(h1.hex);
            b = h2.label == 1 ? -ConvertNumber(h2.hex) : ConvertNumber(h2.hex);
            c = a - b;
            return new Hex(ConvertHex(c));
        }
        public static Hex operator *(Hex h1, Hex h2)
        {
            double a, b, c;
            a = h1.label == 1 ? -ConvertNumber(h1.hex) : ConvertNumber(h1.hex);
            b = h2.label == 1 ? -ConvertNumber(h2.hex) : ConvertNumber(h2.hex);
            c = a * b;
            return new Hex(ConvertHex(c));
        }
        public static Hex operator /(Hex h1, Hex h2)
        {
            double a, b, c;
            a = h1.label == 1 ? -ConvertNumber(h1.hex) : ConvertNumber(h1.hex);
            b = h2.label == 1 ? -ConvertNumber(h2.hex) : ConvertNumber(h2.hex);
            c = a / b;
            return new Hex(ConvertHex(c));
        }
        private static double ConvertNumber(string str)
        {
            double temp = 0;
            if (str.IndexOf(",") == -1)
            {
                char[] tempInt = str.ToCharArray();
                temp=ConvertInt(tempInt);
            }
            else
            {
                char[] tempInt = str.Substring(0,str.IndexOf(",")).ToCharArray();
                char[] tempDouble = str.Substring(str.IndexOf(",") + 1).ToCharArray();
                temp = ConvertInt(tempInt)+ConvertDouble(tempDouble);
            }
            return temp;
        }

        public static double ConvertInt(char[] tempInt)
        {
            double temp=0;
            for (int i = tempInt.Length - 1; i >= 0; i--)
            {
                temp += Array.IndexOf(Numbers, tempInt[i]) * Math.Pow(16, tempInt.Length - 1 - i);
            }
            return temp;
        }
        public static double ConvertDouble(char[] tempDouble)
        {
            double temp = 0;
            for (int i = 0; i > -tempDouble.Length; i--)
            {
                temp += Array.IndexOf(Numbers, tempDouble[-i]) * Math.Pow(16, i - 1);
            }
            return temp;
        }
        private static string ConvertHex(double c)
        {
            int sign = c < 0 ? -1 : 1;
            c = Math.Abs(c);
            int tempInt = (int)Math.Truncate(c);
            double tempDouble = c - tempInt;
            string result= String.Concat(ConvertHexInt(tempInt), ConvertHexDouble(tempDouble));
            result = BeautifulNumber(result);
            return sign==-1?String.Concat("-",result):result;
        }
        public static string ConvertHexInt(int tempInt)
        {
            string s = "";
            while (tempInt / 16 != 0)
            {
                s = String.Concat(Numbers[tempInt % 16], s);
                tempInt = tempInt / 16;
            }
            s= String.Concat(Numbers[tempInt % 16], s);
            return s;
        }
        public static string ConvertHexDouble(double tempDouble)
        {
            string s = ".";
            for(int i = 0; i < 10; i++)
            {
                tempDouble = tempDouble * 16;
                s = String.Concat(s, Numbers[(int)tempDouble]);
                tempDouble = tempDouble - (int)Math.Truncate(tempDouble);
            }
            return s;
        }

        public static string BeautifulNumber(string number)
        {
            while (number.LastIndexOf("0") == number.Length - 1)
            {
                number=number.Remove(number.Length - 1);
            }
            if(number.LastIndexOf(".") == number.Length - 1)
            {
                number=number.Remove(number.Length - 1);
            }
            return number;
        }

        public override string ToString()
        {
            return _hex;
        }
    }
}
