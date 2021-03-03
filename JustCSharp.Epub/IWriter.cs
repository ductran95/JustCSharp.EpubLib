using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub
{
    public interface IWriter
    {
        void Write();
        Task WriteAsync(CancellationToken cancellationToken = default);
    }
}