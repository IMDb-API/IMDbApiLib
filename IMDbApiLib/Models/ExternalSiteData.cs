namespace IMDbApiLib.Models;

public class ExternalSiteData : ApiBaseModel
{
    public ExternalSiteData()
    {
    }

    public ExternalSiteData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public ExternalSiteData(string? id, string errorMessage)
    {
        IMDbId = id ?? string.Empty;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string OfficialWebsite { get; set; } = string.Empty;
    public ExternalSiteDataItem? IMDb { get; set; }
    public ExternalSiteDataItem? TheMovieDb { get; set; }
    public ExternalSiteDataItem? RottenTomatoes { get; set; }
    public ExternalSiteDataItem? Metacritic { get; set; }
    public ExternalSiteDataItem? Netflix { get; set; }
    public ExternalSiteDataItem? GooglePlay { get; set; }
    public ExternalSiteDataItem? FilmAffinity { get; set; }
    public ExternalSiteDataItem? Freebase { get; set; }
    public ExternalSiteDataItem? GND { get; set; }
    public ExternalSiteDataItem? VIAF { get; set; }
    public ExternalSiteDataItem? AlloCine { get; set; }
    public ExternalSiteDataItem? AllMovie { get; set; }
    public ExternalSiteDataItem? PORT { get; set; }
    public ExternalSiteDataItem? DNF { get; set; }
    public ExternalSiteDataItem? MovieMeter { get; set; }
    public ExternalSiteDataItem? BoxOfficeMojo { get; set; }
    public ExternalSiteDataItem? CSFD { get; set; }
    public ExternalSiteDataItem? KINENOTE { get; set; }
    public ExternalSiteDataItem? Allcinema { get; set; }
    public ExternalSiteDataItem? Kinopoisk { get; set; }
    public ExternalSiteDataItem? Elonet { get; set; }
    public ExternalSiteDataItem? LdiF { get; set; }
    public ExternalSiteDataItem? Cineplex { get; set; }
    public ExternalSiteDataItem? EDb { get; set; }
    public ExternalSiteDataItem? ElCinema { get; set; }
    public ExternalSiteDataItem? Scope_dk { get; set; }
    public ExternalSiteDataItem? SwedishFilmDatabaseFilm { get; set; }
    public ExternalSiteDataItem? ElFilm { get; set; }
    public ExternalSiteDataItem? OFDb { get; set; }
    public ExternalSiteDataItem? OpenMediaDatabase { get; set; }
    public ExternalSiteDataItem? QuoraTopic { get; set; }
    public ExternalSiteDataItem? Cinema_de { get; set; }
    public ExternalSiteDataItem? DeutscheSynchronkartei { get; set; }
    public ExternalSiteDataItem? MovieWalker { get; set; }
    public ExternalSiteDataItem? TVGuide { get; set; }
    public ExternalSiteDataItem? Filmweb_pl { get; set; }
    public ExternalSiteDataItem? ISAN { get; set; }
    public ExternalSiteDataItem? EIDR { get; set; }
    public ExternalSiteDataItem? AFICatalogOfFeature { get; set; }
    public ExternalSiteDataItem? TheNumbers { get; set; }
    public ExternalSiteDataItem? TCMMovieDatabase { get; set; }
    public ExternalSiteDataItem? Cine_gr { get; set; }
    public ExternalSiteDataItem? BFINationalArchive { get; set; }
    public ExternalSiteDataItem? ExploitationVisa { get; set; }
    public ExternalSiteDataItem? Sratim { get; set; }
    public ExternalSiteDataItem? CineRessources { get; set; }
    public ExternalSiteDataItem? CinemathequeQuebecoise { get; set; }
    public ExternalSiteDataItem? EncyclopaediaBritannicaOnline { get; set; }
    public ExternalSiteDataItem? BechdelTestMovieList { get; set; }
    public ExternalSiteDataItem? Movieplayer_it { get; set; }
    public ExternalSiteDataItem? MYmovies { get; set; }
    public ExternalSiteDataItem? Cinematografo { get; set; }
    public ExternalSiteDataItem? LUMIERE { get; set; }
    public ExternalSiteDataItem? BFI { get; set; }
    public ExternalSiteDataItem? Prisma { get; set; }
    public ExternalSiteDataItem? CineMagia { get; set; }
    public ExternalSiteDataItem? Daum { get; set; }
    public ExternalSiteDataItem? Douban { get; set; }
    public ExternalSiteDataItem? MuseumOfModernArt { get; set; }
    public ExternalSiteDataItem? IlMondoDeiDoppiatori { get; set; }
    public ExternalSiteDataItem? Fandango { get; set; }
    public ExternalSiteDataItem? Moviepilot_de { get; set; }
    public ExternalSiteDataItem? SUDOCAuthorities { get; set; }
    public ExternalSiteDataItem? BibliothequeNationaleDeFrance { get; set; }
    public ExternalSiteDataItem? Siamzone { get; set; }
    public ExternalSiteDataItem? AcademyAwardsDatabase { get; set; }
    public ExternalSiteDataItem? KnowYourMeme { get; set; }
    public ExternalSiteDataItem? TheEncyclopediaOfScienceFiction { get; set; }
    public ExternalSiteDataItem? Letterboxd { get; set; }
    public ExternalSiteDataItem? ComicVine { get; set; }
    public ExternalSiteDataItem? TheTVDB { get; set; }
    public ExternalSiteDataItem? TVSpielfilmSeries { get; set; }
    public List<LanguageUrl> WikipediaUrls { get; set; } = [];
}

public class ExternalSiteDataItem
{
    public string Id { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

public class LanguageUrl(string language, string title, string url)
{
    public string Language { get; set; } = language;
    public string Title { get; set; } = title;
    public string Url { get; set; } = url;
}