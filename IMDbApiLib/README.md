# IMDbApiLib
The TV-API is a web service for receiving movie, serial and cast informations. APIs results is a JSON and includes items such as movie specifications, images, posters, trailers, ratings, Wikipedia page content and more. [see more »](https://tv-api.com)

## Nuget
Install from Nuget using the command: **Install-Package IMDbApiLib** View more about that here:  https://nuget.org/packages/IMDbApiLib

## API Documentation
[https://tv-api.com/api](https://tv-api.com/api)

## Usage
Usage Examples
```csharp
var apiLib = new ApiLib("API-Key");

// Search
var data = await apiLib.SearchMovieAsync("leon the professional 1994");

// Title Data
var data = await apiLib.TitleAsync("tt0110413");

// Title Data (French Language)
var data = await apiLib.TitleAsync("tt0110413", Language.fr);

// Title Data - Get Full Data
var data = await apiLib.TitleAsync("tt0110413", Language.en, "FullActor,FullCast,Posters,Images,Trailer,Ratings,Wikipedia");

// Report - As PNG File
var data = await apiLib.ReportAsync("tt0110413", Language.en);

// Images (From IMDb)
var data = await apiLib.ImagesAsync("tt0110413");

// Posters (From TheMovieDb)
var data = await apiLib.PostersAsync("tt0110413");

// Trailer
var data = await apiLib.TrailerAsync("tt0110413");

// ExternalSites (Get Movie or Series TV in all external sites with Identifier and URL)
var data = await apiLib.ExternalSitesAsync("tt0110413");

// Ratings (Get ratings of Movie or Series TV in: IMDb, Metacritic, RottenTommatoes, TheMovieDb and TV.com)
var data = await apiLib.RatingsAsync("tt0110413");

// Wikipedia (PlainText and Html)
var data = await apiLib.WikipediaAsync("tt0110413", , IMDbApiLib.Models.Language.en);

// AdvancedSearch
var input = new AdvancedSearchInput();
input.Genres = AdvancedSearchGenre.Action | AdvancedSearchGenre.Adventure;
input.Sort = AdvancedSearchSort.User_Rating_Descending;
input.ReleaseDateFrom = "2010-01-01";
input.NumberOfVotesFrom = 5000;

input.Languages = AdvancedSearchLanguage.English | AdvancedSearchLanguage.French;
// OR - Multiple languages
//input.LanguagesStr = $"{AdvancedSearchLanguage.English.GetDescription()},{AdvancedSearchLanguage.French.GetDescription()}";

input.Countries = AdvancedSearchCountry.United_States;
// OR - Multiple countries
//input.CountriesStr = $"{AdvancedSearchCountry.United_States},{AdvancedSearchCountry.France},{AdvancedSearchCountry.United_Kingdom}";

string queryString = input.ToString();
var advancedSearchdata = await apiLib.AdvancedSearchAsync(input);
```

----
## List of all APIs
### Search APIs
* **Search** (expression)
* **SearchTitle** (expression)
* **SearchMovie** (expression)
* **SearchSeries** (expression)
* **SearchName** (expression)
* **SearchEpisode** (expression)
* **SearchCompany** (expression)
* **SearchKeyword** (expression)
* **AdvancedSearch** (params)

### Title APIs
* **Title** (id, options?)
* **Report** (id, options?)
* **FullCast** (id)
* **Posters** (id)
* **Images** (id, options?)
* **Trailer** (id)
* **Ratings** (id)
* **UserRatings** (id)
* **SeasonEpisodes** (id, seasonNumber)
* **ExternalSites** (id)
* **Wikipedia** (id)
* **Reviews** (id)
* **MetacriticReviews** (id)
* **FAQ** (id)
* **Awards** (id)

### Other APIs
* **Top250Movies** ()
* **Top250TVs** ()
* **MostPopularMovies** ()
* **MostPopularTVs** ()
* **InTheaters** ()
* **ComingSoon** ()
* **BoxOffice** ()
* **BoxOfficeAllTime** ()
* **Name** (nmId)
* **NameAwards** (nmId)
* **Company** (coId)
* **Keyword** (kwId)
* **YouTubeTrailer** (id)

### Tools APIs
* **Usage** ()
* **ResizeImage** (WxH, url)
* **ResizePoster** (WxH, url)