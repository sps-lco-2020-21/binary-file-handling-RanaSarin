using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageManipulation.App
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] logo = File.ReadAllBytes("sps.bmp");
            byte first = logo[0];
            byte second = logo[1];

            byte[] array = File.ReadAllBytes("logo");
            Console.WriteLine("BMP File Size ", array[2], "  ", array[3]);
            Console.WriteLine("Image Height ", array[18], array[19], array[20], array[21]);
            Console.WriteLine("Image Width  ", array[22], array[23], array[24], array[25]);
            Console.WriteLine("Colour Depth ", array[28], array[29]);
            //Can no longer open image so do not know if it will work
            //Will try to fix and then I'll do some Stenogrpahy
            char b = 'B';
            char m = 'M';

            int res1 = first ^ (byte)b;
            int res2 = second ^ (byte)m;
            string _ = Console.ReadLine();
        }
    }
}
