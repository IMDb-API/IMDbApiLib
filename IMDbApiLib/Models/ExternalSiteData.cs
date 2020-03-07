using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class ExternalSiteData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public string OfficialWebsite { get; set; }

        public ExternalSiteItem IMDb { get; set; }
        public ExternalSiteItem TheMovieDb { get; set; }
        public ExternalSiteItem RottenTomatoes { get; set; }
        public ExternalSiteItem Metacritic { get; set; }
        public ExternalSiteItem Netflix { get; set; }
        public ExternalSiteItem GooglePlay { get; set; }
        public ExternalSiteItem FilmAffinity { get; set; }
        public ExternalSiteItem Freebase { get; set; }
        public ExternalSiteItem GND { get; set; }
        public ExternalSiteItem VIAF { get; set; }
        public ExternalSiteItem AlloCine { get; set; }
        public ExternalSiteItem AllMovie { get; set; }
        public ExternalSiteItem PORT { get; set; }
        public ExternalSiteItem DNF { get; set; }
        public ExternalSiteItem MovieMeter { get; set; }
        public ExternalSiteItem BoxOfficeMojo { get; set; }
        public ExternalSiteItem CSFD { get; set; }
        public ExternalSiteItem KINENOTE { get; set; }
        public ExternalSiteItem Allcinema { get; set; }
        public ExternalSiteItem Kinopoisk { get; set; }
        public ExternalSiteItem Elonet { get; set; }
        public ExternalSiteItem LdiF { get; set; }
        public ExternalSiteItem Cineplex { get; set; }
        public ExternalSiteItem EDb { get; set; }
        public ExternalSiteItem elCinema { get; set; }
        public ExternalSiteItem Scope_dk { get; set; }
        public ExternalSiteItem SwedishFilmDatabaseFilm { get; set; }
        public ExternalSiteItem elFilm { get; set; }
        public ExternalSiteItem OFDb { get; set; }
        public ExternalSiteItem OpenMediaDatabase { get; set; }
        public ExternalSiteItem QuoraTopic { get; set; }
        public ExternalSiteItem Cinema_de { get; set; }
        public ExternalSiteItem DeutscheSynchronkartei { get; set; }
        public ExternalSiteItem MovieWalker { get; set; }
        public ExternalSiteItem TVGuide { get; set; }
        public ExternalSiteItem Filmweb_pl { get; set; }
        public ExternalSiteItem TV_com { get; set; }
        public ExternalSiteItem ISAN { get; set; }
        public ExternalSiteItem EIDR { get; set; }
        public ExternalSiteItem AFICatalogOfFeature { get; set; }
        public ExternalSiteItem TheNumbers { get; set; }
        public ExternalSiteItem TCMMovieDatabase { get; set; }
        public ExternalSiteItem Cine_gr { get; set; }
        public ExternalSiteItem BFINationalArchive { get; set; }
        public ExternalSiteItem ExploitationVisa { get; set; }
        public ExternalSiteItem Sratim { get; set; }
        public ExternalSiteItem CineRessources { get; set; }
        public ExternalSiteItem CinemathequeQuebecoise { get; set; }
        public ExternalSiteItem EncyclopaediaBritannicaOnline { get; set; }
        public ExternalSiteItem BechdelTestMovieList { get; set; }
        public ExternalSiteItem Movieplayer_it { get; set; }
        public ExternalSiteItem MYmovies { get; set; }
        public ExternalSiteItem Cinematografo { get; set; }
        public ExternalSiteItem LUMIERE { get; set; }
        public ExternalSiteItem BFI { get; set; }
        public ExternalSiteItem Prisma { get; set; }
        public ExternalSiteItem CineMagia { get; set; }
        public ExternalSiteItem Daum { get; set; }
        public ExternalSiteItem Douban { get; set; }
        public ExternalSiteItem MuseumOfModernArt { get; set; }
        public ExternalSiteItem IlMondoDeiDoppiatori { get; set; }
        public ExternalSiteItem Fandango { get; set; }
        public ExternalSiteItem Moviepilot_de { get; set; }
        public ExternalSiteItem SUDOCAuthorities { get; set; }
        public ExternalSiteItem BibliothequeNationaleDeFrance { get; set; }
        public ExternalSiteItem Siamzone { get; set; }
        public ExternalSiteItem AcademyAwardsDatabase { get; set; }
        public ExternalSiteItem KnowYourMeme { get; set; }
        public ExternalSiteItem TheEncyclopediaOfScienceFiction { get; set; }
        public ExternalSiteItem Letterboxd { get; set; }
        public ExternalSiteItem ComicVine { get; set; }

        // TV
        public ExternalSiteItem TheTVDB { get; set; }
        public ExternalSiteItem TVSpielfilmSeries { get; set; }

        // Wikipedia LanguageUrls
        public List<LanguageUrl> WikipediaUrls { set; get; }

        public string ErrorMessage { get; set; }
    }

    public class ExternalSiteItem
    {
        public string Id { get; set; }

        public string Url { get; set; }
    }

    public class LanguageUrl
    {
        public LanguageUrl(string language, string title, string url)
        {
            Language = language;
            Title = title;
            Url = url;
        }

        public string Language { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
