﻿using IMDbApiLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public abstract class ApiUtils
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

        #region Others
        public static int Percentage(long current, long total)
        {
            if (current < 0)
                current = 0;
            if (total < 1)
                total = 1;

            return Convert.ToInt32(((decimal)current / total) * 100);
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

            var dlSiteNames = removeSiteNames.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
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
            catch
            {
                return false;
            }
        }
        #endregion

        #region Download
        public static async Task<string> GetStringAsync(string url, WebProxy webProxy = null)
        {
            try
            {
                string json = null;
                using (var webClient = new WebClient())
                {
                    if (webProxy != null)
                    {
                        webClient.Proxy = webProxy;
                    }

                    json = await webClient.DownloadStringTaskAsync(url);
                }

                return json;

                //var handler = new HttpClientHandler();
                //if (webProxy != null)
                //{
                //    handler.Proxy = webProxy;
                //    handler.UseProxy = true;
                //}

                //var httpClient = new HttpClient(handler);
                //return await httpClient.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<T> GetObjectAsync<T>(string url, WebProxy webProxy = null)
        {
            try
            {
                string json = await GetStringAsync(url, webProxy);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<byte[]> GetBytesAsync(string url, WebProxy webProxy = null)
        {
            try
            {
                byte[] bytes = null;
                using (var webClient = new WebClient())
                {
                    if (webProxy != null)
                    {
                        webClient.Proxy = webProxy;
                    }

                    bytes = await webClient.DownloadDataTaskAsync(new Uri(url));
                }

                return bytes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<byte[]> GetBytesAsync(string url, ProgressData progress, CancellationToken cancellationToken = default, WebProxy webProxy = null)
        {
            try
            {
                byte[] bytes = null;
                using (var client = new WebClient())
                {
                    if (webProxy != null)
                    {
                        client.Proxy = webProxy;
                    }

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task SaveFileAsync(string url, string filePath, WebProxy webProxy = null)
        {
            try
            {
                byte[] bytes = await GetBytesAsync(url, webProxy);
                File.WriteAllBytes(filePath, bytes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task SaveFileAsync(string url, string filePath, ProgressData progress, CancellationToken cancellationToken = default, WebProxy webProxy = null)
        {
            try
            {
                byte[] bytes = await GetBytesAsync(url, progress, cancellationToken, webProxy);
                File.WriteAllBytes(filePath, bytes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
