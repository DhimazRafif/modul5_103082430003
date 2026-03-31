using System.Numerics;

public class Penjumlahan
{
    public T JumlahTigaAngka <T>(T angka1, T angka2, T angka3) where T:INumber<T>
    {
        dynamic pj1 = angka1 + angka2;
        dynamic hasil = pj1 + angka3;
        return hasil;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //NIM berakhiran 3 pakai double (103082430003) 10 30 82 
        Penjumlahan pjl = new Penjumlahan();
        double penjumlahanTA = pjl.JumlahTigaAngka(10.00,30.00,82.00);
        Console.WriteLine("Hasil Penjumlahan Tiga Angka adalah : "+ penjumlahanTA);
    }
}