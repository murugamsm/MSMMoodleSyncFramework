
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MSMMoodleSyncFramework.Service.Response
{

    [XmlRoot(ElementName = "SINGLE")]
    public class SINGLE
    {
        [XmlElement(ElementName = "KEY")]
        public List<KEY> KEY { get; set; }
    }

}
