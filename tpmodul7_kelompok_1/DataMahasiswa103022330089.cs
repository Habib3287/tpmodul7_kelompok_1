using System.Text.Json;
using static DataMahasiswa103022330089;

class DataMahasiswa103022330089
{
    public class Nama
    {
        public String depan;
        public String belakang;
    }
    public class Mahasiswa103022330089
    {
        public Nama nama;
        public long nim;
        public String fakultas;
    }

    public void readJSON()
    {
        var dataJson = File.ReadAllText("../../../tp7_1_103022330089.json");

        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa103022330089>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama {0} {1} dengan NIM {2}", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim);
    }

    class program {
        public static void Main(string[] args)
        {
            DataMahasiswa103022330089 data = new DataMahasiswa103022330089();
            data.readJSON();
        }

    }
}
