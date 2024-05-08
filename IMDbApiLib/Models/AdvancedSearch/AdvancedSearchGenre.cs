using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchGenre
    {
        [Display(Name = "Action")]
        [Description("action")]
        Action = 1,
        [Display(Name = "Adventure")]
        [Description("adventure")]
        Adventure = 2,
        [Display(Name = "Animation")]
        [Description("animation")]
        Animation = 4,
        [Display(Name = "Biography")]
        [Description("biography")]
        Biography = 8,
        [Display(Name = "Comedy")]
        [Description("comedy")]
        Comedy = 16,
        [Display(Name = "Crime")]
        [Description("crime")]
        Crime = 32,
        [Display(Name = "Documentary")]
        [Description("documentary")]
        Documentary = 64,
        [Display(Name = "Drama")]
        [Description("drama")]
        Drama = 128,
        [Display(Name = "Family")]
        [Description("family")]
        Family = 256,
        [Display(Name = "Fantasy")]
        [Description("fantasy")]
        Fantasy = 512,
        [Display(Name = "Film-Noir")]
        [Description("film-noir")]
        Film_Noir = 1024,
        [Display(Name = "Game-Show")]
        [Description("show")]
        Game_Show = 2048,
        [Display(Name = "History")]
        [Description("history")]
        History = 4096,
        [Display(Name = "Horror")]
        [Description("horror")]
        Horror = 8192,
        [Display(Name = "Music")]
        [Description("music")]
        Music = 16384,
        [Display(Name = "Musical")]
        [Description("musical")]
        Musical = 32768,
        [Display(Name = "Mystery")]
        [Description("mystery")]
        Mystery = 65536,
        [Display(Name = "News")]
        [Description("news")]
        News = 131072,
        [Display(Name = "Reality-TV")]
        [Description("reality-tv")]
        Reality_TV = 262144,
        [Display(Name = "Romance")]
        [Description("romance")]
        Romance = 524288,
        [Display(Name = "Sci-Fi")]
        [Description("sci-fi")]
        Sci_Fi = 1048576,
        [Display(Name = "Sport")]
        [Description("sport")]
        Sport = 2097152,
        [Display(Name = "Talk-Show")]
        [Description("talk-show")]
        Talk_Show = 4194304,
        [Display(Name = "Thriller")]
        [Description("thriller")]
        Thriller = 8388608,
        [Display(Name = "War")]
        [Description("war")]
        War = 16777216,
        [Display(Name = "Western")]
        [Description("wester")]
        Western = 33554432
    }
}