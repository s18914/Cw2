using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace cw2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //default
            var pathFile = "data.csv";
            var pathResult = "result.xml";
            var type = "xml";
            var lines = File.ReadLines(pathFile);
            var logPath = @"C:\Users\peacr\Desktop\log.txt";   //log, used for errors (ArgumentException()/FileNotFoundException())

            if (!File.Exists(logPath))
            {
                throw new FileNotFoundException("Podana sciezka jest niepoprawna");
                
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

            try
            {
                

               

                //args.Length == 3 ? args[0] : "https://www.pja.edu.pl";

                var client = new HttpClient();
                var result = await client.GetAsync("https://www.pja.edu.pl");

                if (!result.IsSuccessStatusCode) return;

                String html = await result.Content.ReadAsStringAsync();

                var regex = new Regex("[a-z]+[az0-9]*@[a-z.]+");
                var matches = regex.Matches(html);
                var set = new HashSet<string>();

                // LINQ
                var list = new List<string>();
                var elementy = from e in list
                               where e.StartsWith("A")
                               select e;
                //sk³adnia bardziej jak w java
                var elementy2 = list.Where(s => s.StartsWith("A"));






                var slownik = new Dictionary<string, string>();

                foreach (var m in matches)
                {
                    Console.WriteLine(m);
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine("Wystapil blad " + exc.ToString());
            }



            Console.WriteLine("Koniec!");
        }
    }
}
