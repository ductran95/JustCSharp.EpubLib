using System.IO;

namespace JustCSharp.Epub.Utilities
{
    /// <summary>
    /// A Proxy stream which acts as expected, that is it passes the method
    /// calls on to the proxied stream and doesn't change which methods are
    /// being called.
    /// </summary>
    /// <remarks>
    /// It is an alternative base class to FilterInputStream
    /// to increase reusability, because FilterInputStream changes the
    /// methods being called, such as read(byte[]) to read(byte[], int, int).
    /// See the protected methods for ways in which a subclass can easily decorate
    /// a stream with custom pre-, post- or error processing functionality.
    /// </remarks>
    public abstract class ProxyInputStream: Stream
    {
        public ProxyInputStream(Stream proxy) : base(proxy)
        {
            
        }
    }
}