using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class Debug {
        [JsonPropertyName("init_app")]
        public double InitApp {
            get; set;
        }
        [JsonPropertyName("parsed_url")]
        public double ParsedUrl {
            get; set;
        }
        [JsonPropertyName("auth_an_client")]
        public double AuthAnClient {
            get; set;
        }
        [JsonPropertyName("locale")]
        public double Locale {
            get; set;
        }
        [JsonPropertyName("selector_fields")]
        public double SelectorFields {
            get; set;
        }
        [JsonPropertyName("translations")]
        public double Translations {
            get; set;
        }
        [JsonPropertyName("pre_view")]
        public double PreView {
            get; set;
        }
        [JsonPropertyName("require_once")]
        public double RequireOnce {
            get; set;
        }
        [JsonPropertyName("connectivity_type")]
        public double ConnectivityType {
            get; set;
        }
        [JsonPropertyName("device_registry")]
        public double DeviceRegistry {
            get; set;
        }
        [JsonPropertyName("api_auth")]
        public double ApiAuth {
            get; set;
        }
        [JsonPropertyName("ops")]
        public double Ops {
            get; set;
        }
    }
}
