using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub
{
    public class EpubRootFolder: EpubElementFolder
    {
        #region Const



        #endregion

        #region Properties


        #endregion

        #region Constructors

        internal EpubRootFolder()
        {
            
        }

        internal EpubRootFolder(string folder)
        {
            Folder = folder;
        }

        #endregion

        #region Public Methods

        public override void Read()
        {
        }

        public override Task ReadAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public override void Write()
        {
        }

        public override Task WriteAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        #endregion
        
        #region Internal & Private Methods


        #endregion
    }
}