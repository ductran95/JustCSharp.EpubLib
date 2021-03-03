using System.Threading;
using System.Threading.Tasks;

namespace JustCSharp.Epub
{
    public interface IReader
    {
        void Read();
        Task ReadAsync(CancellationToken cancellationToken = default);
    }
}