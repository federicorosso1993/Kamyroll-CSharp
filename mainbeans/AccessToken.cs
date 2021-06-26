using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class AccessToken {
        [JsonPropertyName("access_token")]
        public string AccessTokenIn {
            get; set;
        }
        [JsonPropertyName("expires_in")]
        public int ExpiresIn {
            get; set;
        }
        [JsonPropertyName("token_type")]
        public string TokenType {
            get; set;
        }
        [JsonPropertyName("scope")]
        public string Scope {
            get; set;
        }
        [JsonPropertyName("country")]
        public string Country {
            get; set;
        }
    }
}
