using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("请输入需要转换的语句");
            string c = Console.ReadLine();
            c = c.Replace("Z", "A");
            c = c.Replace("Y", "Z");
            c = c.Replace("W", "X");
            c = c.Replace("X", "Y");
            c = c.Replace("V", "W");
            c = c.Replace("U", "V");
            c = c.Replace("T", "U");
            c = c.Replace("S", "T");
            c = c.Replace("R", "S");
            c = c.Replace("Q", "R");
            c = c.Replace("P", "Q");
            c = c.Replace("O", "P");
            c = c.Replace("N", "O");
            c = c.Replace("M", "N");
            c = c.Replace("L", "M");
            c = c.Replace("K", "L");
            c = c.Replace("J", "K");
            c = c.Replace("I", "J");
            c = c.Replace("H", "I");
            c = c.Replace("G", "H");
            c = c.Replace("F", "G");
            c = c.Replace("E", "F");
            c = c.Replace("D", "E");
            c = c.Replace("C", "D");
            c = c.Replace("B", "C");
            c = c.Replace("A", "B");
            c = c.Replace("z", "a");
            c = c.Replace("y", "z");
            c = c.Replace("x", "y");
            c = c.Replace("w", "x");
            c = c.Replace("v", "w");
            c = c.Replace("u", "v");
            c = c.Replace("t", "u");
            c = c.Replace("s", "t");
            c = c.Replace("r", "s");
            c = c.Replace("q", "r");
            c = c.Replace("p", "q");
            c = c.Replace("o", "p");
            c = c.Replace("n", "o");
            c = c.Replace("m", "n");
            c = c.Replace("l", "m");
            c = c.Replace("k", "l");
            c = c.Replace("j", "k");
            c = c.Replace("i", "j");
            c = c.Replace("h", "i");
            c = c.Replace("g", "h");
            c = c.Replace("f", "g");
            c = c.Replace("e", "f");
            c = c.Replace("d", "e");
            c = c.Replace("c", "d");
            c = c.Replace("b", "c");
            c = c.Replace("a", "b");
            Console.WriteLine(c);*/

            //char ch1 = char.Parse(Console.ReadLine());
            //char[] ch1=string1.ToCharArray();
            string st1=Console.ReadLine();
            int length=st1.Length;
            char[] ch1=new char[length];
            for(int i=0;i<length;i++)
            {
                ch1[i]=st1[i];
                /*bool stop=char.IsWhiteSpace(ch1[i]);
                if(stop==true)
                {
                    break;
                }*/
            }
            for (int i = 0; i < length ; i++)
            {
                int num;
                num = (int)ch1[i];
                num = num + 1;      
                ch1[i] = (char)num;
            }
            Console.WriteLine(ch1);
        }
    }
}
