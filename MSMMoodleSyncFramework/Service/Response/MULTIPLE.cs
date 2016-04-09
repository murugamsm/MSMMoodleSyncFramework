
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MSMMoodleSyncFramework.Service.Response
{

    [XmlRoot(ElementName = "MULTIPLE")]
    public class MULTIPLE
    {
        [XmlElement(ElementName = "SINGLE")]
        public SINGLE SINGLE { get; set; }
    }

}
