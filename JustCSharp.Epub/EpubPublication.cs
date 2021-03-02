using System.Collections.Generic;
using System.IO;
using JustCSharp.Epub.Documents;
using JustCSharp.Epub.Meta;
using JustCSharp.Epub.Mime;

namespace JustCSharp.Epub
{
    public class EpubPublication
    {
        public string Version { get; set; }
        
        public EpubMetaInf MetaInf { get; set; }
        public List<EpubRendition> Renditions { get; set; }
        public EpubMimetype Mimetype { get; set; }
        
        internal EpubPublication()
        {
            
        }

        #region Static

        public static EpubPublication Load(string fileUrl)
        {
            return new EpubPublication();
        }
        
        public static EpubPublication Load(byte[] fileContent, string fileName)
        {
            return new EpubPublication();
        }
        
        public static EpubPublication Load(Stream fileContent, string fileName)
        {
            return new EpubPublication();
        }

        #endregion
    }
}