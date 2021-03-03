using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Extensions
{
    public static class ByteExtension
    {
        public static void WriteToFile(this byte[] data, string filePath, int bufferSize = 4096)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.None,
                bufferSize: bufferSize, useAsync: false))
            {
                sourceStream.Write(data, 0, data.Length);
            };
        }
        
        public static async Task WriteToFileAsync(this byte[] data, string filePath, int bufferSize = 4096, CancellationToken cancellationToken = default)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.None,
                bufferSize: bufferSize, useAsync: true))
            {
                await sourceStream.WriteAsync(data, 0, data.Length, cancellationToken);
            };
        }
    }
}