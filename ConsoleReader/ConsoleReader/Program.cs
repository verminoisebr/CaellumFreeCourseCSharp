﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TextReader leitor = Console.In;
            string linha = "";
            while(linha != null)
            {
                linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
            if (linha == null)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            */
            using (TextReader leitor = Console.In)
            {
                string linha = "";
                string linhaControl = "";
                ConsoleColor[] cor = new ConsoleColor[5] { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Red };
                while (linhaControl != null)
                {
                    linhaControl = leitor.ReadLine();
                    linha += "\n"+linhaControl.Substring(0,1).ToUpper()+linhaControl.Substring(1);                    
                    Console.WriteLine("Você digitou isso: " + linha);
                    int i = new Random().Next(0, 5);
                    Console.ForegroundColor = cor[i];
                }
            }
        }
    }
}
