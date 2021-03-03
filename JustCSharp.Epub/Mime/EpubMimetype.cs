using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Extensions;

namespace JustCSharp.Epub.Mime
{
    public class EpubMimetype: IWriter
    {
        #region Const

        private const string FileName = "mimetype";
        private const int BufferSize = 4096;

        #endregion

        #region Properties

        public string Mimetype { get; set; }
        public EpubPublication Publication { get; }

        #endregion

        #region Constructors

        internal EpubMimetype()
        {
            Mimetype = "application/epub+zip";
        }

        public EpubMimetype(EpubPublication publication): this()
        {
            Publication = publication;
        }

        #endregion

        #region Public Methods

        public void Write()
        {
            byte[] encodedText = GetEncodingContent();
            var filePath = GetFilePath();
            
            encodedText.WriteToFile(filePath, BufferSize);
        }

        public async Task WriteAsync(CancellationToken cancellationToken = default)
        {
            byte[] encodedText = GetEncodingContent();
            var filePath = GetFilePath();

            await encodedText.WriteToFileAsync(filePath, BufferSize, cancellationToken: cancellationToken);
        }

        #endregion
        
        #region Internal & Private Methods

        internal string GetFilePath()
        {
            return Path.Combine(Publication.FilePath, FileName);
        }

        internal byte[] GetEncodingContent()
        {
            return Publication.Encoding.GetBytes(Mimetype);
        }

        #endregion
    }
}