﻿using System;
using System.IO;
using System.Linq;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                Console.WriteLine("Please enter the file's address:");
                string fileAdress = Console.ReadLine();
                string file = Path.GetFileName(fileAdress);
                client.DownloadFile(fileAdress, String.Format("../../{0}", file));
                Console.WriteLine("Download complete!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid address!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address is empty!");
            }
            catch (WebException)
            {
                Console.WriteLine("The link was not found!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The operation was not supported!");
            }
            catch (IOException)
            {
                Console.WriteLine("Input/Output error!");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Not enough memory!");
            }
        }
    }
}