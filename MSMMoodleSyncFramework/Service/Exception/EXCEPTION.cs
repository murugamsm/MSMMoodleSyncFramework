
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MSMMoodleSyncFramework.Service.Exception
{

    [XmlRoot(ElementName = "EXCEPTION")]
    public class EXCEPTION
    {

        [XmlElement(ElementName = "MESSAGE")]
        public string MESSAGE { get; set; }

        [XmlElement(ElementName = "DEBUGINFO")]
        public string DEBUGINFO { get; set; }

        [XmlAttribute(AttributeName = "class")]
        public string Class { get; set; }

    }

}
