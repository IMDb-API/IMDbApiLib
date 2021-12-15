using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchSoundMix : long
    {
        [Display(Name = "Mono")]
        [Description("mono")]
        Mono = 1,
        [Display(Name = "Silent")]
        [Description("silent")]
        Silent = 2,
        [Display(Name = "Stereo")]
        [Description("stereo")]
        Stereo = 4,
        [Display(Name = "Dolby Digital")]
        [Description("dolby_digital")]
        Dolby_Digital = 8,
        [Display(Name = "Dolby")]
        [Description("dolby")]
        Dolby = 16,
        [Display(Name = "Dolby SR")]
        [Description("dolby_sr")]
        Dolby_SR = 32,
        [Display(Name = "DTS")]
        [Description("dts")]
        DTS = 64,
        [Display(Name = "SDDS")]
        [Description("sdds")]
        SDDS = 128,
        [Display(Name = "Ultra Stereo")]
        [Description("ultra_stereo")]
        Ultra_Stereo = 256,
        [Display(Name = "4 Track Stereo")]
        [Description("4_track_stereo")]
        Four4_Track_Stereo = 512,
        [Display(Name = "70 mm 6-Track")]
        [Description("70_mm_6_track")]
        Seventy70_mm_6_Track = 1024,
        [Display(Name = "Vitaphone")]
        [Description("vitaphone")]
        Vitaphone = 2048,
        [Display(Name = "Dolby Digital EX")]
        [Description("dolby_digital_ex")]
        Dolby_Digital_EX = 4096,
        [Display(Name = "De Forest Phonofilm")]
        [Description("de_forest_phonofilm")]
        De_Forest_Phonofilm = 8192,
        [Display(Name = "DTS Stereo")]
        [Description("dts_stereo")]
        DTS_Stereo = 16384,
        [Display(Name = "Chronophone")]
        [Description("chronophone")]
        Chronophone = 32768,
        [Display(Name = "6 track stereo")]
        [Description("6_track_stereo")]
        Six6_Track_Stereo = 65536,
        [Display(Name = "DTS-ES")]
        [Description("dts_es")]
        DTS_ES = 131072,
        [Display(Name = "Perspecta Stereo")]
        [Description("perspecta_stereo")]
        Perspecta_Stereo = 262144,
        [Display(Name = "Cinephone")]
        [Description("cinephone")]
        Cinephone = 524288,
        [Display(Name = "3 Channel Stereo")]
        [Description("3_channel_stereo")]
        Three3_Channel_stereo = 1048576,
        [Display(Name = "Cinematophone")]
        [Description("cinematophone")]
        Cinematophone = 2097152,
        [Display(Name = "Sonics_DDP")]
        [Description("sonics_ddp")]
        Sonics_DDP = 4194304,
        [Display(Name = "12 Track Digital Sound")]
        [Description("12_track_digital_sound")]
        Twelve12_Track_Digital_Sound = 8388608,
        [Display(Name = "DTS 70 mm")]
        [Description("dts_70_mm")]
        DTS_70_mm = 16777216,
        [Display(Name = "IMAX 6 Track")]
        [Description("imax_6_track")]
        IMAX_6_Track = 33554432,
        [Display(Name = "Matrix Surround")]
        [Description("matrix_surround")]
        Matrix_Surround = 67108864,
        [Display(Name = "Sonix")]
        [Description("sonix")]
        Sonix = 134217728,
        [Display(Name = "Sensurround")]
        [Description("sensurround")]
        Sensurround = 268435456,
        [Display(Name = "Cinerama 7-Track")]
        [Description("cinerama_7_track")]
        Cinerama_7_Track = 536870912,
        [Display(Name = "Kinoplasticon")]
        [Description("kinoplasticon")]
        Kinoplasticon = 1073741824,
        [Display(Name = "Digitrac Digital Audio System")]
        [Description("digitrac_digital_audio_system")]
        Digitrac_Digital_Audio_System = 2147483648,
        [Display(Name = "Cinesound")]
        [Description("cinesound")]
        Cinesound = 4294967296,
        [Display(Name = "Phono Kinema")]
        [Description("phono_kinema")]
        Phono_Kinema = 8589934592,
        [Display(Name = "CDS")]
        [Description("cds")]
        CDS = 17179869184,
        [Display(Name = "LC-Concept Digital Sound")]
        [Description("lc_concept_digital_sound")]
        LC_Concept_Digital_Sound = 34359738368
    }
}