
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
        
    [XmlRoot(ElementName = "SINGLE")]
    public class SINGLE
    {
        [XmlElement(ElementName = "KEY")]
        public List<KEY> KEY { get; set; }
    }
        
    [XmlRoot(ElementName = "MULTIPLE")]
    public class MULTIPLE
    {
        [XmlElement(ElementName = "SINGLE")]
        public SINGLE SINGLE { get; set; }
    }

    [XmlRoot(ElementName = "RESPONSE")]
    public class RESPONSE
    {
        [XmlElement(ElementName = "MULTIPLE")]
        public MULTIPLE MULTIPLE { get; set; }
    }
        
}
