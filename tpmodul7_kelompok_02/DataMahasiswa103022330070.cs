using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_02
{
   
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

    class DataMahasiswa103022330070
    {
        public void ReadJSON()
        {
            string filePath = "tp7_1_103022330070.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
                Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + ex.Message);
            }
        }
    }
}