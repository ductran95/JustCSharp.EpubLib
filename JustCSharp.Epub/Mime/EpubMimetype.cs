using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Extensions;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub.Mime
{
    public class EpubMimetype : EpubElementTextFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubPublication Publication { get; set; }

        public string Mimetype { get; set; }
        

        #endregion

        #region Constructors

        internal EpubMimetype(): base()
        {
            Encoding = Encoding.UTF8;
            FileName = "mimetype";
            Mimetype = "application/epub+zip";
        }

        public EpubMimetype(EpubPublication publication) : this()
        {
            Publication = publication;
            Parent = publication.Parent;
            Encoding = Publication.Encoding;
        }

        #endregion

        #region Public Methods

        

        #endregion

        #region Internal & Private Methods

        protected override void OnRawDataChanged(string rawData)
        {
            Mimetype = rawData;
        }

        protected override string BuildRawData()
        {
            return Mimetype;
        }

        #endregion
    }
}