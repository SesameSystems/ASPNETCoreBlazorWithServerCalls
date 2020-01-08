using System;
using System.Xml.Serialization;

namespace ASPNETCoreBlazorWithServerCalls.Codes
{

    [Serializable]
    public class SPDatabaseDetailsRequest
    {

        [XmlIgnore]
        public string DatabaseId { get; set; }

    }

}
