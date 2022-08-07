using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cpfcheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Atomo -> CPF-CNPJ Checker";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
 ██████╗██████╗ ███████╗ ██╗ ██████╗███╗   ██╗██████╗     ██╗
██╔════╝██╔══██╗██╔════╝██╔╝██╔════╝████╗  ██║██╔══██╗    ██║
██║     ██████╔╝█████╗ ██╔╝ ██║     ██╔██╗ ██║██████╔╝    ██║
██║     ██╔═══╝ ██╔══╝██╔╝  ██║     ██║╚██╗██║██╔═══╝██   ██║
╚██████╗██║     ██║  ██╔╝   ╚██████╗██║ ╚████║██║    ╚█████╔╝
 ╚═════╝╚═╝     ╚═╝  ╚═╝     ╚═════╝╚═╝  ╚═══╝╚═╝     ╚════╝ 
                                                             
 ██████╗██╗  ██╗███████╗ ██████╗██╗  ██╗███████╗██████╗      
██╔════╝██║  ██║██╔════╝██╔════╝██║ ██╔╝██╔════╝██╔══██╗     
██║     ███████║█████╗  ██║     █████╔╝ █████╗  ██████╔╝     
██║     ██╔══██║██╔══╝  ██║     ██╔═██╗ ██╔══╝  ██╔══██╗     
╚██████╗██║  ██║███████╗╚██████╗██║  ██╗███████╗██║  ██║     
 ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝     
                                                             
Telegram: @Mahitozin
Github: https://github.com/Mahitozin
"); 
            Console.ResetColor();
            string cpf = input("Digite um cpf/cnpj -> ");

            if(Regex.Match(cpf, @"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$").Success)
            {
                log("CPF valido", ConsoleColor.DarkGreen);
            }
            else if (Regex.Match(cpf, @"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}").Success)
            {
                log("CNPJ valido", ConsoleColor.DarkGreen);

            }
            else
            {
                log("CPF ou CNPJ invalido", ConsoleColor.DarkRed);
            }

            Console.ReadLine();
        }

        static string input(string msg)
        {
            ConsoleColor cb = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now.ToString("hh:mm:ss")}] ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(msg);
            Console.ForegroundColor = cb;

            return Console.ReadLine();
        }

        static void log(string msg, ConsoleColor cor)
        {
            ConsoleColor cb = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now.ToString("hh:mm:ss")}] ");
            Console.ForegroundColor = cor;
            Console.WriteLine(msg);
            Console.ForegroundColor = cb;
        }
    }
}
