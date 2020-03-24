using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw2.Models
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
}
