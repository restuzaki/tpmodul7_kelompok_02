using Newtonsoft.Json;
using System;
using System.IO;

public class DataMahasiswa103022300025
{
    public string nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string json = File.ReadAllText(@"../../../tp7_1_103022300025.json");
        var mhs = JsonConvert.DeserializeObject<DataMahasiswa103022300025>(json);

        Console.WriteLine($"Nama {mhs.nama} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
    }
}
