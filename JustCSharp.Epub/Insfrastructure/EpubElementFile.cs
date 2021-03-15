using JustCSharp.Epub.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementFile : IReader, IWriter
    {
        #region Properties

        public EpubElementFolder Parent { get; set; }
        public string FileName { get; set; }
        public int BufferSize { get; set; }

        #endregion

        #region Public Methods

        public abstract void Read();

        public abstract Task ReadAsync(CancellationToken cancellationToken = default);

        public abstract void Write();

        public abstract Task WriteAsync(CancellationToken cancellationToken = default);

        #endregion
        
        #region Internal & Private Methods

        internal virtual string GetFilePath()
        {
            return Path.Combine(Parent.GetFolderPath(), FileName);
        }

        #endregion
    }
}
