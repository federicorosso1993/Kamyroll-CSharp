using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class CrSession {
        [JsonPropertyName("data")]
        public Data Data {
            get; set;
        }
        [JsonPropertyName("error")]
        public bool IsError {
            get; set;
        }
        [JsonPropertyName("code")]
        public string Code {
            get; set;
        }
    }
}
