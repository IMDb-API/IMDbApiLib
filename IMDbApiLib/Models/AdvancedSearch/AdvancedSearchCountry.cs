using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchCountry
{
    [Display(Name = "Afghanistan", Description = "AF")]
    Afghanistan,

    [Display(Name = "Åland Islands", Description = "AX")]
    AlandIslands,

    [Display(Name = "Albania", Description = "AL")]
    Albania,

    [Display(Name = "Algeria", Description = "DZ")]
    Algeria,

    [Display(Name = "American Samoa", Description = "AS")]
    AmericanSamoa,

    [Display(Name = "Andorra", Description = "AD")]
    Andorra,

    [Display(Name = "Angola", Description = "AO")]
    Angola,

    [Display(Name = "Anguilla", Description = "AI")]
    Anguilla,

    [Display(Name = "Antarctica", Description = "AQ")]
    Antarctica,

    [Display(Name = "Antigua & Barbuda", Description = "AG")]
    AntiguaAndBarbuda,

    [Display(Name = "Argentina", Description = "AR")]
    Argentina,

    [Display(Name = "Armenia", Description = "AM")]
    Armenia,

    [Display(Name = "Aruba", Description = "AW")]
    Aruba,

    [Display(Name = "Australia", Description = "AU")]
    Australia,

    [Display(Name = "Austria", Description = "AT")]
    Austria,

    [Display(Name = "Azerbaijan", Description = "AZ")]
    Azerbaijan,

    [Display(Name = "Bahamas", Description = "BS")]
    Bahamas,

    [Display(Name = "Bahrain", Description = "BH")]
    Bahrain,

    [Display(Name = "Bangladesh", Description = "BD")]
    Bangladesh,

    [Display(Name = "Barbados", Description = "BB")]
    Barbados,

    [Display(Name = "Belarus", Description = "BY")]
    Belarus,

    [Display(Name = "Belgium", Description = "BE")]
    Belgium,

    [Display(Name = "Belize", Description = "BZ")]
    Belize,

    [Display(Name = "Benin", Description = "BJ")]
    Benin,

    [Display(Name = "Bermuda", Description = "BM")]
    Bermuda,

    [Display(Name = "Bhutan", Description = "BT")]
    Bhutan,

    [Display(Name = "Bolivia", Description = "BO")]
    Bolivia,

    [Display(Name = "Bosnia & Herzegovina", Description = "BA")]
    BosniaAndHerzegovina,

    [Display(Name = "Botswana", Description = "BW")]
    Botswana,

    [Display(Name = "Bouvet Island", Description = "BV")]
    BouvetIsland,

    [Display(Name = "Brazil", Description = "BR")]
    Brazil,

    [Display(Name = "British Indian Ocean Territory", Description = "IO")]
    BritishIndianOceanTerritory,

    [Display(Name = "British Virgin Islands", Description = "VG")]
    BritishVirginIslands,

    [Display(Name = "Brunei", Description = "BN")]
    Brunei,

    [Display(Name = "Bulgaria", Description = "BG")]
    Bulgaria,

    [Display(Name = "Burkina Faso", Description = "BF")]
    BurkinaFaso,

    [Display(Name = "Burma", Description = "BUMM")]
    Burma,

    [Display(Name = "Burundi", Description = "BI")]
    Burundi,

    [Display(Name = "Cambodia", Description = "KH")]
    Cambodia,

    [Display(Name = "Cameroon", Description = "CM")]
    Cameroon,

    [Display(Name = "Canada", Description = "CA")]
    Canada,

    [Display(Name = "Cape Verde", Description = "CV")]
    CapeVerde,

    [Display(Name = "Caribbean Netherlands", Description = "BQ")]
    CaribbeanNetherlands,

    [Display(Name = "Cayman Islands", Description = "KY")]
    CaymanIslands,

    [Display(Name = "Central African Republic", Description = "CF")]
    CentralAfricanRepublic,

    [Display(Name = "Chad", Description = "TD")]
    Chad,

    [Display(Name = "Chile", Description = "CL")]
    Chile,

    [Display(Name = "China", Description = "CN")]
    China,

    [Display(Name = "Christmas Island", Description = "CX")]
    ChristmasIsland,

    [Display(Name = "Cocos (Keeling) Islands", Description = "CC")]
    CocosKeelingIslands,

    [Display(Name = "Colombia", Description = "CO")]
    Colombia,

    [Display(Name = "Comoros", Description = "KM")]
    Comoros,

    [Display(Name = "Congo - Brazzaville", Description = "CG")]
    CongoBrazzaville,

    [Display(Name = "Congo - Kinshasa", Description = "CD")]
    CongoKinshasa,

    [Display(Name = "Cook Islands", Description = "CK")]
    CookIslands,

    [Display(Name = "Costa Rica", Description = "CR")]
    CostaRica,

    [Display(Name = "Côte d’Ivoire", Description = "CI")]
    CotedIvoire,

    [Display(Name = "Croatia", Description = "HR")]
    Croatia,

    [Display(Name = "Cuba", Description = "CU")]
    Cuba,

    [Display(Name = "Curaçao", Description = "CW")]
    Curacao,

    [Display(Name = "Cyprus", Description = "CY")]
    Cyprus,

    [Display(Name = "Czechia", Description = "CZ")]
    Czechia,

    [Display(Name = "Czechoslovakia", Description = "CSHH")]
    Czechoslovakia,

    [Display(Name = "Denmark", Description = "DK")]
    Denmark,

    [Display(Name = "Djibouti", Description = "DJ")]
    Djibouti,

    [Display(Name = "Dominica", Description = "DM")]
    Dominica,

    [Display(Name = "Dominican Republic", Description = "DO")]
    DominicanRepublic,

    [Display(Name = "East Germany", Description = "DDDE")]
    EastGermany,

    [Display(Name = "Ecuador", Description = "EC")]
    Ecuador,

    [Display(Name = "Egypt", Description = "EG")]
    Egypt,

    [Display(Name = "El Salvador", Description = "SV")]
    ElSalvador,

    [Display(Name = "Equatorial Guinea", Description = "GQ")]
    EquatorialGuinea,

    [Display(Name = "Eritrea", Description = "ER")]
    Eritrea,

    [Display(Name = "Estonia", Description = "EE")]
    Estonia,

    [Display(Name = "Eswatini", Description = "SZ")]
    Eswatini,

    [Display(Name = "Ethiopia", Description = "ET")]
    Ethiopia,

    [Display(Name = "Falkland Islands", Description = "FK")]
    FalklandIslands,

    [Display(Name = "Faroe Islands", Description = "FO")]
    FaroeIslands,

    [Display(Name = "Federal Republic of Yugoslavia", Description = "YUCS")]
    FederalRepublicOfYugoslavia,

    [Display(Name = "Fiji", Description = "FJ")]
    Fiji,

    [Display(Name = "Finland", Description = "FI")]
    Finland,

    [Display(Name = "France", Description = "FR")]
    France,

    [Display(Name = "French Guiana", Description = "GF")]
    FrenchGuiana,

    [Display(Name = "French Polynesia", Description = "PF")]
    FrenchPolynesia,

    [Display(Name = "French Southern Territories", Description = "TF")]
    FrenchSouthernTerritories,

    [Display(Name = "Gabon", Description = "GA")]
    Gabon,

    [Display(Name = "Gambia", Description = "GM")]
    Gambia,

    [Display(Name = "Georgia", Description = "GE")]
    Georgia,

    [Display(Name = "Germany", Description = "DE")]
    Germany,

    [Display(Name = "Ghana", Description = "GH")]
    Ghana,

    [Display(Name = "Gibraltar", Description = "GI")]
    Gibraltar,

    [Display(Name = "Greece", Description = "GR")]
    Greece,

    [Display(Name = "Greenland", Description = "GL")]
    Greenland,

    [Display(Name = "Grenada", Description = "GD")]
    Grenada,

    [Display(Name = "Guadeloupe", Description = "GP")]
    Guadeloupe,

    [Display(Name = "Guam", Description = "GU")]
    Guam,

    [Display(Name = "Guatemala", Description = "GT")]
    Guatemala,

    [Display(Name = "Guernsey", Description = "GG")]
    Guernsey,

    [Display(Name = "Guinea", Description = "GN")]
    Guinea,

    [Display(Name = "Guinea-Bissau", Description = "GW")]
    GuineaBissau,

    [Display(Name = "Guyana", Description = "GY")]
    Guyana,

    [Display(Name = "Haiti", Description = "HT")]
    Haiti,

    [Display(Name = "Heard & McDonald Islands", Description = "HM")]
    HeardAndMcDonaldIslands,

    [Display(Name = "Honduras", Description = "HN")]
    Honduras,

    [Display(Name = "Hong Kong SAR China", Description = "HK")]
    HongKongSarChina,

    [Display(Name = "Hungary", Description = "HU")]
    Hungary,

    [Display(Name = "Iceland", Description = "IS")]
    Iceland,

    [Display(Name = "India", Description = "IN")]
    India,

    [Display(Name = "Indonesia", Description = "ID")]
    Indonesia,

    [Display(Name = "Iran", Description = "IR")]
    Iran,

    [Display(Name = "Iraq", Description = "IQ")]
    Iraq,

    [Display(Name = "Ireland", Description = "IE")]
    Ireland,

    [Display(Name = "Isle of Man", Description = "IM")]
    IsleOfMan,

    [Display(Name = "Israel", Description = "IL")]
    Israel,

    [Display(Name = "Italy", Description = "IT")]
    Italy,

    [Display(Name = "Jamaica", Description = "JM")]
    Jamaica,

    [Display(Name = "Japan", Description = "JP")]
    Japan,

    [Display(Name = "Jersey", Description = "JE")]
    Jersey,

    [Display(Name = "Jordan", Description = "JO")]
    Jordan,

    [Display(Name = "Kazakhstan", Description = "KZ")]
    Kazakhstan,

    [Display(Name = "Kenya", Description = "KE")]
    Kenya,

    [Display(Name = "Kiribati", Description = "KI")]
    Kiribati,

    [Display(Name = "Korea", Description = "XKO")]
    Korea,

    [Display(Name = "Kosovo", Description = "XKV")]
    Kosovo,

    [Display(Name = "Kuwait", Description = "KW")]
    Kuwait,

    [Display(Name = "Kyrgyzstan", Description = "KG")]
    Kyrgyzstan,

    [Display(Name = "Laos", Description = "LA")]
    Laos,

    [Display(Name = "Latvia", Description = "LV")]
    Latvia,

    [Display(Name = "Lebanon", Description = "LB")]
    Lebanon,

    [Display(Name = "Lesotho", Description = "LS")]
    Lesotho,

    [Display(Name = "Liberia", Description = "LR")]
    Liberia,

    [Display(Name = "Libya", Description = "LY")]
    Libya,

    [Display(Name = "Liechtenstein", Description = "LI")]
    Liechtenstein,

    [Display(Name = "Lithuania", Description = "LT")]
    Lithuania,

    [Display(Name = "Luxembourg", Description = "LU")]
    Luxembourg,

    [Display(Name = "Macao SAR China", Description = "MO")]
    MacaoSarChina,

    [Display(Name = "Madagascar", Description = "MG")]
    Madagascar,

    [Display(Name = "Malawi", Description = "MW")]
    Malawi,

    [Display(Name = "Malaysia", Description = "MY")]
    Malaysia,

    [Display(Name = "Maldives", Description = "MV")]
    Maldives,

    [Display(Name = "Mali", Description = "ML")]
    Mali,

    [Display(Name = "Malta", Description = "MT")]
    Malta,

    [Display(Name = "Marshall Islands", Description = "MH")]
    MarshallIslands,

    [Display(Name = "Martinique", Description = "MQ")]
    Martinique,

    [Display(Name = "Mauritania", Description = "MR")]
    Mauritania,

    [Display(Name = "Mauritius", Description = "MU")]
    Mauritius,

    [Display(Name = "Mayotte", Description = "YT")]
    Mayotte,

    [Display(Name = "Mexico", Description = "MX")]
    Mexico,

    [Display(Name = "Micronesia", Description = "FM")]
    Micronesia,

    [Display(Name = "Moldova", Description = "MD")]
    Moldova,

    [Display(Name = "Monaco", Description = "MC")]
    Monaco,

    [Display(Name = "Mongolia", Description = "MN")]
    Mongolia,

    [Display(Name = "Montenegro", Description = "ME")]
    Montenegro,

    [Display(Name = "Montserrat", Description = "MS")]
    Montserrat,

    [Display(Name = "Morocco", Description = "MA")]
    Morocco,

    [Display(Name = "Mozambique", Description = "MZ")]
    Mozambique,

    [Display(Name = "Myanmar (Burma)", Description = "MM")]
    MyanmarBurma,

    [Display(Name = "Namibia", Description = "NA")]
    Namibia,

    [Display(Name = "Nauru", Description = "NR")]
    Nauru,

    [Display(Name = "Nepal", Description = "NP")]
    Nepal,

    [Display(Name = "Netherlands", Description = "NL")]
    Netherlands,

    [Display(Name = "Netherlands Antilles", Description = "AN")]
    NetherlandsAntilles,

    [Display(Name = "New Caledonia", Description = "NC")]
    NewCaledonia,

    [Display(Name = "New Zealand", Description = "NZ")]
    NewZealand,

    [Display(Name = "Nicaragua", Description = "NI")]
    Nicaragua,

    [Display(Name = "Niger", Description = "NE")]
    Niger,

    [Display(Name = "Nigeria", Description = "NG")]
    Nigeria,

    [Display(Name = "Niue", Description = "NU")]
    Niue,

    [Display(Name = "Norfolk Island", Description = "NF")]
    NorfolkIsland,

    [Display(Name = "North Korea", Description = "KP")]
    NorthKorea,

    [Display(Name = "North Macedonia", Description = "MK")]
    NorthMacedonia,

    [Display(Name = "North Vietnam", Description = "VDVN")]
    NorthVietnam,

    [Display(Name = "Northern Mariana Islands", Description = "MP")]
    NorthernMarianaIslands,

    [Display(Name = "Norway", Description = "NO")]
    Norway,

    [Display(Name = "Oman", Description = "OM")]
    Oman,

    [Display(Name = "Pakistan", Description = "PK")]
    Pakistan,

    [Display(Name = "Palau", Description = "PW")]
    Palau,

    [Display(Name = "Palestine", Description = "XPI")]
    Palestine,

    [Display(Name = "Palestinian Territories", Description = "PS")]
    PalestinianTerritories,

    [Display(Name = "Panama", Description = "PA")]
    Panama,

    [Display(Name = "Papua New Guinea", Description = "PG")]
    PapuaNewGuinea,

    [Display(Name = "Paraguay", Description = "PY")]
    Paraguay,

    [Display(Name = "Peru", Description = "PE")]
    Peru,

    [Display(Name = "Philippines", Description = "PH")]
    Philippines,

    [Display(Name = "Pitcairn Islands", Description = "PN")]
    PitcairnIslands,

    [Display(Name = "Poland", Description = "PL")]
    Poland,

    [Display(Name = "Portugal", Description = "PT")]
    Portugal,

    [Display(Name = "Puerto Rico", Description = "PR")]
    PuertoRico,

    [Display(Name = "Qatar", Description = "QA")]
    Qatar,

    [Display(Name = "Réunion", Description = "RE")]
    Reunion,

    [Display(Name = "Romania", Description = "RO")]
    Romania,

    [Display(Name = "Russia", Description = "RU")]
    Russia,

    [Display(Name = "Rwanda", Description = "RW")]
    Rwanda,

    [Display(Name = "Samoa", Description = "WS")]
    Samoa,

    [Display(Name = "San Marino", Description = "SM")]
    SanMarino,

    [Display(Name = "São Tomé & Príncipe", Description = "ST")]
    SaoTomeAndPrincipe,

    [Display(Name = "Saudi Arabia", Description = "SA")]
    SaudiArabia,

    [Display(Name = "Senegal", Description = "SN")]
    Senegal,

    [Display(Name = "Serbia", Description = "RS")]
    Serbia,

    [Display(Name = "Serbia and Montenegro", Description = "CSXX")]
    SerbiaAndMontenegro,

    [Display(Name = "Seychelles", Description = "SC")]
    Seychelles,

    [Display(Name = "Siam", Description = "XSI")]
    Siam,

    [Display(Name = "Sierra Leone", Description = "SL")]
    SierraLeone,

    [Display(Name = "Singapore", Description = "SG")]
    Singapore,

    [Display(Name = "Slovakia", Description = "SK")]
    Slovakia,

    [Display(Name = "Slovenia", Description = "SI")]
    Slovenia,

    [Display(Name = "Solomon Islands", Description = "SB")]
    SolomonIslands,

    [Display(Name = "Somalia", Description = "SO")]
    Somalia,

    [Display(Name = "South Africa", Description = "ZA")]
    SouthAfrica,

    [Display(Name = "South Georgia & South Sandwich Islands", Description = "GS")]
    SouthGeorgiaAndSouthSandwichIslands,

    [Display(Name = "South Korea", Description = "KR")]
    SouthKorea,

    [Display(Name = "Soviet Union", Description = "SUHH")]
    SovietUnion,

    [Display(Name = "Spain", Description = "ES")]
    Spain,

    [Display(Name = "Sri Lanka", Description = "LK")]
    SriLanka,

    [Display(Name = "St. Barthélemy", Description = "BL")]
    StBarthelemy,

    [Display(Name = "St. Helena", Description = "SH")]
    StHelena,

    [Display(Name = "St. Kitts & Nevis", Description = "KN")]
    StKittsAndNevis,

    [Display(Name = "St. Lucia", Description = "LC")]
    StLucia,

    [Display(Name = "St. Martin", Description = "MF")]
    StMartin,

    [Display(Name = "St. Pierre & Miquelon", Description = "PM")]
    StPierreAndMiquelon,

    [Display(Name = "St. Vincent & Grenadines", Description = "VC")]
    StVincentAndGrenadines,

    [Display(Name = "Sudan", Description = "SD")]
    Sudan,

    [Display(Name = "Suriname", Description = "SR")]
    Suriname,

    [Display(Name = "Svalbard & Jan Mayen", Description = "SJ")]
    SvalbardAndJanMayen,

    [Display(Name = "Sweden", Description = "SE")]
    Sweden,

    [Display(Name = "Switzerland", Description = "CH")]
    Switzerland,

    [Display(Name = "Syria", Description = "SY")]
    Syria,

    [Display(Name = "Taiwan", Description = "TW")]
    Taiwan,

    [Display(Name = "Tajikistan", Description = "TJ")]
    Tajikistan,

    [Display(Name = "Tanzania", Description = "TZ")]
    Tanzania,

    [Display(Name = "Thailand", Description = "TH")]
    Thailand,

    [Display(Name = "Timor-Leste", Description = "TL")]
    TimorLeste,

    [Display(Name = "Togo", Description = "TG")]
    Togo,

    [Display(Name = "Tokelau", Description = "TK")]
    Tokelau,

    [Display(Name = "Tonga", Description = "TO")]
    Tonga,

    [Display(Name = "Trinidad & Tobago", Description = "TT")]
    TrinidadAndTobago,

    [Display(Name = "Tunisia", Description = "TN")]
    Tunisia,

    [Display(Name = "Turkey", Description = "TR")]
    Turkey,

    [Display(Name = "Turkmenistan", Description = "TM")]
    Turkmenistan,

    [Display(Name = "Turks & Caicos Islands", Description = "TC")]
    TurksAndCaicosIslands,

    [Display(Name = "Tuvalu", Description = "TV")]
    Tuvalu,

    [Display(Name = "U.S. Outlying Islands", Description = "UM")]
    USOutlyingIslands,

    [Display(Name = "U.S. Virgin Islands", Description = "VI")]
    USVirginIslands,

    [Display(Name = "Uganda", Description = "UG")]
    Uganda,

    [Display(Name = "Ukraine", Description = "UA")]
    Ukraine,

    [Display(Name = "United Arab Emirates", Description = "AE")]
    UnitedArabEmirates,

    [Display(Name = "United Kingdom", Description = "GB")]
    UnitedKingdom,

    [Display(Name = "United States", Description = "US")]
    UnitedStates,

    [Display(Name = "Uruguay", Description = "UY")]
    Uruguay,

    [Display(Name = "Uzbekistan", Description = "UZ")]
    Uzbekistan,

    [Display(Name = "Vanuatu", Description = "VU")]
    Vanuatu,

    [Display(Name = "Vatican City", Description = "VA")]
    VaticanCity,

    [Display(Name = "Venezuela", Description = "VE")]
    Venezuela,

    [Display(Name = "Vietnam", Description = "VN")]
    Vietnam,

    [Display(Name = "Wallis & Futuna", Description = "WF")]
    WallisAndFutuna,

    [Display(Name = "West Germany", Description = "XWG")]
    WestGermany,

    [Display(Name = "Western Sahara", Description = "EH")]
    WesternSahara,

    [Display(Name = "Yemen", Description = "YE")]
    Yemen,

    [Display(Name = "Yugoslavia", Description = "XYU")]
    Yugoslavia,

    [Display(Name = "Zaire", Description = "ZRCD")]
    Zaire,

    [Display(Name = "Zambia", Description = "ZM")]
    Zambia,

    [Display(Name = "Zimbabwe", Description = "ZW")]
    Zimbabwe,
}