using System;
<<<<<<< HEAD
using System.Xml.Serialization;

namespace Cw2.Models
{
    [XmlRoot("student")]
    public class Student
    {
        [XmlAttribute(attributeName: "indexNumber")]
        public string Indeks { get; set; }

        [XmlElement(elementName: "fname")]
        public string Imie { get; set; }

        [XmlElement(elementName: "lname")]
        public string Nazwisko { get; set; }

        [XmlElement(elementName: "birthdate")]
        public string DataUrodz { get; set; }

        [XmlElement(elementName: "email")]
        public string Email { get; set; }

        [XmlElement(elementName: "mothersName")]
        public string ImieMatki { get; set; }

        [XmlElement(elementName: "fathersName")]
        public string ImieOjca { get; set; }

        public Studies studies { get; set; }

        public Student() { }
=======
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

>>>>>>> 1968c43e53ea1cee18756e14f6e480547639a703
    }
}
