using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class Links {
        [JsonPropertyName("resource")]
        public Resource Resource {
            get; set;
        }
    }
}
