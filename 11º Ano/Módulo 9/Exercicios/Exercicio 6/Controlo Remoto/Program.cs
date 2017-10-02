using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlo_Remoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisão tv = new Televisão(5.5, 2.7, 100, 100);

            tv.ligar();

            tv.rc.controloCanal(true, 15);

            tv.rc.controloVolume(true);

            Console.WriteLine("Volume: {0}, Canal: {1}", tv.rc.volume, tv.rc.canal);

            tv.desligar();

            tv.ligar();

            Console.WriteLine("Volume: {0}, Canal: {1}", tv.rc.volume, tv.rc.canal);

            Console.ReadLine();
        }
    }
}
