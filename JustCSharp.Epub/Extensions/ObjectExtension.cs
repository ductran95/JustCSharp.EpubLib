using JustCSharp.Epub.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace JustCSharp.Epub.Extensions
{
    public static class ObjectExtension
    {
        public static string SerializeXml<T>(this T data, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            using (var stringWriter = new StringWriterWithEncoding(encoding))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringWriter, data);
                return stringWriter.ToString();
            }
        }
        
        public static string SerializeXml(this object data, Type type, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            using (var stringWriter = new StringWriterWithEncoding(encoding))
            {
                var serializer = new XmlSerializer(type);
                serializer.Serialize(stringWriter, data);
                return stringWriter.ToString();
            }
        }

        public static T DeserializeXml<T>(this string xmlString)
        {
            using (var stringReader = new StringReader(xmlString))
            {
                var serializer = new XmlSerializer(typeof(T));
                var data = serializer.Deserialize(stringReader);
                return (T) data;
            }
        }
        
        public static object DeserializeXml(this string xmlString, Type type)
        {
            using (var stringReader = new StringReader(xmlString))
            {
                var serializer = new XmlSerializer(type);
                var data = serializer.Deserialize(stringReader);
                return data;
            }
        }
    }
}
