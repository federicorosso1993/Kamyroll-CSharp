using System.Collections.Generic;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Kamyroll_CSharp_Obj {
    public class Resource {
        public string href {
            get; set;
        }
    }

    public class Links {
        public Resource resource {
            get; set;
        }
    }

    public class Actions {
    }

    public class ArME {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class DeDE {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class EnUS {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class EsES {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class EsLA {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class FrFR {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class ItIT {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class PtBR {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class RuRU {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

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

    public class Captions {
    }

    public class Softsub {
        public string locale {
            get; set;
        }
        public string url {
            get; set;
        }
        public string format {
            get; set;
        }
        public string hardsub_locale {
            get; set;
        }
    }

    public class AdaptiveDash {
        public Softsub softsub {
            get; set;
        }

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

    public class AdaptiveHls {
        public Softsub softsub {
            get; set;
        }

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

    public class DownloadHls {
        public Softsub softsub {
            get; set;
        }
    }

    public class DrmAdaptiveDash {
        public Softsub softsub {
            get; set;
        }

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

    public class DrmAdaptiveHls {
        public Softsub softsub {
            get; set;
        }

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

    public class DrmDownloadHls {
        public Softsub softsub {
            get; set;
        }
    }

    public class DrmMultitrackAdaptiveHlsV2 {
        public Softsub softsub {
            get; set;
        }

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

    public class MultitrackAdaptiveHlsV2 {
        public Softsub softsub {
            get; set;
        }

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

    public class Urls {
        public Softsub softsub {
            get; set;
        }
    }

    public class VoAdaptiveDash {
        public Softsub softsub {
            get; set;
        }

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

    public class VoAdaptiveHls {
        public Softsub softsub {
            get; set;
        }

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

    public class VoDrmAdaptiveDash {
        public Softsub softsub {
            get; set;
        }

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

    public class VoDrmAdaptiveHls {
        public Softsub softsub {
            get; set;
        }

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

    public class Streams {
        public AdaptiveDash adaptive_dash {
            get; set;
        }
        public AdaptiveHls adaptive_hls {
            get; set;
        }
        public DownloadHls download_hls {
            get; set;
        }
        public DrmAdaptiveDash drm_adaptive_dash {
            get; set;
        }
        public DrmAdaptiveHls drm_adaptive_hls {
            get; set;
        }
        public DrmDownloadHls drm_download_hls {
            get; set;
        }
        public DrmMultitrackAdaptiveHlsV2 drm_multitrack_adaptive_hls_v2 {
            get; set;
        }
        public MultitrackAdaptiveHlsV2 multitrack_adaptive_hls_v2 {
            get; set;
        }
        public Urls urls {
            get; set;
        }
        public VoAdaptiveDash vo_adaptive_dash {
            get; set;
        }
        public VoAdaptiveHls vo_adaptive_hls {
            get; set;
        }
        public VoDrmAdaptiveDash vo_drm_adaptive_dash {
            get; set;
        }
        public VoDrmAdaptiveHls vo_drm_adaptive_hls {
            get; set;
        }
    }

    public class StreamLinks {
        public string __class__ {
            get; set;
        }
        public string __href__ {
            get; set;
        }
        public string __resource_key__ {
            get; set;
        }
        public Links __links__ {
            get; set;
        }
        public Actions __actions__ {
            get; set;
        }
        public string media_id {
            get; set;
        }
        public string audio_locale {
            get; set;
        }
        public Subtitles subtitles {
            get; set;
        }
        public Captions captions {
            get; set;
        }
        public Streams streams {
            get; set;
        }
        public List<string> bifs {
            get; set;
        }
    }
    public class User {
        public string @class {
            get; set;
        }
        public string user_id {
            get; set;
        }
        public string etp_guid {
            get; set;
        }
        public string username {
            get; set;
        }
        public string email {
            get; set;
        }
        public string first_name {
            get; set;
        }
        public string last_name {
            get; set;
        }
        public string premium {
            get; set;
        }
        public bool is_publisher {
            get; set;
        }
        public object access_type {
            get; set;
        }
        public DateTime created {
            get; set;
        }
    }

    public class Debug {
        public double init_app {
            get; set;
        }
        public double parsed_url {
            get; set;
        }
        public double auth_an_client {
            get; set;
        }
        public double locale {
            get; set;
        }
        public double selector_fields {
            get; set;
        }
        public double translations {
            get; set;
        }
        public double pre_view {
            get; set;
        }
        public double require_once {
            get; set;
        }
        public double connectivity_type {
            get; set;
        }
        public double device_registry {
            get; set;
        }
        public double api_auth {
            get; set;
        }
        public double ops {
            get; set;
        }
    }

    public class Data {
        public string session_id {
            get; set;
        }
        public string country_code {
            get; set;
        }
        public string ip {
            get; set;
        }
        public string device_type {
            get; set;
        }
        public string device_id {
            get; set;
        }
        public User user {
            get; set;
        }
        public object auth {
            get; set;
        }
        public DateTime expires {
            get; set;
        }
        public string version {
            get; set;
        }
        public List<object> ops {
            get; set;
        }
        public string connectivity_type {
            get; set;
        }
        public Debug debug {
            get; set;
        }
    }

    public class CrSession {
        public Data data {
            get; set;
        }
        public bool error {
            get; set;
        }
        public string code {
            get; set;
        }
    }
}

namespace Kamyroll_CSharp {

    public class Links {
        [JsonPropertyName("episode/season")]
        public EpisodeSeason EpisodeSeason {
            get; set;
        }

        [JsonPropertyName("episode/series")]
        public EpisodeSeries EpisodeSeries {
            get; set;
        }
        public Resource resource {
            get; set;
        }

        [JsonPropertyName("resource/channel")]
        public ResourceChannel ResourceChannel {
            get; set;
        }
        public Streams streams {
            get; set;
        }
    }

    public class Actions {
    }

    public class EpisodeSeason {
        public string href {
            get; set;
        }
    }

    public class EpisodeSeries {
        public string href {
            get; set;
        }
    }

    public class Resource {
        public string href {
            get; set;
        }
    }

    public class ResourceChannel {
        public string href {
            get; set;
        }
    }

    public class Streams {
        public string href {
            get; set;
        }
    }

    public class Thumbnail {
        public int width {
            get; set;
        }
        public int height {
            get; set;
        }
        public string type {
            get; set;
        }
        public string source {
            get; set;
        }
    }

    public class Images {
        public List<List<Thumbnail>> thumbnail {
            get; set;
        }
    }

    public class EpisodeMetadata {
        public string series_id {
            get; set;
        }
        public string series_title {
            get; set;
        }
        public string season_id {
            get; set;
        }
        public string season_title {
            get; set;
        }
        public int season_number {
            get; set;
        }
        public int episode_number {
            get; set;
        }
        public string episode {
            get; set;
        }
        public int sequence_number {
            get; set;
        }
        public int duration_ms {
            get; set;
        }
        public DateTime episode_air_date {
            get; set;
        }
        public bool is_premium_only {
            get; set;
        }
        public bool is_mature {
            get; set;
        }
        public bool mature_blocked {
            get; set;
        }
        public bool is_subbed {
            get; set;
        }
        public bool is_dubbed {
            get; set;
        }
        public bool is_clip {
            get; set;
        }
        public bool available_offline {
            get; set;
        }
        public List<string> maturity_ratings {
            get; set;
        }
        public List<string> subtitle_locales {
            get; set;
        }
        public string availability_notes {
            get; set;
        }
    }

    public class Item {
        public string __class__ {
            get; set;
        }
        public string __href__ {
            get; set;
        }
        public Links __links__ {
            get; set;
        }
        public Actions __actions__ {
            get; set;
        }
        public string id {
            get; set;
        }
        public string external_id {
            get; set;
        }
        public string channel_id {
            get; set;
        }
        public string title {
            get; set;
        }
        public string description {
            get; set;
        }
        public string promo_title {
            get; set;
        }
        public string promo_description {
            get; set;
        }
        public string type {
            get; set;
        }
        public string slug {
            get; set;
        }
        public string slug_title {
            get; set;
        }
        public Images images {
            get; set;
        }
        public EpisodeMetadata episode_metadata {
            get; set;
        }
        public string playback {
            get; set;
        }
        public string linked_resource_key {
            get; set;
        }
    }

    public class StreamInfo {
        public string __class__ {
            get; set;
        }
        public string __href__ {
            get; set;
        }
        public string __resource_key__ {
            get; set;
        }
        public Links __links__ {
            get; set;
        }
        public Actions __actions__ {
            get; set;
        }
        public int total {
            get; set;
        }
        public List<Item> items {
            get; set;
        }
    }
    public class LoginData {
        public string session_id {
            get; set;
        }

        public string account {
            get; set;
        }

        public string password {
            get; set;
        }
    }
    public class Debug {
        public double init_app {
            get; set;
        }
        public double parsed_url {
            get; set;
        }
        public double auth_an_client {
            get; set;
        }
        public double locale {
            get; set;
        }
        public double selector_fields {
            get; set;
        }
        public double translations {
            get; set;
        }
        public double pre_view {
            get; set;
        }
        public double require_once {
            get; set;
        }
        public double connectivity_type {
            get; set;
        }
        public double ops {
            get; set;
        }
    }

    public class Data {
        public string session_id {
            get; set;
        }
        public string country_code {
            get; set;
        }
        public string ip {
            get; set;
        }
        public string device_type {
            get; set;
        }
        public string device_id {
            get; set;
        }
        public string user {
            get; set;
        }
        public string auth {
            get; set;
        }
        public string expires {
            get; set;
        }
        public string version {
            get; set;
        }
        public List<string> ops {
            get; set;
        }
        public string connectivity_type {
            get; set;
        }
        public Debug debug {
            get; set;
        }
    }

    public class CrSession {
        public Data data {
            get; set;
        }
        public bool error {
            get; set;
        }
        public string code {
            get; set;
        }
    }

    public class AccessToken {
        public string access_token {
            get; set;
        }
        public int expires_in {
            get; set;
        }
        public string token_type {
            get; set;
        }
        public string scope {
            get; set;
        }
        public string country {
            get; set;
        }
    }

    public class Cms {
        public string bucket {
            get; set;
        }
        public string policy {
            get; set;
        }
        public string signature {
            get; set;
        }
        public string key_pair_id {
            get; set;
        }
        public DateTime expires {
            get; set;
        }
    }

    public class ServiceCr {
        public Cms cms {
            get; set;
        }
        public bool service_available {
            get; set;
        }
        public bool default_marketing_opt_in {
            get; set;
        }
    }

    public class CrId {
        public string account_id {
            get; set;
        }
        public string external_id {
            get; set;
        }
        public bool email_verified {
            get; set;
        }
        public DateTime created {
            get; set;
        }
    }

    public class CrAccount {
        public bool cr_beta_opt_in {
            get; set;
        }
        public bool crleg_email_verified {
            get; set;
        }
        public string email {
            get; set;
        }
        public string maturity_rating {
            get; set;
        }
        public bool opt_out_android_in_app_marketing {
            get; set;
        }
        public bool opt_out_free_trials {
            get; set;
        }
        public bool opt_out_new_media_queue_updates {
            get; set;
        }
        public bool opt_out_newsletters {
            get; set;
        }
        public bool opt_out_pm_updates {
            get; set;
        }
        public bool opt_out_promotional_updates {
            get; set;
        }
        public bool opt_out_queue_updates {
            get; set;
        }
        public bool opt_out_store_deals {
            get; set;
        }
        public bool qa_user {
            get; set;
        }
        public string username {
            get; set;
        }
    }

    public class ConfigObject {
        public string session_id {
            get; set;
        }
        public string etp_rt {
            get; set;
        }
        public string channel {
            get; set;
        }
        public string country_code {
            get; set;
        }
        public string maturity_rating {
            get; set;
        }
        public string policy {
            get; set;
        }
        public string signature {
            get; set;
        }
        public string key_pair_id {
            get; set;
        }
        public string account_id {
            get; set;
        }
        public string external_id {
            get; set;
        }
    }


    class Program {
        static HttpClient client = new HttpClient();
        static string tokenTypeG = "";
        static string accessTokenG = "";
        static string linkdownload = "";
        static string youtubeDlPath = "";
        static string dlPath = "";
        static ConfigObject config = new ConfigObject();

        static void Main(string[] args) {

            List<string> arguments = new List<string>(args);
            int indexLogin = arguments.FindIndex(a => a.Contains("--login")) + 1;

            int indexLink = arguments.FindIndex(a => a.Contains("--download")) + 1;
            linkdownload = arguments[indexLink];

            int indexYoutubeDlPath = arguments.FindIndex(a => a.Contains("--youtubedlpath")) + 1;
            while (!arguments[indexYoutubeDlPath].Contains("--")) {
                youtubeDlPath = youtubeDlPath + arguments[indexYoutubeDlPath] + " ";
                indexYoutubeDlPath++;
            }
            youtubeDlPath = youtubeDlPath.Substring(0, youtubeDlPath.Length - 1);

            int indexDlPath = arguments.FindIndex(a => a.Contains("--dlpath")) + 1;
            while (!arguments[indexDlPath].Contains("--")) {
                dlPath = dlPath + arguments[indexDlPath] + " ";
                indexDlPath++;
            }
            dlPath = dlPath.Substring(0, dlPath.Length - 1);

            if (arguments.Contains("--login") && linkdownload != "") {
                LoginAsync(arguments[indexLogin]).Wait();

                DownloadAsync(linkdownload).Wait();
            } else {
                Console.WriteLine("Login and download link required");
            }
        }

        public static async Task LoginAsync(string args_login) {
            string email = "";
            string password = "";
            try {
                email = args_login.Split(":")[0].Trim();
                password = args_login.Split(":")[1].Trim();
            } catch {
                Console.WriteLine("Invalid login");
            }
            var endpoint = "https://api.crunchyroll.com/start_session.0.json?version=1.0&access_token=LNDJgOit5yaRIWN&device_type=com.crunchyroll.windows.desktop&device_id=Az2srGnChW65fuxYz2Xxl1GcZQgtGgI";
            try {
                HttpResponseMessage response = await client.GetAsync(endpoint);
                string responsestring = await response.Content.ReadAsStringAsync();
                CrSession crSession = JsonSerializer.Deserialize<CrSession>(responsestring);
                var session_id = crSession.data.session_id;
                endpoint = "https://api.crunchyroll.com/login.0.json";
                var data = new Dictionary<string, string> {
                {
                    "session_id",
                    session_id},
                {
                    "account",
                    email},
                {
                    "password",
                    password}
                };

                HttpResponseMessage response2 = await client.PostAsync(endpoint, new FormUrlEncodedContent(data));
                responsestring = await response2.Content.ReadAsStringAsync();
                StartSessionAsync(session_id).Wait();
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        public static async Task StartSessionAsync(string session_id) {
            string channel = "";
            var endpoint = "https://api.crunchyroll.com/start_session.0.json?session_id=" + session_id;
            var cookieContainer = new CookieContainer();
            var uri = new Uri(endpoint);
            var etp_rt = "";
            var premium = "";
            var country_code = "";
            using (var httpClientHandler = new HttpClientHandler {
                CookieContainer = cookieContainer
            }) {
                using (var httpClient = new HttpClient(httpClientHandler)) {
                    var responseI = await httpClient.GetAsync(uri);
                    var cookie = cookieContainer.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "etp_rt");
                    etp_rt = cookie.Value;
                    string responsestringI = await responseI.Content.ReadAsStringAsync();
                    Kamyroll_CSharp_Obj.CrSession crSession = JsonSerializer.Deserialize<Kamyroll_CSharp_Obj.CrSession>(responsestringI);
                    premium = crSession.data.user.premium;
                    country_code = crSession.data.country_code;
                }
            }

            if (premium == "") {
                channel = "-";
            } else {
                channel = "crunchyroll";
            }

            GetHeadersAsync(session_id, etp_rt).Wait();
            
            endpoint = "https://beta-api.crunchyroll.com/index/v2";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenTypeG, accessTokenG);
            HttpResponseMessage response = await client.GetAsync(endpoint);
            string responsestring = await response.Content.ReadAsStringAsync();
            ServiceCr serviceCr = JsonSerializer.Deserialize<ServiceCr>(responsestring);
            var policy = serviceCr.cms.policy;
            var signature = serviceCr.cms.signature;
            var key_pair_id = serviceCr.cms.key_pair_id;

            endpoint = "https://beta-api.crunchyroll.com/accounts/v1/me";
            response = await client.GetAsync(endpoint);
            responsestring = await response.Content.ReadAsStringAsync();
            CrId crId = JsonSerializer.Deserialize<CrId>(responsestring);
            var account_id = crId.account_id;
            var external_id = crId.external_id;
            
            endpoint = "https://beta-api.crunchyroll.com/accounts/v1/me/profile";
            response = await client.GetAsync(endpoint);
            responsestring = await response.Content.ReadAsStringAsync();
            CrAccount crAccount = JsonSerializer.Deserialize<CrAccount>(responsestring);
            var maturity_rating = crAccount.maturity_rating;

            config.session_id = session_id;
            config.etp_rt = etp_rt;
            config.channel = channel;
            config.country_code = country_code;
            config.maturity_rating = maturity_rating;
            config.policy = policy;
            config.signature = signature;
            config.key_pair_id = key_pair_id;
            config.account_id = account_id;
            config.external_id = external_id;
        }

        public static async Task GetHeadersAsync(string session_id, string etp_rt) {
            var endpoint = "https://beta-api.crunchyroll.com/auth/v1/token";
            var data = new Dictionary<string, string> {
                {
                    "grant_type",
                    "etp_rt_cookie"}};

            
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            
            var client2 = new HttpClient(handler);
            client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bm9haWhkZXZtXzZpeWcwYThsMHE6");
            cookieContainer.Add(new Uri(endpoint), new Cookie("session_id", session_id));
            cookieContainer.Add(new Uri(endpoint), new Cookie("etp_rt", etp_rt));

            try {
                HttpResponseMessage response = await client2.PostAsync(endpoint, new FormUrlEncodedContent(data));
                string responsestring = await response.Content.ReadAsStringAsync();
                AccessToken accessToken = JsonSerializer.Deserialize<AccessToken>(responsestring);
                var access_token = accessToken.access_token;
                var token_type = accessToken.token_type;
                tokenTypeG = token_type;
                accessTokenG = access_token;
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        public static async Task DownloadAsync(string linkdownload) {
            string episodecode = linkdownload.Split("/")[5];
            string endpoint = "https://beta-api.crunchyroll.com/cms/v2/" + config.country_code + "/" + config.maturity_rating + "/" + config.channel + "/objects/" + episodecode + "?locale=" + GetLocale(config.country_code) + "&Signature=" + config.signature + "&Policy=" + config.policy + "&Key-Pair-Id=" + config.key_pair_id;
            try {
                HttpResponseMessage response = await client.GetAsync(endpoint);
                string responsestring = await response.Content.ReadAsStringAsync();
                StreamInfo streamInfo = JsonSerializer.Deserialize<StreamInfo>(responsestring);
                string serietitle = streamInfo.items[0].episode_metadata.season_title;
                string title = streamInfo.items[0].title;
                string episodenumber = config.country_code == "IT" ? "Episodio " + streamInfo.items[0].episode_metadata.episode_number : "Episode " + streamInfo.items[0].episode_metadata.episode_number;
                string streamid = streamInfo.items[0].__links__.streams.href.Split("/")[7] + "/" + streamInfo.items[0].__links__.streams.href.Split("/")[8];
                endpoint = "https://beta-api.crunchyroll.com/cms/v2/" + config.country_code + "/" + config.maturity_rating + "/" + config.channel + "/videos/" + streamid + "?locale=" + GetLocale(config.country_code) + "&Signature=" + config.signature + "&Policy=" + config.policy + "&Key-Pair-Id=" + config.key_pair_id;
                response = await client.GetAsync(endpoint);
                responsestring = await response.Content.ReadAsStringAsync();
                responsestring = responsestring.Replace("\"\":", "\"softsub\":");
                Kamyroll_CSharp_Obj.StreamLinks streamLinks = JsonSerializer.Deserialize<Kamyroll_CSharp_Obj.StreamLinks>(responsestring);
                endpoint = streamLinks.streams.adaptive_hls.softsub.url;
                response = await client.GetAsync(endpoint);
                responsestring = await response.Content.ReadAsStringAsync();

                string maxres = "";

                if (responsestring.Split("RESOLUTION=1920x1080").Length > 1)
                    maxres = "1920x1080";
                else if (responsestring.Split("RESOLUTION=1280x720").Length > 1)
                    maxres = "1280x720";
                else if (responsestring.Split("RESOLUTION=848x480").Length > 1)
                    maxres = "848x480";
                else if (responsestring.Split("RESOLUTION=640x480").Length > 1)
                    maxres = "640x480";
                else if (responsestring.Split("RESOLUTION=640x360").Length > 1)
                    maxres = "640x360";
                else if (responsestring.Split("RESOLUTION=480x360").Length > 1)
                    maxres = "480x360";
                else if (responsestring.Split("RESOLUTION=428x240").Length > 1)
                    maxres = "428x240";
                else if (responsestring.Split("RESOLUTION=320x240").Length > 1)
                    maxres = "320x240";
                else
                    maxres = responsestring.Split("RESOLUTION=")[1].Substring(0, 7);

                string installationPath = dlPath == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) : dlPath;
                string installationYDlPath = youtubeDlPath == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) : youtubeDlPath;

                Process proc = new Process();
                proc.StartInfo.FileName = "powershell.exe";
                proc.StartInfo.Arguments = "/c " + "cd " + installationPath.Substring(0, 1) + @":\" + "'" + installationPath.Substring(3) + "'; " + installationYDlPath.Substring(0, 1) + @":\" + "'" + installationYDlPath.Substring(3) + "'" + @"\./youtube-dl.exe --output '" + serietitle + " " + episodenumber + " – " + title + "-" + episodecode + ".mp4' 'http" + responsestring.Split("RESOLUTION=" + maxres)[1].Split("http")[1].Split("#EXT-X-STREAM")[0].Replace("\\n", "") + "' --prefer-ffmpeg --no-check-certificate";
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                string subLang = GetLocale(config.country_code);
                try {
                    switch (subLang) {
                        case "es-LA":
                            endpoint = streamLinks.subtitles.EsLA.url;
                            break;
                        case "es-ES":
                            endpoint = streamLinks.subtitles.EsES.url;
                            break;
                        case "fr-FR":
                            endpoint = streamLinks.subtitles.FrFR.url;
                            break;
                        case "pt-BR":
                            endpoint = streamLinks.subtitles.PtBR.url;
                            break;
                        case "it-IT":
                            endpoint = streamLinks.subtitles.ItIT.url;
                            break;
                        case "de-DE":
                            endpoint = streamLinks.subtitles.DeDE.url;
                            break;
                        case "ru-RU":
                            endpoint = streamLinks.subtitles.RuRU.url;
                            break;
                        case "ar-ME":
                            endpoint = streamLinks.subtitles.ArME.url;
                            break;
                        default:
                            endpoint = streamLinks.subtitles.EnUS.url;
                            break;
                    }
                }catch {
                    subLang = "en-US";
                    endpoint = streamLinks.subtitles.EnUS.url;
                }
                
                response = await client.GetAsync(endpoint);
                responsestring = await response.Content.ReadAsStringAsync();
                string[] subtitles = { responsestring };
                await File.WriteAllLinesAsync(installationPath + @"\" + serietitle + " " + episodenumber + " – " + title + "-" + episodecode + "." + subLang + ".ass", subtitles);
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        private static string GetLocale(string countrycode) {
            switch (countrycode) {
                case "JP":
                    return "ja-JP";
                case "LA":
                    return "es-LA";
                case "ES":
                    return "es-ES";
                case "FR":
                    return "fr-FR";
                case "BR":
                    return "pt-BR";
                case "IT":
                    return "it-IT";
                case "DE":
                    return "de-DE";
                case "RU":
                    return "ru-RU";
                case "ME":
                    return "ar-ME";
                default:
                    return "en-US";
            }
        }
    }
}
