﻿using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103022330070 dataMhs = new DataMahasiswa103022330070();
            dataMhs.ReadJSON();
            

            KuliahMahasiswa103022330070 kuliah = new KuliahMahasiswa103022330070();            
            kuliah.ReadJSON();
            Console.ReadKey();
        }
    }
}

