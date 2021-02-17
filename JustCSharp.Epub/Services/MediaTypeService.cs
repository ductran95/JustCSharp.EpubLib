using System.Collections.Generic;
using JustCSharp.Epub.Domain;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Services
{
    public static class MediaTypeService
    {
        public static readonly MediaType XHTML =
            new MediaType("application/xhtml+xml", ".xhtml", new string[] {".htm", ".html", ".xhtml"});

        public static readonly MediaType EPUB = new MediaType("application/epub+zip", ".epub");
        public static readonly MediaType NCX = new MediaType("application/x-dtbncx+xml", ".ncx");

        public static readonly MediaType JAVASCRIPT = new MediaType("text/javascript", ".js");
        public static readonly MediaType CSS = new MediaType("text/css", ".css");

        // images
        public static readonly MediaType JPG = new MediaType("image/jpeg", ".jpg", new string[] {".jpg", ".jpeg"});
        public static readonly MediaType PNG = new MediaType("image/png", ".png");
        public static readonly MediaType GIF = new MediaType("image/gif", ".gif");

        public static readonly MediaType SVG = new MediaType("image/svg+xml", ".svg");

        // fonts
        public static readonly MediaType TTF = new MediaType("application/x-truetype-font", ".ttf");
        public static readonly MediaType OPENTYPE = new MediaType("application/vnd.ms-opentype", ".otf");
        public static readonly MediaType WOFF = new MediaType("application/font-woff", ".woff");

        // audio
        public static readonly MediaType MP3 = new MediaType("audio/mpeg", ".mp3");
        public static readonly MediaType OGG = new MediaType("audio/ogg", ".ogg");

        // video
        public static readonly MediaType MP4 = new MediaType("video/mp4", ".mp4");

        public static readonly MediaType SMIL = new MediaType("application/smil+xml", ".smil");
        public static readonly MediaType XPGT = new MediaType("application/adobe-page-template+xml", ".xpgt");
        public static readonly MediaType PLS = new MediaType("application/pls+xml", ".pls");

        public static MediaType[] mediatypes = new MediaType[]
        {
            XHTML, EPUB, JPG, PNG, GIF, CSS, SVG, TTF, NCX, XPGT, OPENTYPE, WOFF, SMIL, PLS, JAVASCRIPT, MP3, MP4, OGG
        };

        public static Dictionary<string, MediaType> mediaTypesByName = new Dictionary<string, MediaType>();

        static MediaTypeService()
        {
            for (int i = 0; i < mediatypes.Length; i++)
            {
                mediaTypesByName[mediatypes[i].Name] = mediatypes[i];
            }
        }


        public static bool IsBitmapImage(MediaType mediaType)
        {
            return Equals(mediaType, JPG) || Equals(mediaType, PNG) || Equals(mediaType, GIF);
        }

        /// <summary>
        /// Gets the MediaType based on the file extension.
        /// Null of no matching extension found.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>the MediaType based on the file extension.</returns>
        public static MediaType DetermineMediaType(string filename)
        {
            foreach (var mediaType in mediaTypesByName.Values)
            {
                foreach (string extension in mediaType.Extensions)
                {
                    if (StringUtil.EndsWithIgnoreCase(filename, extension))
                    {
                        return mediaType;
                    }
                }
            }

            return null;
        }

        public static MediaType GetMediaTypeByName(string mediaTypeName)
        {
            return mediaTypesByName[mediaTypeName];
        }
    }
}