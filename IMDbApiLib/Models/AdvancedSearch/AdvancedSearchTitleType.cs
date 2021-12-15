using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchTitleType
    {
        [Display(Name = "Feature Film")]
        [Description("feature")]
        Feature_Film = 1,
        [Display(Name = "TV Movie")]
        [Description("tv_movie")]
        TV_Movie = 2,
        [Display(Name = "TV Series")]
        [Description("tv_series")]
        TV_Series = 4,
        [Display(Name = "TV Episode")]
        [Description("tv_episode")]
        TV_Episode = 8,
        [Display(Name = "TV Special")]
        [Description("tv_special")]
        TV_Special = 16,
        [Display(Name = "Mini-Series")]
        [Description("tv_miniseries")]
        Mini_Series = 32,
        [Display(Name = "Documentary")]
        [Description("documentary")]
        Documentary = 64,
        [Display(Name = "Video Game")]
        [Description("video_game")]
        Video_Game = 128,
        [Display(Name = "Short")]
        [Description("short")]
        Short = 256,
        [Display(Name = "Video")]
        [Description("video")]
        Video = 512,
        [Display(Name = "TV Short")]
        [Description("tv_short")]
        TV_Short = 1024,
        [Display(Name = "Podcast Series")]
        [Description("podcast_series")]
        Podcast_Series = 2048,
        [Display(Name = "Podcast Episode")]
        [Description("podcast_episode")]
        Podcast_Episode = 4096,
        [Display(Name = "Music Video")]
        [Description("music_video")]
        Music_Video = 8132
    }
}