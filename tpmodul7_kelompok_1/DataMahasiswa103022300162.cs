using System;
using System.IO;
using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Mahasiswa
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

public class DataMahasiswa103022300162
{
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_103022300162.json");
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var data = new DataMahasiswa103022300162();
        data.ReadJSON();
    }
}


