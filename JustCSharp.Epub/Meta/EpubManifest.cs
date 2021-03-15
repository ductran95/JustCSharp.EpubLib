using JustCSharp.Epub.Extensions;
using JustCSharp.Epub.Insfrastructure;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JustCSharp.Epub.Meta
{
    /// <summary>
    /// Optional manifest.xml file
    /// </summary>
    public class EpubManifest: EpubElementTextFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubMetaInf MetaInf => (EpubMetaInf)Parent;

        #endregion

        #region Constructors

        internal EpubManifest()
        {
            SetDefaultData();
        }

        internal EpubManifest(EpubMetaInf metaInf) : this()
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }

        private void SetDefaultData()
        {
            FileName = "manifest.xml";
            BufferSize = 4096;
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void OnRawDataChanged(string rawData)
        {
            var newObject = rawData.DeserializeXml<EpubManifest>();
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