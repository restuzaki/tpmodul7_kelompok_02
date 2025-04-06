using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class KuliahMahasiswa103022300025
{
    public List<MataKuliah> mataKuliah { get; set; }

    public static void ReadJSON()
    {
        string json = File.ReadAllText(@"../../../tp7_2_103022300025.json");
        var kuliah = JsonConvert.DeserializeObject<KuliahMahasiswa103022300025>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in kuliah.mataKuliah)
        {
            Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
            i++;
        }
    }
}

public class MataKuliah
{
    public string kode { get; set; }
    public string nama { get; set; }
}
