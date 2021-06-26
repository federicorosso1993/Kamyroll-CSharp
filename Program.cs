﻿using System.Collections.Generic;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.Net.Http.Headers;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Kamyroll_CSharp {
    class Program {
        static HttpClient client = new HttpClient();
        static string tokenTypeG = "";
        static string accessTokenG = "";
        static List<string> linkdownloads = new List<string>();
        static string youtubeDlPath = "";
        static string dlPath = "";
        static ConfigObject config = new ConfigObject();

        static void Main(string[] args) {

            List<string> arguments = new List<string>(args);
            int indexLogin = arguments.FindIndex(a => a.Contains("--login")) + 1;

            int indexLink = arguments.FindIndex(a => a.Contains("--download")) + 1;
            while (arguments.Count > indexLink && !arguments[indexLink].Contains("--")) {
                linkdownloads.Add(arguments[indexLink]);
                indexLink++;
            }

            int indexYoutubeDlPath = arguments.FindIndex(a => a.Contains("--youtubedlpath")) + 1;
            while (arguments.Count > indexYoutubeDlPath && !arguments[indexYoutubeDlPath].Contains("--")) {
                youtubeDlPath = youtubeDlPath + arguments[indexYoutubeDlPath] + " ";
                indexYoutubeDlPath++;
            }
            youtubeDlPath = youtubeDlPath != "" ? youtubeDlPath.Substring(0, youtubeDlPath.Length - 1) : "";

            int indexDlPath = arguments.FindIndex(a => a.Contains("--dlpath")) + 1;
            while (arguments.Count > indexDlPath && !arguments[indexDlPath].Contains("--")) {
                dlPath = dlPath + arguments[indexDlPath] + " ";
                indexDlPath++;
            }
            dlPath = dlPath != "" ? dlPath.Substring(0, dlPath.Length - 1) : "";

            if (arguments.Contains("--login") && linkdownloads.Count > 0) {
                LoginAsync(arguments[indexLogin]).Wait();

                foreach(string linkdownload in linkdownloads) {
                    DownloadAsync(linkdownload).Wait();
                }
            } else {
                Console.WriteLine("Login and download link required");
            }
        }

        public static async Task LoginAsync(string argsLogin) {
            string email = "";
            string password = "";
            try {
                email = argsLogin.Split(":")[0].Trim();
                password = argsLogin.Split(":")[1].Trim();
            } catch {
                Console.WriteLine("Invalid login");
            }
            var endpoint = "https://api.crunchyroll.com/start_session.0.json?version=1.0&access_token=LNDJgOit5yaRIWN&device_type=com.crunchyroll.windows.desktop&device_id=Az2srGnChW65fuxYz2Xxl1GcZQgtGgI";
            try {
                HttpResponseMessage response = await client.GetAsync(endpoint);
                string responsestring = await response.Content.ReadAsStringAsync();
                CrSession crSession = JsonSerializer.Deserialize<CrSession>(responsestring);
                var sessionId = crSession.Data.SessionId;
                endpoint = "https://api.crunchyroll.com/login.0.json";
                var data = new Dictionary<string, string> {
                {
                    "session_id",
                    sessionId},
                {
                    "account",
                    email},
                {
                    "password",
                    password}
                };

                HttpResponseMessage response2 = await client.PostAsync(endpoint, new FormUrlEncodedContent(data));
                responsestring = await response2.Content.ReadAsStringAsync();
                StartSessionAsync(sessionId).Wait();
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        public static async Task StartSessionAsync(string sessionId) {
            string channel = "";
            var endpoint = "https://api.crunchyroll.com/start_session.0.json?session_id=" + sessionId;
            var cookieContainer = new CookieContainer();
            var uri = new Uri(endpoint);
            var etpRt = "";
            var premium = "";
            var countryCode = "";
            using (var httpClientHandler = new HttpClientHandler {
                CookieContainer = cookieContainer
            }) {
                using (var httpClient = new HttpClient(httpClientHandler)) {
                    var responseI = await httpClient.GetAsync(uri);
                    var cookie = cookieContainer.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "etp_rt");
                    etpRt = cookie.Value;
                    string responsestringI = await responseI.Content.ReadAsStringAsync();
                    Kamyroll_CSharp_Obj.CrSession crSession = JsonSerializer.Deserialize<Kamyroll_CSharp_Obj.CrSession>(responsestringI);
                    premium = crSession.Data.User.Premium;
                    countryCode = crSession.Data.CountryCode;
                }
            }

            if (premium == "") {
                channel = "-";
            } else {
                channel = "crunchyroll";
            }

            GetHeadersAsync(sessionId, etpRt).Wait();
            
            endpoint = "https://beta-api.crunchyroll.com/index/v2";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenTypeG, accessTokenG);
            HttpResponseMessage response = await client.GetAsync(endpoint);
            string responsestring = await response.Content.ReadAsStringAsync();
            ServiceCr serviceCr = JsonSerializer.Deserialize<ServiceCr>(responsestring);
            var policy = serviceCr.Cms.Policy;
            var signature = serviceCr.Cms.Signature;
            var keyPairId = serviceCr.Cms.KeyPairId;

            endpoint = "https://beta-api.crunchyroll.com/accounts/v1/me";
            response = await client.GetAsync(endpoint);
            responsestring = await response.Content.ReadAsStringAsync();
            CrId crId = JsonSerializer.Deserialize<CrId>(responsestring);
            var accountId = crId.AccountId;
            var externalId = crId.ExternalId;
            
            endpoint = "https://beta-api.crunchyroll.com/accounts/v1/me/profile";
            response = await client.GetAsync(endpoint);
            responsestring = await response.Content.ReadAsStringAsync();
            CrAccount crAccount = JsonSerializer.Deserialize<CrAccount>(responsestring);
            var maturityRating = crAccount.MaturityRating;

            config.SessionId = sessionId;
            config.EtpRt = etpRt;
            config.Channel = channel;
            config.CountryCode = countryCode;
            config.MaturityRating = maturityRating;
            config.Policy = policy;
            config.Signature = signature;
            config.KeyPairId = keyPairId;
            config.AccountId = accountId;
            config.ExternalId = externalId;
        }

        public static async Task GetHeadersAsync(string sessionId, string etpRt) {
            var endpoint = "https://beta-api.crunchyroll.com/auth/v1/token";
            var data = new Dictionary<string, string> {
                {
                    "grant_type",
                    "etp_rt_cookie"}};

            
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            
            var client2 = new HttpClient(handler);
            client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bm9haWhkZXZtXzZpeWcwYThsMHE6");
            cookieContainer.Add(new Uri(endpoint), new Cookie("session_id", sessionId));
            cookieContainer.Add(new Uri(endpoint), new Cookie("etp_rt", etpRt));

            try {
                HttpResponseMessage response = await client2.PostAsync(endpoint, new FormUrlEncodedContent(data));
                string responsestring = await response.Content.ReadAsStringAsync();
                AccessToken accessToken = JsonSerializer.Deserialize<AccessToken>(responsestring);
                var accessTokenIn = accessToken.AccessTokenIn;
                var tokenType = accessToken.TokenType;
                tokenTypeG = tokenType;
                accessTokenG = accessTokenIn;
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        public static async Task DownloadAsync(string linkdownload) {
            string episodecode = linkdownload.Split("/")[5];
            string endpoint = "https://beta-api.crunchyroll.com/cms/v2/" + config.CountryCode + "/" + config.MaturityRating + "/" + config.Channel + "/objects/" + episodecode + "?locale=" + GetLocale(config.CountryCode) + "&Signature=" + config.Signature + "&Policy=" + config.Policy + "&Key-Pair-Id=" + config.KeyPairId;
            try {
                HttpResponseMessage response = await client.GetAsync(endpoint);
                string responsestring = await response.Content.ReadAsStringAsync();
                StreamInfo streamInfo = JsonSerializer.Deserialize<StreamInfo>(responsestring);
                string serietitle = streamInfo.Items[0].EpisodeMetadata.SeasonTitle;
                string title = streamInfo.Items[0].Title;
                string episodenumber = config.CountryCode == "IT" ? "Episodio " + streamInfo.Items[0].EpisodeMetadata.EpisodeNumber : "Episode " + streamInfo.Items[0].EpisodeMetadata.EpisodeNumber;
                string streamid = streamInfo.Items[0].Links.Streams.Href.Split("/")[7] + "/" + streamInfo.Items[0].Links.Streams.Href.Split("/")[8];
                endpoint = "https://beta-api.crunchyroll.com/cms/v2/" + config.CountryCode + "/" + config.MaturityRating + "/" + config.Channel + "/videos/" + streamid + "?locale=" + GetLocale(config.CountryCode) + "&Signature=" + config.Signature + "&Policy=" + config.Policy + "&Key-Pair-Id=" + config.KeyPairId;
                response = await client.GetAsync(endpoint);
                responsestring = await response.Content.ReadAsStringAsync();
                responsestring = responsestring.Replace("\"\":", "\"softsub\":");
                Kamyroll_CSharp_Obj.StreamLinks streamLinks = JsonSerializer.Deserialize<Kamyroll_CSharp_Obj.StreamLinks>(responsestring);
                endpoint = streamLinks.Streams.AdaptiveHls.Softsub.Url;
                response = await client.GetAsync(endpoint);
                responsestring = await response.Content.ReadAsStringAsync();

                string maxres = "";

                if (responsestring.Split("RESOLUTION=1920x1080").Length > 1)
                    maxres = "1920x1080";
                else if (responsestring.Split("RESOLUTION=1280x720").Length > 1)
                    maxres = "1280x720";
                else if (responsestring.Split("RESOLUTION=848x480").Length > 1)
                    maxres = "848x480";
                else if (responsestring.Split("RESOLUTION=640x480").Length > 1)
                    maxres = "640x480";
                else if (responsestring.Split("RESOLUTION=640x360").Length > 1)
                    maxres = "640x360";
                else if (responsestring.Split("RESOLUTION=480x360").Length > 1)
                    maxres = "480x360";
                else if (responsestring.Split("RESOLUTION=428x240").Length > 1)
                    maxres = "428x240";
                else if (responsestring.Split("RESOLUTION=320x240").Length > 1)
                    maxres = "320x240";
                else
                    maxres = responsestring.Split("RESOLUTION=")[1].Substring(0, 7);

                string installationPath = dlPath == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) : dlPath;
                string installationYDlPath = youtubeDlPath == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) : youtubeDlPath;
                string titletotal = serietitle + " " + episodenumber + " – " + title + " - " + episodecode + ".mp4";

                Process proc = new Process();
                proc.StartInfo.FileName = "powershell.exe";
                proc.StartInfo.Arguments = "/c " + "cd " + installationPath.Substring(0, 1) + @":\" + "'" + installationPath.Substring(3) + "'; " + installationYDlPath.Substring(0, 1) + @":\" + "'" + installationYDlPath.Substring(3) + "'" + @"\./youtube-dl.exe --output " + "\"\"\"" + titletotal + "\"\"\" " + "'http" + responsestring.Split("RESOLUTION=" + maxres)[1].Split("http")[1].Split("#EXT-X-STREAM")[0] + "' --prefer-ffmpeg --no-check-certificate";
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                string subLang = GetLocale(config.CountryCode);
                try {
                    switch (subLang) {
                        case "es-LA":
                            endpoint = streamLinks.Subtitles.EsLA.Url;
                            break;
                        case "es-ES":
                            endpoint = streamLinks.Subtitles.EsES.Url;
                            break;
                        case "fr-FR":
                            endpoint = streamLinks.Subtitles.FrFR.Url;
                            break;
                        case "pt-BR":
                            endpoint = streamLinks.Subtitles.PtBR.Url;
                            break;
                        case "it-IT":
                            endpoint = streamLinks.Subtitles.ItIT.Url;
                            break;
                        case "de-DE":
                            endpoint = streamLinks.Subtitles.DeDE.Url;
                            break;
                        case "ru-RU":
                            endpoint = streamLinks.Subtitles.RuRU.Url;
                            break;
                        case "ar-ME":
                            endpoint = streamLinks.Subtitles.ArME.Url;
                            break;
                        default:
                            endpoint = streamLinks.Subtitles.EnUS.Url;
                            break;
                    }
                }catch {
                    subLang = "en-US";
                    endpoint = streamLinks.Subtitles.EnUS.Url;
                }
                
                response = await client.GetAsync(endpoint);
                responsestring = await response.Content.ReadAsStringAsync();
                string[] subtitles = { responsestring };
                await File.WriteAllLinesAsync(installationPath + @"\" + titletotal + "." + subLang + ".ass", subtitles);
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        private static string GetLocale(string countrycode) {
            switch (countrycode) {
                case "JP":
                    return "ja-JP";
                case "LA":
                    return "es-LA";
                case "ES":
                    return "es-ES";
                case "FR":
                    return "fr-FR";
                case "BR":
                    return "pt-BR";
                case "IT":
                    return "it-IT";
                case "DE":
                    return "de-DE";
                case "RU":
                    return "ru-RU";
                case "ME":
                    return "ar-ME";
                default:
                    return "en-US";
            }
        }
    }
}
