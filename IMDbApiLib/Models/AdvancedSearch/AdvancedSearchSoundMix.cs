using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchSoundMix : long
{
    [Display(Name = "12-Track Digital Sound", Description = "12_track_digital_sound")]
    TwelveTrackDigitalSound = 1,

    [Display(Name = "3 Channel Stereo", Description = "3_channel_stereo")]
    ThreeChannelStereo = 2,

    [Display(Name = "4-Track Stereo", Description = "4_track_stereo")]
    FourTrackStereo = 4,

    [Display(Name = "6-Track Stereo", Description = "6_track_stereo")]
    SixTrackStereo = 8,

    [Display(Name = "70 mm 6-Track", Description = "70_mm_6_track")]
    SeventyMm6Track = 16,

    [Display(Name = "AGA Sound System", Description = "aga_sound_system")]
    AGASoundSystem = 32,

    [Display(Name = "Auro 11.1", Description = "auro_11.1")]
    Auro111 = 64,

    [Display(Name = "CDS", Description = "cds")]
    CDS = 128,

    [Display(Name = "Chronophone", Description = "chronophone")]
    Chronophone = 256,

    [Display(Name = "Cinematophone", Description = "cinematophone")]
    Cinematophone = 512,

    [Display(Name = "Cinephone", Description = "cinephone")]
    Cinephone = 1024,

    [Display(Name = "Cinerama 7-Track", Description = "cinerama_7_track")]
    Cinerama7Track = 2048,

    [Display(Name = "Cinesound", Description = "cinesound")]
    Cinesound = 4096,

    [Display(Name = "D-Cinema 48kHz 5.1", Description = "d_cinema_48khz_5.1")]
    DCinema48kHz51 = 8192,

    [Display(Name = "Datasat", Description = "datasat")]
    Datasat = 16384,

    [Display(Name = "De Forest Phonofilm", Description = "de_forest_phonofilm")]
    DeForestPhonofilm = 32768,

    [Display(Name = "Digitrac Digital Audio System", Description = "digitrac_digital_audio_system")]
    DigitracDigitalAudioSystem = 65536,

    [Display(Name = "Dolby", Description = "dolby")]
    Dolby = 131072,

    [Display(Name = "Dolby Atmos", Description = "dolby_atmos")]
    DolbyAtmos = 262144,

    [Display(Name = "Dolby Digital", Description = "dolby_digital")]
    DolbyDigital = 524288,

    [Display(Name = "Dolby Digital EX", Description = "dolby_digital_ex")]
    DolbyDigitalEX = 1048576,

    [Display(Name = "Dolby SR", Description = "dolby_sr")]
    DolbySR = 2097152,

    [Display(Name = "Dolby Stereo", Description = "dolby_stereo")]
    DolbyStereo = 4194304,

    [Display(Name = "Dolby Surround 7.1", Description = "dolby_surround_7.1")]
    DolbySurround71 = 8388608,

    [Display(Name = "DTS", Description = "dts")]
    DTS = 16777216,

    [Display(Name = "DTS 70 mm", Description = "dts_70_mm")]
    DTS70mm = 33554432,

    [Display(Name = "DTS Stereo", Description = "dts_stereo")]
    DTSStereo = 67108864,

    [Display(Name = "DTS-ES", Description = "dts_es")]
    DTSES = 134217728,

    [Display(Name = "IMAX 6-Track", Description = "imax_6_track")]
    IMAX6Track = 268435456,

    [Display(Name = "Kinoplasticon", Description = "kinoplasticon")]
    Kinoplasticon = 536870912,

    [Display(Name = "LC-Concept Digital Sound", Description = "lc_concept_digital_sound")]
    LCConceptDigitalSound = 1073741824,

    [Display(Name = "Matrix Surround", Description = "matrix_surround")]
    MatrixSurround = 2147483648,

    [Display(Name = "Mono", Description = "mono")]
    Mono = 4294967296,

    [Display(Name = "Perspecta Stereo", Description = "perspecta_stereo")]
    PerspectaStereo = 8589934592,

    [Display(Name = "Phono-Kinema", Description = "phono_kinema")]
    PhonoKinema = 17179869184,

    [Display(Name = "SDDS", Description = "sdds")]
    SDDS = 34359738368,

    [Display(Name = "Sensurround", Description = "sensurround")]
    Sensurround = 68719476736,

    [Display(Name = "Silent", Description = "silent")]
    Silent = 137438953472,

    [Display(Name = "Sonics-DDP", Description = "sonics_ddp")]
    SonicsDDP = 274877906944,

    [Display(Name = "Sonix", Description = "sonix")]
    Sonix = 549755813888,

    [Display(Name = "Stereo", Description = "stereo")]
    Stereo = 1099511627776,

    [Display(Name = "Ultra Stereo", Description = "ultra_stereo")]
    UltraStereo = 2199023255552,

    [Display(Name = "Vitaphone", Description = "vitaphone")]
    Vitaphone = 4398046511104,
}