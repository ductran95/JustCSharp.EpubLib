using System.Collections.Generic;
using System.Linq;

namespace JustCSharp.Epub.Domain
{
    public class MediaType
    {
        public string Name { get; }
        public string DefaultExtension { get; }
        public List<string> Extensions { get; }

        public MediaType(string name, string defaultExtension): this(name, defaultExtension, new List<string>())
        {
        }

        public MediaType(string name, string defaultExtension,
            string[] extensions): this(name, defaultExtension, extensions.ToList())
        {
        }

        public MediaType(string name, string defaultExtension,
            List<string> extensions)
        {
            this.Name = name;
            this.DefaultExtension = defaultExtension;
            this.Extensions = extensions;
        }

        public override bool Equals(object? obj)
        {
            if(obj is not MediaType) {
                return false;
            }
            
            return Name.Equals(((MediaType) obj).Name);
        }

        public override int GetHashCode()
        {
            if (Name == null) {
                return 0;
            }
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}