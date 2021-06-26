using System.Text.Json.Serialization;

namespace Kamyroll_CSharp {
    public class CrAccount {
        [JsonPropertyName("cr_beta_opt_in")]
        public bool IsCrBetaOptIn {
            get; set;
        }
        [JsonPropertyName("crleg_email_verified")]
        public bool IsCrlegEmailVerified {
            get; set;
        }
        [JsonPropertyName("email")]
        public string Email {
            get; set;
        }
        [JsonPropertyName("maturity_rating")]
        public string MaturityRating {
            get; set;
        }
        [JsonPropertyName("opt_out_android_in_app_marketing")]
        public bool IsOptOutAndroidInAppMarketing {
            get; set;
        }
        [JsonPropertyName("opt_out_free_trials")]
        public bool IsOptOutFreeTrials {
            get; set;
        }
        [JsonPropertyName("opt_out_new_media_queue_updates")]
        public bool IsOptOutNewMediaQueueUpdates {
            get; set;
        }
        [JsonPropertyName("opt_out_newsletters")]
        public bool IsOptOutNewsletters {
            get; set;
        }
        [JsonPropertyName("opt_out_pm_updates")]
        public bool IsOptOutPmUpdates {
            get; set;
        }
        [JsonPropertyName("opt_out_promotional_updates")]
        public bool IsOptOutPromotionalUpdates {
            get; set;
        }
        [JsonPropertyName("opt_out_queue_updates")]
        public bool IsOptOutQueueUpdates {
            get; set;
        }
        [JsonPropertyName("opt_out_store_deals")]
        public bool IsOptOutStoreDeals {
            get; set;
        }
        [JsonPropertyName("qa_user")]
        public bool IsQaUser {
            get; set;
        }
        [JsonPropertyName("username")]
        public string Username {
            get; set;
        }
    }
}
