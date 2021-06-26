using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class Resource {
        [JsonPropertyName("href")]
        public string Href {
            get; set;
        }
    }
}
