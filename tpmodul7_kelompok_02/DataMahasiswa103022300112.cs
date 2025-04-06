using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_02
{
    public class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }

    class DataMahasiswa103022300112
    {
        [JsonPropertyName("nama")]
        public Nama Nama { get; set; }

        [JsonPropertyName("nim")]
        public long Nim { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }

        public static void ReadJSON()
        {
            string path = "../../../tp7_1_103022300112.json";
            string json = File.ReadAllText(path);


            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<DataMahasiswa103022300112>(json, options);


            Console.WriteLine($"Nama {data.Nama.Depan} {data.Nama.Belakang} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
        }
    }
}