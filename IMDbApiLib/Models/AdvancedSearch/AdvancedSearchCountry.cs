using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchCountry
    {
        [Display(Name = "Afghanistan")]
        [Description("af")]
        Afghanistan,
        [Display(Name = "Åland Islands")]
        [Description("ax")]
        Aland_Islands,
        [Display(Name = "Albania")]
        [Description("al")]
        Albania,
        [Display(Name = "Algeria")]
        [Description("dz")]
        Algeria,
        [Display(Name = "American Samoa")]
        [Description("as")]
        American_Samoa,
        [Display(Name = "Andorra")]
        [Description("ad")]
        Andorra,
        [Display(Name = "Angola")]
        [Description("ao")]
        Angola,
        [Display(Name = "Anguilla")]
        [Description("ai")]
        Anguilla,
        [Display(Name = "Antarctica")]
        [Description("aq")]
        Antarctica,
        [Display(Name = "Antigua and Barbuda")]
        [Description("ag")]
        Antigua_and_Barbuda,
        [Display(Name = "Argentina")]
        [Description("ar")]
        Argentina,
        [Display(Name = "Armenia")]
        [Description("am")]
        Armenia,
        [Display(Name = "Aruba")]
        [Description("aw")]
        Aruba,
        [Display(Name = "Australia")]
        [Description("au")]
        Australia,
        [Display(Name = "Austria")]
        [Description("at")]
        Austria,
        [Display(Name = "Azerbaijan")]
        [Description("az")]
        Azerbaijan,
        [Display(Name = "Bahamas")]
        [Description("bs")]
        Bahamas,
        [Display(Name = "Bahrain")]
        [Description("bh")]
        Bahrain,
        [Display(Name = "Bangladesh")]
        [Description("bd")]
        Bangladesh,
        [Display(Name = "Barbados")]
        [Description("bb")]
        Barbados,
        [Display(Name = "Belarus")]
        [Description("by")]
        Belarus,
        [Display(Name = "Belgium")]
        [Description("be")]
        Belgium,
        [Display(Name = "Belize")]
        [Description("bz")]
        Belize,
        [Display(Name = "Benin")]
        [Description("bj")]
        Benin,
        [Display(Name = "Bermuda")]
        [Description("bm")]
        Bermuda,
        [Display(Name = "Bhutan")]
        [Description("bt")]
        Bhutan,
        [Display(Name = "Bolivia")]
        [Description("bo")]
        Bolivia,
        [Display(Name = "Bonaire, Sint Eustatius and Saba")]
        [Description("bq")]
        Bonaire_Sint_Eustatius_and_Saba,
        [Display(Name = "Bosnia and Herzegovina")]
        [Description("ba")]
        Bosnia_and_Herzegovina,
        [Display(Name = "Botswana")]
        [Description("bw")]
        Botswana,
        [Display(Name = "Bouvet Island")]
        [Description("bv")]
        Bouvet_Island,
        [Display(Name = "Brazil")]
        [Description("br")]
        Brazil,
        [Display(Name = "British Indian Ocean Territory")]
        [Description("io")]
        British_Indian_Ocean_Territory,
        [Display(Name = "British Virgin Islands")]
        [Description("vg")]
        British_Virgin_Islands,
        [Display(Name = "Brunei Darussalam")]
        [Description("bn")]
        Brunei_Darussalam,
        [Display(Name = "Bulgaria")]
        [Description("bg")]
        Bulgaria,
        [Display(Name = "Burkina Faso")]
        [Description("bf")]
        Burkina_Faso,
        [Display(Name = "Burma")]
        [Description("bumm")]
        Burma,
        [Display(Name = "Burundi")]
        [Description("bi")]
        Burundi,
        [Display(Name = "Cambodia")]
        [Description("kh")]
        Cambodia,
        [Display(Name = "Cameroon")]
        [Description("cm")]
        Cameroon,
        [Display(Name = "Canada")]
        [Description("ca")]
        Canada,
        [Display(Name = "Cape Verde")]
        [Description("cv")]
        Cape_Verde,
        [Display(Name = "Cayman Islands")]
        [Description("ky")]
        Cayman_Islands,
        [Display(Name = "Central African Republic")]
        [Description("cf")]
        Central_African_Republic,
        [Display(Name = "Chad")]
        [Description("td")]
        Chad,
        [Display(Name = "Chile")]
        [Description("cl")]
        Chile,
        [Display(Name = "China")]
        [Description("cn")]
        China,
        [Display(Name = "Christmas Island")]
        [Description("cx")]
        Christmas_Island,
        [Display(Name = "Cocos (Keeling) Islands")]
        [Description("cc")]
        Cocos_Keeling_Islands,
        [Display(Name = "Colombia")]
        [Description("co")]
        Colombia,
        [Display(Name = "Comoros")]
        [Description("km")]
        Comoros,
        [Display(Name = "Congo")]
        [Description("cg")]
        Congo,
        [Display(Name = "Cook Islands")]
        [Description("ck")]
        Cook_Islands,
        [Display(Name = "Costa Rica")]
        [Description("cr")]
        Costa_Rica,
        [Display(Name = "Côte d'Ivoire")]
        [Description("ci")]
        Cote_d_Ivoire,
        [Display(Name = "Croatia")]
        [Description("hr")]
        Croatia,
        [Display(Name = "Cuba")]
        [Description("cu")]
        Cuba,
        [Display(Name = "Cyprus")]
        [Description("cy")]
        Cyprus,
        [Display(Name = "Czech Republic")]
        [Description("cz")]
        Czech_Republic,
        [Display(Name = "Czechoslovakia")]
        [Description("cshh")]
        Czechoslovakia,
        [Display(Name = "Democratic Republic of the Congo")]
        [Description("cd")]
        Democratic_Republic_of_the_Congo,
        [Display(Name = "Denmark")]
        [Description("dk")]
        Denmark,
        [Display(Name = "Djibouti")]
        [Description("dj")]
        Djibouti,
        [Display(Name = "Dominica")]
        [Description("dm")]
        Dominica,
        [Display(Name = "Dominican Republic")]
        [Description("do")]
        Dominican_Republic,
        [Display(Name = "East Germany")]
        [Description("ddde")]
        East_Germany,
        [Display(Name = "Ecuador")]
        [Description("ec")]
        Ecuador,
        [Display(Name = "Egypt")]
        [Description("eg")]
        Egypt,
        [Display(Name = "El Salvador")]
        [Description("sv")]
        El_Salvador,
        [Display(Name = "Equatorial Guinea")]
        [Description("gq")]
        Equatorial_Guinea,
        [Display(Name = "Eritrea")]
        [Description("er")]
        Eritrea,
        [Display(Name = "Estonia")]
        [Description("ee")]
        Estonia,
        [Display(Name = "Ethiopia")]
        [Description("et")]
        Ethiopia,
        [Display(Name = "Falkland Islands")]
        [Description("fk")]
        Falkland_Islands,
        [Display(Name = "Faroe Islands")]
        [Description("fo")]
        Faroe_Islands,
        [Display(Name = "Federal Republic of Yugoslavia")]
        [Description("yucs")]
        Federal_Republic_of_Yugoslavia,
        [Display(Name = "Federated States of Micronesia")]
        [Description("fm")]
        Federated_States_of_Micronesia,
        [Display(Name = "Fiji")]
        [Description("fj")]
        Fiji,
        [Display(Name = "Finland")]
        [Description("fi")]
        Finland,
        [Display(Name = "France")]
        [Description("fr")]
        France,
        [Display(Name = "French Guiana")]
        [Description("gf")]
        French_Guiana,
        [Display(Name = "French Polynesia")]
        [Description("pf")]
        French_Polynesia,
        [Display(Name = "French Southern Territories")]
        [Description("tf")]
        French_Southern_Territories,
        [Display(Name = "Gabon")]
        [Description("ga")]
        Gabon,
        [Display(Name = "Gambia")]
        [Description("gm")]
        Gambia,
        [Display(Name = "Georgia")]
        [Description("ge")]
        Georgia,
        [Display(Name = "Germany")]
        [Description("de")]
        Germany,
        [Display(Name = "Ghana")]
        [Description("gh")]
        Ghana,
        [Display(Name = "Gibraltar")]
        [Description("gi")]
        Gibraltar,
        [Display(Name = "Greece")]
        [Description("gr")]
        Greece,
        [Display(Name = "Greenland")]
        [Description("gl")]
        Greenland,
        [Display(Name = "Grenada")]
        [Description("gd")]
        Grenada,
        [Display(Name = "Guadeloupe")]
        [Description("gp")]
        Guadeloupe,
        [Display(Name = "Guam")]
        [Description("gu")]
        Guam,
        [Display(Name = "Guatemala")]
        [Description("gt")]
        Guatemala,
        [Display(Name = "Guernsey")]
        [Description("gg")]
        Guernsey,
        [Display(Name = "Guinea")]
        [Description("gn")]
        Guinea,
        [Display(Name = "Guinea-Bissau")]
        [Description("gw")]
        Guinea_Bissau,
        [Display(Name = "Guyana")]
        [Description("gy")]
        Guyana,
        [Display(Name = "Haiti")]
        [Description("ht")]
        Haiti,
        [Display(Name = "Heard Island and McDonald Islands")]
        [Description("hm")]
        Heard_Island_and_McDonald_Islands,
        [Display(Name = "Holy See (Vatican City State)")]
        [Description("va")]
        Holy_See_Vatican_City_State,
        [Display(Name = "Honduras")]
        [Description("hn")]
        Honduras,
        [Display(Name = "Hong Kong")]
        [Description("hk")]
        Hong_Kong,
        [Display(Name = "Hungary")]
        [Description("hu")]
        Hungary,
        [Display(Name = "Iceland")]
        [Description("is")]
        Iceland,
        [Display(Name = "India")]
        [Description("in")]
        India,
        [Display(Name = "Indonesia")]
        [Description("id")]
        Indonesia,
        [Display(Name = "Iran")]
        [Description("ir")]
        Iran,
        [Display(Name = "Iraq")]
        [Description("iq")]
        Iraq,
        [Display(Name = "Ireland")]
        [Description("ie")]
        Ireland,
        [Display(Name = "Isle of Man")]
        [Description("im")]
        Isle_of_Man,
        [Display(Name = "Israel")]
        [Description("il")]
        Israel,
        [Display(Name = "Italy")]
        [Description("it")]
        Italy,
        [Display(Name = "Jamaica")]
        [Description("jm")]
        Jamaica,
        [Display(Name = "Japan")]
        [Description("jp")]
        Japan,
        [Display(Name = "Jersey")]
        [Description("je")]
        Jersey,
        [Display(Name = "Jordan")]
        [Description("jo")]
        Jordan,
        [Display(Name = "Kazakhstan")]
        [Description("kz")]
        Kazakhstan,
        [Display(Name = "Kenya")]
        [Description("ke")]
        Kenya,
        [Display(Name = "Kiribati")]
        [Description("ki")]
        Kiribati,
        [Display(Name = "Korea")]
        [Description("xko")]
        Korea,
        [Display(Name = "Kosovo")]
        [Description("xkv")]
        Kosovo,
        [Display(Name = "Kuwait")]
        [Description("kw")]
        Kuwait,
        [Display(Name = "Kyrgyzstan")]
        [Description("kg")]
        Kyrgyzstan,
        [Display(Name = "Laos")]
        [Description("la")]
        Laos,
        [Display(Name = "Latvia")]
        [Description("lv")]
        Latvia,
        [Display(Name = "Lebanon")]
        [Description("lb")]
        Lebanon,
        [Display(Name = "Lesotho")]
        [Description("ls")]
        Lesotho,
        [Display(Name = "Liberia")]
        [Description("lr")]
        Liberia,
        [Display(Name = "Libya")]
        [Description("ly")]
        Libya,
        [Display(Name = "Liechtenstein")]
        [Description("li")]
        Liechtenstein,
        [Display(Name = "Lithuania")]
        [Description("lt")]
        Lithuania,
        [Display(Name = "Luxembourg")]
        [Description("lu")]
        Luxembourg,
        [Display(Name = "Macao")]
        [Description("mo")]
        Macao,
        [Display(Name = "Madagascar")]
        [Description("mg")]
        Madagascar,
        [Display(Name = "Malawi")]
        [Description("mw")]
        Malawi,
        [Display(Name = "Malaysia")]
        [Description("my")]
        Malaysia,
        [Display(Name = "Maldives")]
        [Description("mv")]
        Maldives,
        [Display(Name = "Mali")]
        [Description("ml")]
        Mali,
        [Display(Name = "Malta")]
        [Description("mt")]
        Malta,
        [Display(Name = "Marshall Islands")]
        [Description("mh")]
        Marshall_Islands,
        [Display(Name = "Martinique")]
        [Description("mq")]
        Martinique,
        [Display(Name = "Mauritania")]
        [Description("mr")]
        Mauritania,
        [Display(Name = "Mauritius")]
        [Description("mu")]
        Mauritius,
        [Display(Name = "Mayotte")]
        [Description("yt")]
        Mayotte,
        [Display(Name = "Mexico")]
        [Description("mx")]
        Mexico,
        [Display(Name = "Moldova")]
        [Description("md")]
        Moldova,
        [Display(Name = "Monaco")]
        [Description("mc")]
        Monaco,
        [Display(Name = "Mongolia")]
        [Description("mn")]
        Mongolia,
        [Display(Name = "Montenegro")]
        [Description("me")]
        Montenegro,
        [Display(Name = "Montserrat")]
        [Description("ms")]
        Montserrat,
        [Display(Name = "Morocco")]
        [Description("ma")]
        Morocco,
        [Display(Name = "Mozambique")]
        [Description("mz")]
        Mozambique,
        [Display(Name = "Myanmar")]
        [Description("mm")]
        Myanmar,
        [Display(Name = "Namibia")]
        [Description("na")]
        Namibia,
        [Display(Name = "Nauru")]
        [Description("nr")]
        Nauru,
        [Display(Name = "Nepal")]
        [Description("np")]
        Nepal,
        [Display(Name = "Netherlands")]
        [Description("nl")]
        Netherlands,
        [Display(Name = "Netherlands Antilles")]
        [Description("an")]
        Netherlands_Antilles,
        [Display(Name = "New Caledonia")]
        [Description("nc")]
        New_Caledonia,
        [Display(Name = "New Zealand")]
        [Description("nz")]
        New_Zealand,
        [Display(Name = "Nicaragua")]
        [Description("ni")]
        Nicaragua,
        [Display(Name = "Niger")]
        [Description("ne")]
        Niger,
        [Display(Name = "Nigeria")]
        [Description("ng")]
        Nigeria,
        [Display(Name = "Niue")]
        [Description("nu")]
        Niue,
        [Display(Name = "Norfolk Island")]
        [Description("nf")]
        Norfolk_Island,
        [Display(Name = "North Korea")]
        [Description("kp")]
        North_Korea,
        [Display(Name = "North Vietnam")]
        [Description("vdvn")]
        North_Vietnam,
        [Display(Name = "Northern Mariana Islands")]
        [Description("mp")]
        Northern_Mariana_Islands,
        [Display(Name = "Norway")]
        [Description("no")]
        Norway,
        [Display(Name = "Oman")]
        [Description("om")]
        Oman,
        [Display(Name = "Pakistan")]
        [Description("pk")]
        Pakistan,
        [Display(Name = "Palau")]
        [Description("pw")]
        Palau,
        [Display(Name = "Palestine")]
        [Description("xpi")]
        Palestine,
        [Display(Name = "Palestinian Territory")]
        [Description("ps")]
        Palestinian_Territory,
        [Display(Name = "Panama")]
        [Description("pa")]
        Panama,
        [Display(Name = "Papua New Guinea")]
        [Description("pg")]
        Papua_New_Guinea,
        [Display(Name = "Paraguay")]
        [Description("py")]
        Paraguay,
        [Display(Name = "Peru")]
        [Description("pe")]
        Peru,
        [Display(Name = "Philippines")]
        [Description("ph")]
        Philippines,
        [Display(Name = "Poland")]
        [Description("pl")]
        Poland,
        [Display(Name = "Portugal")]
        [Description("pt")]
        Portugal,
        [Display(Name = "Pitcairn")]
        [Description("pn")]
        Pitcairn,
        [Display(Name = "Puerto Rico")]
        [Description("pr")]
        Puerto_Rico,
        [Display(Name = "Qatar")]
        [Description("qa")]
        Qatar,
        [Display(Name = "Republic of Macedonia")]
        [Description("mk")]
        Republic_of_Macedonia,
        [Display(Name = "Réunion")]
        [Description("re")]
        Reunion,
        [Display(Name = "Romania")]
        [Description("ro")]
        Romania,
        [Display(Name = "Russia")]
        [Description("ru")]
        Russia,
        [Display(Name = "Rwanda")]
        [Description("rw")]
        Rwanda,
        [Display(Name = "Saint Barthélemy")]
        [Description("bl")]
        Saint_Barthelemy,
        [Display(Name = "Saint Helena")]
        [Description("sh")]
        Saint_Helena,
        [Display(Name = "Saint Kitts and Nevis")]
        [Description("kn")]
        Saint_Kitts_and_Nevis,
        [Display(Name = "Saint Lucia")]
        [Description("lc")]
        Saint_Lucia,
        [Display(Name = "Saint Martin (French part)")]
        [Description("mf")]
        Saint_Martin_French_part,
        [Display(Name = "Saint Pierre and Miquelon")]
        [Description("pm")]
        Saint_Pierre_and_Miquelon,
        [Display(Name = "Saint Vincent and the Grenadines")]
        [Description("vc")]
        Saint_Vincent_and_the_Grenadines,
        [Display(Name = "Samoa")]
        [Description("ws")]
        Samoa,
        [Display(Name = "San Marino")]
        [Description("sm")]
        San_Marino,
        [Display(Name = "Sao Tome and Principe")]
        [Description("st")]
        Sao_Tome_and_Principe,
        [Display(Name = "Saudi Arabia")]
        [Description("sa")]
        Saudi_Arabia,
        [Display(Name = "Senegal")]
        [Description("sn")]
        Senegal,
        [Display(Name = "Serbia")]
        [Description("rs")]
        Serbia,
        [Display(Name = "Serbia and Montenegro")]
        [Description("csxx")]
        Serbia_and_Montenegro,
        [Display(Name = "Seychelles")]
        [Description("sc")]
        Seychelles,
        [Display(Name = "Siam")]
        [Description("xsi")]
        Siam,
        [Display(Name = "Sierra Leone")]
        [Description("sl")]
        Sierra_Leone,
        [Display(Name = "Singapore")]
        [Description("sg")]
        Singapore,
        [Display(Name = "Slovakia")]
        [Description("sk")]
        Slovakia,
        [Display(Name = "Slovenia")]
        [Description("si")]
        Slovenia,
        [Display(Name = "Solomon Islands")]
        [Description("sb")]
        Solomon_Islands,
        [Display(Name = "Somalia")]
        [Description("so")]
        Somalia,
        [Display(Name = "South Africa")]
        [Description("za")]
        South_Africa,
        [Display(Name = "South Georgia and the South Sandwich Islands")]
        [Description("gs")]
        South_Georgia_and_the_South_Sandwich_Islands,
        [Display(Name = "South Korea")]
        [Description("kr")]
        South_Korea,
        [Display(Name = "Soviet Union")]
        [Description("suhh")]
        Soviet_Union,
        [Display(Name = "Spain")]
        [Description("es")]
        Spain,
        [Display(Name = "Sri Lanka")]
        [Description("lk")]
        Sri_Lanka,
        [Display(Name = "Sudan")]
        [Description("sd")]
        Sudan,
        [Display(Name = "Suriname")]
        [Description("sr")]
        Suriname,
        [Display(Name = "Svalbard and Jan Mayen")]
        [Description("sj")]
        Svalbard_and_Jan_Mayen,
        [Display(Name = "Swaziland")]
        [Description("sz")]
        Swaziland,
        [Display(Name = "Sweden")]
        [Description("se")]
        Sweden,
        [Display(Name = "Switzerland")]
        [Description("ch")]
        Switzerland,
        [Display(Name = "Syria")]
        [Description("sy")]
        Syria,
        [Display(Name = "Taiwan")]
        [Description("tw")]
        Taiwan,
        [Display(Name = "Tajikistan")]
        [Description("tj")]
        Tajikistan,
        [Display(Name = "Tanzania")]
        [Description("tz")]
        Tanzania,
        [Display(Name = "Thailand")]
        [Description("th")]
        Thailand,
        [Display(Name = "Timor-Leste")]
        [Description("tl")]
        Timor_Leste,
        [Display(Name = "Togo")]
        [Description("tg")]
        Togo,
        [Display(Name = "Tokelau")]
        [Description("tk")]
        Tokelau,
        [Display(Name = "Tonga")]
        [Description("to")]
        Tonga,
        [Display(Name = "Trinidad and Tobago")]
        [Description("tt")]
        Trinidad_and_Tobago,
        [Display(Name = "Tunisia")]
        [Description("tn")]
        Tunisia,
        [Display(Name = "Turkey")]
        [Description("tr")]
        Turkey,
        [Display(Name = "Turkmenistan")]
        [Description("tm")]
        Turkmenistan,
        [Display(Name = "Turks and Caicos Islands")]
        [Description("tc")]
        Turks_and_Caicos_Islands,
        [Display(Name = "Tuvalu")]
        [Description("tv")]
        Tuvalu,
        [Display(Name = "U.S. Virgin Islands")]
        [Description("vi")]
        US_Virgin_Islands,
        [Display(Name = "Uganda")]
        [Description("ug")]
        Uganda,
        [Display(Name = "Ukraine")]
        [Description("ua")]
        Ukraine,
        [Display(Name = "United Arab Emirates")]
        [Description("ae")]
        United_Arab_Emirates,
        [Display(Name = "United Kingdom")]
        [Description("gb")]
        United_Kingdom,
        [Display(Name = "United States")]
        [Description("us")]
        United_States,
        [Display(Name = "United States Minor Outlying Islands")]
        [Description("um")]
        United_States_Minor_Outlying_Islands,
        [Display(Name = "Uruguay")]
        [Description("uy")]
        Uruguay,
        [Display(Name = "Uzbekistan")]
        [Description("uz")]
        Uzbekistan,
        [Display(Name = "Vanuatu")]
        [Description("vu")]
        Vanuatu,
        [Display(Name = "Venezuela")]
        [Description("ve")]
        Venezuela,
        [Display(Name = "Vietnam")]
        [Description("vn")]
        Vietnam,
        [Display(Name = "Wallis and Futuna")]
        [Description("wf")]
        Wallis_and_Futuna,
        [Display(Name = "West Germany")]
        [Description("xwg")]
        West_Germany,
        [Display(Name = "Western Sahara")]
        [Description("eh")]
        Western_Sahara,
        [Display(Name = "Yemen")]
        [Description("ye")]
        Yemen,
        [Display(Name = "Yugoslavia")]
        [Description("xyu")]
        Yugoslavia,
        [Display(Name = "Zaire")]
        [Description("zrcd")]
        Zaire,
        [Display(Name = "Zambia")]
        [Description("zm")]
        Zambia,
        [Display(Name = "Zimbabwe")]
        [Description("zw")]
        Zimbabwe
    }
}