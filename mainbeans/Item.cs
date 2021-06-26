using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class Item {
        [JsonPropertyName("__class__")]
        public string UnderClass {
            get; set;
        }
        [JsonPropertyName("__href__")]
        public string Href {
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
        [JsonPropertyName("id")]
        public string Id {
            get; set;
        }
        [JsonPropertyName("external_id")]
        public string ExternalId {
            get; set;
        }
        [JsonPropertyName("channel_id")]
        public string ChannelId {
            get; set;
        }
        [JsonPropertyName("title")]
        public string Title {
            get; set;
        }
        [JsonPropertyName("description")]
        public string Description {
            get; set;
        }
        [JsonPropertyName("promo_title")]
        public string PromoTitle {
            get; set;
        }
        [JsonPropertyName("promo_description")]
        public string PromoDescription {
            get; set;
        }
        [JsonPropertyName("type")]
        public string Type {
            get; set;
        }
        [JsonPropertyName("slug")]
        public string Slug {
            get; set;
        }
        [JsonPropertyName("slug_title")]
        public string SlugTitle {
            get; set;
        }
        [JsonPropertyName("images")]
        public Images Images {
            get; set;
        }
        [JsonPropertyName("episode_metadata")]
        public EpisodeMetadata EpisodeMetadata {
            get; set;
        }
        [JsonPropertyName("playback")]
        public string Playback {
            get; set;
        }
        [JsonPropertyName("linked_resource_key")]
        public string LinkedResourceKey {
            get; set;
        }
    }

}
