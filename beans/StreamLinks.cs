using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class StreamLinks {
        [JsonPropertyName("__class__")]
        public string UnderClass {
            get; set;
        }
        [JsonPropertyName("__href__")]
        public string Href {
            get; set;
        }
        [JsonPropertyName("__resource_key__")]
        public string ResourceKey {
            get; set;
        }
        [JsonPropertyName("__links__")]
        public Links Links {
            get; set;
        }
        [JsonPropertyName("__actions__")]
        public Actions Actions {
            get; set;
        }
        [JsonPropertyName("media_id")]
        public string MediaId {
            get; set;
        }
        [JsonPropertyName("audio_locale")]
        public string AudioLocale {
            get; set;
        }
        [JsonPropertyName("subtitles")]
        public Subtitles Subtitles {
            get; set;
        }
        [JsonPropertyName("captions")]
        public Captions Captions {
            get; set;
        }
        [JsonPropertyName("streams")]
        public Streams Streams {
            get; set;
        }
        [JsonPropertyName("bifs")]
        public List<string> Bifs {
            get; set;
        }
    }
}
