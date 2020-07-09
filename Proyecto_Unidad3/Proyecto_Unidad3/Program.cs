using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Proyecto_Unidad3
{
    class Program
    {
        static SerialPort Arduino = new SerialPort("COM5", 9600);
        static void Main(string[] args)
        {         
            Arduino.Open();

            if (Arduino.IsOpen)
            {
                Console.WriteLine("com abierto");
                byte[] data = Encoding.ASCII.GetBytes("w");
                byte[] data1 = Encoding.ASCII.GetBytes("s");
            }
            else
            {
                Console.WriteLine("com cerrado");
            }
            Console.ReadKey();
        }
    }
}
