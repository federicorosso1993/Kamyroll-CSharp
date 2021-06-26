using System;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class CrId {
        [JsonPropertyName("account_id")]
        public string AccountId {
            get; set;
        }
        [JsonPropertyName("external_id")]
        public string ExternalId {
            get; set;
        }
        [JsonPropertyName("email_verified")]
        public bool IsEmailVerified {
            get; set;
        }
        [JsonPropertyName("created")]
        public DateTime Created {
            get; set;
        }
    }
}
