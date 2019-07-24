using System;
using System.Collections.Generic;
using OOFS.Model;

namespace OOFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = "";

            while(command.ToLower() != "exit")
            {
                Console.Write("Command: ");
                command = Console.ReadLine();
                
                switch(command.ToLower())
                {
                    case "create":
                        Console.WriteLine(Business.Business.Create("drive", "A", "A:\\"));
                    break;
                    case "delete":
                    break;
                    case "move":
                    break;
                    case "writetofile":
                    break;
                    case "dir":
                        dir(); 
                    break;
                    default:
                        Console.WriteLine("Usage:");
                        Console.WriteLine("create -type -name -path");
                        Console.WriteLine("delete -path");
                        Console.WriteLine("move -sourcePath -destinationPath");
                        Console.WriteLine("writetofile -path -content");
                        Console.WriteLine("exit");
                    break;
                }
            }
        }

        private static void dir()
        {
            var drivesList = Business.Business.Dir();
            foreach(var drive in drivesList)
            {
                Console.WriteLine("Drive Name: " + drive.Name + " Path: " + drive.Path);
            }
        }
    }
}