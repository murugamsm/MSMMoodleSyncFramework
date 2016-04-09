
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MSMMoodleSyncFramework.Service.Response
{
    
    [XmlRoot(ElementName = "RESPONSE")]
    public class RESPONSE
    {
        [XmlElement(ElementName = "MULTIPLE")]
        public MULTIPLE MULTIPLE { get; set; }
    }
        
}
