
﻿using System.Numerics;

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : INumber<T>
    {
        dynamic pj1 = angka1 + angka2;
        dynamic hasil = pj1 + angka3;
        return hasil;
    }
}
﻿public class SimpleDataBase<T>
{
    private List <T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List <T>();
        this.inputDates = new List <DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i=0;i<storedData.Count();i++)
        {
            Console.WriteLine($"Data : {i+1} berisi {storedData[i]}, yang disimpan pada waktu {inputDates[i]}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //NIM berakhiran 3 pakai double (103082430003) 10 30 82 

        //Generic Method
        Penjumlahan pjl = new Penjumlahan();
        double penjumlahanTA = pjl.JumlahTigaAngka(10.00,30.00,82.00);
        Console.WriteLine("Hasil Penjumlahan Tiga Angka adalah : "+ penjumlahanTA);

        //Generic Class
        SimpleDataBase<double> dataNIM = new SimpleDataBase<double>();
        dataNIM.AddNewData(10.0);
        dataNIM.AddNewData(30.0);
        dataNIM.AddNewData(82.0);

        dataNIM.PrintAllData();

    }
}
        
    
