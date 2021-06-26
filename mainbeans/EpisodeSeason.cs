using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class EpisodeSeason {
        [JsonPropertyName("href")]
        public string Href {
            get; set;
        }
    }
}
