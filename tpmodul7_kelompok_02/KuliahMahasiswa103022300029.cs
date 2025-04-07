using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_02
{
    public class MataKuliah
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    class KuliahMahasiswa103022300029
    {
        [JsonPropertyName("courses")]
        public List<MataKuliah> Courses { get; set; }

        public static void ReadJSON()
        {
            string path = "../../../tp7_2_103022300029.json";
            string json = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<KuliahMahasiswa103022300029>(json, options);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in data.Courses)
            {
                Console.WriteLine($"MK {i} {mk.Code} - {mk.Name}");
                i++;
            }
        }
    }
}