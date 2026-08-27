using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchAward
{
    [Display(Name = "Oscar-Winner", Description = "oscar_winner")]
    OscarWinner = 1,

    [Display(Name = "Emmy-Winner", Description = "emmy_winner")]
    EmmyWinner = 2,

    [Display(Name = "Golden Globe-Winner", Description = "golden_globe_winner")]
    GoldenGlobeWinner = 4,

    [Display(Name = "Oscar-Nominee", Description = "oscar_nominee")]
    OscarNominee = 8,

    [Display(Name = "Emmy-Nominee", Description = "emmy_nominee")]
    EmmyNominee = 16,

    [Display(Name = "Golden Globe-Nominee", Description = "golden_globe_nominee")]
    GoldenGlobeNominee = 32,

    [Display(Name = "Best Picture-Winner", Description = "best_picture_winner")]
    BestPictureWinner = 64,

    [Display(Name = "Oscar Best Picture-Nominees", Description = "oscar_best_picture_nominees")]
    OscarBestPictureNominees = 128,

    [Display(Name = "Best Director-Winner", Description = "best_director_winner")]
    BestDirectorWinner = 256,

    [Display(Name = "Oscar Best Director-Nominees", Description = "oscar_best_director_nominees")]
    OscarBestDirectorNominees = 512,

    [Display(Name = "National Film Preservation Board-Winner", Description = "national_film_preservation_board_winner")]
    NationalFilmPreservationBoardWinner = 1024,

    [Display(Name = "Razzie-Winner", Description = "razzie_winner")]
    RazzieWinner = 2048,

    [Display(Name = "Razzie-Nominee", Description = "razzie_nominee")]
    RazzieNominee = 4096,

    [Display(Name = "IMDb Top 100 Movies", Description = "top_100")]
    Top100 = 8192,

    [Display(Name = "IMDb Top 250 Movies", Description = "top_250")]
    Top250 = 16384,

    [Display(Name = "IMDb Top 1000 Movies", Description = "top_1000")]
    Top1000 = 32768,

    [Display(Name = "IMDb Bottom 100 Movies", Description = "bottom_100")]
    Bottom100 = 65536,

    [Display(Name = "IMDb Bottom 250 Movies", Description = "bottom_250")]
    Bottom250 = 131072,

    [Display(Name = "IMDb Bottom 1000 Movies", Description = "bottom_1000")]
    Bottom1000 = 262144,
}