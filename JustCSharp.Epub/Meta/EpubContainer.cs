using JustCSharp.Epub.Extensions;
using JustCSharp.Epub.Insfrastructure;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JustCSharp.Epub.Meta
{
    /// <summary>
    /// Required container.xml file
    /// </summary>
    [XmlRoot(ElementName = "container", Namespace = "urn:oasis:names:tc:opendocument:xmlns:container")]
    public class EpubContainer : EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubMetaInf MetaInf => (EpubMetaInf) Parent;

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        
        [XmlArray(ElementName = "rootfiles")]
        public List<RootFile> RootFiles { get; set; }

        #endregion

        #region Constructors

        internal EpubContainer()
        {
            SetDefaultData();
        }

        internal EpubContainer(EpubMetaInf metaInf)
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            FileName = "container.xml";
            BufferSize = 4096;
            Encoding = Encoding.UTF8;
            Version = "1.0";
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void OnRawDataChanged(string rawData)
        {
            var newObject = rawData.DeserializeXml<EpubContainer>();

            this.Version = newObject.Version;
            this.RootFiles = newObject.RootFiles;
        }

        protected override string BuildRawData()
        {
            return this.SerializeXml(Encoding);
        }

        #endregion

        #region Sub Classes

        [XmlRoot(ElementName = "")]
        public class RootFile
        {
            [XmlAttribute(AttributeName = "full-path")]
            public string FullPath { get; set; }

            [XmlAttribute(AttributeName = "media-type")]
            public string MediaType { get; set; }
        }

        #endregion
    }
}