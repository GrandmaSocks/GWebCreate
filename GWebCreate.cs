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
                Console.ForegroundColor = ConsoleColor.Green; // Set console text color to green


                for (int i = 0; i < message.Length; ++i)
                {
                    Thread.Sleep(50);
                    Console.Write(message[i]);
                }

                Console.ForegroundColor = ConsoleColor.White; // Reset color to white



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1] Standard Mode");
                Console.WriteLine("[2] Portfolio Mode");
                string modeInput = Console.ReadLine();

                switch (modeInput)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Standard Mode Selected");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine("Enter the name the folder should have");
                        string folderInput = Console.ReadLine();

                        string folderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\" + "" + folderInput; // Combines the desktop directory with what the user inputs to create a folder on the desktop with a custom name
                        string imagesFolderPath = folderPath + "\\" + "images";

                        string indexPath = folderPath + "\\" + "index.html"; 
                        string stylePath = folderPath + "\\" + "style.css"; // The method I chose to create the paths for the files 
                        string JSPath = folderPath + "\\" + "main.js"; 

                        string[] indexLines = { "<!DOCTYPE html>", "", "<html=\"en\">", "", "<head>", "", "<meta charset=\"UTF-8\">", "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">", "", "<title>Document</title>", "<link rel=\"stylesheet\" href=\"style.css\">", "", "</head>", "", "<body>", "", "</body>", "", "</html>" }; // This is the easiest way I could find to write multiple lines into a file
                        // Every new element in the array is a new line

                        string[] styleLines = { ":root{}", "", "h1{}", "", "p{}" };

                        string[] jsLines = { };

                        System.IO.Directory.CreateDirectory(folderPath);
                        System.IO.Directory.CreateDirectory(imagesFolderPath); // Create our folders

                        File.WriteAllLines(indexPath, indexLines);
                        File.WriteAllLines(stylePath, styleLines); // Create our files
                        File.WriteAllLines(JSPath, jsLines);

                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Portfolio Mode Selected");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        Console.Clear();

                        // Exact same process here expect some diffrent files

                        Console.WriteLine("Enter the name the folder should have");
                        string portfolioFolderInput = Console.ReadLine();

                        string portfolioFolderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\" + "" + portfolioFolderInput;
                        string PortfolioImagesFolderPath = portfolioFolderPath + "\\" + "images";

                        string PindexPath = portfolioFolderPath + "\\" + "index.html";
                        string PortfolioPath = portfolioFolderPath + "\\" + "portfolio.html";
                        string ContactPath = portfolioFolderPath + "\\" + "contact.html";
                        string PstylePath = portfolioFolderPath + "\\" + "style.css";
                        string PJSPath = portfolioFolderPath + "\\" + "main.js";

                        string[] PindexLines = { "<!DOCTYPE html>", "", "<html=\"en\">", "", "<head>", "", "<meta charset=\"UTF-8\">", "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">", "", "<title>Document</title>", "<link rel=\"stylesheet\" href=\"style.css\">", "", "</head>", "", "<body>", "", "</body>", "", "</html>" };

                        string[] PortfolioLines = { "<!DOCTYPE html>", "", "<html=\"en\">", "", "<head>", "", "<meta charset=\"UTF-8\">", "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">", "", "<title>Portfolio</title>", "<link rel=\"stylesheet\" href=\"style.css\">", "", "</head>", "", "<body>", "", "</body>", "", "</html>" };

                        string[] ContactLines = { "<!DOCTYPE html>", "", "<html=\"en\">", "", "<head>", "", "<meta charset=\"UTF-8\">", "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">", "", "<title>Portfolio</title>", "<link rel=\"stylesheet\" href=\"style.css\">", "", "</head>", "", "<body>", "", "</body>", "", "</html>" };

                        string[] PstyleLines = { ":root{}", "", "h1{}", "", "p{}" };

                        System.IO.Directory.CreateDirectory(portfolioFolderPath);
                        System.IO.Directory.CreateDirectory(PortfolioImagesFolderPath);

                        File.WriteAllLines(PindexPath, PindexLines);
                        File.WriteAllLines(PortfolioPath, PortfolioLines);
                        File.WriteAllLines(ContactPath, ContactLines);
                        File.WriteAllLines(PstylePath, PstyleLines);


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
