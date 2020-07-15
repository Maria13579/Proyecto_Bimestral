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
        static int op = 0;
        static bool estado = true;
        static void Main(string[] args)
        {
            Arduino.Open();
            while (op < 3)
            {

                Console.WriteLine("--------Cinta de opciones--------");
                Console.WriteLine("1. Subir Talanquera");
                Console.WriteLine("2. Bajar Talanquera");
                Console.WriteLine("3. Salir");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("\n");
                while (estado == true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el número de opcion que desea");
                        op = int.Parse(Console.ReadLine());
                        estado = false;
                    }
                    catch
                    {
                        Console.WriteLine("Solo valores enteros: \n");
                    }
                }
                estado = true; 
                Console.Clear();
                if (op == 1)
                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        //byte[] data = Encoding.ASCII.GetBytes("w");
                        //Arduino.Write(data, 0, data.Length);
                        Arduino.Write("w")
                    }
                    else
                    {
                        Console.WriteLine("com cerrado");
                    }
                }
                if (op == 2)
                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                       // byte[] data1 = Encoding.ASCII.GetBytes("s");
                       // Arduino.Write(data1, 0, data1.Length);
                        Arduino.Write("s");
                    }
                    else
                    {
                        Console.WriteLine("com cerrado");
                    }
                }
                
            }
            if(op == 3)
            {
                Console.WriteLine("Gracias por usar nuestra aplicacion");
            }
            Arduino.Close();
            Console.ReadKey();
/*
https://create.arduino.cc/editor/maria_serrano/37e5ebc5-67ed-46e2-822f-0fe948900123/preview  
             * Maria Serrano
             * Mijhal Alvarez
             * Karla Acevedo
             */

        }
    }
}

