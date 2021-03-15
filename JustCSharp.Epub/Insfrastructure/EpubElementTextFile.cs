using JustCSharp.Epub.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementTextFile : EpubElementFile
    {
        #region Properties

        public string RawData
        {
            get => BuildRawData();
            set => OnRawDataChanged(value);
        }

        public Encoding Encoding { get; set; }

        #endregion

        #region Public Methods

        public override void Read()
        {
            RawData = GetFilePath().ReadFromFile(Encoding, BufferSize);
        }

        public override async Task ReadAsync(CancellationToken cancellationToken = default)
        {
            RawData = await GetFilePath().ReadFromFileAsync(Encoding, BufferSize, cancellationToken).ConfigureAwait(false);
        }

        public override void Write()
        {
            GetFilePath().WriteToFile(RawData, Encoding, BufferSize);
        }

        public override async Task WriteAsync(CancellationToken cancellationToken = default)
        {
            await GetFilePath().WriteToFileAsync(RawData, Encoding, BufferSize, cancellationToken).ConfigureAwait(false);
        }

        #endregion
        
        #region Internal & Private Methods

        protected abstract void OnRawDataChanged(string rawData);

        protected abstract string BuildRawData();

        #endregion
    }
}
