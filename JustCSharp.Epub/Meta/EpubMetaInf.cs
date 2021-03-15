using JustCSharp.Epub.Insfrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Meta
{
    public class EpubMetaInf: EpubElementFolder
    {
        #region Const



        #endregion

        #region Properties

        public EpubRootFolder RootFolder => (EpubRootFolder) RootFolder;

        public EpubPublication Publication { get; set; }
        
        public EpubContainer Container { get; set; }
        public EpubManifest Manifest { get; set; }
        public EpubMetadata Metadata { get; set; }

        #endregion

        #region Constructors

        internal EpubMetaInf()
        {
            SetDefaultData();
            Container = new EpubContainer();
        }
        
        internal EpubMetaInf(EpubPublication publication)
        {
            SetDefaultData();
            Publication = publication;
            Parent = publication.Parent;
        }
        
        private void SetDefaultData()
        {
            
        }

        #endregion

        #region Public Methods

        public override void Read()
        {
            throw new System.NotImplementedException();
        }

        public override async Task ReadAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public override void Write()
        {
            throw new System.NotImplementedException();
        }

        public override async Task WriteAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        
        #region Internal & Private Methods


        #endregion
    }
}