using System.Text.Json;
using static DataMahasiswa103022330068;

class DataMahasiswa103022330068
{
    public class Nama
    {
        public String depan;
        public String belakang;
    }
    public class Mahasiswa103022330068
    {
        public Nama nama;
        public long nim;
        public String fakultas;
    }

    public  void ReadJSON()
    {
        var dataJson = File.ReadAllText("../../../tp7_1_103022330068.json");

        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa103022330068>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama {0} {1} dengan NIM {2} dari fakultas {3} ", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);
    }
    class Main
    {
        public static void main(string[] args)
        {
            var data = new DataMahasiswa103022330068();
            data.ReadJSON();
        }
    }
}
