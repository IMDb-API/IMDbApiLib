using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchLanguage
    {
        [Display(Name = "Abkhazian")]
        [Description("ab")]
        Abkhazian,
        [Display(Name = "Aboriginal")]
        [Description("qac")]
        Aboriginal,
        [Display(Name = "Aché")]
        [Description("guq")]
        Ache,
        [Display(Name = "Acholi")]
        [Description("qam")]
        Acholi,
        [Display(Name = "Afrikaans")]
        [Description("af")]
        Afrikaans,
        [Display(Name = "Aidoukrou")]
        [Description("qas")]
        Aidoukrou,
        [Display(Name = "Akan")]
        [Description("ak")]
        Akan,
        [Display(Name = "Albanian")]
        [Description("sq")]
        Albanian,
        [Display(Name = "Aleut")]
        [Description("ale")]
        Aleut,
        [Display(Name = "Algonquin")]
        [Description("alg")]
        Algonquin,
        [Display(Name = "American Sign Language")]
        [Description("ase")]
        American_Sign_Language,
        [Display(Name = "Amharic")]
        [Description("am")]
        Amharic,
        [Display(Name = "Apache languages")]
        [Description("apa")]
        Apache_languages,
        [Display(Name = "Arabic")]
        [Description("ar")]
        Arabic,
        [Display(Name = "Aragonese")]
        [Description("an")]
        Aragonese,
        [Display(Name = "Aramaic")]
        [Description("arc")]
        Aramaic,
        [Display(Name = "Arapaho")]
        [Description("arp")]
        Arapaho,
        [Display(Name = "Archi")]
        [Description("aqc")]
        Archi,
        [Display(Name = "Armenian")]
        [Description("hy")]
        Armenian,
        [Display(Name = "Assamese")]
        [Description("as")]
        Assamese,
        [Display(Name = "Assiniboine")]
        [Description("asb")]
        Assiniboine,
        [Display(Name = "Assyrian Neo-Aramaic")]
        [Description("aii")]
        Assyrian_Neo_Aramaic,
        [Display(Name = "Athapascan languages")]
        [Description("ath")]
        Athapascan_languages,
        [Display(Name = "Australian Sign Language")]
        [Description("asf")]
        Australian_Sign_Language,
        [Display(Name = "Awadhi")]
        [Description("awa")]
        Awadhi,
        [Display(Name = "Aymara")]
        [Description("ay")]
        Aymara,
        [Display(Name = "Azerbaijani")]
        [Description("az")]
        Azerbaijani,
        [Display(Name = "Bable")]
        [Description("ast")]
        Bable,
        [Display(Name = "Baka")]
        [Description("qbd")]
        Baka,
        [Display(Name = "Balinese")]
        [Description("ban")]
        Balinese,
        [Display(Name = "Bambara")]
        [Description("bm")]
        Bambara,
        [Display(Name = "Bashkir")]
        [Description("ba")]
        Bashkir,
        [Display(Name = "Basque")]
        [Description("eu")]
        Basque,
        [Display(Name = "Bassari")]
        [Description("bsc")]
        Bassari,
        [Display(Name = "Belarusian")]
        [Description("be")]
        Belarusian,
        [Display(Name = "Bemba")]
        [Description("bem")]
        Bemba,
        [Display(Name = "Bengali")]
        [Description("bn")]
        Bengali,
        [Display(Name = "Berber languages")]
        [Description("ber")]
        Berber_languages,
        [Display(Name = "Bhojpuri")]
        [Description("bho")]
        Bhojpuri,
        [Display(Name = "Bicolano")]
        [Description("qbi")]
        Bicolano,
        [Display(Name = "Bodo")]
        [Description("qbh")]
        Bodo,
        [Display(Name = "Bonda")]
        [Description("bfw")]
        Bonda,
        [Display(Name = "Bosnian")]
        [Description("bs")]
        Bosnian,
        [Display(Name = "Brazilian Sign Language")]
        [Description("bzs")]
        Brazilian_Sign_Language,
        [Display(Name = "Breton")]
        [Description("br")]
        Breton,
        [Display(Name = "British Sign Language")]
        [Description("bfi")]
        British_Sign_Language,
        [Display(Name = "Bulgarian")]
        [Description("bg")]
        Bulgarian,
        [Display(Name = "Burmese")]
        [Description("my")]
        Burmese,
        [Display(Name = "Burushaski")]
        [Description("bsk")]
        Burushaski,
        [Display(Name = "Cantonese")]
        [Description("yue")]
        Cantonese,
        [Display(Name = "Catalan")]
        [Description("ca")]
        Catalan,
        [Display(Name = "Central Khmer")]
        [Description("km")]
        Central_Khmer,
        [Display(Name = "Chakma")]
        [Description("ccp")]
        Chakma,
        [Display(Name = "Chaozhou")]
        [Description("qax")]
        Chaozhou,
        [Display(Name = "Chechen")]
        [Description("ce")]
        Chechen,
        [Display(Name = "Cherokee")]
        [Description("chr")]
        Cherokee,
        [Display(Name = "Cheyenne")]
        [Description("chy")]
        Cheyenne,
        [Display(Name = "Chhattisgarhi")]
        [Description("hne")]
        Chhattisgarhi,
        [Display(Name = "Chinese")]
        [Description("zh")]
        Chinese,
        [Display(Name = "Chukchi")]
        [Description("ckt")]
        Chukchi,
        [Display(Name = "Cornish")]
        [Description("kw")]
        Cornish,
        [Display(Name = "Corsican")]
        [Description("co")]
        Corsican,
        [Display(Name = "Cree")]
        [Description("cr")]
        Cree,
        [Display(Name = "Creek")]
        [Description("mus")]
        Creek,
        [Display(Name = "Croatian")]
        [Description("hr")]
        Croatian,
        [Display(Name = "Crow")]
        [Description("cro")]
        Crow,
        [Display(Name = "Czech")]
        [Description("cs")]
        Czech,
        [Display(Name = "Danish")]
        [Description("da")]
        Danish,
        [Display(Name = "Dari")]
        [Description("prs")]
        Dari,
        [Display(Name = "Desiya")]
        [Description("dso")]
        Desiya,
        [Display(Name = "Dinka")]
        [Description("din")]
        Dinka,
        [Display(Name = "Djerma")]
        [Description("qaw")]
        Djerma,
        [Display(Name = "Dogri")]
        [Description("doi")]
        Dogri,
        [Display(Name = "Dutch")]
        [Description("nl")]
        Dutch,
        [Display(Name = "Dyula")]
        [Description("dyu")]
        Dyula,
        [Display(Name = "Dzongkha")]
        [Description("dz")]
        Dzongkha,
        [Display(Name = "East-Greenlandic")]
        [Description("qbc")]
        East_Greenlandic,
        [Display(Name = "Eastern Frisian")]
        [Description("frs")]
        Eastern_Frisian,
        [Display(Name = "Egyptian (Ancient)")]
        [Description("egy")]
        Egyptian_Ancient,
        [Display(Name = "English")]
        [Description("en")]
        English,
        [Display(Name = "Esperanto")]
        [Description("eo")]
        Esperanto,
        [Display(Name = "Estonian")]
        [Description("et")]
        Estonian,
        [Display(Name = "Ewe")]
        [Description("ee")]
        Ewe,
        [Display(Name = "Faliasch")]
        [Description("qbg")]
        Faliasch,
        [Display(Name = "Faroese")]
        [Description("fo")]
        Faroese,
        [Display(Name = "Filipino")]
        [Description("fil")]
        Filipino,
        [Display(Name = "Finnish")]
        [Description("fi")]
        Finnish,
        [Display(Name = "Flemish")]
        [Description("qbn")]
        Flemish,
        [Display(Name = "Fon")]
        [Description("fon")]
        Fon,
        [Display(Name = "French")]
        [Description("fr")]
        French,
        [Display(Name = "French Sign Language")]
        [Description("fsl")]
        French_Sign_Language,
        [Display(Name = "Friulian")]
        [Description("fur")]
        Friulian,
        [Display(Name = "Fulah")]
        [Description("ff")]
        Fulah,
        [Display(Name = "Fur")]
        [Description("fvr")]
        Fur,
        [Display(Name = "Gaelic")]
        [Description("gd")]
        Gaelic,
        [Display(Name = "Galician")]
        [Description("gl")]
        Galician,
        [Display(Name = "Georgian")]
        [Description("ka")]
        Georgian,
        [Display(Name = "German")]
        [Description("de")]
        German,
        [Display(Name = "German Sign Language")]
        [Description("gsg")]
        German_Sign_Language,
        [Display(Name = "Grebo")]
        [Description("grb")]
        Grebo,
        [Display(Name = "Greek")]
        [Description("el")]
        Greek,
        [Display(Name = "Greek, Ancient (to 1453)")]
        [Description("grc")]
        Greek_Ancient_to_1453,
        [Display(Name = "Greenlandic")]
        [Description("kl")]
        Greenlandic,
        [Display(Name = "Guarani")]
        [Description("gn")]
        Guarani,
        [Display(Name = "Gujarati")]
        [Description("gu")]
        Gujarati,
        [Display(Name = "Gumatj")]
        [Description("gnn")]
        Gumatj,
        [Display(Name = "Gunwinggu")]
        [Description("gup")]
        Gunwinggu,
        [Display(Name = "Gutob")]
        [Description("gbj")]
        Gutob,
        [Display(Name = "Haitian")]
        [Description("ht")]
        Haitian,
        [Display(Name = "Haida")]
        [Description("hai")]
        Haida,
        [Display(Name = "Hakka")]
        [Description("hak")]
        Hakka,
        [Display(Name = "Haryanvi")]
        [Description("bgc")]
        Haryanvi,
        [Display(Name = "Hassanya")]
        [Description("qav")]
        Hassanya,
        [Display(Name = "Hausa")]
        [Description("ha")]
        Hausa,
        [Display(Name = "Hawaiian")]
        [Description("haw")]
        Hawaiian,
        [Display(Name = "Hebrew")]
        [Description("he")]
        Hebrew,
        [Display(Name = "Hindi")]
        [Description("hi")]
        Hindi,
        [Display(Name = "Hmong")]
        [Description("hmn")]
        Hmong,
        [Display(Name = "Ho")]
        [Description("hoc")]
        Ho,
        [Display(Name = "Hokkien")]
        [Description("qab")]
        Hokkien,
        [Display(Name = "Hopi")]
        [Description("hop")]
        Hopi,
        [Display(Name = "Hungarian")]
        [Description("hu")]
        Hungarian,
        [Display(Name = "Iban")]
        [Description("iba")]
        Iban,
        [Display(Name = "Ibo")]
        [Description("qag")]
        Ibo,
        [Display(Name = "Icelandic")]
        [Description("is")]
        Icelandic,
        [Display(Name = "Icelandic Sign Language")]
        [Description("icl")]
        Icelandic_Sign_Language,
        [Display(Name = "Indian Sign Language")]
        [Description("ins")]
        Indian_Sign_Language,
        [Display(Name = "Indonesian")]
        [Description("id")]
        Indonesian,
        [Display(Name = "Inuktitut")]
        [Description("iu")]
        Inuktitut,
        [Display(Name = "Inupiaq")]
        [Description("ik")]
        Inupiaq,
        [Display(Name = "Irish Gaelic")]
        [Description("ga")]
        Irish_Gaelic,
        [Display(Name = "Irula")]
        [Description("iru")]
        Irula,
        [Display(Name = "Italian")]
        [Description("it")]
        Italian,
        [Display(Name = "Japanese")]
        [Description("ja")]
        Japanese,
        [Display(Name = "Japanese Sign Language")]
        [Description("jsl")]
        Japanese_Sign_Language,
        [Display(Name = "Jola-Fonyi")]
        [Description("dyo")]
        Jola_Fonyi,
        [Display(Name = "Ju'hoan")]
        [Description("ktz")]
        Ju_hoan,
        [Display(Name = "Kaado")]
        [Description("qbf")]
        Kaado,
        [Display(Name = "Kabuverdianu")]
        [Description("kea")]
        Kabuverdianu,
        [Display(Name = "Kabyle")]
        [Description("kab")]
        Kabyle,
        [Display(Name = "Kalmyk-Oirat")]
        [Description("xal")]
        Kalmyk_Oirat,
        [Display(Name = "Kannada")]
        [Description("kn")]
        Kannada,
        [Display(Name = "Karajá")]
        [Description("kpj")]
        Karaja,
        [Display(Name = "Karbi")]
        [Description("mjw")]
        Karbi,
        [Display(Name = "Karen")]
        [Description("kar")]
        Karen,
        [Display(Name = "Kazakh")]
        [Description("kk")]
        Kazakh,
        [Display(Name = "Khanty")]
        [Description("kca")]
        Khanty,
        [Display(Name = "Khasi")]
        [Description("kha")]
        Khasi,
        [Display(Name = "Kikuyu")]
        [Description("ki")]
        Kikuyu,
        [Display(Name = "Kinyarwanda")]
        [Description("rw")]
        Kinyarwanda,
        [Display(Name = "Kirundi")]
        [Description("qar")]
        Kirundi,
        [Display(Name = "Klingon")]
        [Description("tlh")]
        Klingon,
        [Display(Name = "Kodava")]
        [Description("kfa")]
        Kodava,
        [Display(Name = "Kokborok")]
        [Description("trp")]
        Kokborok,
        [Display(Name = "Konkani")]
        [Description("kok")]
        Konkani,
        [Display(Name = "Korean")]
        [Description("ko")]
        Korean,
        [Display(Name = "Korean Sign Language")]
        [Description("kvk")]
        Korean_Sign_Language,
        [Display(Name = "Korowai")]
        [Description("khe")]
        Korowai,
        [Display(Name = "Kriolu")]
        [Description("qaq")]
        Kriolu,
        [Display(Name = "Kru")]
        [Description("kro")]
        Kru,
        [Display(Name = "Kudmali")]
        [Description("kyw")]
        Kudmali,
        [Display(Name = "Kuna")]
        [Description("qbb")]
        Kuna,
        [Display(Name = "Kurdish")]
        [Description("ku")]
        Kurdish,
        [Display(Name = "Kusunda")]
        [Description("kgg")]
        Kusunda,
        [Display(Name = "Kwakiutl")]
        [Description("kwk")]
        Kwakiutl,
        [Display(Name = "Kyrgyz")]
        [Description("ky")]
        Kyrgyz,
        [Display(Name = "Ladakhi")]
        [Description("lbj")]
        Ladakhi,
        [Display(Name = "Ladino")]
        [Description("lad")]
        Ladino,
        [Display(Name = "Lao")]
        [Description("lo")]
        Lao,
        [Display(Name = "Latin")]
        [Description("la")]
        Latin,
        [Display(Name = "Latvian")]
        [Description("lv")]
        Latvian,
        [Display(Name = "Limbu")]
        [Description("lif")]
        Limbu,
        [Display(Name = "Lingala")]
        [Description("ln")]
        Lingala,
        [Display(Name = "Lithuanian")]
        [Description("lt")]
        Lithuanian,
        [Display(Name = "Low German")]
        [Description("nds")]
        Low_German,
        [Display(Name = "Luxembourgish")]
        [Description("lb")]
        Luxembourgish,
        [Display(Name = "Macedonian")]
        [Description("mk")]
        Macedonian,
        [Display(Name = "Macro-Jê")]
        [Description("qbm")]
        Macro_Je,
        [Display(Name = "Magahi")]
        [Description("mag")]
        Magahi,
        [Display(Name = "Maithili")]
        [Description("mai")]
        Maithili,
        [Display(Name = "Malagasy")]
        [Description("mg")]
        Malagasy,
        [Display(Name = "Malay")]
        [Description("ms")]
        Malay,
        [Display(Name = "Malayalam")]
        [Description("ml")]
        Malayalam,
        [Display(Name = "Malecite-Passamaquoddy")]
        [Description("pqm")]
        Malecite_Passamaquoddy,
        [Display(Name = "Malinka")]
        [Description("qap")]
        Malinka,
        [Display(Name = "Maltese")]
        [Description("mt")]
        Maltese,
        [Display(Name = "Manchu")]
        [Description("mnc")]
        Manchu,
        [Display(Name = "Mandarin")]
        [Description("cmn")]
        Mandarin,
        [Display(Name = "Mandingo")]
        [Description("man")]
        Mandingo,
        [Display(Name = "Manipuri")]
        [Description("mni")]
        Manipuri,
        [Display(Name = "Maori")]
        [Description("mi")]
        Maori,
        [Display(Name = "Mapudungun")]
        [Description("arn")]
        Mapudungun,
        [Display(Name = "Marathi")]
        [Description("mr")]
        Marathi,
        [Display(Name = "Marshallese")]
        [Description("mh")]
        Marshallese,
        [Display(Name = "Masai")]
        [Description("mas")]
        Masai,
        [Display(Name = "Masalit")]
        [Description("mls")]
        Masalit,
        [Display(Name = "Maya")]
        [Description("myn")]
        Maya,
        [Display(Name = "Mende")]
        [Description("men")]
        Mende,
        [Display(Name = "Micmac")]
        [Description("mic")]
        Micmac,
        [Display(Name = "Middle English")]
        [Description("enm")]
        Middle_English,
        [Display(Name = "Min Nan")]
        [Description("nan")]
        Min_Nan,
        [Display(Name = "Minangkabau")]
        [Description("min")]
        Minangkabau,
        [Display(Name = "Mirandese")]
        [Description("mwl")]
        Mirandese,
        [Display(Name = "Mixtec")]
        [Description("qmt")]
        Mixtec,
        [Display(Name = "Mizo")]
        [Description("lus")]
        Mizo,
        [Display(Name = "Mohawk")]
        [Description("moh")]
        Mohawk,
        [Display(Name = "Mongolian")]
        [Description("mn")]
        Mongolian,
        [Display(Name = "Montagnais")]
        [Description("moe")]
        Montagnais,
        [Display(Name = "More")]
        [Description("qaf")]
        More,
        [Display(Name = "Morisyen")]
        [Description("mfe")]
        Morisyen,
        [Display(Name = "Nagpuri")]
        [Description("qbl")]
        Nagpuri,
        [Display(Name = "Nahuatl")]
        [Description("nah")]
        Nahuatl,
        [Display(Name = "Nama")]
        [Description("qba")]
        Nama,
        [Display(Name = "Navajo")]
        [Description("nv")]
        Navajo,
        [Display(Name = "Naxi")]
        [Description("nbf")]
        Naxi,
        [Display(Name = "Ndebele")]
        [Description("nd")]
        Ndebele,
        [Display(Name = "Neapolitan")]
        [Description("nap")]
        Neapolitan,
        [Display(Name = "Nenets")]
        [Description("yrk")]
        Nenets,
        [Display(Name = "Nepali")]
        [Description("ne")]
        Nepali,
        [Display(Name = "Nisga'a")]
        [Description("ncg")]
        Nisga_a,
        [Display(Name = "None")]
        [Description("zxx")]
        None,
        [Display(Name = "Norse, Old")]
        [Description("non")]
        Norse_Old,
        [Display(Name = "North American Indian")]
        [Description("nai")]
        North_American_Indian,
        [Display(Name = "Norwegian")]
        [Description("no")]
        Norwegian,
        [Display(Name = "Nushi")]
        [Description("qbk")]
        Nushi,
        [Display(Name = "Nyaneka")]
        [Description("nyk")]
        Nyaneka,
        [Display(Name = "Nyanja")]
        [Description("ny")]
        Nyanja,
        [Display(Name = "Occitan")]
        [Description("oc")]
        Occitan,
        [Display(Name = "Ojibwa")]
        [Description("oj")]
        Ojibwa,
        [Display(Name = "Ojihimba")]
        [Description("qaz")]
        Ojihimba,
        [Display(Name = "Old English")]
        [Description("ang")]
        Old_English,
        [Display(Name = "Oriya")]
        [Description("or")]
        Oriya,
        [Display(Name = "Papiamento")]
        [Description("pap")]
        Papiamento,
        [Display(Name = "Parsee")]
        [Description("qaj")]
        Parsee,
        [Display(Name = "Pashtu")]
        [Description("ps")]
        Pashtu,
        [Display(Name = "Pawnee")]
        [Description("paw")]
        Pawnee,
        [Display(Name = "Persian")]
        [Description("fa")]
        Persian,
        [Display(Name = "Peul")]
        [Description("qai")]
        Peul,
        [Display(Name = "Pirahã")]
        [Description("myp")]
        Piraha,
        [Display(Name = "Polish")]
        [Description("pl")]
        Polish,
        [Display(Name = "Polynesian")]
        [Description("qah")]
        Polynesian,
        [Display(Name = "Portuguese")]
        [Description("pt")]
        Portuguese,
        [Display(Name = "Pular")]
        [Description("fuf")]
        Pular,
        [Display(Name = "Punjabi")]
        [Description("pa")]
        Punjabi,
        [Display(Name = "Purepecha")]
        [Description("tsz")]
        Purepecha,
        [Display(Name = "Quechua")]
        [Description("qu")]
        Quechua,
        [Display(Name = "Quenya")]
        [Description("qya")]
        Quenya,
        [Display(Name = "Rajasthani")]
        [Description("raj")]
        Rajasthani,
        [Display(Name = "Rawan")]
        [Description("qbj")]
        Rawan,
        [Display(Name = "Rhaetian")]
        [Description("xrr")]
        Rhaetian,
        [Display(Name = "Romanian")]
        [Description("ro")]
        Romanian,
        [Display(Name = "Romansh")]
        [Description("rm")]
        Romansh,
        [Display(Name = "Romany")]
        [Description("rom")]
        Romany,
        [Display(Name = "Rotuman")]
        [Description("rtm")]
        Rotuman,
        [Display(Name = "Russian")]
        [Description("ru")]
        Russian,
        [Display(Name = "Russian Sign Language")]
        [Description("rsl")]
        Russian_Sign_Language,
        [Display(Name = "Ryukyuan")]
        [Description("qao")]
        Ryukyuan,
        [Display(Name = "Saami")]
        [Description("qae")]
        Saami,
        [Display(Name = "Samoan")]
        [Description("sm")]
        Samoan,
        [Display(Name = "Sanskrit")]
        [Description("sa")]
        Sanskrit,
        [Display(Name = "Santali")]
        [Description("sat")]
        Santali,
        [Display(Name = "Sardinian")]
        [Description("sc")]
        Sardinian,
        [Display(Name = "Scanian")]
        [Description("qay")]
        Scanian,
        [Display(Name = "Serbian")]
        [Description("sr")]
        Serbian,
        [Display(Name = "Serbo-Croatian")]
        [Description("qbo")]
        Serbo_Croatian,
        [Display(Name = "Serer")]
        [Description("srr")]
        Serer,
        [Display(Name = "Shanghainese")]
        [Description("qad")]
        Shanghainese,
        [Display(Name = "Shanxi")]
        [Description("qau")]
        Shanxi,
        [Display(Name = "Shipibo")]
        [Description("shp")]
        Shipibo,
        [Display(Name = "Shona")]
        [Description("sn")]
        Shona,
        [Display(Name = "Shoshoni")]
        [Description("shh")]
        Shoshoni,
        [Display(Name = "Sicilian")]
        [Description("scn")]
        Sicilian,
        [Display(Name = "Silbo Gomero")]
        [Description("qsg")]
        Silbo_Gomero,
        [Display(Name = "Sindarin")]
        [Description("sjn")]
        Sindarin,
        [Display(Name = "Sindhi")]
        [Description("sd")]
        Sindhi,
        [Display(Name = "Sinhala")]
        [Description("si")]
        Sinhala,
        [Display(Name = "Sioux")]
        [Description("sio")]
        Sioux,
        [Display(Name = "Slovak")]
        [Description("sk")]
        Slovak,
        [Display(Name = "Slovenian")]
        [Description("sl")]
        Slovenian,
        [Display(Name = "Somali")]
        [Description("so")]
        Somali,
        [Display(Name = "Songhay")]
        [Description("son")]
        Songhay,
        [Display(Name = "Soninke")]
        [Description("snk")]
        Soninke,
        [Display(Name = "Sorbian languages")]
        [Description("wen")]
        Sorbian_languages,
        [Display(Name = "Sotho")]
        [Description("st")]
        Sotho,
        [Display(Name = "Sousson")]
        [Description("qbe")]
        Sousson,
        [Display(Name = "Spanish")]
        [Description("es")]
        Spanish,
        [Display(Name = "Spanish Sign Language")]
        [Description("ssp")]
        Spanish_Sign_Language,
        [Display(Name = "Sranan")]
        [Description("srn")]
        Sranan,
        [Display(Name = "Swahili")]
        [Description("sw")]
        Swahili,
        [Display(Name = "Swedish")]
        [Description("sv")]
        Swedish,
        [Display(Name = "Swiss German")]
        [Description("gsw")]
        Swiss_German,
        [Display(Name = "Sylheti")]
        [Description("syl")]
        Sylheti,
        [Display(Name = "Taa")]
        [Description("nmn")]
        Taa,
        [Display(Name = "Tagalog")]
        [Description("tl")]
        Tagalog,
        [Display(Name = "Tajik")]
        [Description("tg")]
        Tajik,
        [Display(Name = "Tamashek")]
        [Description("tmh")]
        Tamashek,
        [Display(Name = "Tamil")]
        [Description("ta")]
        Tamil,
        [Display(Name = "Tarahumara")]
        [Description("tac")]
        Tarahumara,
        [Display(Name = "Tatar")]
        [Description("tt")]
        Tatar,
        [Display(Name = "Telugu")]
        [Description("te")]
        Telugu,
        [Display(Name = "Teochew")]
        [Description("qak")]
        Teochew,
        [Display(Name = "Thai")]
        [Description("th")]
        Thai,
        [Display(Name = "Tibetan")]
        [Description("bo")]
        Tibetan,
        [Display(Name = "Tigrigna")]
        [Description("qan")]
        Tigrigna,
        [Display(Name = "Tlingit")]
        [Description("tli")]
        Tlingit,
        [Display(Name = "Tok Pisin")]
        [Description("tpi")]
        Tok_Pisin,
        [Display(Name = "Tonga (Tonga Islands)")]
        [Description("to")]
        Tonga__Islands,
        [Display(Name = "Tsonga")]
        [Description("ts")]
        Tsonga,
        [Display(Name = "Tswa")]
        [Description("tsc")]
        Tswa,
        [Display(Name = "Tswana")]
        [Description("tn")]
        Tswana,
        [Display(Name = "Tulu")]
        [Description("tcy")]
        Tulu,
        [Display(Name = "Tupi")]
        [Description("tup")]
        Tupi,
        [Display(Name = "Turkish")]
        [Description("tr")]
        Turkish,
        [Display(Name = "Turkmen")]
        [Description("tk")]
        Turkmen,
        [Display(Name = "Tuvinian")]
        [Description("tyv")]
        Tuvinian,
        [Display(Name = "Tuyuca")]
        [Description("tue")]
        Tuyuca,
        [Display(Name = "Tzotzil")]
        [Description("tzo")]
        Tzotzil,
        [Display(Name = "Ukrainian")]
        [Description("uk")]
        Ukrainian,
        [Display(Name = "Ukrainian Sign Language")]
        [Description("ukl")]
        Ukrainian_Sign_Language,
        [Display(Name = "Ungwatsi")]
        [Description("qat")]
        Ungwatsi,
        [Display(Name = "Urdu")]
        [Description("ur")]
        Urdu,
        [Display(Name = "Uzbek")]
        [Description("uz")]
        Uzbek,
        [Display(Name = "Vietnamese")]
        [Description("vi")]
        Vietnamese,
        [Display(Name = "Visayan")]
        [Description("qaa")]
        Visayan,
        [Display(Name = "Washoe")]
        [Description("was")]
        Washoe,
        [Display(Name = "Welsh")]
        [Description("cy")]
        Welsh,
        [Display(Name = "Wolof")]
        [Description("wo")]
        Wolof,
        [Display(Name = "Xhosa")]
        [Description("xh")]
        Xhosa,
        [Display(Name = "Yakut")]
        [Description("sah")]
        Yakut,
        [Display(Name = "Yapese")]
        [Description("yap")]
        Yapese,
        [Display(Name = "Yiddish")]
        [Description("yi")]
        Yiddish,
        [Display(Name = "Yoruba")]
        [Description("yo")]
        Yoruba,
        [Display(Name = "Yupik")]
        [Description("ypk")]
        Yupik,
        [Display(Name = "Zulu")]
        [Description("zu")]
        Zulu
    }
}