using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class EnUS {
        [JsonPropertyName("locale")]
        public string Locale {
            get; set;
        }
        [JsonPropertyName("url")]
        public string Url {
            get; set;
        }
        [JsonPropertyName("format")]
        public string Format {
            get; set;
        }
        [JsonPropertyName("hardsub_locale")]
        public string HardsubLocale {
            get; set;
        }
    }
}
