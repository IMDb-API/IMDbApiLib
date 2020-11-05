using IMDbApiLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public abstract class Utils
    {
        #region Ordinal Numbers
        public static Dictionary<int, string> GetOrdinalDic()
        {
            var dic = new Dictionary<int, string>
                {
                    { 1, "first" },
                    { 2, "second" },
                    { 3, "third" },
                    { 4, "fourth" },
                    { 5, "fifth" },
                    { 6, "sixth" },
                    { 7, "seventh" },
                    { 8, "eighth" },
                    { 9, "ninth" },
                    { 10, "tenth" },
                    { 11, "eleventh" },
                    { 12, "twelfth" },
                    { 13, "thirteenth" },
                    { 14, "fourteenth" },
                    { 15, "fifteenth" },
                    { 16, "sixteenth" },
                    { 17, "seventeenth" },
                    { 18, "eighteenth" },
                    { 19, "nineteenth" },
                    { 20, "twentieth" },
                    { 21, "twenty-first" },
                    { 22, "twenty-second" },
                    { 23, "twenty-third" },
                    { 24, "twenty-fourth" },
                    { 25, "twenty-fifth" },
                    { 26, "twenty-sixth" },
                    { 27, "twenty-seventh" },
                    { 28, "twenty-eighth" },
                    { 29, "twenty-ninth" },
                    { 30, "thirtieth" },
                    { 31, "thirty-first" },
                    { 32, "thirty-second" },
                    { 33, "thirty-third" },
                    { 34, "thirty-fourth" },
                    { 35, "thirty-fifth" },
                    { 36, "thirty-sixth" },
                    { 37, "thirty-seventh" },
                    { 38, "thirty-eighth" },
                    { 39, "thirty-ninth" },
                    { 40, "fortieth" },
                    { 41, "forty-first" },
                    { 42, "forty-second" },
                    { 43, "forty-third" },
                    { 44, "forty-fourth" },
                    { 45, "forty-fifth" },
                    { 46, "forty-sixth" },
                    { 47, "forty-seventh" },
                    { 48, "forty-eighth" },
                    { 49, "forty-ninth" },
                    { 50, "fiftieth" },
                    { 51, "fifty-first" },
                    { 52, "fifty-second" },
                    { 53, "fifty-third" },
                    { 54, "fifty-fourth" },
                    { 55, "fifty-fifth" },
                    { 56, "fifty-sixth" },
                    { 57, "fifty-seventh" },
                    { 58, "fifty-eighth" },
                    { 59, "fifty-ninth" },
                    { 60, "sixtieth" },
                    { 61, "sixty-first" },
                    { 62, "sixty-second" },
                    { 63, "sixty-third" },
                    { 64, "sixty-fourth" },
                    { 65, "sixty-fifth" },
                    { 66, "sixty-sixth" },
                    { 67, "sixty-seventh" },
                    { 68, "sixty-eighth" },
                    { 69, "sixty-ninth" },
                    { 70, "seventieth" },
                    { 71, "seventy-first" },
                    { 72, "seventy-second" },
                    { 73, "seventy-third" },
                    { 74, "seventy-fourth" },
                    { 75, "seventy-fifth" },
                    { 76, "seventy-sixth" },
                    { 77, "seventy-seventh" },
                    { 78, "seventy-eighth" },
                    { 79, "seventy-ninth" },
                    { 80, "seventieth" },
                    { 81, "eighty-first" },
                    { 82, "eighty-second" },
                    { 83, "eighty-third" },
                    { 84, "eighty-fourth" },
                    { 85, "eighty-fifth" },
                    { 86, "eighty-sixth" },
                    { 87, "eighty-seventh" },
                    { 88, "eighty-eighth" },
                    { 89, "eighty-ninth" },
                    { 90, "seventieth" },
                    { 91, "ninety-first" },
                    { 92, "ninety-second" },
                    { 93, "ninety-third" },
                    { 94, "ninety-fourth" },
                    { 95, "ninety-fifth" },
                    { 96, "ninety-sixth" },
                    { 97, "ninety-seventh" },
                    { 98, "ninety-eighth" },
                    { 99, "ninety-ninth" }
                };

            return dic;
        }
        #endregion

        #region Languages
        public static Dictionary<string, string> Languages
        {
            get
            {
                var languages = new Dictionary<string, string>();
                languages.Add("afrikaans", "af");
                languages.Add("albanian", "sq");
                languages.Add("arabic", "ar");
                languages.Add("armenian", "hy");
                languages.Add("azerbaijani", "az");
                languages.Add("basque", "eu");
                languages.Add("belarusian", "be");
                languages.Add("bengali", "bn");
                languages.Add("bulgarian", "bg");
                languages.Add("catalan", "ca");
                languages.Add("croatian", "hr");
                languages.Add("czech", "cs");
                languages.Add("danish", "da");
                languages.Add("dutch", "nl");
                languages.Add("english", "en");
                languages.Add("esperanto", "eo");
                languages.Add("estonian", "et");
                languages.Add("filipino", "tl");
                languages.Add("finnish", "fi");
                languages.Add("french", "fr");
                languages.Add("galician", "gl");
                languages.Add("german", "de");
                languages.Add("georgian", "ka");
                languages.Add("greek", "el");
                languages.Add("haitian creole", "ht");
                languages.Add("hebrew", "iw");
                languages.Add("hindi", "hi");
                languages.Add("hungarian", "hu");
                languages.Add("icelandic", "is");
                languages.Add("indonesian", "id");
                languages.Add("irish", "ga");
                languages.Add("italian", "it");
                languages.Add("japanese", "ja");
                languages.Add("korean", "ko");
                languages.Add("lao", "lo");
                languages.Add("latin", "la");
                languages.Add("latvian", "lv");
                languages.Add("lithuanian", "lt");
                languages.Add("macedonian", "mk");
                languages.Add("malay", "ms");
                languages.Add("maltese", "mt");
                languages.Add("norwegian", "no");
                languages.Add("polish", "pl");
                languages.Add("romanian", "ro");
                languages.Add("russian", "ru");
                languages.Add("serbian", "sr");
                languages.Add("slovak", "sk");
                languages.Add("slovenian", "sl");
                languages.Add("spanish", "es");
                languages.Add("swahili", "sw");
                languages.Add("swedish", "sv");
                languages.Add("tamil", "ta");
                languages.Add("telugu", "te");
                languages.Add("thai", "th");
                languages.Add("turkish", "tr");
                languages.Add("ukrainian", "uk");
                languages.Add("urdu", "ur");
                languages.Add("vietnamese", "vi");
                languages.Add("welsh", "cy");
                languages.Add("yiddish", "yi");
                languages.Add("burmese", "my");
                languages.Add("malayalam", "ml");

                languages.Add("farsi_persian", "fa");
                languages.Add("portuguese", "pt");
                languages.Add("brazillian-portuguese", "pt-BR");
                languages.Add("big_5_code", "b5c");
                languages.Add("chinese", "zh");
                languages.Add("chinese-bg-code", "zhbc");
                languages.Add("cambodian-khmer", "km");

                // Sort Languages
                var sortDic = new SortedDictionary<string, string>(languages);
                languages = new Dictionary<string, string>(sortDic);

                return languages;
            }
        }

        public static Dictionary<string, string> SubtitleLanguages
        {
            get
            {
                var languages = new Dictionary<string, string>();
                languages.Add("farsi_persian", "fa");

                return languages;
            }
        }
        #endregion

        #region GenerateRandom
        private static readonly Random _rnd = new Random();
        public static string GenerateRandom(int count)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                int num = _rnd.Next(1, 2 + 1);
                if (num <= 1)
                    num = _rnd.Next(97, 122 + 1); // a..z
                else if (num >= 2)
                    num = _rnd.Next(48, 57 + 1); // 0..9

                char c = Convert.ToChar(num);
                sb.Append(c);
            }

            return sb.ToString();
        }
        #endregion

        public static async Task<string> DownloadJsonAsync(string url, WebProxy webProxy = null)
        {
            try
            {
                string json = string.Empty;
                var client = new WebClient();
                if (webProxy != null)
                    client.Proxy = webProxy;
                client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 70.0.3538.77 Safari / 537.36");
                json = await client.DownloadStringTaskAsync(url);

                return json;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                {
                    var resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound) // HTTP 404
                    {
                        //Handle it
                    }
                    else if (resp.StatusCode == HttpStatusCode.BadRequest) // HTTP 400
                    {
                        //Handle it
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<T> DownloadObjectAsync<T>(string url, WebProxy webProxy = null)
        {
            try
            {
                var client = new WebClient();
                if (webProxy != null)
                    client.Proxy = webProxy;
                client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 70.0.3538.77 Safari / 537.36");
                string json = await client.DownloadStringTaskAsync(url);

                if (string.IsNullOrEmpty(json))
                    throw new Exception("Server Not Founded");

                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Percentage(long current, long maximum)
        {
            if (current < 0)
                current = 0;
            if (maximum < 1)
                maximum = 1;

            return Convert.ToInt32(((decimal)current / maximum) * 100);
        }

        public static async Task DownloadFileAsync(string filePath, string url, WebProxy webProxy = null)
        {
            try
            {
                using (var client = new WebClient())
                {
                    if (webProxy != null)
                        client.Proxy = webProxy;

                    await client.DownloadFileTaskAsync(url, filePath);
                }
            }
            catch
            { }
        }

        public static async Task DownloadImageAsync(string filePath, string url, WebProxy webProxy = null)
        {
            try
            {
                using (var client = new WebClient())
                {
                    if (webProxy != null)
                        client.Proxy = webProxy;

                    if (!File.Exists(filePath))
                    {
                        await client.DownloadFileTaskAsync(url, filePath);
                    }
                    else // Check equal
                    {
                        var bytes = await client.DownloadDataTaskAsync(url);
                        var img = BytesToImage(bytes);
                        var fi = new FileInfo(filePath);
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                        var sameFileNames = new DirectoryInfo(fi.DirectoryName).GetFiles($"{fileNameWithoutExtension}*.jpg").ToList();
                        bool isDupplicate = false;
                        foreach (var s in sameFileNames)
                        {
                            if (s.Length + 1024 > bytes.Length && s.Length - 1024 < bytes.Length)
                            {
                                isDupplicate = true;
                                break;
                            }
                        }

                        if (!isDupplicate)
                        {
                            string newFilePath = $"{fi.DirectoryName}\\{fileNameWithoutExtension}-{GenerateRandom(6)}{fi.Extension}";
                            img.Save(newFilePath, ImageFormat.Jpeg);
                        }
                    }

                }

            }
            catch
            {

            }
        }

        public static void RemoveDuplicatedFiles(string dir)
        {
            if (!Directory.Exists(dir))
                return;

            Directory.GetFiles(dir, "*.jpg")
                .Select(
                f => new
                {
                    FileName = f,
                    FileHash = GetHash(f)
                })
                .GroupBy(f => f.FileHash)
                .Select(g => new { FileHash = g.Key, Files = g.Select(z => z.FileName).ToList() })
                .SelectMany(f => f.Files.Skip(1))
                .ToList()
                .ForEach(File.Delete);
        }

        public static string GetHash(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Encoding.UTF8.GetString(new SHA1Managed().ComputeHash(fileStream));
            }
        }

        public static async Task<string> GetUrlFilenameAsync(string url, WebProxy webProxy = null)
        {
            try
            {
                string result = "";

                var req = WebRequest.Create(url);
                req.Method = "HEAD";
                if (webProxy != null)
                    req.Proxy = webProxy;

                using (var response = await req.GetResponseAsync())
                {
                    if (!string.IsNullOrEmpty(response.Headers["Content-Disposition"]))
                    {
                        result = response.Headers["Content-Disposition"].Substring(response.Headers["Content-Disposition"].IndexOf("filename=") + 9).Replace("\"", "");
                        result = Encoding.UTF8.GetString(Array.ConvertAll(System.Text.RegularExpressions.Regex.Unescape(result).ToCharArray(), c => (byte)c));
                        result = Path.GetInvalidFileNameChars().Aggregate(result, (current, c) => current.Replace(c.ToString(), string.Empty));
                        if (!string.IsNullOrEmpty(result) && result.Contains(";"))
                        {
                            int indexOf = result.IndexOf(";");
                            result = result.Substring(0, indexOf);
                        }
                    }
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] ImageToBytes(Image img)
        {
            return ImageToBytes(img, ImageFormat.Png);
        }

        public static byte[] ImageToBytes(Image img, Size size)
        {
            if (img == null)
                return null;

            if (img.Width > size.Width || img.Height > size.Height)
                img = ResizeImage(img, size);

            return ImageToBytes(img, ImageFormat.Png);
        }

        public static byte[] ImageToBytes(Image img, ImageFormat imgFormat)
        {
            if (img == null)
                return null;

            var ms = new MemoryStream();
            img.Save(ms, imgFormat);
            return ms.ToArray();
        }

        public static Image BytesToImage(byte[] bytes)
        {
            if (bytes == null)
                return null;

            var ms = new MemoryStream(bytes);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static Image BytesToImage(byte[] bytes, Size size)
        {
            if (bytes == null)
                return null;

            var img = BytesToImage(bytes);
            if (img.Width > size.Width || img.Height > size.Height)
                return ResizeImage(img, size);

            return img;
        }

        public static Image ResizeImage(Image img, Size size)
        {
            var ratioX = (double)size.Width / img.Width;
            var ratioY = (double)size.Height / img.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(img.Width * ratio);
            var newHeight = (int)(img.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(img, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public static string RenameToPhisicalName(string originalName)
        {
            originalName = originalName.Replace(":", " -");
            originalName = originalName.Replace("/", "-");
            originalName = originalName.Replace("\\", " - ");
            originalName = originalName.Replace("?", "");
            originalName = originalName.Replace("*", "");
            originalName = originalName.Replace("<", "");
            originalName = originalName.Replace(">", "");

            Path.GetInvalidFileNameChars().ToList().ForEach(ix => originalName = originalName.Replace(ix, ' '));

            return originalName;
        }

        public static string RemoveDlSiteName(string name, string removeSiteNames)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(removeSiteNames))
                return name;

            var dlSiteNames = removeSiteNames.Trim().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var dx in dlSiteNames)
            {
                if (!string.IsNullOrEmpty(dx))
                    name = name.Replace(dx, "");
            }

            name = name.Replace("[]", "").Replace("[l]", "").Replace("()", "");

            if (name.EndsWith(".") || name.EndsWith("_") || name.EndsWith("-"))
                name = name.Remove(name.Length - 1, 1);

            name = name.Trim();

            return name;
        }

        public static void Shutdown()
        {
            try
            {
                var process = new System.Diagnostics.ProcessStartInfo("shutdown", "/s /t 0");
                process.CreateNoWindow = true;
                process.UseShellExecute = false;
                System.Diagnostics.Process.Start(process);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<byte[]> DownloadDataAsync(string url, ProgressData progress = null, CancellationToken cancellationToken = default(CancellationToken), WebProxy webProxy = null)
        {
            try
            {
                byte[] bytes = null;
                using (var client = new WebClient())
                {
                    if (webProxy != null)
                        client.Proxy = webProxy;

                    client.DownloadProgressChanged += (s, e) => progress?.Report(e.BytesReceived, e.TotalBytesToReceive);
                    client.DownloadDataCompleted += (s, e) =>
                    {
                        if (e.Error != null || e.Cancelled)
                            bytes = null;

                        bytes = e.Result;
                    };

                    client.DownloadDataAsync(new Uri(url));

                    while (client.IsBusy)
                    {
                        if (cancellationToken.IsCancellationRequested)
                            throw new TaskCanceledException("Operation canceled by user.");

                        await Task.Delay(500);
                    }
                }

                return bytes;
            }
            catch
            {
                return null;
            }
        }

        public static List<string> GetSubtitleDataDirectoris(string movieRootDir, SubtitleData subtitleData)
        {
            var dirs = new List<string>();
            if (subtitleData is null || !string.IsNullOrEmpty(subtitleData.ErrorMessage))
                return dirs;

            movieRootDir = Path.Combine(movieRootDir, "Subtitles");
            dirs.Add(movieRootDir);

            bool hasFa = subtitleData.Subtitles != null && subtitleData.Subtitles.Count > 0;

            var seasons = new List<int?>();

            if (hasFa)
            {
                dirs.Add(Path.Combine(movieRootDir, SubtitleLanguage.Fa.ToString()));
                seasons.AddRange(subtitleData.Subtitles.Where(sx => sx.SeasonNumber.HasValue).Select(sx => sx.SeasonNumber).Distinct());
            }

            seasons = seasons.Distinct().ToList();
            if (hasFa)
                seasons.ForEach(sx => dirs.Add(Path.Combine(movieRootDir, Language.fa.ToString(), $"Season {sx.Value}")));

            return dirs;
        }

        public static void CreateSubtitleDataDirectoris(string movieRootDir, SubtitleData subtitleData)
        {
            var dirs = GetSubtitleDataDirectoris(movieRootDir, subtitleData);

            foreach (var d in dirs)
            {
                if (!Directory.Exists(d))
                    Directory.CreateDirectory(d);
            }
        }

        public static void CreateUrlShortcut(string dir, string fileName, string url)
        {
            if (string.IsNullOrEmpty(dir) || string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(url))
                return;

            string filePath = Path.Combine(dir, fileName);
            string content = $"[InternetShortcut]";
            content += Environment.NewLine;
            content += $"URL={url}";
            File.WriteAllText(filePath, content);
        }

        public static async Task<bool> PingAsync(string host)
        {
            try
            {
                var ping = new System.Net.NetworkInformation.Ping();
                var reply = await ping.SendPingAsync(host, 1000);

                return (reply.Status == System.Net.NetworkInformation.IPStatus.Success);
            }
            catch { return false; }
        }
    }
}
