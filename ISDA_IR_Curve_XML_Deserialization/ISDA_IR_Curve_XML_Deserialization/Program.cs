using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Xml.Serialization;


namespace ISDA_IR_Curve_XML_Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string XMLFilesDirectory = @"path to the XML file"; // replace this by the path to the file InterestRates_USD_20170609.xml
            string Currency = @"USD";
            string Date = "20170609";
            string GenericFileName = "InterestRates_" + Currency + "_" + Date;
            string XMLFileName = GenericFileName + ".xml";
            string CurrencyXMLFileInitialLocationName = XMLFilesDirectory + @"\" + XMLFileName;
            XmlSerializer serializer = new XmlSerializer(typeof(interestRateCurve));
            Stream reader = new FileStream(CurrencyXMLFileInitialLocationName, FileMode.Open);
            interestRateCurve IRCurve = (interestRateCurve)serializer.Deserialize(reader);
            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
