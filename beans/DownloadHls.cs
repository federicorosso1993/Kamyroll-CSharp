using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class DownloadHls {
        [JsonPropertyName("softsub")]
        public Softsub Softsub {
            get; set;
        }
    }
}
