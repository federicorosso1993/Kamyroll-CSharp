using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class EpisodeSeries {
        [JsonPropertyName("href")]
        public string Href {
            get; set;
        }
    }
}
