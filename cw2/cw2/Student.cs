using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace Cw2
{
    public class Student
    {
        public int Nazwisko { get; set; }

        private string imie;

        public string Imie
        {
            get { return imie; }
            set
            {
                if (value == null) throw new ArgumentException();
                imie = value;
            }
        }

    }

    public class Program
    {
        public static async Task Main(string[] args)
        {

            try
            {
                var url = args.Length > 0 ? args[0] : "https://www.pja.edu.pl";

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
                //składnia bardziej jak w java
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

