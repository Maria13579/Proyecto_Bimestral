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
                 Arduino.Write(data, 0, data.Length);
                byte[] data1 = Encoding.ASCII.GetBytes("s");
                Arduino.Write(data1, 0, data1.Length);
            }
            else
            {
                Console.WriteLine("com cerrado");
            }
            Console.ReadKey();
            Arduino.Close();
        }
    }
}

