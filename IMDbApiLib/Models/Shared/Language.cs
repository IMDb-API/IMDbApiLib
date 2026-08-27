using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum Language
{
    [Display(Name = "English", Description = "EN (English)")]
    EN,

    [Display(Name = "Afrikaans", Description = "AF (Afrikaans)")]
    AF,

    [Display(Name = "Albanian", Description = "SQ (Albanian)")]
    SQ,

    [Display(Name = "Amharic", Description = "AM (Amharic)")]
    AM,

    [Display(Name = "Arabic", Description = "AR (Arabic)")]
    AR,

    [Display(Name = "Armenian", Description = "HY (Armenian)")]
    HY,

    [Display(Name = "Azerbaijani", Description = "AZ (Azerbaijani)")]
    AZ,

    [Display(Name = "Basque", Description = "EU (Basque)")]
    EU,

    [Display(Name = "Belarusian", Description = "BE (Belarusian)")]
    BE,

    [Display(Name = "Bengali", Description = "BN (Bengali)")]
    BN,

    [Display(Name = "Bosnian", Description = "BS (Bosnian)")]
    BS,

    [Display(Name = "Bulgarian", Description = "BG (Bulgarian)")]
    BG,

    [Display(Name = "Catalan", Description = "CA (Catalan)")]
    CA,

    [Display(Name = "Cebuano", Description = "CEB (Cebuano)")]
    CEB,

    [Display(Name = "Chichewa", Description = "NY (Chichewa)")]
    NY,

    [Display(Name = "Chinese", Description = "ZH (Chinese)")]
    ZH,

    [Display(Name = "Corsican", Description = "CO (Corsican)")]
    CO,

    [Display(Name = "Croatian", Description = "HR (Croatian)")]
    HR,

    [Display(Name = "Czech", Description = "CS (Czech)")]
    CS,

    [Display(Name = "Danish", Description = "DA (Danish)")]
    DA,

    [Display(Name = "Dutch", Description = "NL (Dutch)")]
    NL,

    [Display(Name = "Esperanto", Description = "EO (Esperanto)")]
    EO,

    [Display(Name = "Estonian", Description = "ET (Estonian)")]
    ET,

    [Display(Name = "Filipino", Description = "TL (Filipino)")]
    TL,

    [Display(Name = "Finnish", Description = "FI (Finnish)")]
    FI,

    [Display(Name = "French", Description = "FR (French)")]
    FR,

    [Display(Name = "Frisian", Description = "FY (Frisian)")]
    FY,

    [Display(Name = "Galician", Description = "GL (Galician)")]
    GL,

    [Display(Name = "Georgian", Description = "KA (Georgian)")]
    KA,

    [Display(Name = "German", Description = "DE (German)")]
    DE,

    [Display(Name = "Greek", Description = "EL (Greek)")]
    EL,

    [Display(Name = "Gujarati", Description = "GU (Gujarati)")]
    GU,

    [Display(Name = "Haitian Creole", Description = "HT (Haitian Creole)")]
    HT,

    [Display(Name = "Hausa", Description = "HA (Hausa)")]
    HA,

    [Display(Name = "Hawaiian", Description = "HAW (Hawaiian)")]
    HAW,

    [Display(Name = "Hebrew", Description = "IW (Hebrew)")]
    IW,

    [Display(Name = "Hindi", Description = "HI (Hindi)")]
    HI,

    [Display(Name = "Hmong", Description = "HMN (Hmong)")]
    HMN,

    [Display(Name = "Hungarian", Description = "HU (Hungarian)")]
    HU,

    [Display(Name = "Icelandic", Description = "IS (Icelandic)")]
    IS,

    [Display(Name = "Igbo", Description = "IG (Igbo)")]
    IG,

    [Display(Name = "Indonesian", Description = "ID (Indonesian)")]
    ID_iso,

    [Display(Name = "Irish", Description = "GA (Irish)")]
    GA,

    [Display(Name = "Italian", Description = "IT (Italian)")]
    IT,

    [Display(Name = "Japanese", Description = "JA (Japanese)")]
    JA,

    [Display(Name = "Javanese", Description = "JW (Javanese)")]
    JW,

    [Display(Name = "Kannada", Description = "KN (Kannada)")]
    KN,

    [Display(Name = "Kazakh", Description = "KK (Kazakh)")]
    KK,

    [Display(Name = "Khmer", Description = "KM (Khmer)")]
    KM,

    [Display(Name = "Kinyarwanda", Description = "RW (Kinyarwanda)")]
    RW,

    [Display(Name = "Korean", Description = "KO (Korean)")]
    KO,

    [Display(Name = "Kurdish", Description = "KU (Kurdish)")]
    KU,

    [Display(Name = "Kyrgyz", Description = "KY (Kyrgyz)")]
    KY,

    [Display(Name = "Lao", Description = "LO (Lao)")]
    LO,

    [Display(Name = "Latin", Description = "LA (Latin)")]
    LA,

    [Display(Name = "Latvian", Description = "LV (Latvian)")]
    LV,

    [Display(Name = "Lithuanian", Description = "LT (Lithuanian)")]
    LT,

    [Display(Name = "Luxembourgish", Description = "LB (Luxembourgish)")]
    LB,

    [Display(Name = "Macedonian", Description = "MK (Macedonian)")]
    MK,

    [Display(Name = "Malagasy", Description = "MG (Malagasy)")]
    MG,

    [Display(Name = "Malay", Description = "MS (Malay)")]
    MS,

    [Display(Name = "Malayalam", Description = "ML (Malayalam)")]
    ML,

    [Display(Name = "Maltese", Description = "MT (Maltese)")]
    MT,

    [Display(Name = "Maori", Description = "MI (Maori)")]
    MI,

    [Display(Name = "Marathi", Description = "MR (Marathi)")]
    MR,

    [Display(Name = "Mongolian", Description = "MN (Mongolian)")]
    MN,

    [Display(Name = "Myanmar (Burmese)", Description = "MY (Myanmar (Burmese))")]
    MY,

    [Display(Name = "Nepali", Description = "NE (Nepali)")]
    NE,

    [Display(Name = "Norwegian", Description = "NO (Norwegian)")]
    NO,

    [Display(Name = "Odia (Oriya)", Description = "OR (Odia (Oriya))")]
    OR,

    [Display(Name = "Pashto", Description = "PS (Pashto)")]
    PS,

    [Display(Name = "Persian", Description = "FA (Persian)")]
    FA,

    [Display(Name = "Polish", Description = "PL (Polish)")]
    PL,

    [Display(Name = "Portuguese", Description = "PT (Portuguese)")]
    PT,

    [Display(Name = "Punjabi", Description = "PA (Punjabi)")]
    PA,

    [Display(Name = "Romanian", Description = "RO (Romanian)")]
    RO,

    [Display(Name = "Russian", Description = "RU (Russian)")]
    RU,

    [Display(Name = "Samoan", Description = "SM (Samoan)")]
    SM,

    [Display(Name = "Scots Gaelic", Description = "GD (Scots Gaelic)")]
    GD,

    [Display(Name = "Serbian", Description = "SR (Serbian)")]
    SR,

    [Display(Name = "Sesotho", Description = "ST (Sesotho)")]
    ST,

    [Display(Name = "Shona", Description = "SN (Shona)")]
    SN,

    [Display(Name = "Sindhi", Description = "SD (Sindhi)")]
    SD,

    [Display(Name = "Sinhala", Description = "SI (Sinhala)")]
    SI,

    [Display(Name = "Slovak", Description = "SK (Slovak)")]
    SK,

    [Display(Name = "Slovenian", Description = "SL (Slovenian)")]
    SL,

    [Display(Name = "Somali", Description = "SO (Somali)")]
    SO,

    [Display(Name = "Spanish", Description = "ES (Spanish)")]
    ES,

    [Display(Name = "Sundanese", Description = "SU (Sundanese)")]
    SU,

    [Display(Name = "Swahili", Description = "SW (Swahili)")]
    SW,

    [Display(Name = "Swedish", Description = "SV (Swedish)")]
    SV,

    [Display(Name = "Tajik", Description = "TG (Tajik)")]
    TG,

    [Display(Name = "Tamil", Description = "TA (Tamil)")]
    TA,

    [Display(Name = "Tatar", Description = "TT (Tatar)")]
    TT,

    [Display(Name = "Telugu", Description = "TE (Telugu)")]
    TE,

    [Display(Name = "Thai", Description = "TH (Thai)")]
    TH,

    [Display(Name = "Turkish", Description = "TR (Turkish)")]
    TR,

    [Display(Name = "Turkmen", Description = "TK (Turkmen)")]
    TK,

    [Display(Name = "Ukrainian", Description = "UK (Ukrainian)")]
    UK,

    [Display(Name = "Urdu", Description = "UR (Urdu)")]
    UR,

    [Display(Name = "Uyghur", Description = "UG (Uyghur)")]
    UG,

    [Display(Name = "Uzbek", Description = "UZ (Uzbek)")]
    UZ,

    [Display(Name = "Vietnamese", Description = "VI (Vietnamese)")]
    VI,

    [Display(Name = "Welsh", Description = "CY (Welsh)")]
    CY,

    [Display(Name = "Xhosa", Description = "XH (Xhosa)")]
    XH,

    [Display(Name = "Yiddish", Description = "YI (Yiddish)")]
    YI,

    [Display(Name = "Yoruba", Description = "YO (Yoruba)")]
    YO,

    [Display(Name = "Zulu", Description = "ZU (Zulu)")]
    ZU,
}