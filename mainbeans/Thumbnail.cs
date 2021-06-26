using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class Thumbnail {
        [JsonPropertyName("width")]
        public int Width {
            get; set;
        }
        [JsonPropertyName("height")]
        public int Height {
            get; set;
        }
        [JsonPropertyName("type")]
        public string Type {
            get; set;
        }
        [JsonPropertyName("source")]
        public string Source {
            get; set;
        }
    }
}
