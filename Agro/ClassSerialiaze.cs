using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
 public   class ClassSerialiaze
    {
        public static void SerialiazeToXml<T>(ref T inObject, string inFileName)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                System.IO.StreamWriter file = new System.IO.StreamWriter(inFileName);
                writer.Serialize(file, inObject);
                file.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void DeserializationFromXml<T>(ref T inObject, string inFileName)
        {
            if (System.IO.File.Exists(inFileName))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(T));
                System.IO.StreamReader file = new System.IO.StreamReader(inFileName);
                inObject = (T)reader.Deserialize(file);
                file.Close();
            }
        }

    }
}
