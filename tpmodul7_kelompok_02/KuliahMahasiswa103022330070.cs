using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_02
{
    public class Matkul
    {
        public string code { get; set; }
        public string name { get; set; }
    }
   
    class KuliahMahasiswa103022330070
    {
        public List<Matkul> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = "tp7_2_103022330070.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                KuliahMahasiswa103022330070 data = JsonSerializer.Deserialize<KuliahMahasiswa103022330070>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int index = 1;
                foreach (var mk in data.courses)
                {
                    Console.WriteLine($"MK {index++} {mk.code} - {mk.name}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + ex.Message);
            }

        }
    }
}
