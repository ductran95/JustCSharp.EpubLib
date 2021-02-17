using System;
using JustCSharp.Epub.Extensions;

namespace JustCSharp.Epub.Domain
{
    /// <summary>
    /// A relator denotes which role a certain individual had in the creation/modification of the ebook.
    /// </summary>
    /// <remarks>
    /// Examples are 'creator', 'blurb writer', etc.
    /// This is contains the complete Library of Concress relator list.
    /// </remarks>
    /// <see href="http://www.loc.gov/marc/relators/relaterm.html"> MARC Code List for Relators </see>
    public enum Relator
    {
        #region A

        /// <summary>
        /// Use for a person or organization who principally exhibits acting skills in a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("act", "Actor")] ACTOR,

        /// <summary>
        /// Use for a person or organization who 1) reworks a musical composition, usually for a different medium, or 2) rewrites novels or stories for motion pictures or other audiovisual medium.
        /// </summary>
        [RelatorAttr("adp", "Adapter")] ADAPTER,

        /// <summary>
        /// Use for a person or organization that reviews, examines and interprets data or information in a specific area.
        /// </summary>
        [RelatorAttr("anl", "Analyst")] ANALYST,

        /// <summary>
        /// Use for a person or organization who draws the two-dimensional figures, manipulates the three dimensional objects and/or also programs the computer to move objects and images for the purpose of animated film processing. Animation cameras, stands, celluloid screens, transparencies and inks are some of the tools of the animator.
        /// </summary>
        [RelatorAttr("anm", "Animator")] ANIMATOR,

        /// <summary>
        /// Use for a person who writes manuscript annotations on a printed item.
        /// </summary>
        [RelatorAttr("ann", "Annotator")] ANNOTATOR,

        /// <summary>
        /// Use for a person or organization responsible for the submission of an application or who is named as eligible for the results of the processing of the application (e.g., bestowing of rights, reward, title, position).
        /// </summary>
        [RelatorAttr("app", "Applicant")] APPLICANT,

        /// <summary>
        /// Use for a person or organization who designs structures or oversees their construction.
        /// </summary>
        [RelatorAttr("arc", "Architect")] ARCHITECT,

        /// <summary>
        /// Use for a person or organization who transcribes a musical composition, usually for a different medium from that of the original; in an arrangement the musical substance remains essentially unchanged.
        /// </summary>
        [RelatorAttr("arr", "Arranger")] ARRANGER,

        /// <summary>
        /// Use for a person (e.g., a painter or sculptor) who makes copies of works of visual art.
        /// </summary>
        [RelatorAttr("acp", "Art copyist")] ART_COPYIST,

        /// <summary>
        /// Use for a person (e.g., a painter) or organization who conceives, and perhaps also implements, an original graphic design or work of art, if specific codes (e.g., [egr], [etr]) are not desired. For book illustrators, prefer Illustrator [ill].
        /// </summary>
        [RelatorAttr("art", "Artist")] ARTIST,

        /// <summary>
        /// Use for a person responsible for controlling the development of the artistic style of an entire production, including the choice of works to be presented and selection of senior production staff.
        /// </summary>
        [RelatorAttr("ard", "Artistic director")]
        ARTISTIC_DIRECTOR,

        /// <summary>
        /// Use for a person or organization to whom a license for printing or publishing has been transferred.
        /// </summary>
        [RelatorAttr("asg", "Assignee")] ASSIGNEE,

        /// <summary>
        /// Use for a person or organization associated with or found in an item or collection, which cannot be determined to be that of a Former owner [fmo] or other designated relator indicative of provenance.
        /// </summary>
        [RelatorAttr("asn", "Associated name")]
        ASSOCIATED_NAME,

        /// <summary>
        /// Use for an author, artist, etc., relating him/her to a work for which there is or once was substantial authority for designating that person as author, creator, etc. of the work.
        /// </summary>
        [RelatorAttr("att", "Attributed name")]
        ATTRIBUTED_NAME,

        /// <summary>
        /// Use for a person or organization in charge of the estimation and public auctioning of goods, particularly books, artistic works, etc.
        /// </summary>
        [RelatorAttr("auc", "Auctioneer")] AUCTIONEER,

        /// <summary>
        /// Use for a person or organization chiefly responsible for the intellectual or artistic content of a work, usually printed text. This term may also be used when more than one person or body bears such responsibility.
        /// </summary>
        [RelatorAttr("aut", "Author")] AUTHOR,

        /// <summary>
        /// Use for a person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
        /// </summary>
        [RelatorAttr("aqt", "Author in quotations or text extracts")]
        AUTHOR_IN_QUOTATIONS_OR_TEXT_EXTRACTS,

        /// <summary>
        /// Use for a person or organization responsible for an afterword, postface, colophon, etc. but who is not the chief author of a work.
        /// </summary>
        [RelatorAttr("aft", "Author of afterword, colophon, etc.")]
        AUTHOR_OF_AFTERWORD_COLOPHON_ETC,

        /// <summary>
        /// Use for a person or organization responsible for the dialog or spoken commentary for a screenplay or sound recording.
        /// </summary>
        [RelatorAttr("aud", "Author of dialog")]
        AUTHOR_OF_DIALOG,

        /// <summary>
        /// Use for a person or organization responsible for an introduction, preface, foreword, or other critical introductory matter, but who is not the chief author.
        /// </summary>
        [RelatorAttr("aui", "Author of introduction, etc.")]
        AUTHOR_OF_INTRODUCTION_ETC,

        /// <summary>
        /// Use for a person or organization responsible for a motion picture screenplay, dialog, spoken commentary, etc.
        /// </summary>
        [RelatorAttr("aus", "Author of screenplay, etc.")]
        AUTHOR_OF_SCREENPLAY_ETC,
        
        #endregion

        #region B
        
        /// <summary>
        /// Use for a person or organization responsible for a work upon which the work represented by the catalog record is based. This may be appropriate for adaptations, sequels, continuations, indexes, etc.
        /// </summary>
        [RelatorAttr("ant", "Bibliographic antecedent")]
        BIBLIOGRAPHIC_ANTECEDENT,

        /// <summary>
        /// Use for a person or organization responsible for the binding of printed or manuscript materials.
        /// </summary>
        [RelatorAttr("bnd", "Binder")] BINDER,

        /// <summary>
        /// Use for a person or organization responsible for the binding design of a book, including the type of binding, the type of materials used, and any decorative aspects of the binding.
        /// </summary>
        [RelatorAttr("bdd", "Binding designer")]
        BINDING_DESIGNER,

        /// <summary>
        /// Use for the named entity responsible for writing a commendation or testimonial for a work, which appears on or within the publication itself, frequently on the back or dust jacket of print publications or on advertising material for all media.
        /// </summary>
        [RelatorAttr("blw", "Blurb writer")] BLURB_WRITER,

        /// <summary>
        /// Use for a person or organization responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used.
        /// </summary>
        [RelatorAttr("bkd", "Book designer")] BOOK_DESIGNER,

        /// <summary>
        /// Use for a person or organization responsible for the production of books and other print media, if specific codes (e.g., [bkd], [egr], [tyd], [prt]) are not desired.
        /// </summary>
        [RelatorAttr("bkp", "Book producer")] BOOK_PRODUCER,

        /// <summary>
        /// Use for a person or organization responsible for the design of flexible covers designed for or published with a book, including the type of materials used, and any decorative aspects of the bookjacket.
        /// </summary>
        [RelatorAttr("bjd", "Bookjacket designer")]
        BOOKJACKET_DESIGNER,

        /// <summary>
        /// Use for a person or organization responsible for the design of a book owner's identification label that is most commonly pasted to the inside front cover of a book.
        /// </summary>
        [RelatorAttr("bpd", "Bookplate designer")]
        BOOKPLATE_DESIGNER,

        /// <summary>
        /// Use for a person or organization who makes books and other bibliographic materials available for purchase. Interest in the materials is primarily lucrative.
        /// </summary>
        [RelatorAttr("bsl", "Bookseller")] BOOKSELLER,
        
        #endregion

        #region C

        /// <summary>
        /// Use for a person or organization who writes in an artistic hand, usually as a copyist and or engrosser.
        /// </summary>
        [RelatorAttr("cll", "Calligrapher")] CALLIGRAPHER,

        /// <summary>
        /// Use for a person or organization responsible for the creation of maps and other cartographic materials.
        /// </summary>
        [RelatorAttr("ctg", "Cartographer")] CARTOGRAPHER,

        /// <summary>
        /// Use for a censor, bowdlerizer, expurgator, etc., official or private.
        /// </summary>
        [RelatorAttr("cns", "Censor")] CENSOR,

        /// <summary>
        /// Use for a person or organization who composes or arranges dances or other movements (e.g., "master of swords")] for a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("chr", "Choreographer")] CHOREOGRAPHER,

        /// <summary>
        /// Use for a person or organization who is in charge of the images captured for a motion picture film. The cinematographer works under the supervision of a director, and may also be referred to as director of photography. Do not confuse with videographer.
        /// </summary>
        [RelatorAttr("cng", "Cinematographer")]
        CINEMATOGRAPHER,

        /// <summary>
        /// Use for a person or organization for whom another person or organization is acting.
        /// </summary>
        [RelatorAttr("cli", "Client")] CLIENT,

        /// <summary>
        /// Use for a person or organization that takes a limited part in the elaboration of a work of another person or organization that brings complements (e.g., appendices, notes) to the work.
        /// </summary>
        [RelatorAttr("clb", "Collaborator")] COLLABORATOR,

        /// <summary>
        /// Use for a person or organization who has brought together material from various sources that has been arranged, described, and cataloged as a collection. A collector is neither the creator of the material nor a person to whom manuscripts in the collection may have been addressed.
        /// </summary>
        [RelatorAttr("col", "Collector")] COLLECTOR,

        /// <summary>
        /// Use for a person or organization responsible for the production of photographic prints from film or other colloid that has ink-receptive and ink-repellent surfaces.
        /// </summary>
        [RelatorAttr("clt", "Collotyper")] COLLOTYPER,

        /// <summary>
        /// Use for the named entity responsible for applying color to drawings, prints, photographs, maps, moving images, etc.
        /// </summary>
        [RelatorAttr("clr", "Colorist")] COLORIST,

        /// <summary>
        /// Use for a person or organization who provides interpretation, analysis, or a discussion of the subject matter on a recording, motion picture, or other audiovisual medium.
        /// </summary>
        [RelatorAttr("cmm", "Commentator")] COMMENTATOR,

        /// <summary>
        /// Use for a person or organization responsible for the commentary or explanatory notes about a text. For the writer of manuscript annotations in a printed book, use Annotator [ann].
        /// </summary>
        [RelatorAttr("cwt", "Commentator for written text")]
        COMMENTATOR_FOR_WRITTEN_TEXT,

        /// <summary>
        /// Use for a person or organization who produces a work or publication by selecting and putting together material from the works of various persons or bodies.
        /// </summary>
        [RelatorAttr("com", "Compiler")] COMPILER,

        /// <summary>
        /// Use for the party who applies to the courts for redress, usually in an equity proceeding.
        /// </summary>
        [RelatorAttr("cpl", "Complainant")] COMPLAINANT,

        /// <summary>
        /// Use for a complainant who takes an appeal from one court or jurisdiction to another to reverse the judgment, usually in an equity proceeding.
        /// </summary>
        [RelatorAttr("cpt", "Complainant-appellant")]
        COMPLAINANT_APPELLANT,

        /// <summary>
        /// Use for a complainant against whom an appeal is taken from one court or jurisdiction to another to reverse the judgment, usually in an equity proceeding.
        /// </summary>
        [RelatorAttr("cpe", "Complainant-appellee")]
        COMPLAINANT_APPELLEE,

        /// <summary>
        /// Use for a person or organization who creates a musical work, usually a piece of music in manuscript or printed form.
        /// </summary>
        [RelatorAttr("cmp", "Composer")] COMPOSER,

        /// <summary>
        /// Use for a person or organization responsible for the creation of metal slug, or molds made of other materials, used to produce the text and images in printed matter.
        /// </summary>
        [RelatorAttr("cmt", "Compositor")] COMPOSITOR,

        /// <summary>
        /// Use for a person or organization responsible for the original idea on which a work is based, this includes the scientific author of an audio-visual item and the conceptor of an advertisement.
        /// </summary>
        [RelatorAttr("ccp", "Conceptor")] CONCEPTOR,

        /// <summary>
        /// Use for a person who directs a performing group (orchestra, chorus, opera, etc.) in a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("cnd", "Conductor")] CONDUCTOR,

        /// <summary>
        /// Use for the named entity responsible for documenting, preserving, or treating printed or manuscript material, works of art, artifacts, or other media.
        /// </summary>
        [RelatorAttr("con", "Conservator")] CONSERVATOR,

        /// <summary>
        /// Use for a person or organization relevant to a resource, who is called upon for professional advice or services in a specialized field of knowledge or training.
        /// </summary>
        [RelatorAttr("csl", "Consultant")] CONSULTANT,

        /// <summary>
        /// Use for a person or organization relevant to a resource, who is engaged specifically to provide an intellectual overview of a strategic or operational task and by analysis, specification, or instruction, to create or propose a cost-effective course of action or solution.
        /// </summary>
        [RelatorAttr("csp", "Consultant to a project")]
        CONSULTANT_TO_A_PROJECT,

        /// <summary>
        /// Use for the party who opposes, resists, or disputes, in a court of law, a claim, decision, result, etc.
        /// </summary>
        [RelatorAttr("cos", "Contestant")] CONTESTANT,

        /// <summary>
        /// Use for a contestant who takes an appeal from one court of law or jurisdiction to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("cot", "Contestant-appellant")]
        CONTESTANT_APPELLANT,

        /// <summary>
        /// Use for a contestant against whom an appeal is taken from one court of law or jurisdiction to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("coe", "Contestant-appellee")]
        CONTESTANT_APPELLEE,

        /// <summary>
        /// Use for the party defending a claim, decision, result, etc. being opposed, resisted, or disputed in a court of law.
        /// </summary>
        [RelatorAttr("cts", "Contestee")] CONTESTEE,

        /// <summary>
        /// Use for a contestee who takes an appeal from one court or jurisdiction to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("ctt", "Contestee-appellant")]
        CONTESTEE_APPELLANT,

        /// <summary>
        /// Use for a contestee against whom an appeal is taken from one court or jurisdiction to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("cte", "Contestee-appellee")]
        CONTESTEE_APPELLEE,

        /// <summary>
        /// Use for a person or organization relevant to a resource, who enters into a contract with another person or organization to perform a specific task.
        /// </summary>
        [RelatorAttr("ctr", "Contractor")] CONTRACTOR,

        /// <summary>
        /// Use for a person or organization one whose work has been contributed to a larger work, such as an anthology, serial publication, or other compilation of individual works. Do not use if the sole function in relation to a work is as author, editor, compiler or translator.
        /// </summary>
        [RelatorAttr("ctb", "Contributor")] CONTRIBUTOR,

        /// <summary>
        /// Use for a person or organization listed as a copyright owner at the time of registration. Copyright can be granted or later transferred to another person or organization, at which time the claimant becomes the copyright holder.
        /// </summary>
        [RelatorAttr("cpc", "Copyright claimant")]
        COPYRIGHT_CLAIMANT,

        /// <summary>
        /// Use for a person or organization to whom copy and legal rights have been granted or transferred for the intellectual content of a work. The copyright holder, although not necessarily the creator of the work, usually has the exclusive right to benefit financially from the sale and use of the work to which the associated copyright protection applies.
        /// </summary>
        [RelatorAttr("cph", "Copyright holder")]
        COPYRIGHT_HOLDER,

        /// <summary>
        /// Use for a person or organization who is a corrector of manuscripts, such as the scriptorium official who corrected the work of a scribe. For printed matter, use Proofreader.
        /// </summary>
        [RelatorAttr("crr", "Corrector")] CORRECTOR,

        /// <summary>
        /// Use for a person or organization who was either the writer or recipient of a letter or other communication.
        /// </summary>
        [RelatorAttr("crp", "Correspondent")] CORRESPONDENT,

        /// <summary>
        /// Use for a person or organization who designs or makes costumes, fixes hair, etc., for a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("cst", "Costume designer")]
        COSTUME_DESIGNER,

        /// <summary>
        /// Use for a person or organization responsible for the graphic design of a book cover, album cover, slipcase, box, container, etc. For a person or organization responsible for the graphic design of an entire book, use Book designer; for book jackets, use Bookjacket designer.
        /// </summary>
        [RelatorAttr("cov", "Cover designer")] COVER_DESIGNER,

        /// <summary>
        /// Use for a person or organization responsible for the intellectual or artistic content of a work.
        /// </summary>
        [RelatorAttr("cre", "Creator")] CREATOR,

        /// <summary>
        /// Use for a person or organization responsible for conceiving and organizing an exhibition.
        /// </summary>
        [RelatorAttr("cur", "Curator of an exhibition")]
        CURATOR_OF_AN_EXHIBITION,
        
        #endregion

        #region D

        /// <summary>
        /// Use for a person or organization who principally exhibits dancing skills in a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("dnc", "Dancer")] DANCER,

        /// <summary>
        /// Use for a person or organization that submits data for inclusion in a database or other collection of data.
        /// </summary>
        [RelatorAttr("dtc", "Data contributor")]
        DATA_CONTRIBUTOR,

        /// <summary>
        /// Use for a person or organization responsible for managing databases or other data sources.
        /// </summary>
        [RelatorAttr("dtm", "Data manager")] DATA_MANAGER,

        /// <summary>
        /// Use for a person or organization to whom a book, manuscript, etc., is dedicated (not the recipient of a gift).
        /// </summary>
        [RelatorAttr("dte", "Dedicatee")] DEDICATEE,

        /// <summary>
        /// Use for the author of a dedication, which may be a formal statement or in epistolary or verse form.
        /// </summary>
        [RelatorAttr("dto", "Dedicator")] DEDICATOR,

        /// <summary>
        /// Use for the party defending or denying allegations made in a suit and against whom relief or recovery is sought in the courts, usually in a legal action.
        /// </summary>
        [RelatorAttr("dfd", "Defendant")] DEFENDANT,

        /// <summary>
        /// Use for a defendant who takes an appeal from one court or jurisdiction to another to reverse the judgment, usually in a legal action.
        /// </summary>
        [RelatorAttr("dft", "Defendant-appellant")]
        DEFENDANT_APPELLANT,

        /// <summary>
        /// Use for a defendant against whom an appeal is taken from one court or jurisdiction to another to reverse the judgment, usually in a legal action.
        /// </summary>
        [RelatorAttr("dfe", "Defendant-appellee")]
        DEFENDANT_APPELLEE,

        /// <summary>
        /// Use for the organization granting a degree for which the thesis or dissertation described was presented.
        /// </summary>
        [RelatorAttr("dgg", "Degree grantor")] DEGREE_GRANTOR,

        /// <summary>
        /// Use for a person or organization executing technical drawings from others' designs.
        /// </summary>
        [RelatorAttr("dln", "Delineator")] DELINEATOR,

        /// <summary>
        /// Use for an entity depicted or portrayed in a work, particularly in a work of art.
        /// </summary>
        [RelatorAttr("dpc", "Depicted")] DEPICTED,

        /// <summary>
        /// Use for a person or organization placing material in the physical custody of a library or repository without transferring the legal title.
        /// </summary>
        [RelatorAttr("dpt", "Depositor")] DEPOSITOR,

        /// <summary>
        /// Use for a person or organization responsible for the design if more specific codes (e.g., [bkd], [tyd]) are not desired.
        /// </summary>
        [RelatorAttr("dsr", "Designer")] DESIGNER,

        /// <summary>
        /// Use for a person or organization who is responsible for the general management of a work or who supervises the production of a performance for stage, screen, or sound recording.
        /// </summary>
        [RelatorAttr("drt", "Director")] DIRECTOR,

        /// <summary>
        /// Use for a person who presents a thesis for a university or higher-level educational degree.
        /// </summary>
        [RelatorAttr("dis", "Dissertant")] DISSERTANT,

        /// <summary>
        /// Use for the name of a place from which a resource, e.g., a serial, is distributed.
        /// </summary>
        [RelatorAttr("dbp", "Distribution place")]
        DISTRIBUTION_PLACE,

        /// <summary>
        /// Use for a person or organization that has exclusive or shared marketing rights for an item.
        /// </summary>
        [RelatorAttr("dst", "Distributor")] DISTRIBUTOR,

        /// <summary>
        /// Use for a person or organization who is the donor of a book, manuscript, etc., to its present owner. Donors to previous owners are designated as Former owner [fmo] or Inscriber [ins].
        /// </summary>
        [RelatorAttr("dnr", "Donor")] DONOR,

        /// <summary>
        /// Use for a person or organization who prepares artistic or technical drawings.
        /// </summary>
        [RelatorAttr("drm", "Draftsman")] DRAFTSMAN,

        /// <summary>
        /// Use for a person or organization to which authorship has been dubiously or incorrectly ascribed.
        /// </summary>
        [RelatorAttr("dub", "Dubious author")] DUBIOUS_AUTHOR,
        
        #endregion

        #region E

        /// <summary>
        /// Use for a person or organization who prepares for publication a work not primarily his/her own, such as by elucidating text, adding introductory or other critical matter, or technically directing an editorial staff.
        /// </summary>
        [RelatorAttr("edt", "Editor")] EDITOR,

        /// <summary>
        /// Use for a person responsible for setting up a lighting rig and focusing the lights for a production, and running the lighting at a performance.
        /// </summary>
        [RelatorAttr("elg", "Electrician")] ELECTRICIAN,

        /// <summary>
        /// Use for a person or organization who creates a duplicate printing surface by pressure molding and electrodepositing of metal that is then backed up with lead for printing.
        /// </summary>
        [RelatorAttr("elt", "Electrotyper")] ELECTROTYPER,

        /// <summary>
        /// Use for a person or organization that is responsible for technical planning and design, particularly with construction.
        /// </summary>
        [RelatorAttr("eng", "Engineer")] ENGINEER,

        /// <summary>
        /// Use for a person or organization who cuts letters, figures, etc. on a surface, such as a wooden or metal plate, for printing.
        /// </summary>
        [RelatorAttr("egr", "Engraver")] ENGRAVER,

        /// <summary>
        /// Use for a person or organization who produces text or images for printing by subjecting metal, glass, or some other surface to acid or the corrosive action of some other substance.
        /// </summary>
        [RelatorAttr("etr", "Etcher")] ETCHER,

        /// <summary>
        /// Use for the name of the place where an event such as a conference or a concert took place.
        /// </summary>
        [RelatorAttr("evp", "Event place")] EVENT_PLACE,

        /// <summary>
        /// Use for a person or organization in charge of the description and appraisal of the value of goods, particularly rare items, works of art, etc.
        /// </summary>
        [RelatorAttr("exp", "Expert")] EXPERT,
        
        #endregion

        #region F

        /// <summary>
        /// Use for a person or organization that executed the facsimile.
        /// </summary>
        [RelatorAttr("fac", "Facsimilist")] FACSIMILIST,

        /// <summary>
        /// Use for a person or organization that manages or supervises the work done to collect raw data or do research in an actual setting or environment (typically applies to the natural and social sciences).
        /// </summary>
        [RelatorAttr("fld", "Field director")] FIELD_DIRECTOR,

        /// <summary>
        /// Use for a person or organization who is an editor of a motion picture film. This term is used regardless of the medium upon which the motion picture is produced or manufactured (e.g., acetate film, video tape).
        /// </summary>
        [RelatorAttr("flm", "Film editor")] FILM_EDITOR,

        /// <summary>
        /// Use for a person or organization who is identified as the only party or the party of the first part. In the case of transfer of right, this is the assignor, transferor, licensor, grantor, etc. Multiple parties can be named jointly as the first party
        /// </summary>
        [RelatorAttr("fpy", "First party")] FIRST_PARTY,

        /// <summary>
        /// Use for a person or organization who makes or imitates something of value or importance, especially with the intent to defraud.
        /// </summary>
        [RelatorAttr("frg", "Forger")] FORGER,

        /// <summary>
        /// Use for a person or organization who owned an item at any time in the past. Includes those to whom the material was once presented. A person or organization giving the item to the present owner is designated as Donor [dnr]
        /// </summary>
        [RelatorAttr("fmo", "Former owner")] FORMER_OWNER,

        /// <summary>
        /// Use for a person or organization that furnished financial support for the production of the work.
        /// </summary>
        [RelatorAttr("fnd", "Funder")] FUNDER,
        
        #endregion

        /// <summary>
        /// Use for a person responsible for geographic information system (GIS) development and integration with global positioning system data.
        /// </summary>
        [RelatorAttr("gis", "Geographic information specialist")]
        GEOGRAPHIC_INFORMATION_SPECIALIST,

        #region H

        /// <summary>
        /// Use for a person or organization in memory or honor of whom a book, manuscript, etc. is donated.
        /// </summary>
        [RelatorAttr("hnr", "Honoree")] HONOREE,

        /// <summary>
        /// Use for a person who is invited or regularly leads a program (often broadcast) that includes other guests, performers, etc. (e.g., talk show host).
        /// </summary>
        [RelatorAttr("hst", "Host")] HOST,
        
        #endregion

        #region I

        /// <summary>
        /// Use for a person or organization responsible for the decoration of a work (especially manuscript material) with precious metals or color, usually with elaborate designs and motifs.
        /// </summary>
        [RelatorAttr("ilu", "Illuminator")] ILLUMINATOR,

        /// <summary>
        /// Use for a person or organization who conceives, and perhaps also implements, a design or illustration, usually to accompany a written text.
        /// </summary>
        [RelatorAttr("ill", "Illustrator")] ILLUSTRATOR,

        /// <summary>
        /// Use for a person who signs a presentation statement.
        /// </summary>
        [RelatorAttr("ins", "Inscriber")] INSCRIBER,

        /// <summary>
        /// Use for a person or organization who principally plays an instrument in a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("itr", "Instrumentalist")]
        INSTRUMENTALIST,

        /// <summary>
        /// Use for a person or organization who is interviewed at a consultation or meeting, usually by a reporter, pollster, or some other information gathering agent.
        /// </summary>
        [RelatorAttr("ive", "Interviewee")] INTERVIEWEE,

        /// <summary>
        /// Use for a person or organization who acts as a reporter, pollster, or other information gathering agent in a consultation or meeting involving one or more individuals.
        /// </summary>
        [RelatorAttr("ivr", "Interviewer")] INTERVIEWER,

        /// <summary>
        /// Use for a person or organization who first produces a particular useful item, or develops a new process for obtaining a known item or result.
        /// </summary>
        [RelatorAttr("inv", "Inventor")] INVENTOR,
        
        #endregion

        #region L

        /// <summary>
        /// Use for an institution that provides scientific analyses of material samples.
        /// </summary>
        [RelatorAttr("lbr", "Laboratory")] LABORATORY,

        /// <summary>
        /// Use for a person or organization that manages or supervises work done in a controlled setting or environment.
        /// </summary>
        [RelatorAttr("ldr", "Laboratory director")]
        LABORATORY_DIRECTOR,

        /// <summary>
        /// Use for a person or organization whose work involves coordinating the arrangement of existing and proposed land features and structures.
        /// </summary>
        [RelatorAttr("lsa", "Landscape architect")]
        LANDSCAPE_ARCHITECT,

        /// <summary>
        /// Use to indicate that a person or organization takes primary responsibility for a particular activity or endeavor. Use with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators.
        /// </summary>
        [RelatorAttr("led", "Lead")] LEAD,

        /// <summary>
        /// Use for a person or organization permitting the temporary use of a book, manuscript, etc., such as for photocopying or microfilming.
        /// </summary>
        [RelatorAttr("len", "Lender")] LENDER,

        /// <summary>
        /// Use for the party who files a libel in an ecclesiastical or admiralty case.
        /// </summary>
        [RelatorAttr("lil", "Libelant")] LIBELANT,

        /// <summary>
        /// Use for a libelant who takes an appeal from one ecclesiastical court or admiralty to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("lit", "Libelant-appellant")]
        LIBELANT_APPELLANT,

        /// <summary>
        /// Use for a libelant against whom an appeal is taken from one ecclesiastical court or admiralty to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("lie", "Libelant-appellee")]
        LIBELANT_APPELLEE,

        /// <summary>
        /// Use for a party against whom a libel has been filed in an ecclesiastical court or admiralty.
        /// </summary>
        [RelatorAttr("lel", "Libelee")] LIBELEE,

        /// <summary>
        /// Use for a libelee who takes an appeal from one ecclesiastical court or admiralty to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("let", "Libelee-appellant")]
        LIBELEE_APPELLANT,

        /// <summary>
        /// Use for a libelee against whom an appeal is taken from one ecclesiastical court or admiralty to another to reverse the judgment.
        /// </summary>
        [RelatorAttr("lee", "Libelee-appellee")]
        LIBELEE_APPELLEE,

        /// <summary>
        /// Use for a person or organization who is a writer of the text of an opera, oratorio, etc.
        /// </summary>
        [RelatorAttr("lbt", "Librettist")] LIBRETTIST,

        /// <summary>
        /// Use for a person or organization who is an original recipient of the right to print or publish.
        /// </summary>
        [RelatorAttr("lse", "Licensee")] LICENSEE,

        /// <summary>
        /// Use for person or organization who is a signer of the license, imprimatur, etc.
        /// </summary>
        [RelatorAttr("lso", "Licensor")] LICENSOR,

        /// <summary>
        /// Use for a person or organization who designs the lighting scheme for a theatrical presentation, entertainment, motion picture, etc.
        /// </summary>
        [RelatorAttr("lgd", "Lighting designer")]
        LIGHTING_DESIGNER,

        /// <summary>
        /// Use for a person or organization who prepares the stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.
        /// </summary>
        [RelatorAttr("ltg", "Lithographer")] LITHOGRAPHER,

        /// <summary>
        /// Use for a person or organization who is a writer of the text of a song.
        /// </summary>
        [RelatorAttr("lyr", "Lyricist")] LYRICIST,
        
        #endregion

        #region M

        /// <summary>
        /// Use for a person or organization that makes an artifactual work (an object made or modified by one or more persons). Examples of artifactual works include vases, cannons or pieces of furniture.
        /// </summary>
        [RelatorAttr("mfr", "Manufacturer")] MANUFACTURER,

        /// <summary>
        /// Use for the named entity responsible for marbling paper, cloth, leather, etc. used in construction of a resource.
        /// </summary>
        [RelatorAttr("mrb", "Marbler")] MARBLER,

        /// <summary>
        /// Use for a person or organization performing the coding of SGML, HTML, or XML markup of metadata, text, etc.
        /// </summary>
        [RelatorAttr("mrk", "Markup editor")] MARKUP_EDITOR,

        /// <summary>
        /// Use for a person or organization primarily responsible for compiling and maintaining the original description of a metadata set (e.g., geospatial metadata set).
        /// </summary>
        [RelatorAttr("mdc", "Metadata contact")]
        METADATA_CONTACT,

        /// <summary>
        /// Use for a person or organization responsible for decorations, illustrations, letters, etc. cut on a metal surface for printing or decoration.
        /// </summary>
        [RelatorAttr("mte", "Metal-engraver")] METAL_ENGRAVER,

        /// <summary>
        /// Use for a person who leads a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.
        /// </summary>
        [RelatorAttr("mod", "Moderator")] MODERATOR,

        /// <summary>
        /// Use for a person or organization that supervises compliance with the contract and is responsible for the report and controls its distribution. Sometimes referred to as the grantee, or controlling agency.
        /// </summary>
        [RelatorAttr("mon", "Monitor")] MONITOR,

        /// <summary>
        /// Use for a person who transcribes or copies musical notation
        /// </summary>
        [RelatorAttr("mcp", "Music copyist")] MUSIC_COPYIST,

        /// <summary>
        /// Use for a person responsible for basic music decisions about a production, including coordinating the work of the composer, the sound editor, and sound mixers, selecting musicians, and organizing and/or conducting sound for rehearsals and performances.
        /// </summary>
        [RelatorAttr("msd", "Musical director")]
        MUSICAL_DIRECTOR,

        /// <summary>
        /// Use for a person or organization who performs music or contributes to the musical content of a work when it is not possible or desirable to identify the function more precisely.
        /// </summary>
        [RelatorAttr("mus", "Musician")] MUSICIAN,
        
        #endregion

        /// <summary>
        /// Use for a person who is a speaker relating the particulars of an act, occurrence, or course of events.
        /// </summary>
        [RelatorAttr("nrt", "Narrator")] NARRATOR,

        #region O

        /// <summary>
        /// Use for a person or organization responsible for opposing a thesis or dissertation.
        /// </summary>
        [RelatorAttr("opn", "Opponent")] OPPONENT,

        /// <summary>
        /// Use for a person or organization responsible for organizing a meeting for which an item is the report or proceedings.
        /// </summary>
        [RelatorAttr("orm", "Organizer of meeting")]
        ORGANIZER_OF_MEETING,

        /// <summary>
        /// Use for a person or organization performing the work, i.e., the name of a person or organization associated with the intellectual content of the work. This category does not include the publisher or personal affiliation, or sponsor except where it is also the corporate author.
        /// </summary>
        [RelatorAttr("org", "Originator")] ORIGINATOR,

        /// <summary>
        /// Use for relator codes from other lists which have no equivalent in the MARC list or for terms which have not been assigned a code.
        /// </summary>
        [RelatorAttr("oth", "Other")] OTHER,

        /// <summary>
        /// Use for a person or organization that currently owns an item or collection.
        /// </summary>
        [RelatorAttr("own", "Owner")] OWNER,
        
        #endregion

        #region P

        /// <summary>
        /// Use for a person or organization responsible for the production of paper, usually from wood, cloth, or other fibrous material.
        /// </summary>
        [RelatorAttr("ppm", "Papermaker")] PAPERMAKER,

        /// <summary>
        /// Use for a person or organization that applied for a patent.
        /// </summary>
        [RelatorAttr("pta", "Patent applicant")]
        PATENT_APPLICANT,

        /// <summary>
        /// Use for a person or organization that was granted the patent referred to by the item.
        /// </summary>
        [RelatorAttr("pth", "Patent holder")] PATENT_HOLDER,

        /// <summary>
        /// Use for a person or organization responsible for commissioning a work. Usually a patron uses his or her means or influence to support the work of artists, writers, etc. This includes those who commission and pay for individual works.
        /// </summary>
        [RelatorAttr("pat", "Patron")] PATRON,

        /// <summary>
        /// Use for a person or organization who exhibits musical or acting skills in a musical or dramatic presentation or entertainment, if specific codes for those functions ([act], [dnc], [itr], [voc], etc.) are not used. If specific codes are used, [prf] is used for a person whose principal skill is not known or specified.
        /// </summary>
        [RelatorAttr("prf", "Performer")] PERFORMER,

        /// <summary>
        /// Use for an authority (usually a government agency) that issues permits under which work is accomplished.
        /// </summary>
        [RelatorAttr("pma", "Permitting agency")]
        PERMITTING_AGENCY,

        /// <summary>
        /// Use for a person or organization responsible for taking photographs, whether they are used in their original form or as reproductions.
        /// </summary>
        [RelatorAttr("pht", "Photographer")] PHOTOGRAPHER,

        /// <summary>
        /// Use for the party who complains or sues in court in a personal action, usually in a legal proceeding.
        /// </summary>
        [RelatorAttr("ptf", "Plaintiff")] PLAINTIFF,

        /// <summary>
        /// Use for a plaintiff who takes an appeal from one court or jurisdiction to another to reverse the judgment, usually in a legal proceeding.
        /// </summary>
        [RelatorAttr("ptt", "Plaintiff-appellant")]
        PLAINTIFF_APPELLANT,

        /// <summary>
        /// Use for a plaintiff against whom an appeal is taken from one court or jurisdiction to another to reverse the judgment, usually in a legal proceeding.
        /// </summary>
        [RelatorAttr("pte", "Plaintiff-appellee")]
        PLAINTIFF_APPELLEE,

        /// <summary>
        /// Use for a person or organization responsible for the production of plates, usually for the production of printed images and/or text.
        /// </summary>
        [RelatorAttr("plt", "Platemaker")] PLATEMAKER,

        /// <summary>
        /// Use for a person or organization who prints texts, whether from type or plates.
        /// </summary>
        [RelatorAttr("prt", "Printer")] PRINTER,

        /// <summary>
        /// Use for a person or organization who prints illustrations from plates.
        /// </summary>
        [RelatorAttr("pop", "Printer of plates")]
        PRINTER_OF_PLATES,

        /// <summary>
        /// Use for a person or organization who makes a relief, intaglio, or planographic printing surface.
        /// </summary>
        [RelatorAttr("prm", "Printmaker")] PRINTMAKER,

        /// <summary>
        /// Use for a person or organization primarily responsible for performing or initiating a process, such as is done with the collection of metadata sets.
        /// </summary>
        [RelatorAttr("prc", "Process contact")]
        PROCESS_CONTACT,

        /// <summary>
        /// Use for a person or organization responsible for the making of a motion picture, including business aspects, management of the productions, and the commercial success of the work.
        /// </summary>
        [RelatorAttr("pro", "Producer")] PRODUCER,

        /// <summary>
        /// Use for a person responsible for all technical and business matters in a production.
        /// </summary>
        [RelatorAttr("pmn", "Production manager")]
        PRODUCTION_MANAGER,

        /// <summary>
        /// Use for a person or organization associated with the production (props, lighting, special effects, etc.) of a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("prd", "Production personnel")]
        PRODUCTION_PERSONNEL,

        /// <summary>
        /// Use for a person or organization responsible for the creation and/or maintenance of computer program design documents, source code, and machine-executable digital files and supporting documentation.
        /// </summary>
        [RelatorAttr("prg", "Programmer")] PROGRAMMER,

        /// <summary>
        /// Use for a person or organization with primary responsibility for all essential aspects of a project, or that manages a very large project that demands senior level responsibility, or that has overall responsibility for managing projects, or provides overall direction to a project manager.
        /// </summary>
        [RelatorAttr("pdr", "Project director")]
        PROJECT_DIRECTOR,

        /// <summary>
        /// Use for a person who corrects printed matter. For manuscripts, use Corrector [crr].
        /// </summary>
        [RelatorAttr("pfr", "Proofreader")] PROOFREADER,

        /// <summary>
        /// Use for the name of the place where a resource is published.
        /// </summary>
        [RelatorAttr("pup", "Publication place")]
        PUBLICATION_PLACE,

        /// <summary>
        /// Use for a person or organization that makes printed matter, often text, but also printed music, artwork, etc. available to the public.
        /// </summary>
        [RelatorAttr("pbl", "Publisher")] PUBLISHER,

        /// <summary>
        /// Use for a person or organization who presides over the elaboration of a collective work to ensure its coherence or continuity. This includes editors-in-chief, literary editors, editors of series, etc.
        /// </summary>
        [RelatorAttr("pbd", "Publishing director")]
        PUBLISHING_DIRECTOR,

        /// <summary>
        /// Use for a person or organization who manipulates, controls, or directs puppets or marionettes in a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("ppt", "Puppeteer")] PUPPETEER,
        
        #endregion

        #region R

        /// <summary>
        /// Use for a person or organization to whom correspondence is addressed.
        /// </summary>
        [RelatorAttr("rcp", "Recipient")] RECIPIENT,

        /// <summary>
        /// Use for a person or organization who supervises the technical aspects of a sound or video recording session.
        /// </summary>
        [RelatorAttr("rce", "Recording engineer")]
        RECORDING_ENGINEER,

        /// <summary>
        /// Use for a person or organization who writes or develops the framework for an item without being intellectually responsible for its content.
        /// </summary>
        [RelatorAttr("red", "Redactor")] REDACTOR,

        /// <summary>
        /// Use for a person or organization who prepares drawings of architectural designs (i.e., renderings) in accurate, representational perspective to show what the project will look like when completed.
        /// </summary>
        [RelatorAttr("ren", "Renderer")] RENDERER,

        /// <summary>
        /// Use for a person or organization who writes or presents reports of news or current events on air or in print.
        /// </summary>
        [RelatorAttr("rpt", "Reporter")] REPORTER,

        /// <summary>
        /// Use for an agency that hosts data or material culture objects and provides services to promote long term, consistent and shared use of those data or objects.
        /// </summary>
        [RelatorAttr("rps", "Repository")] REPOSITORY,

        /// <summary>
        /// Use for a person who directed or managed a research project.
        /// </summary>
        [RelatorAttr("rth", "Research team head")]
        RESEARCH_TEAM_HEAD,

        /// <summary>
        /// Use for a person who participated in a research project but whose role did not involve direction or management of it.
        /// </summary>
        [RelatorAttr("rtm", "Research team member")]
        RESEARCH_TEAM_MEMBER,

        /// <summary>
        /// Use for a person or organization responsible for performing research.
        /// </summary>
        [RelatorAttr("res", "Researcher")] RESEARCHER,

        /// <summary>
        /// Use for the party who makes an answer to the courts pursuant to an application for redress, usually in an equity proceeding.
        /// </summary>
        [RelatorAttr("rsp", "Respondent")] RESPONDENT,

        /// <summary>
        /// Use for a respondent who takes an appeal from one court or jurisdiction to another to reverse the judgment, usually in an equity proceeding.
        /// </summary>
        [RelatorAttr("rst", "Respondent-appellant")]
        RESPONDENT_APPELLANT,

        /// <summary>
        /// Use for a respondent against whom an appeal is taken from one court or jurisdiction to another to reverse the judgment, usually in an equity proceeding.
        /// </summary>
        [RelatorAttr("rse", "Respondent-appellee")]
        RESPONDENT_APPELLEE,

        /// <summary>
        /// Use for a person or organization legally responsible for the content of the published material.
        /// </summary>
        [RelatorAttr("rpy", "Responsible party")]
        RESPONSIBLE_PARTY,

        /// <summary>
        /// Use for a person or organization, other than the original choreographer or director, responsible for restaging a choreographic or dramatic work and who contributes minimal new content.
        /// </summary>
        [RelatorAttr("rsg", "Restager")] RESTAGER,

        /// <summary>
        /// Use for a person or organization responsible for the review of a book, motion picture, performance, etc.
        /// </summary>
        [RelatorAttr("rev", "Reviewer")] REVIEWER,

        /// <summary>
        /// Use for a person or organization responsible for parts of a work, often headings or opening parts of a manuscript, that appear in a distinctive color, usually red.
        /// </summary>
        [RelatorAttr("rbr", "Rubricator")] RUBRICATOR,
        
        #endregion

        #region S

        /// <summary>
        /// Use for a person or organization who is the author of a motion picture screenplay.
        /// </summary>
        [RelatorAttr("sce", "Scenarist")] SCENARIST,

        /// <summary>
        /// Use for a person or organization who brings scientific, pedagogical, or historical competence to the conception and realization on a work, particularly in the case of audio-visual items.
        /// </summary>
        [RelatorAttr("sad", "Scientific advisor")]
        SCIENTIFIC_ADVISOR,

        /// <summary>
        /// Use for a person who is an amanuensis and for a writer of manuscripts proper. For a person who makes pen-facsimiles, use Facsimilist [fac].
        /// </summary>
        [RelatorAttr("scr", "Scribe")] SCRIBE,

        /// <summary>
        /// Use for a person or organization who models or carves figures that are three-dimensional representations.
        /// </summary>
        [RelatorAttr("scl", "Sculptor")] SCULPTOR,

        /// <summary>
        /// Use for a person or organization who is identified as the party of the second part. In the case of transfer of right, this is the assignee, transferee, licensee, grantee, etc. Multiple parties can be named jointly as the second party.
        /// </summary>
        [RelatorAttr("spy", "Second party")] SECOND_PARTY,

        /// <summary>
        /// Use for a person or organization who is a recorder, redactor, or other person responsible for expressing the views of a organization.
        /// </summary>
        [RelatorAttr("sec", "Secretary")] SECRETARY,

        /// <summary>
        /// Use for a person or organization who translates the rough sketches of the art director into actual architectural structures for a theatrical presentation, entertainment, motion picture, etc. Set designers draw the detailed guides and specifications for building the set.
        /// </summary>
        [RelatorAttr("std", "Set designer")] SET_DESIGNER,

        /// <summary>
        /// Use for a person whose signature appears without a presentation or other statement indicative of provenance. When there is a presentation statement, use Inscriber [ins].
        /// </summary>
        [RelatorAttr("sgn", "Signer")] SIGNER,

        /// <summary>
        /// Use for a person or organization who uses his/her/their voice with or without instrumental accompaniment to produce music. A performance may or may not include actual words.
        /// </summary>
        [RelatorAttr("sng", "Singer")] SINGER,

        /// <summary>
        /// Use for a person who produces and reproduces the sound score (both live and recorded), the installation of microphones, the setting of sound levels, and the coordination of sources of sound for a production.
        /// </summary>
        [RelatorAttr("sds", "Sound designer")] SOUND_DESIGNER,

        /// <summary>
        /// Use for a person who participates in a program (often broadcast) and makes a formalized contribution or presentation generally prepared in advance.
        /// </summary>
        [RelatorAttr("spk", "Speaker")] SPEAKER,

        /// <summary>
        /// Use for a person or organization that issued a contract or under the auspices of which a work has been written, printed, published, etc.
        /// </summary>
        [RelatorAttr("spn", "Sponsor")] SPONSOR,

        /// <summary>
        /// Use for a person who is in charge of everything that occurs on a performance stage, and who acts as chief of all crews and assistant to a director during rehearsals.
        /// </summary>
        [RelatorAttr("stm", "Stage manager")] STAGE_MANAGER,

        /// <summary>
        /// Use for an organization responsible for the development or enforcement of a standard.
        /// </summary>
        [RelatorAttr("stn", "Standards body")] STANDARDS_BODY,

        /// <summary>
        /// Use for a person or organization who creates a new plate for printing by molding or copying another printing surface.
        /// </summary>
        [RelatorAttr("str", "Stereotyper")] STEREOTYPER,

        /// <summary>
        /// Use for a person relaying a story with creative and/or theatrical interpretation.
        /// </summary>
        [RelatorAttr("stl", "Storyteller")] STORYTELLER,

        /// <summary>
        /// Use for a person or organization that supports (by allocating facilities, staff, or other resources) a project, program, meeting, event, data objects, material culture objects, or other entities capable of support.
        /// </summary>
        [RelatorAttr("sht", "Supporting host")]
        SUPPORTING_HOST,

        /// <summary>
        /// Use for a person or organization who does measurements of tracts of land, etc. to determine location, forms, and boundaries.
        /// </summary>
        [RelatorAttr("srv", "Surveyor")] SURVEYOR,
        
        #endregion

        #region T

        /// <summary>
        /// Use for a person who, in the context of a resource, gives instruction in an intellectual subject or demonstrates while teaching physical skills.
        /// </summary>
        [RelatorAttr("tch", "Teacher")] TEACHER,

        /// <summary>
        /// Use for a person who is ultimately in charge of scenery, props, lights and sound for a production.
        /// </summary>
        [RelatorAttr("tcd", "Technical director")]
        TECHNICAL_DIRECTOR,

        /// <summary>
        /// Use for a person under whose supervision a degree candidate develops and presents a thesis, mémoire, or text of a dissertation.
        /// </summary>
        [RelatorAttr("ths", "Thesis advisor")] THESIS_ADVISOR,

        /// <summary>
        /// Use for a person who prepares a handwritten or typewritten copy from original material, including from dictated or orally recorded material. For makers of pen-facsimiles, use Facsimilist [fac].
        /// </summary>
        [RelatorAttr("trc", "Transcriber")] TRANSCRIBER,

        /// <summary>
        /// Use for a person or organization who renders a text from one language into another, or from an older form of a language into the modern form.
        /// </summary>
        [RelatorAttr("trl", "Translator")] TRANSLATOR,

        /// <summary>
        /// Use for a person or organization who designed the type face used in a particular item.
        /// </summary>
        [RelatorAttr("tyd", "Type designer")] TYPE_DESIGNER,

        /// <summary>
        /// Use for a person or organization primarily responsible for choice and arrangement of type used in an item. If the typographer is also responsible for other aspects of the graphic design of a book (e.g., Book designer [bkd]), codes for both functions may be needed.
        /// </summary>
        [RelatorAttr("tyg", "Typographer")] TYPOGRAPHER,
        
        #endregion

        /// <summary>
        /// Use for the name of a place where a university that is associated with a resource is located, for example, a university where an academic dissertation or thesis was presented.
        /// </summary>
        [RelatorAttr("uvp", "University place")]
        UNIVERSITY_PLACE,

        /// <summary>
        /// Use for a person or organization in charge of a video production, e.g. the video recording of a stage production as opposed to a commercial motion picture. The videographer may be the camera operator or may supervise one or more camera operators. Do not confuse with cinematographer.
        /// </summary>
        [RelatorAttr("vdg", "Videographer")] VIDEOGRAPHER,

        /// <summary>
        /// Use for a person or organization who principally exhibits singing skills in a musical or dramatic presentation or entertainment.
        /// </summary>
        [RelatorAttr("voc", "Vocalist")] VOCALIST,

        /// <summary>
        /// Use for a person who verifies the truthfulness of an event or action.
        /// </summary>
        [RelatorAttr("wit", "Witness")] WITNESS,

        /// <summary>
        /// Use for a person or organization who makes prints by cutting the image in relief on the end-grain of a wood block.
        /// </summary>
        [RelatorAttr("wde", "Wood-engraver")] WOOD_ENGRAVER,

        /// <summary>
        /// Use for a person or organization who makes prints by cutting the image in relief on the plank side of a wood block.
        /// </summary>
        [RelatorAttr("wdc", "Woodcutter")] WOODCUTTER,

        /// <summary>
        /// Use for a person or organization who writes significant material which accompanies a sound recording or other audiovisual material.
        /// </summary>
        [RelatorAttr("wam", "Writer of accompanying material")]
        WRITER_OF_ACCOMPANYING_MATERIAL
    }

    [AttributeUsage(AttributeTargets.Field)]
    internal class RelatorAttr : Attribute
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        public RelatorAttr(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }

    internal static class RelatorExtensions
    {
        internal static string GetName(this Relator r)
        {
            var attr = r.GetAttribute<RelatorAttr>();
            return attr?.Name;
        }

        internal static string GetCode(this Relator r)
        {
            var attr = r.GetAttribute<RelatorAttr>();
            return attr?.Code;
        }

        internal static Relator ByCode(this Relator r, string code)
        {
            foreach (var relator in Enum.GetValues<Relator>())
            {
                if (relator.GetCode() == code)
                {
                    return relator;
                }
            }

            return r;
        }
    }
}