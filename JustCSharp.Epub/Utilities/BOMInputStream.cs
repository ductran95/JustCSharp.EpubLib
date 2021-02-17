namespace JustCSharp.Epub.Utilities
{
    /// <summary>
    /// This class is used to wrap a stream that includes an encoded
    /// <see cref="ByteOrderMark"/> as its first bytes.
    /// </summary>
    /// <remarks>
    /// This class detects these bytes and, if required, can automatically skip them
    /// and return the subsequent byte as the first byte in the stream.
    /// </remarks>
    public class BOMInputStream
    {
        
    }
}