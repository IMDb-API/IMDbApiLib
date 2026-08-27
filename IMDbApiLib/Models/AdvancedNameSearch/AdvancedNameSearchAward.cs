using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

[Flags]
public enum AdvancedNameSearchAward
{
    [Display(Name = "Best Actress-Nominated", Description = "oscar_best_actress_nominees")]
    BestActressNominated = 1,

    [Display(Name = "Best Actor-Nominated", Description = "oscar_best_actor_nominees")]
    BestActorNominated = 2,

    [Display(Name = "Best Actress-Winning", Description = "oscar_best_actress_winners")]
    BestActressWinning = 4,

    [Display(Name = "Best Actor-Winning", Description = "oscar_best_actor_winners")]
    BestActorWinning = 8,

    [Display(Name = "Best Supporting Actress-Nominated", Description = "oscar_best_supporting_actress_nominees")]
    BestSupportingActressNominated = 16,

    [Display(Name = "Best Supporting Actor-Nominated", Description = "oscar_best_supporting_actor_nominees")]
    BestSupportingActorNominated = 32,

    [Display(Name = "Best Supporting Actress-Winning", Description = "oscar_best_supporting_actress_winners")]
    BestSupportingActressWinning = 64,

    [Display(Name = "Best Supporting Actor-Winning", Description = "oscar_best_supporting_actor_winners")]
    BestSupportingActorWinning = 128,

    [Display(Name = "Best Director-Nominated", Description = "oscar_best_director_nominees")]
    BestDirectorNominated = 256,

    [Display(Name = "Best Director-Winning", Description = "oscar_best_director_winners")]
    BestDirectorWinning = 512,

    [Display(Name = "Oscar-Nominated", Description = "oscar_nominees")]
    OscarNominated = 1024,

    [Display(Name = "Emmy Award-Nominated", Description = "emmy_nominees")]
    EmmyAwardNominated = 2048,

    [Display(Name = "Golden Globe-Nominated", Description = "golden_globe_nominees")]
    GoldenGlobeNominated = 4096,

    [Display(Name = "Oscar-Winning", Description = "oscar_winners")]
    OscarWinning = 8192,

    [Display(Name = "Emmy Award-Winning", Description = "emmy_winners")]
    EmmyAwardWinning = 16384,

    [Display(Name = "Golden Globe-Winning", Description = "golden_globe_winners")]
    GoldenGlobeWinning = 32768,
}