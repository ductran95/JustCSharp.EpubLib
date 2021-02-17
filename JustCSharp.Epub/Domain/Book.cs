using System;
using System.Collections.Generic;

namespace JustCSharp.Epub.Domain
{
    /// <summary>
    /// Representation of a Book.
    /// </summary>
    /// <remarks>
    /// All resources of a Book (html, css, xml, fonts, images) are represented as Resources. See getResources() for access to these.<br/>
    /// A Book as 3 indexes into these Resources, as per the epub specification.<br/>
    /// <dl>
    /// <dt>Spine</dt>
    /// <dd>these are the Resources to be shown when a user reads the book from start to finish.</dd>
    /// <dt>Table of Contents</dt>
    /// <dd>The table of contents. Table of Contents references may be in a different order and contain different Resources than the spine, and often do.
    /// <dt>Guide</dt>
    /// </dd>The Guide has references to a set of special Resources like the cover page, the Glossary, the copyright page, etc.
    /// </dl>
    /// <p/>
    /// The complication is that these 3 indexes may and usually do point to different pages.
    /// A chapter may be split up in 2 pieces to fit it in to memory. Then the spine will contain both pieces, but the Table of Contents only the first.
    /// The Content page may be in the Table of Contents, the Guide, but not in the Spine.
    /// Etc.
    /// <p/>
    /// </remarks>
    public class Book
    {
        private Resources _resources = new Resources();
        private Metadata _metadata = new Metadata();
        private Spine _spine = new Spine();
        private TableOfContents _tableOfContents = new TableOfContents();
        private Guide _guide = new Guide();
        private Resource _opfResource;
        private Resource _ncxResource;
        private Resource _coverImage;  
        
        public Resources Resources { get; set; }
        public Metadata Metadata { get; set; }
        public Spine Spine { get; set; }
        public TableOfContents TableOfContents { get; set; }
        public Guide Guide { get; set; }
        public Resource OpfResource { get; set; }
        public Resource NcxResource { get; set; }
        public Resource CoverImage { get; set; }
        
        
    }
}