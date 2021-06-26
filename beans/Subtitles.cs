using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class Subtitles {
        [JsonPropertyName("ar-ME")]
        public ArME ArME {
            get; set;
        }

        [JsonPropertyName("de-DE")]
        public DeDE DeDE {
            get; set;
        }

        [JsonPropertyName("en-US")]
        public EnUS EnUS {
            get; set;
        }

        [JsonPropertyName("es-ES")]
        public EsES EsES {
            get; set;
        }

        [JsonPropertyName("es-LA")]
        public EsLA EsLA {
            get; set;
        }

        [JsonPropertyName("fr-FR")]
        public FrFR FrFR {
            get; set;
        }

        [JsonPropertyName("it-IT")]
        public ItIT ItIT {
            get; set;
        }

        [JsonPropertyName("pt-BR")]
        public PtBR PtBR {
            get; set;
        }

        [JsonPropertyName("ru-RU")]
        public RuRU RuRU {
            get; set;
        }
    }
}
