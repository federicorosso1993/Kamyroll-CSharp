using System.Collections.Generic;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.Net.Http.Headers;

namespace Kamyroll_CSharp_Obj {
    public class User {
        public string @class {
            get; set;
        }
        public string user_id {
            get; set;
        }
        public string etp_guid {
            get; set;
        }
        public string username {
            get; set;
        }
        public string email {
            get; set;
        }
        public string first_name {
            get; set;
        }
        public string last_name {
            get; set;
        }
        public string premium {
            get; set;
        }
        public bool is_publisher {
            get; set;
        }
        public object access_type {
            get; set;
        }
        public DateTime created {
            get; set;
        }
    }

    public class Debug {
        public double init_app {
            get; set;
        }
        public double parsed_url {
            get; set;
        }
        public double auth_an_client {
            get; set;
        }
        public double locale {
            get; set;
        }
        public double selector_fields {
            get; set;
        }
        public double translations {
            get; set;
        }
        public double pre_view {
            get; set;
        }
        public double require_once {
            get; set;
        }
        public double connectivity_type {
            get; set;
        }
        public double device_registry {
            get; set;
        }
        public double api_auth {
            get; set;
        }
        public double ops {
            get; set;
        }
    }

    public class Data {
        public string session_id {
            get; set;
        }
        public string country_code {
            get; set;
        }
        public string ip {
            get; set;
        }
        public string device_type {
            get; set;
        }
        public string device_id {
            get; set;
        }
        public User user {
            get; set;
        }
        public object auth {
            get; set;
        }
        public DateTime expires {
            get; set;
        }
        public string version {
            get; set;
        }
        public List<object> ops {
            get; set;
        }
        public string connectivity_type {
            get; set;
        }
        public Debug debug {
            get; set;
        }
    }

    public class CrSession {
        public Data data {
            get; set;
        }
        public bool error {
            get; set;
        }
        public string code {
            get; set;
        }
    }
}

namespace Kamyroll_CSharp {

    public class LoginData {
        public string session_id {
            get; set;
        }

        public string account {
            get; set;
        }

        public string password {
            get; set;
        }
    }
    public class Debug {
        public double init_app {
            get; set;
        }
        public double parsed_url {
            get; set;
        }
        public double auth_an_client {
            get; set;
        }
        public double locale {
            get; set;
        }
        public double selector_fields {
            get; set;
        }
        public double translations {
            get; set;
        }
        public double pre_view {
            get; set;
        }
        public double require_once {
            get; set;
        }
        public double connectivity_type {
            get; set;
        }
        public double ops {
            get; set;
        }
    }

    public class Data {
        public string session_id {
            get; set;
        }
        public string country_code {
            get; set;
        }
        public string ip {
            get; set;
        }
        public string device_type {
            get; set;
        }
        public string device_id {
            get; set;
        }
        public string user {
            get; set;
        }
        public string auth {
            get; set;
        }
        public string expires {
            get; set;
        }
        public string version {
            get; set;
        }
        public List<string> ops {
            get; set;
        }
        public string connectivity_type {
            get; set;
        }
        public Debug debug {
            get; set;
        }
    }

    public class CrSession {
        public Data data {
            get; set;
        }
        public bool error {
            get; set;
        }
        public string code {
            get; set;
        }
    }

    public class AccessToken {
        public string access_token {
            get; set;
        }
        public int expires_in {
            get; set;
        }
        public string token_type {
            get; set;
        }
        public string scope {
            get; set;
        }
        public string country {
            get; set;
        }
    }

    public class Cms {
        public string bucket {
            get; set;
        }
        public string policy {
            get; set;
        }
        public string signature {
            get; set;
        }
        public string key_pair_id {
            get; set;
        }
        public DateTime expires {
            get; set;
        }
    }

    public class ServiceCr {
        public Cms cms {
            get; set;
        }
        public bool service_available {
            get; set;
        }
        public bool default_marketing_opt_in {
            get; set;
        }
    }

    public class CrId {
        public string account_id {
            get; set;
        }
        public string external_id {
            get; set;
        }
        public bool email_verified {
            get; set;
        }
        public DateTime created {
            get; set;
        }
    }

    public class CrAccount {
        public bool cr_beta_opt_in {
            get; set;
        }
        public bool crleg_email_verified {
            get; set;
        }
        public string email {
            get; set;
        }
        public string maturity_rating {
            get; set;
        }
        public bool opt_out_android_in_app_marketing {
            get; set;
        }
        public bool opt_out_free_trials {
            get; set;
        }
        public bool opt_out_new_media_queue_updates {
            get; set;
        }
        public bool opt_out_newsletters {
            get; set;
        }
        public bool opt_out_pm_updates {
            get; set;
        }
        public bool opt_out_promotional_updates {
            get; set;
        }
        public bool opt_out_queue_updates {
            get; set;
        }
        public bool opt_out_store_deals {
            get; set;
        }
        public bool qa_user {
            get; set;
        }
        public string username {
            get; set;
        }
    }


    class Program {
        static HttpClient client = new HttpClient();
        static string tokenTypeG = "";
        static string accessTokenG = "";
        static string linkdownload = "";

        static void Main(string[] args) {

            List<string> arguments = new List<string>(args);
            int indexLogin = arguments.FindIndex(a => a.Contains("--login")) + 1;

            int indexLink = arguments.FindIndex(a => a.Contains("--download")) + 1;
            linkdownload = arguments[indexLink];

            if (arguments.Contains("--login")) {
                LoginAsync(arguments[indexLogin], arguments.Contains("--us_unblocker")).Wait();

                //Download(linkdownload);
                //from link extract episode code example: https://beta.crunchyroll.com/it/watch/GN7UDWD1J/Ambizioni-e-scelte
                // GN7UDWD1J
                //api call to base url:
                //https://beta-api.crunchyroll.com/cms/v2/country_code/maturity_rating/channel/objects/episodecode?locale=getlocale&Signature=signature&Policy=policy&Key-Pair-Id=key_pair_id
                //getlocale (from country code) locale = "en-US" countries = ["", "JP", "US", "LA", "ES", "FR", "BR", "IT", "DE", "RU", "ME"] locales = ["", "ja-JP", "en-US", "es-LA", "es-ES", "fr-FR", "pt-BR", "it-IT", "de-DE", "ru-RU", "ar-ME"]
                //response.items[0].__links__.streams.href
                //from here we can continue with the original code
            } else {
                System.Diagnostics.Debug.WriteLine("Login or session required");
            }
        }

        public static async Task LoginAsync(string args_login, bool us_unblocker) {
            HttpClient clientProxy = null;
            string email = "";
            string password = "";
            try {
                email = args_login.Split(":")[0].Trim();
                password = args_login.Split(":")[1].Trim();
            } catch {
                Console.WriteLine("Invalid login");
            }
            var endpoint = "https://api.crunchyroll.com/start_session.0.json?version=1.0&access_token=LNDJgOit5yaRIWN&device_type=com.crunchyroll.windows.desktop&device_id=Az2srGnChW65fuxYz2Xxl1GcZQgtGgI";
            try {
                HttpResponseMessage response = await client.GetAsync(endpoint);
                string responsestring = await response.Content.ReadAsStringAsync();
                CrSession crSession = JsonSerializer.Deserialize<CrSession>(responsestring);
                if (us_unblocker) {
                    var handler = new HttpClientHandler();
                    var httpClientHandler = new HttpClientHandler {
                        Proxy = new WebProxy("http://149.28.96.242:3128", false),
                        UseProxy = true
                    };

                    clientProxy = new HttpClient(handler);
                }
                var session_id = crSession.data.session_id;
                endpoint = "https://api.crunchyroll.com/login.0.json";
                var data = new Dictionary<string, string> {
                {
                    "session_id",
                    session_id},
                {
                    "account",
                    email},
                {
                    "password",
                    password}
                };

                HttpResponseMessage response2 = await (us_unblocker ? clientProxy.PostAsync(endpoint, new FormUrlEncodedContent(data)) : client.PostAsync(endpoint, new FormUrlEncodedContent(data)));
                responsestring = await response2.Content.ReadAsStringAsync();
                StartSessionAsync(session_id, us_unblocker).Wait();
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        public static async Task StartSessionAsync(string session_id, bool us_unblocker) {
            string channel = "";
            var endpoint = "https://api.crunchyroll.com/start_session.0.json?session_id=" + session_id;
            var cookieContainer = new CookieContainer();
            var uri = new Uri(endpoint);
            var etp_rt = "";
            var premium = "";
            var country_code = "";
            using (var httpClientHandler = new HttpClientHandler {
                CookieContainer = cookieContainer
            }) {
                using (var httpClient = new HttpClient(httpClientHandler)) {
                    var responseI = await httpClient.GetAsync(uri);
                    var cookie = cookieContainer.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "etp_rt");
                    etp_rt = cookie.Value;
                    string responsestringI = await responseI.Content.ReadAsStringAsync();
                    Kamyroll_CSharp_Obj.CrSession crSession = JsonSerializer.Deserialize<Kamyroll_CSharp_Obj.CrSession>(responsestringI);
                    premium = crSession.data.user.premium;
                    country_code = crSession.data.country_code;
                }
            }

            if (premium == "") {
                channel = "-";
            } else {
                channel = "crunchyroll";
            }

            GetHeadersAsync(session_id, etp_rt, us_unblocker).Wait();
            
            endpoint = "https://beta-api.crunchyroll.com/index/v2";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenTypeG, accessTokenG);
            HttpResponseMessage response = await client.GetAsync(endpoint);
            string responsestring = await response.Content.ReadAsStringAsync();
            ServiceCr serviceCr = JsonSerializer.Deserialize<ServiceCr>(responsestring);
            var policy = serviceCr.cms.policy;
            var signature = serviceCr.cms.signature;
            var key_pair_id = serviceCr.cms.key_pair_id;

            endpoint = "https://beta-api.crunchyroll.com/accounts/v1/me";
            response = await client.GetAsync(endpoint);
            responsestring = await response.Content.ReadAsStringAsync();
            CrId crId = JsonSerializer.Deserialize<CrId>(responsestring);
            var account_id = crId.account_id;
            var external_id = crId.external_id;
            
            endpoint = "https://beta-api.crunchyroll.com/accounts/v1/me/profile";
            response = await client.GetAsync(endpoint);
            responsestring = await response.Content.ReadAsStringAsync();
            CrAccount crAccount = JsonSerializer.Deserialize<CrAccount>(responsestring);
            var maturity_rating = crAccount.maturity_rating;

            //create Config Object
            // session_id etp_rt us_unblocker channel country_code maturity_rating policy signature key_pair_id account_id external_id
        }

        public static async Task GetHeadersAsync(string session_id, string etp_rt, bool us_unblocker) {
            var endpoint = "https://beta-api.crunchyroll.com/auth/v1/token";
            var data = new Dictionary<string, string> {
                {
                    "grant_type",
                    "etp_rt_cookie"}};

            
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            if (us_unblocker) {
                handler.Proxy = new WebProxy("http://149.28.96.242:3128", false);
                handler.UseProxy = true;
            }
            var client2 = new HttpClient(handler);
            client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bm9haWhkZXZtXzZpeWcwYThsMHE6");
            cookieContainer.Add(new Uri(endpoint), new Cookie("session_id", session_id));
            cookieContainer.Add(new Uri(endpoint), new Cookie("etp_rt", etp_rt));

            try {
                HttpResponseMessage response = await client2.PostAsync(endpoint, new FormUrlEncodedContent(data));
                string responsestring = await response.Content.ReadAsStringAsync();
                AccessToken accessToken = JsonSerializer.Deserialize<AccessToken>(responsestring);
                var access_token = accessToken.access_token;
                var token_type = accessToken.token_type;
                tokenTypeG = token_type;
                accessTokenG = access_token;
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        //public static object get_formats(object arg_formats) {
        //    object id;
        //    object type;
        //    streams_id = arg_formats;
        //    var config = get_config();
        //    var endpoint = "https://beta-api.crunchyroll.com/cms/v2/{}/{}/{}/videos/{}/streams?locale={}&Signature={}&Policy={}&Key-Pair-Id={}".format(config.get("country_code"), config.get("maturity_rating"), config.get("channel"), streams_id, get_locale(), config.get("signature"), config.get("policy"), config.get("key_pair_id"));
        //    var r = requests.get(endpoint);
        //    var href = r.json().get("__links__").get("resource").get("href");
        //    if (href.Contains("movies")) {
        //        type = "movies";
        //        id = href.split("movies/")[1].split("/")[0].strip();
        //    } else {
        //        type = "episodes";
        //        id = href.split("episodes/")[1].split("/")[0].strip();
        //    }
        //    init_download(type, id);
        //    audio_locale = r.json().get("audio_locale");
        //    formats_subtitles(get_items(r.json().get("subtitles")));
        //    formats_videos(get_items(r.json().get("streams").get("adaptive_hls")));
        //}

        //public static object init_download(object type, object id) {
        //    object title;
        //    var config = get_config();
        //    var endpoint = "https://beta-api.crunchyroll.com/cms/v2/{}/{}/{}/{}/{}?locale={}&Signature={}&Policy={}&Key-Pair-Id={}".format(config.get("country_code"), config.get("maturity_rating"), config.get("channel"), type, id, get_locale(), config.get("signature"), config.get("policy"), config.get("key_pair_id"));
        //    var r = requests.get(endpoint);
        //    if (type == "movies") {
        //        title = r.json().get("title");
        //        var thumbnails = json.dumps(r.json().get("images").get("thumbnail")).replace("[", "").replace("]", "");
        //        var thumbnail = json.loads("[{}]".format(thumbnails));
        //        dl_path = check_characters(title);
        //        dl_title = check_characters(title);
        //        dl_cover = thumbnail[thumbnail.Count - 1].get("source");
        //    } else {
        //        var series_id = r.json().get("series_id");
        //        var series_title = r.json().get("series_title");
        //        var season_title = r.json().get("season_title");
        //        var season_number = r.json().get("season_number");
        //        var episode = r.json().get("episode");
        //        title = r.json().get("title");
        //        endpoint = "https://beta-api.crunchyroll.com/cms/v2/{}/{}/{}/series/{}?locale={}&Signature={}&Policy={}&Key-Pair-Id={}".format(config.get("country_code"), config.get("maturity_rating"), config.get("channel"), series_id, get_locale(), config.get("signature"), config.get("policy"), config.get("key_pair_id"));
        //        r = requests.get(endpoint);
        //        var poster_tall = json.dumps(r.json().get("images").get("poster_tall")).replace("[", "").replace("]", "");
        //        var poster = json.loads("[{}]".format(poster_tall));
        //        dl_path = check_characters("{}/S{} - {}".format(series_title, season_number, season_title));
        //        dl_title = check_characters("[S{}.Ep{}] {} - {}".format(season_number, episode, series_title, title));
        //        dl_cover = poster[poster.Count - 1].get("source");
        //    }
        //}

        //public static object formats_subtitles(object items) {
        //    subtitles_format_code = new List<object>();
        //    var locale = new List<object>();
        //    subtitles_url = new List<object>();
        //    subtitles_extension = new List<object>();
        //    foreach (var item in items) {
        //        locale.append(item.get("locale"));
        //        subtitles_url.append(item.get("url"));
        //        subtitles_extension.append(item.get("format"));
        //        subtitles_format_code.append("{}-subtitles-{}".format(streams_id, item.get("locale")));
        //    }
        //    if (display) {
        //        Console.WriteLine("\n[debug] Subtitles for {}:".format(streams_id));
        //        Console.WriteLine("{0:<40} {1:<20} {2:<20}".format("Format code", "Extension", "Language"));
        //        foreach (var i in Enumerable.Range(0, locale.Count)) {
        //            Console.WriteLine("{0:<40} {1:<20} {2:<20}".format(subtitles_format_code[i], subtitles_extension[i], get_locale_title(locale[i])));
        //        }
        //    }
        //}

        //public static object formats_videos(object items) {
        //    videos_format_code = new List<object>();
        //    var resolutions = new List<object>();
        //    var note = new List<object>();
        //    videos_url = new List<object>();
        //    var index = 1;
        //    foreach (var item in items) {
        //        var hardsub_locale = item.get("hardsub_locale");
        //        var r = requests.get(item.get("url"));
        //        var streams = r.text.split("#EXT-X-STREAM");
        //        foreach (var stream in streams) {
        //            if (stream.Contains("RESOLUTION")) {
        //                var bandwidth = stream.split("BANDWIDTH=")[1].split(",")[0].strip();
        //                var resolution = stream.split("RESOLUTION=")[1].split(",")[0].strip();
        //                var frame_rate = stream.split("FRAME-RATE=")[1].split(",")[0].strip();
        //                var codecs = stream.split("CODECS=\"")[1].split("\"")[0].strip();
        //                var url = "http{}".format(stream.split("http")[1].strip());
        //                var format = "{}-video".format(streams_id);
        //                if (hardsub_locale != "") {
        //                    format = "{}-hardsub-{}".format(format, hardsub_locale);
        //                }
        //                format = "{}-{}".format(format, index);
        //                videos_format_code.append(format);
        //                resolutions.append(resolution);
        //                note.append("[{}] {}k , {}, {}, {}".format(audio_locale, bandwidth, codecs.split(",")[0].strip(), frame_rate, codecs.split(",")[1].strip()));
        //                videos_url.append(url);
        //                index += 1;
        //            }
        //        }
        //    }
        //    if (display) {
        //        Console.WriteLine("\n[debug] Videos for {}:".format(streams_id));
        //        Console.WriteLine("{0:<40} {1:<20} {2:<20} {3:<40}".format("Format code", "Extension", "Resolution", "Note"));
        //        foreach (var i in Enumerable.Range(0, videos_format_code.Count)) {
        //            Console.WriteLine("{0:<40} {1:<20} {2:<20} {3:<40}".format(videos_format_code[i], "mp4", resolutions[i], note[i]));
        //        }
        //    }
        //}

        //public static object download(object args_download, object args_format) {
        //    var stream_id = args_download;
        //    dl_format = args_format;
        //    Console.WriteLine("[debug] Loading formats");
        //    get_formats(stream_id);
        //    dl_url = "";
        //    dl_extension = "";
        //    if (dl_format.Contains("video")) {
        //        foreach (var i in Enumerable.Range(0, videos_format_code.Count)) {
        //            if (dl_format == videos_format_code[i]) {
        //                dl_url = videos_url[i];
        //                dl_extension = "mp4";
        //                break;
        //            }
        //        }
        //    } else if (dl_format.Contains("subtitles")) {
        //        foreach (var i in Enumerable.Range(0, subtitles_format_code.Count)) {
        //            if (dl_format == subtitles_format_code[i]) {
        //                dl_url = subtitles_url[i];
        //                dl_extension = subtitles_extension[i];
        //                break;
        //            }
        //        }
        //    } else {
        //        Console.WriteLine("ERROR: Format not found");
        //        sys.exit(0);
        //    }
        //    if (dl_url != "" && dl_extension != "") {
        //        create_folder();
        //        download_cover();
        //        if (dl_format.Contains("video")) {
        //            download_video();
        //        } else {
        //            download_subtitles();
        //        }
        //    } else {
        //        Console.WriteLine("ERROR: Data loading error");
        //        sys.exit(0);
        //    }
        //}

        //public static object download_cover() {
        //    if (os.path.isfile("{}\\{}\\cover.jpg".format(dl_root, dl_path))) {
        //        os.remove("{}\\{}\\cover.jpg".format(dl_root, dl_path));
        //    }
        //    Console.WriteLine("[debug] Cover download");
        //    var response = requests.get(dl_cover);
        //    var file = open("{}\\{}\\cover.jpg".format(dl_root, dl_path), "wb");
        //    file.write(response.content);
        //    file.close();
        //}
    }
}
