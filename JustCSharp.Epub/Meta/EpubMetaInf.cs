using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Meta
{
    public class EpubMetaInf: IReader, IWriter
    {
        #region Const

        

        #endregion

        #region Properties

        public EpubContainer Container { get; set; }
        public EpubManifest Manifest { get; set; }
        public EpubMetadata Metadata { get; set; }

        #endregion

        #region Constructors

        

        #endregion

        #region Public Methods

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