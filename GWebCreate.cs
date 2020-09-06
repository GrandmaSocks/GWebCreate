using System;
using System.Threading;
using System.IO;
using System.Text;

namespace GWebCreate
{
    class GWebCreate
    {
        static void Main(string[] args)
        {
            static void Intro()
            {
                string message = "GWebCreate a C# Application Created by GrandmaSocks";
                Console.ForegroundColor = ConsoleColor.Green;


                for (int i = 0; i < message.Length; ++i)
                {
                    Thread.Sleep(50);
                    Console.Write(message[i]);
                }

                Console.ForegroundColor = ConsoleColor.White;



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1] Basic / Simple Mode (Fastest)");
                Console.WriteLine("[2] Advanced Mode (Customize your template)");
                string modeInput = Console.ReadLine();

                switch (modeInput)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Basic Mode Selected");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine("Enter the name the folder should have");
                        string folderInput = Console.ReadLine();

                        string folderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\" + "" + folderInput;
                        string indexPath = folderPath + "\\" + "index.html";
                        string stylePath = folderPath + "\\" + "style.css";
                        string JSPath = folderPath + "\\" + "main.js";

                        string[] indexLines = { "<!DOCTYPE html>", "", "<html=\"en\">", "", "<head>", "", "<meta charset=\"UTF-8\">", "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">", "", "<title>Document</title>", "<link rel=\"stylesheet\" href=\"style.css\">", "", "</head>", "", "<body>", "", "</body>", "", "</html>" };

                        string[] styleLines = { ":root{}", "", "h1{}", "", "p{}" };

                        string[] jsLines = { };

                        System.IO.Directory.CreateDirectory(folderPath);

                        File.WriteAllLines(indexPath, indexLines);
                        File.WriteAllLines(stylePath, styleLines);
                        File.WriteAllLines(JSPath, jsLines);

                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Advanced Mode Selected");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        Console.Clear();



                        break;

                    default:
                        Thread.Sleep(350);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error! Please Enter 1 or 2");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1300);
                        Console.Clear();
                        Intro();
                        break;
                }

            }
            Intro();
        }
    }
}
