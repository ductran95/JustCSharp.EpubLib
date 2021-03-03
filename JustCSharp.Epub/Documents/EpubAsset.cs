using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Documents
{
    public abstract class EpubAsset: IReader, IWriter
    {
        #region Const

        

        #endregion

        #region Properties

        

        #endregion

        #region Constructors

        

        #endregion

        #region Public Methods

        

        #endregion
        
        #region Internal & Private Methods

        public abstract void Read();

        public abstract Task ReadAsync(CancellationToken cancellationToken = default);

        public abstract void Write();

        public abstract Task WriteAsync(CancellationToken cancellationToken = default);

        #endregion
    }
}