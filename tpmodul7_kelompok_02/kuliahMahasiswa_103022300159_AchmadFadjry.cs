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

    class kuliahMahasiswa_103022300159_AchmadFadjry
    {
        public List<Matkul> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = "tp7_2_103022300159.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                kuliahMahasiswa_103022300159_AchmadFadjry data = JsonSerializer.Deserialize<kuliahMahasiswa_103022300159_AchmadFadjry>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int index = 1;
                foreach (var mk in data.courses)
                {
                    Console.WriteLine($"MK {index++} {mk.code} - {mk.name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + ex.Message);
            }

        }
    }
}
