using System;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Domain
{
    /// <summary>
    /// Represents one of the authors of the book
    /// </summary>
    public class Author
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public Relator Relator { get; private set; } = Relator.AUTHOR;

        public Author(string singleName) : this("", singleName)
        {
        }
	
        public Author(string firstname, string lastname) {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public override string ToString()
        {
            return Lastname + ", " + Firstname;
        }

        public override int GetHashCode()
        {
            return StringUtil.GetHashCode(Firstname, Lastname);
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Author) {
                return false;
            }
            
            Author other = (Author) obj;
            return Firstname == other.Firstname && Lastname == other.Lastname;
        }

        public Relator SetRole(string code) {
            Relator result = Relator.ByCode(code);
            if (!Enum.IsDefined(typeof(Relator), result)) {
                result = Relator.AUTHOR;
            }
            this.Relator = result;
            return result;
        }
    }
}