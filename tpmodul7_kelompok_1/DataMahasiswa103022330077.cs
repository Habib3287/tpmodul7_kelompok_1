using System.Text.Json;
using static DataMahasiswa103022330077;

class DataMahasiswa103022330077
{
    public class Nama
    {
        public String depan;
        public String belakang;
    }
    public class Mahasiswa103022330077
    {
        public Nama nama;
        public long nim;
        public String fakultas;
    }

    public void readJSON()
    {
        var dataJson = File.ReadAllText("../../../tp7_1_103022330077.json");

        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa103022330077>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama {0} {1} dengan NIM {2}", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim);
    }
    class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa103022330077 kuliah = new DataMahasiswa103022330077();
            kuliah.readJSON();
        }
    }

}
