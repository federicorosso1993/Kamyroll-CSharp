using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class EpisodeMetadata {
        [JsonPropertyName("series_id")]
        public string SeriesId {
            get; set;
        }
        [JsonPropertyName("series_title")]
        public string SeriesTitle {
            get; set;
        }
        [JsonPropertyName("season_id")]
        public string SeasonId {
            get; set;
        }
        [JsonPropertyName("season_title")]
        public string SeasonTitle {
            get; set;
        }
        [JsonPropertyName("season_number")]
        public int SeasonNumber {
            get; set;
        }
        [JsonPropertyName("episode_number")]
        public int? EpisodeNumber {
            get; set;
        }
        [JsonPropertyName("episode")]
        public string Episode {
            get; set;
        }
        [JsonPropertyName("sequence_number")]
        public double SequenceNumber {
            get; set;
        }
        [JsonPropertyName("duration_ms")]
        public int DurationMs {
            get; set;
        }
        [JsonPropertyName("episode_air_date")]
        public DateTime EpisodeAirDate {
            get; set;
        }
        [JsonPropertyName("is_premium_only")]
        public bool IsPremiumOnly {
            get; set;
        }
        [JsonPropertyName("is_mature")]
        public bool IsMature {
            get; set;
        }
        [JsonPropertyName("mature_blocked")]
        public bool IsMatureBlocked {
            get; set;
        }
        [JsonPropertyName("is_subbed")]
        public bool IsSubbed {
            get; set;
        }
        [JsonPropertyName("is_dubbed")]
        public bool IsDubbed {
            get; set;
        }
        [JsonPropertyName("is_clip")]
        public bool IsClip {
            get; set;
        }
        [JsonPropertyName("available_offline")]
        public bool IsAvailableOffline {
            get; set;
        }
        [JsonPropertyName("maturity_ratings")]
        public List<string> MaturityRatings {
            get; set;
        }
        [JsonPropertyName("subtitle_locales")]
        public List<string> SubtitleLocales {
            get; set;
        }
        [JsonPropertyName("availability_notes")]
        public string AvailabilityNotes {
            get; set;
        }
    }
}
