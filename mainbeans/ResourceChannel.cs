using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class ResourceChannel {
        [JsonPropertyName("href")]
        public string Href {
            get; set;
        }
    }
}
