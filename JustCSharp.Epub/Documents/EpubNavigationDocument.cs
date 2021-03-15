using System.Text;
using JustCSharp.Epub.Extensions;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub.Documents
{
    public class EpubNavigationDocument: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubRendition MetaInf => (EpubRendition) Parent;

        #endregion

        #region Constructors

        internal EpubNavigationDocument()
        {
            SetDefaultData();
        }

        internal EpubNavigationDocument(EpubRendition metaInf)
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            FileName = "nav.html";
            BufferSize = 4096;
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void OnRawDataChanged(string rawData)
        {
            var newObject = rawData.DeserializeXml<EpubNavigationDocument>();

        }

        protected override string BuildRawData()
        {
            return this.SerializeXml(Encoding);
        }

        #endregion

        #region Sub Classes

        

        #endregion
    }
}