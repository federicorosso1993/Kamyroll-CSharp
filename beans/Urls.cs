using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class Urls {
        [JsonPropertyName("softsub")]
        public Softsub Softsub {
            get; set;
        }
    }
}
