using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class Images {
        [JsonPropertyName("thumbnail")]
        public List<List<Thumbnail>> Thumbnail {
            get; set;
        }
    }
}
