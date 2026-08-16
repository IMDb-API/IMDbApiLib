using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchTitleType
{
    [Display(Name = "Movie", Description = "feature")]
    Movie = 1,

    [Display(Name = "TV Series", Description = "tv_series")]
    TVSeries = 2,

    [Display(Name = "Short", Description = "short")]
    Short = 4,

    [Display(Name = "TV Episode", Description = "tv_episode")]
    TVEpisode = 8,

    [Display(Name = "TV Mini Series", Description = "tv_miniseries")]
    TVMiniSeries = 16,

    [Display(Name = "TV Movie", Description = "tv_movie")]
    TVMovie = 32,

    [Display(Name = "TV Special", Description = "tv_special")]
    TVSpecial = 64,

    [Display(Name = "TV Short", Description = "tv_short")]
    TVShort = 128,

    [Display(Name = "Video Game", Description = "video_game")]
    VideoGame = 256,

    [Display(Name = "Video", Description = "video")]
    Video = 512,

    [Display(Name = "Music Video", Description = "music_video")]
    MusicVideo = 1024,

    [Display(Name = "Podcast Series", Description = "podcast_series")]
    PodcastSeries = 2048,

    [Display(Name = "Podcast Episode", Description = "podcast_episode")]
    PodcastEpisode = 4096,
}