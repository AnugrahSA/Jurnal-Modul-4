using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204047
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 02, 20));
        }
    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T inputPertama, T inputKedua, T inputKetiga)
        {
            dynamic input1 = inputPertama;
            dynamic input2 = inputKedua;
            dynamic input3 = inputKetiga;

            return input1 + input2 + input3;

        }
    }
}

