# IMDbApiLib

`IMDbApiLib` is the official .NET client for [TV-API](https://tv-api.com), a movie and TV data service.

It provides strongly typed access to title details, cast and crew, images, posters, trailers, ratings, reviews, Wikipedia content, charts, search, people, companies, and more.

> `IMDbApiLib` is the package name. TV-API is the service that provides the data.

## Requirements

- .NET Standard 2.0 or later
- A TV-API key

## Installation

### .NET CLI

```bash
dotnet add package IMDbApiLib --version 3.0.0
```

### Package Manager Console

```powershell
Install-Package IMDbApiLib -Version 3.0.0
```

### PackageReference

```xml
<PackageReference Include="IMDbApiLib" Version="3.0.0" />
```

## Documentation

- [TV-API documentation](https://tv-api.com/docs)
- [TV-API website](https://tv-api.com)

## Quick start

```csharp
using IMDbApiLib;
using IMDbApiLib.Models;

using var api = new ApiLib("YOUR_API_KEY");

var title = await api.TitleAsync("tt0110413");

if (title?.Success == true)
{
    Console.WriteLine(title.Title);
}
else
{
    Console.WriteLine(title?.ErrorMessage);
}
```

## Authentication

Keep your API key outside source code. For ASP.NET Core applications, use User Secrets, environment variables, or a secure configuration provider.

```csharp
using var api = new ApiLib(apiKey);
```

## Language

All methods that support language default to English.

```csharp
var title = await api.TitleAsync("tt0110413", Language.FR);
```

## Title data

```csharp
var title = await api.TitleAsync("tt0110413");

var titleWithOptions = await api.TitleAsync(
    "tt0110413",
    Language.EN,
    options: "FullActor,FullCast,Wikipedia,Posters,Images,Trailer,Ratings");

var titleWithFlags = await api.TitleAsync(
    "tt0110413",
    Language.EN,
    FullActor: true,
    FullCast: true,
    Wikipedia: true,
    Posters: true,
    Images: true,
    Trailer: true,
    Ratings: true);

var report = await api.ReportAsync("tt0110413", Language.EN, "FullActor,FullCast,Posters,Images,Trailer,Wikipedia");
var cast = await api.FullCastAsync("tt0110413");
var images = await api.ImagesAsync("tt0110413");
var posters = await api.PostersAsync("tt0110413");
var trailer = await api.TrailerAsync("tt0110413");
var ratings = await api.RatingsAsync("tt0110413");
var userRatings = await api.UserRatingsAsync("tt0110413");
var externalSites = await api.ExternalSitesAsync("tt0110413");
var wikipedia = await api.WikipediaAsync("tt0110413", Language.EN);
var reviews = await api.ReviewsAsync("tt0110413");
var metacriticReviews = await api.MetacriticReviewsAsync("tt0110413");
var quotes = await api.QuotesAsync("tt0110413");
var goofs = await api.GoofsAsync("tt0110413");
var faq = await api.FAQAsync("tt0110413");
var awards = await api.AwardsAsync("tt0110413");
var episodes = await api.SeasonEpisodesAsync("tt0944947", 1);
```

## Search

```csharp
var movies = await api.SearchMovieAsync("leon the professional");
var series = await api.SearchTVSeriesAsync("breaking bad");
var episodes = await api.SearchTVEpisodeAsync("the last of us");
var titles = await api.SearchTitleAsync("inception");
var names = await api.SearchNameAsync("leonardo dicaprio");
var companies = await api.SearchCompanyAsync("warner bros");
var keywords = await api.SearchKeywordAsync("time travel");
var all = await api.SearchAllAsync("matrix");
```

## Advanced search

```csharp
using IMDbApiLib.Models;

var input = new AdvancedSearchInput
{
    Genres = AdvancedSearchGenre.Action | AdvancedSearchGenre.Adventure,
    UserRatingFrom = 7,
    NumberOfVotesFrom = 5000,
    ReleaseDateFrom = "2010-01-01",
    Languages = AdvancedSearchLanguage.English | AdvancedSearchLanguage.French,
    Countries = AdvancedSearchCountry.United_States
};

var results = await api.AdvancedSearchAsync(input);
```

For multiple country or language values as text:

```csharp
input.CountriesStr = "US,FR,GB";
input.LanguagesStr = "en,fr";
```

## Charts and upcoming releases

```csharp
var topMovies = await api.Top250MoviesAsync();
var topTVs = await api.Top250TVsAsync();
var popularMovies = await api.MostPopularMoviesAsync();
var popularTVs = await api.MostPopularTVsAsync();
var inTheaters = await api.InTheatersAsync();
var upcomingMovies = await api.UpcomingMoviesAsync();
var upcomingSeries = await api.UpcomingTVSeriesAsync();
var upcomingEpisodes = await api.UpcomingTVEpisodesAsync();
var weekendBoxOffice = await api.BoxOfficeAsync();
var allTimeBoxOffice = await api.BoxOfficeAllTimeAsync();
var releases = await api.ReleasesAsync("tt1375666");
```

## Names, companies, lists, and tools

```csharp
var name = await api.NameAsync("nm0000138");
var nameAwards = await api.NameAwardsAsync("nm0000138");
var company = await api.CompanyAsync("co0002663");
var keyword = await api.KeywordAsync("time-travel");
var imdbList = await api.IMDbListAsync("ls000000000");
var countries = await api.CountriesAsync("US");
var ip = await api.IPsAsync("8.8.8.8");
var usage = await api.UsageAsync();
```

## Image resizing and downloads

```csharp
byte[]? image = await api.ResizeImageAsync("300x450", imageUrl);
byte[]? poster = await api.ResizePosterAsync("300x450", posterUrl);

await api.ResizeImageSaveFileAsync("300x450", imageUrl, "image.jpg");
await api.ResizePosterSaveFileAsync("300x450", posterUrl, "poster.jpg");

string resizeUrl = api.ResizeImageUrl("300x450", imageUrl);
```

## Proxy support

```csharp
using var api = new ApiLib(
    apiKey: "YOUR_API_KEY",
    proxyAddress: "http://127.0.0.1:8080",
    proxyUsername: "username",
    proxyPassword: "password");
```

## Error handling

API result models inherit a common error contract. Check `Success` and `ErrorMessage` before using the returned data.

```csharp
var result = await api.TitleAsync("tt0110413");

if (result?.Success != true)
{
    Console.WriteLine(result?.ErrorMessage);
    return;
}
```

## License

MIT