using System.Collections.Generic;

namespace JustCSharp.Epub.Documents
{
    public class EpubRendition
    {
        public EpubPackageDocument PackageDocument { get; set; }
        public List<EpubContentDocument> ContentDocuments { get; set; }
        public EpubNavigationDocument NavigationDocument { get; set; }
        public List<EpubAsset> Assets { get; set; }
    }
}