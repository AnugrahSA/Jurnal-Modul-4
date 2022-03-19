using System;
using System.Collections.Generic;


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

            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(12);
            data.AddNewData(34);
            data.AddNewData(56);
            data.PrintAllData();


        }
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData (T newData)
    {
        this.inputDates.Add(DateTime.Now);
        this.storedData.Add(newData);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.inputDates.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi: " + this.storedData[i] + ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }
}

