using JustCSharp.Epub.Extensions;
using JustCSharp.Epub.Insfrastructure;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace JustCSharp.Epub.Meta
{
    /// <summary>
    /// Optional metadata.xml file
    /// </summary>
    public class EpubMetadata: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubMetaInf MetaInf => (EpubMetaInf)Parent;

        #endregion

        #region Constructors

        internal EpubMetadata()
        {
            SetDefaultData();
        }

        internal EpubMetadata(EpubMetaInf metaInf) : this()
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }

        private void SetDefaultData()
        {
            FileName = "metadata.xml";
            BufferSize = 4096;
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void OnRawDataChanged(string rawData)
        {
            var newObject = rawData.DeserializeXml<EpubMetadata>();
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