using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.IO;
using System.Text;
using System.Xml.Linq;
using cw2.Models;

namespace cw2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //default
            var pathFile = @"C:\Users\admn\Desktop\dane.csv";
            var pathResult = @"C:\Users\admn\Desktop\result.xml";
            var type = "xml";

            var lines = File.ReadLines(pathFile);
            var logPath = @"C:\Users\admn\Desktop\log.txt";  

            if (!File.Exists(logPath))
            {
                using FileStream fs = File.Create(logPath);
            }
            using FileStream streamToLogs = File.OpenWrite(logPath);

            
            for(int i = 0; i<3; i++)
            {
                try
                {
                    if (!string.IsNullOrEmpty(args[i]))
                    {
                        switch (i)
                        {
                            case 0:
                                    pathFile = args[0];
                                    lines = File.ReadLines(pathFile);
                                break;
                            case 1:
                                    pathResult = args[1];
                                break;
                            case 2:
                                if (args[2] == "xml")
                                {
                                    type = args[2];
                                }
                                break;
                        }
                        pathFile = args[i];
                        lines = File.ReadLines(pathFile);
                    }
                }catch (ArgumentException ex)
                {
                    var data = ex.Message + (" Podana œcie¿ka jest niepoprawna " + args[i] + "\n");
                    byte[] bytes = Encoding.UTF8.GetBytes(data);

                    streamToLogs.Write(bytes, 0, bytes.Length);
                    Console.Error.WriteLine("Bad path " + ex.Message);
                }
                catch (FileNotFoundException exep)
                {
                    var data = exep.Message + (" Podany plik " + args[i] + " nie istnieje" + "\n");
                    byte[] bytes = Encoding.UTF8.GetBytes(data);

                    streamToLogs.Write(bytes, 0, bytes.Length);
                    Console.Error.WriteLine("File not found " + exep.Message);
                }
                
            }

            //====================================================================================

           
        }
    }
}
