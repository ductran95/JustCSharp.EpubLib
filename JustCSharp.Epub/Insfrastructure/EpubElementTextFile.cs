using JustCSharp.Epub.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementTextFile : EpubElementFile
    {
        #region Properties

        protected string TextContent { get; set; }
        
        public string RawData
        {
            get => BuildRawData();
            set => OnRawDataChanged(value);
        }

        public Encoding Encoding { get; set; }

        #endregion

        #region Public Methods

        public override void Read(int bufferSize = EpubDefaultValues.BufferSize)
        {
            TextContent = GetFilePath().ReadTextFile(Encoding, bufferSize);
            RawData = TextContent;
        }

        public override async Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            TextContent = await GetFilePath().ReadTextFileAsync(Encoding, bufferSize, cancellationToken).ConfigureAwait(false);
            RawData = TextContent;
        }

        public override void Write(int bufferSize = EpubDefaultValues.BufferSize)
        {
            TextContent = RawData;
            GetFilePath().WriteTextFile(TextContent, Encoding, bufferSize);
        }

        public override async Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            TextContent = RawData;
            await GetFilePath().WriteTextFileAsync(TextContent, Encoding, bufferSize, cancellationToken).ConfigureAwait(false);
        }

        #endregion
        
        #region Internal & Private Methods

        protected abstract void OnRawDataChanged(string rawData);

        protected abstract string BuildRawData();

        #endregion
    }
}
