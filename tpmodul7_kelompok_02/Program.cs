using System;
using System.IO;
using System.Text.Json;
using tpmodul7_kelompok_02;

namespace tpmodul7_kelompok_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataMahasiswa103022330070 dataMhs = new DataMahasiswa103022330070();
            dataMhs103022330070.ReadJSON();

            KuliahMahasiswa103022330070 kuliah = new KuliahMahasiswa103022330070();
            kuliah103022330070.ReadJSON();

            
            DataMahasiswa103022300112.ReadJSON();
            KuliahMahasiswa103022300112.ReadJSON();

            
            DataMahasiswa103022300029.ReadJSON();
            KuliahMahasiswa103022300029.ReadJSON();

            Console.ReadKey();
        }
    }
}
