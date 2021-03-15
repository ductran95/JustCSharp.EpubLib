using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementFolder : IReader, IWriter
    {
        #region Properties

        public EpubElementFolder Parent { get; set; }
        public string Folder { get; set; }

        #endregion

        #region Public Methods

        public abstract void Read();

        public abstract Task ReadAsync(CancellationToken cancellationToken = default);

        public abstract void Write();

        public abstract Task WriteAsync(CancellationToken cancellationToken = default);

        #endregion
        
        #region Internal & Private Methods

        internal virtual string GetFolderPath()
        {
            return Parent != null ? Path.Combine(Parent.GetFolderPath(), Folder) : Folder;
        }
        
        #endregion
    }
}
