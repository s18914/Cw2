<<<<<<< HEAD
﻿using System.Dynamic;
using System.Xml.Serialization;

namespace cw2.Models
{
    [XmlRoot("studies")]
    public class Studies
    {
        [XmlElement(elementName: "name")]
        public string Nazwa { get; set; }
        [XmlElement(elementName: "mode")]
        public string Tryb { get; set; }
        [XmlAttribute("name")]
        public string ActiveStudies { get; set; }
        [XmlAttribute("numberOfStudents")]
        public string Number { get; set; }
        public Studies() { }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw2.Models
{
    public class Studies
    {
>>>>>>> 1968c43e53ea1cee18756e14f6e480547639a703
    }
}
