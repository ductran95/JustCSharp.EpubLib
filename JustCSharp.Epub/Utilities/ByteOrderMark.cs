using System;
using System.Text;

namespace JustCSharp.Epub.Utilities
{
    /// <summary>
    /// Byte Order Mark (BOM) representation -
    /// </summary>
    /// <see cref="BOMInputStream"/>
    /// <see href="http://en.wikipedia.org/wiki/Byte_order_mark">Wikipedia - Byte Order Mark</see>
    public class ByteOrderMark
    {
        /** UTF-8 BOM */
        public static readonly ByteOrderMark UTF8 = new ByteOrderMark("UTF-8", 0xEF, 0xBB, 0xBF);

        /** UTF-16BE BOM (Big Endian) */
        public static readonly ByteOrderMark UTF16BE = new ByteOrderMark("UTF-16BE", 0xFE, 0xFF);

        /** UTF-16LE BOM (Little Endian) */
        public static readonly ByteOrderMark UTF16LE = new ByteOrderMark("UTF-16LE", 0xFF, 0xFE);

        /// <summary>
        /// The name of the {@link java.nio.charset.Charset} the BOM represents.
        /// </summary>
        public string CharsetName { get; }

        /// <summary>
        /// The BOM's bytes.
        /// </summary>
        public int[] Bytes { get; }

        /// <summary>
        /// Construct a new BOM.
        /// </summary>
        /// <param name="charsetName">The name of the charset the BOM represents</param>
        /// <param name="bytes">The BOM's bytes</param>
        /// <exception cref="ArgumentException">
        /// if the charsetName is null or zero length
        /// Or if the bytes are null or zero length
        /// </exception>
        public ByteOrderMark(string charsetName, params int[] bytes)
        {
            if (string.IsNullOrEmpty(charsetName))
            {
                throw new ArgumentException("No charsetName specified");
            }

            if (bytes == null || bytes.Length == 0)
            {
                throw new ArgumentException("No bytes specified");
            }

            this.CharsetName = charsetName;
            this.Bytes = new int[bytes.Length];
            Array.Copy(bytes, 0, this.Bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Return the length of the BOM's bytes.
        /// </summary>
        /// <returns></returns>
        public int Length() => Bytes.Length;

        /// <summary>
        /// The byte at the specified position.
        /// </summary>
        /// <param name="pos"></param>
        public int this[int pos] => Bytes[pos];

        /// <summary>
        /// Return a copy of the BOM's bytes.
        /// </summary>
        /// <returns></returns>
        public byte[] GetCopyOfBytes()
        {
            byte[] copy = new byte[Bytes.Length];
            for (int i = 0; i < Bytes.Length; i++)
            {
                copy[i] = (byte) Bytes[i];
            }

            return copy;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not ByteOrderMark) {
                return false;
            }
            
            ByteOrderMark bom = (ByteOrderMark)obj;
            if (Bytes.Length != bom.Length()) {
                return false;
            }
            for (int i = 0; i < Bytes.Length; i++) {
                if (Bytes[i] != bom[i]) {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = typeof(ByteOrderMark).GetHashCode();
            foreach (int b in Bytes)
            {
                hashCode += b;
            }

            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(nameof(ByteOrderMark));
            builder.Append('[');
            builder.Append(CharsetName);
            builder.Append(": ");
            for (int i = 0; i < Bytes.Length; i++) {
                if (i > 0) {
                    builder.Append(',');
                }
                builder.Append("0x");
                builder.Append((0xFF & Bytes[i]).ToString("X").ToUpper());
            }
            builder.Append(']');
            return builder.ToString();
        }
    }
}