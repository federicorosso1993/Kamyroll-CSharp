using System;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class User {
        [JsonPropertyName("@class")]
        public string AtClass {
            get; set;
        }
        [JsonPropertyName("user_id")]
        public string UserId {
            get; set;
        }
        [JsonPropertyName("etp_guid")]
        public string EtpGuid {
            get; set;
        }
        [JsonPropertyName("username")]
        public string Username {
            get; set;
        }
        [JsonPropertyName("email")]
        public string Email {
            get; set;
        }
        [JsonPropertyName("first_name")]
        public string FirstName {
            get; set;
        }
        [JsonPropertyName("last_name")]
        public string LastName {
            get; set;
        }
        [JsonPropertyName("premium")]
        public string Premium {
            get; set;
        }
        [JsonPropertyName("is_publisher")]
        public bool IsPublisher {
            get; set;
        }
        [JsonPropertyName("access_type")]
        public object AccessType {
            get; set;
        }
        [JsonPropertyName("created")]
        public DateTime Created {
            get; set;
        }
    }
}
