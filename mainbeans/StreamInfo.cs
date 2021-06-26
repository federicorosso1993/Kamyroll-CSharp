using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class StreamInfo {
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
        [JsonPropertyName("total")]
        public int Total {
            get; set;
        }
        [JsonPropertyName("items")]
        public List<Item> Items {
            get; set;
        }
    }
}
