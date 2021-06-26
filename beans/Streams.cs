using System.Text.Json.Serialization;

namespace Kamyroll_CSharp_Obj {
    public class Streams {
        [JsonPropertyName("adaptive_dash")]
        public AdaptiveDash AdaptiveDash {
            get; set;
        }
        [JsonPropertyName("adaptive_hls")]
        public AdaptiveHls AdaptiveHls {
            get; set;
        }
        [JsonPropertyName("download_hls")]
        public DownloadHls DownloadHls {
            get; set;
        }
        [JsonPropertyName("drm_adaptive_dash")]
        public DrmAdaptiveDash DrmAdaptiveDash {
            get; set;
        }
        [JsonPropertyName("drm_adaptive_hls")]
        public DrmAdaptiveHls DrmAdaptiveHls {
            get; set;
        }
        [JsonPropertyName("drm_download_hls")]
        public DrmDownloadHls DrmDownloadHls {
            get; set;
        }
        [JsonPropertyName("drm_multitrack_adaptive_hls_v2")]
        public DrmMultitrackAdaptiveHlsV2 DrmMultitrackAdaptiveHlsV2 {
            get; set;
        }
        [JsonPropertyName("multitrack_adaptive_hls_v2")]
        public MultitrackAdaptiveHlsV2 MultitrackAdaptiveHlsV2 {
            get; set;
        }
        [JsonPropertyName("urls")]
        public Urls Urls {
            get; set;
        }
        [JsonPropertyName("vo_adaptive_dash")]
        public VoAdaptiveDash VoAdaptiveDash {
            get; set;
        }
        [JsonPropertyName("vo_adaptive_hls")]
        public VoAdaptiveHls VoAdaptiveHls {
            get; set;
        }
        [JsonPropertyName("vo_drm_adaptive_dash")]
        public VoDrmAdaptiveDash VoDrmAdaptiveDash {
            get; set;
        }
        [JsonPropertyName("vo_drm_adaptive_hls")]
        public VoDrmAdaptiveHls VoDrmAdaptiveHls {
            get; set;
        }
    }
}
