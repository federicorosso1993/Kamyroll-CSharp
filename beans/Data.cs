using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class Data {
        [JsonPropertyName("session_id")]
        public string SessionId {
            get; set;
        }
        [JsonPropertyName("country_code")]
        public string CountryCode {
            get; set;
        }
        [JsonPropertyName("ip")]
        public string Ip {
            get; set;
        }
        [JsonPropertyName("device_type")]
        public string DeviceType {
            get; set;
        }
        [JsonPropertyName("device_id")]
        public string DeviceId {
            get; set;
        }
        [JsonPropertyName("user")]
        public User User {
            get; set;
        }
        [JsonPropertyName("auth")]
        public object Auth {
            get; set;
        }
        [JsonPropertyName("expires")]
        public DateTime Expires {
            get; set;
        }
        [JsonPropertyName("version")]
        public string Version {
            get; set;
        }
        [JsonPropertyName("ops")]
        public List<object> Ops {
            get; set;
        }
        [JsonPropertyName("connectivity_type")]
        public string ConnectivityType {
            get; set;
        }
        [JsonPropertyName("debug")]
        public Debug Debug {
            get; set;
        }
    }
}
