using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class Links {
        [JsonPropertyName("episode/season")]
        public EpisodeSeason EpisodeSeason {
            get; set;
        }

        [JsonPropertyName("episode/series")]
        public EpisodeSeries EpisodeSeries {
            get; set;
        }
        [JsonPropertyName("resource")]
        public Resource Resource {
            get; set;
        }

        [JsonPropertyName("resource/channel")]
        public ResourceChannel ResourceChannel {
            get; set;
        }
        [JsonPropertyName("streams")]
        public Streams Streams {
            get; set;
        }
    }
}
