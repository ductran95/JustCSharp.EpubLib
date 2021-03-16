using JustCSharp.Epub.Extensions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementXmlFile : EpubElementTextFile
    {
        #region Properties

        

        #endregion

        #region Public Methods

        

        #endregion
        
        #region Internal & Private Methods

        protected abstract void MapFrom(object data);
        
        protected override void OnRawDataChanged(string rawData)
        {
            var newObject = rawData.DeserializeXml(this.GetType());
            MapFrom(newObject);
        }

        protected override string BuildRawData()
        {
            return this.SerializeXml(this.GetType());
        }

        #endregion
    }
}
