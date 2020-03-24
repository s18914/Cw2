<<<<<<< HEAD
﻿using System.Xml.Serialization;

namespace Cw2.Models
{
    public class ActiveStudies
    {
        [XmlArray("activeStudies"), XmlArrayItem("studies")]
        public Studies[] Studia { get; set; }
        public ActiveStudies() { }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw2.Models
{
    public class ActiveStudies
    {
>>>>>>> 1968c43e53ea1cee18756e14f6e480547639a703
    }
}
