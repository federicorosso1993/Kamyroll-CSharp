using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class ServiceCr {
        [JsonPropertyName("cms")]
        public Cms Cms {
            get; set;
        }
        [JsonPropertyName("service_available")]
        public bool IsServiceAvailable {
            get; set;
        }
        [JsonPropertyName("default_marketing_opt_in")]
        public bool IsDefaultMarketingOptIn {
            get; set;
        }
    }
}
