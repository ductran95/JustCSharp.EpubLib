using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Documents;
using JustCSharp.Epub.Meta;
using JustCSharp.Epub.Mime;

namespace JustCSharp.Epub
{
    public class EpubPublication: IReader, IWriter
    {
        #region Const

        

        #endregion

        #region Properties

        public string FilePath { get; set; }
        public string Version { get; set; }
        public Encoding Encoding { get; set; }
        
        public EpubMetaInf MetaInf { get; set; }
        public List<EpubRendition> Renditions { get; set; }
        public EpubMimetype Mimetype { get; set; }

        #endregion

        #region Constructors

        internal EpubPublication()
        {
            Version = "3.2";
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods

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
        
        public void Read()
        {
            throw new System.NotImplementedException();
        }

        public async Task ReadAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public void Write()
        {
            throw new System.NotImplementedException();
        }

        public async Task WriteAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        
        #region Internal & Private Methods

        

        #endregion
    }
}