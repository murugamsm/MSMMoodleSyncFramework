
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MSMMoodleSyncFramework.Service.Response
{

    [XmlRoot(ElementName = "KEY")]
    public class KEY
    {
        [XmlElement(ElementName = "VALUE")]
        public string VALUE { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

}
