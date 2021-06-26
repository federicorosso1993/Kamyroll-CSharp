using System;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class Cms {
        [JsonPropertyName("bucket")]
        public string Bucket {
            get; set;
        }
        [JsonPropertyName("policy")]
        public string Policy {
            get; set;
        }
        [JsonPropertyName("signature")]
        public string Signature {
            get; set;
        }
        [JsonPropertyName("key_pair_id")]
        public string KeyPairId {
            get; set;
        }
        [JsonPropertyName("expires")]
        public DateTime Expires {
            get; set;
        }
    }
}
