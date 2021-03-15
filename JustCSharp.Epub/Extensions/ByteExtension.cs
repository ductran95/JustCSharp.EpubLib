using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub.Extensions
{
    public static class FileExtension
    {
        public static string ReadFromFile(this string filePath, Encoding encoding, int bufferSize = 4096)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.ReadWrite,
                bufferSize: bufferSize, useAsync: false))
            {
                var byteContent = new byte[sourceStream.Length];
                sourceStream.Read(byteContent, 0, (int) sourceStream.Length);
                return encoding.GetString(byteContent);
            };
        }

        public static async Task<string> ReadFromFileAsync(this string filePath, Encoding encoding, int bufferSize = 4096, CancellationToken cancellationToken = default)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.ReadWrite,
                bufferSize: bufferSize, useAsync: false))
            {
                var byteContent = new byte[sourceStream.Length];
                await sourceStream.ReadAsync(byteContent, 0, (int)sourceStream.Length, cancellationToken).ConfigureAwait(false);
                return encoding.GetString(byteContent);
            };
        }

        public static void WriteToFile(this byte[] data, string filePath, int bufferSize = 4096)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read,
                bufferSize: bufferSize, useAsync: false))
            {
                sourceStream.Write(data, 0, data.Length);
            };
        }

        public static void WriteToFile(this string data, string filePath, Encoding encoding, int bufferSize = 4096)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read,
                bufferSize: bufferSize, useAsync: false))
            {
                var byteContent = encoding.GetBytes(data);
                sourceStream.Write(byteContent, 0, data.Length);
            };
        }

        public static async Task WriteToFileAsync(this byte[] data, string filePath, int bufferSize = 4096, CancellationToken cancellationToken = default)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read,
                bufferSize: bufferSize, useAsync: true))
            {
                await sourceStream.WriteAsync(data, 0, data.Length, cancellationToken).ConfigureAwait(false);
            };
        }

        public static async Task WriteToFileAsync(this string data, string filePath, Encoding encoding, int bufferSize = 4096, CancellationToken cancellationToken = default)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read,
                bufferSize: bufferSize, useAsync: false))
            {
                var byteContent = encoding.GetBytes(data);
                await sourceStream.WriteAsync(byteContent, 0, data.Length, cancellationToken).ConfigureAwait(false);
            };
        }

    }
}