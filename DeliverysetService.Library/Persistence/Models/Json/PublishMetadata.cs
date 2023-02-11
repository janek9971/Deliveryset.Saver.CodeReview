using System.Text.Json.Serialization;
using DeliverysetService.Library.Persistence.Models.Enums;
using Newtonsoft.Json;

namespace DeliverysetService.Library.Persistence.Models.Json
{
    public class Antenne
    {
        [JsonProperty("affaire")]
        [JsonPropertyName("affaire")]
        public int Affaire { get; set; }

        [JsonProperty("programme")]
        [JsonPropertyName("programme")]
        public int Programme { get; set; }
    }

    public class PublishAsset
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonProperty("antenne")]
        [JsonPropertyName("antenne")]
        public Antenne Antenne { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("createdAt")]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("legalTitle")]
        [JsonPropertyName("legalTitle")]
        public string LegalTitle { get; set; }

        [JsonProperty("collection")]
        [JsonPropertyName("collection")]
        public int Collection { get; set; }

        [JsonProperty("genericType")]
        [JsonPropertyName("genericType")]
        public string GenericType { get; set; }
    }

    public class At
    {
        [JsonProperty("$date")]
        [JsonPropertyName("$date")]
        public long Date { get; set; }
    }

    public class AudioChannel
    {
        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonProperty("codecName")]
        [JsonPropertyName("codecName")]
        public string CodecName { get; set; }

        [JsonProperty("codecLongName")]
        [JsonPropertyName("codecLongName")]
        public string CodecLongName { get; set; }
    }

    public class AudioTrack
    {
        [JsonProperty("raw")]
        [JsonPropertyName("raw")]
        public Raw Raw { get; set; }

        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonProperty("bitDepth")]
        [JsonPropertyName("bitDepth")]
        public int BitDepth { get; set; }

        [JsonProperty("timeBase")]
        [JsonPropertyName("timeBase")]
        public string TimeBase { get; set; }

        [JsonProperty("codecName")]
        [JsonPropertyName("codecName")]
        public string CodecName { get; set; }

        [JsonProperty("sampleFmt")]
        [JsonPropertyName("sampleFmt")]
        public string SampleFmt { get; set; }

        [JsonProperty("durationTs")]
        [JsonPropertyName("durationTs")]
        public int DurationTs { get; set; }

        [JsonProperty("sampleRate")]
        [JsonPropertyName("sampleRate")]
        public string SampleRate { get; set; }

        [JsonProperty("audioChannels")]
        [JsonPropertyName("audioChannels")]
        public List<AudioChannel> AudioChannels { get; set; }

        [JsonProperty("codecLongName")]
        [JsonPropertyName("codecLongName")]
        public string CodecLongName { get; set; }

        [JsonProperty("durationSecond")]
        [JsonPropertyName("durationSecond")]
        public double DurationSecond { get; set; }
    }

    public class Baton
    {
        [JsonProperty("topLevelInfo")]
        [JsonPropertyName("topLevelInfo")]
        public TopLevelInfo TopLevelInfo { get; set; }
    }

    public class PublishChannel
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonProperty("codecName")]
        [JsonPropertyName("codecName")]
        public string CodecName { get; set; }

        [JsonProperty("codecLongName")]
        [JsonPropertyName("codecLongName")]
        public string CodecLongName { get; set; }

        [JsonProperty("dolbyIndices")]
        [JsonPropertyName("dolbyIndices")]
        public List<object> DolbyIndices { get; set; }

        [JsonProperty("createdAt")]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }

    public class PublishContent
    {
        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonProperty("audioVersion")]
        [JsonPropertyName("audioVersion")]
        public string AudioVersion { get; set; }

        [JsonProperty("channels")]
        [JsonPropertyName("channels")]
        public List<PublishChannel> Channels { get; set; }

        [JsonProperty("_type")]
        [JsonPropertyName("_type")]
        public string Type { get; set; }
    }

    public class Disposition
    {
        [JsonProperty("dub")]
        [JsonPropertyName("dub")]
        public int Dub { get; set; }

        [JsonProperty("forced")]
        [JsonPropertyName("forced")]
        public int Forced { get; set; }

        [JsonProperty("lyrics")]
        [JsonPropertyName("lyrics")]
        public int Lyrics { get; set; }

        [JsonProperty("comment")]
        [JsonPropertyName("comment")]
        public int Comment { get; set; }

        [JsonProperty("default")]
        [JsonPropertyName("default")]
        public int Default { get; set; }

        [JsonProperty("karaoke")]
        [JsonPropertyName("karaoke")]
        public int Karaoke { get; set; }

        [JsonProperty("original")]
        [JsonPropertyName("original")]
        public int Original { get; set; }

        [JsonProperty("attached_pic")]
        [JsonPropertyName("attached_pic")]
        public int AttachedPic { get; set; }

        [JsonProperty("clean_effects")]
        [JsonPropertyName("clean_effects")]
        public int CleanEffects { get; set; }

        [JsonProperty("visual_impaired")]
        [JsonPropertyName("visual_impaired")]
        public int VisualImpaired { get; set; }

        [JsonProperty("hearing_impaired")]
        [JsonPropertyName("hearing_impaired")]
        public int HearingImpaired { get; set; }
    }

    public class PublishEssence
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        [JsonPropertyName("content")]
        public PublishContent Content { get; set; }

        [JsonProperty("resourceId")]
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("createdAt")]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language { get; set; }
    }

    public class Event
    {
        [JsonProperty("at")]
        [JsonPropertyName("at")]
        public At At { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class FfProbe
    {
        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public Format Format { get; set; }

        [JsonProperty("streams")]
        [JsonPropertyName("streams")]
        public List<Stream> Streams { get; set; }
    }

    public class Format
    {
        [JsonProperty("size")]
        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("bit_rate")]
        [JsonPropertyName("bit_rate")]
        public string BitRate { get; set; }

        [JsonProperty("duration")]
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonProperty("filename")]
        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonProperty("nb_streams")]
        [JsonPropertyName("nb_streams")]
        public int NbStreams { get; set; }

        [JsonProperty("format_name")]
        [JsonPropertyName("format_name")]
        public string FormatName { get; set; }

        [JsonProperty("probe_score")]
        [JsonPropertyName("probe_score")]
        public int ProbeScore { get; set; }
    }

    public class Input
    {
        [JsonProperty("profile")]
        [JsonPropertyName("profile")]
        public string Profile { get; set; }

        [JsonProperty("videos")]
        [JsonPropertyName("videos")]
        public List<Video> Videos { get; set; }

        [JsonProperty("subtitles")]
        [JsonPropertyName("subtitles")]
        public List<object> Subtitles { get; set; }

        [JsonProperty("deliverySetId")]
        [JsonPropertyName("deliverySetId")]
        public string DeliverysetId { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Job
    {
        [JsonProperty("at")]
        [JsonPropertyName("at")]
        public DateTime? At { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("events")]
        [JsonPropertyName("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class MediaInfo
    {
        [JsonProperty("Tracks")]
        [JsonPropertyName("Tracks")]
        public List<Track> Tracks { get; set; }

        [JsonProperty("XMLName")]
        [JsonPropertyName("XMLName")]
        public XMLName XMLName { get; set; }
    }

    public class Probe
    {
        [JsonProperty("baton")]
        [JsonPropertyName("baton")]
        public Baton Baton { get; set; }

        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonProperty("ffProbe")]
        [JsonPropertyName("ffProbe")]
        public FfProbe FfProbe { get; set; }

        [JsonProperty("frameRate")]
        [JsonPropertyName("frameRate")]
        public string FrameRate { get; set; }

        [JsonProperty("mediaInfo")]
        [JsonPropertyName("mediaInfo")]
        public MediaInfo MediaInfo { get; set; }

        [JsonProperty("resolution")]
        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("aspectRatio")]
        [JsonPropertyName("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("audioTracks")]
        [JsonPropertyName("audioTracks")]
        public List<AudioTrack> AudioTracks { get; set; }

        [JsonProperty("endOfFileTc")]
        [JsonPropertyName("endOfFileTc")]
        public string EndOfFileTc { get; set; }

        [JsonProperty("videoTracks")]
        [JsonPropertyName("videoTracks")]
        public List<VideoTrack> VideoTracks { get; set; }

        [JsonProperty("endOfMediaTc")]
        [JsonPropertyName("endOfMediaTc")]
        public string EndOfMediaTc { get; set; }

        [JsonProperty("audioBitDepth")]
        [JsonPropertyName("audioBitDepth")]
        public int AudioBitDepth { get; set; }

        [JsonProperty("startOfFileTc")]
        [JsonPropertyName("startOfFileTc")]
        public string StartOfFileTc { get; set; }

        [JsonProperty("endOfFileFrame")]
        [JsonPropertyName("endOfFileFrame")]
        public int EndOfFileFrame { get; set; }

        [JsonProperty("frameRateFloat")]
        [JsonPropertyName("frameRateFloat")]
        public int FrameRateFloat { get; set; }

        [JsonProperty("startOfMediaTc")]
        [JsonPropertyName("startOfMediaTc")]
        public string StartOfMediaTc { get; set; }

        [JsonProperty("endOfMediaFrame")]
        [JsonPropertyName("endOfMediaFrame")]
        public int EndOfMediaFrame { get; set; }

        [JsonProperty("durationOfFileTc")]
        [JsonPropertyName("durationOfFileTc")]
        public string DurationOfFileTc { get; set; }

        [JsonProperty("startOfFileFrame")]
        [JsonPropertyName("startOfFileFrame")]
        public int StartOfFileFrame { get; set; }

        [JsonProperty("durationOfMediaTc")]
        [JsonPropertyName("durationOfMediaTc")]
        public string DurationOfMediaTc { get; set; }

        [JsonProperty("startOfMediaFrame")]
        [JsonPropertyName("startOfMediaFrame")]
        public int StartOfMediaFrame { get; set; }

        [JsonProperty("durationOfFileFrame")]
        [JsonPropertyName("durationOfFileFrame")]
        public int DurationOfFileFrame { get; set; }

        [JsonProperty("durationOfFileSecond")]
        [JsonPropertyName("durationOfFileSecond")]
        public double DurationOfFileSecond { get; set; }

        [JsonProperty("durationOfMediaFrame")]
        [JsonPropertyName("durationOfMediaFrame")]
        public int DurationOfMediaFrame { get; set; }

        [JsonProperty("durationOfMediaSecond")]
        [JsonPropertyName("durationOfMediaSecond")]
        public double DurationOfMediaSecond { get; set; }
    }

    public class Raw
    {
        [JsonProperty("ffProbeIndex")]
        [JsonPropertyName("ffProbeIndex")]
        public int FfProbeIndex { get; set; }

        [JsonProperty("mediaInfoIndex")]
        [JsonPropertyName("mediaInfoIndex")]
        public int MediaInfoIndex { get; set; }
    }

    public class Resource
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonProperty("physicalPath")]
        [JsonPropertyName("physicalPath")]
        public string PhysicalPath { get; set; }

        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonProperty("source")]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("resourceType")]
        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("tag")]
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonProperty("antenneVersion")]
        [JsonPropertyName("antenneVersion")]
        public string AntenneVersion { get; set; }

        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonProperty("probe")]
        [JsonPropertyName("probe")]
        public Probe Probe { get; set; }

        [JsonProperty("createdAt")]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("asset")]
        [JsonPropertyName("asset")]
        public PublishAsset Asset { get; set; }

        [JsonProperty("essences")]
        [JsonPropertyName("essences")]
        public List<PublishEssence> Essences { get; set; }

        [JsonProperty("verificationStatus")]
        [JsonPropertyName("verificationStatus")]
        public string VerificationStatus { get; set; }

        [JsonProperty("fileType")]
        [JsonPropertyName("fileType")]
        public string FileType { get; set; }
    }

    public class PublishMetadata
    {
        [JsonProperty("input")]
        [JsonPropertyName("input")]
        public Input Input { get; set; }

        [JsonProperty("at")]
        [JsonPropertyName("at")]
        public DateTime? At { get; set; }

        [JsonProperty("startedBy")]
        [JsonPropertyName("startedBy")]
        public string StartedBy { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("resourceIds")]
        [JsonPropertyName("resourceIds")]
        public List<string> ResourceIds { get; set; }

        [JsonProperty("jobs")]
        [JsonPropertyName("jobs")]
        public List<Job> Jobs { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public PublishFileStatus Status { get; set; }

        [JsonProperty("retryWorkflowId")]
        [JsonPropertyName("retryWorkflowId")]
        public object RetryWorkflowId { get; set; }
    }

    public class Stream
    {
        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("level")]
        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonProperty("pix_fmt")]
        [JsonPropertyName("pix_fmt")]
        public string PixFmt { get; set; }

        [JsonProperty("profile")]
        [JsonPropertyName("profile")]
        public string Profile { get; set; }

        [JsonProperty("bit_rate")]
        [JsonPropertyName("bit_rate")]
        public string BitRate { get; set; }

        [JsonProperty("duration")]
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonProperty("codec_tag")]
        [JsonPropertyName("codec_tag")]
        public string CodecTag { get; set; }

        [JsonProperty("start_pts")]
        [JsonPropertyName("start_pts")]
        public int StartPts { get; set; }

        [JsonProperty("time_base")]
        [JsonPropertyName("time_base")]
        public string TimeBase { get; set; }

        [JsonProperty("codec_name")]
        [JsonPropertyName("codec_name")]
        public string CodecName { get; set; }

        [JsonProperty("codec_type")]
        [JsonPropertyName("codec_type")]
        public string CodecType { get; set; }

        [JsonProperty("start_time")]
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("color_range")]
        [JsonPropertyName("color_range")]
        public string ColorRange { get; set; }

        [JsonProperty("color_space")]
        [JsonPropertyName("color_space")]
        public string ColorSpace { get; set; }

        [JsonProperty("disposition")]
        [JsonPropertyName("disposition")]
        public Disposition Disposition { get; set; }

        [JsonProperty("duration_ts")]
        [JsonPropertyName("duration_ts")]
        public int DurationTs { get; set; }

        [JsonProperty("has_b_frames")]
        [JsonPropertyName("has_b_frames")]
        public int HasBFrames { get; set; }

        [JsonProperty("r_frame_rate")]
        [JsonPropertyName("r_frame_rate")]
        public string RFrameRate { get; set; }

        [JsonProperty("avg_frame_rate")]
        [JsonPropertyName("avg_frame_rate")]
        public string AvgFrameRate { get; set; }

        [JsonProperty("codec_long_name")]
        [JsonPropertyName("codec_long_name")]
        public string CodecLongName { get; set; }

        [JsonProperty("codec_tag_string")]
        [JsonPropertyName("codec_tag_string")]
        public string CodecTagString { get; set; }

        [JsonProperty("sample_aspect_ratio")]
        [JsonPropertyName("sample_aspect_ratio")]
        public string SampleAspectRatio { get; set; }

        [JsonProperty("display_aspect_ratio")]
        [JsonPropertyName("display_aspect_ratio")]
        public string DisplayAspectRatio { get; set; }

        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int? Index { get; set; }

        [JsonProperty("channels")]
        [JsonPropertyName("channels")]
        public int? Channels { get; set; }

        [JsonProperty("sample_fmt")]
        [JsonPropertyName("sample_fmt")]
        public string SampleFmt { get; set; }

        [JsonProperty("sample_rate")]
        [JsonPropertyName("sample_rate")]
        public string SampleRate { get; set; }

        [JsonProperty("bits_per_sample")]
        [JsonPropertyName("bits_per_sample")]
        public int? BitsPerSample { get; set; }

        [JsonProperty("bits_per_raw_sample")]
        [JsonPropertyName("bits_per_raw_sample")]
        public string BitsPerRawSample { get; set; }
    }

    public class Tags
    {
        [JsonProperty("uid")]
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonProperty("timecode")]
        [JsonPropertyName("timecode")]
        public string Timecode { get; set; }

        [JsonProperty("company_name")]
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("product_name")]
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("generation_uid")]
        [JsonPropertyName("generation_uid")]
        public string GenerationUid { get; set; }

        [JsonProperty("modification_date")]
        [JsonPropertyName("modification_date")]
        public DateTime? ModificationDate { get; set; }
    }

    public class TopLevelInfo
    {
        [JsonProperty("Info")]
        [JsonPropertyName("Info")]
        public int Info { get; set; }

        [JsonProperty("Error")]
        [JsonPropertyName("Error")]
        public int Error { get; set; }

        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonProperty("Warning")]
        [JsonPropertyName("Warning")]
        public int Warning { get; set; }

        [JsonProperty("summary")]
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonProperty("filePath")]
        [JsonPropertyName("filePath")]
        public string FilePath { get; set; }
    }

    public class Track
    {
        [JsonProperty("ID")]
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonProperty("Type")]
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonProperty("Order")]
        [JsonPropertyName("Order")]
        public string Order { get; set; }

        [JsonProperty("Title")]
        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonProperty("Width")]
        [JsonPropertyName("Width")]
        public string Width { get; set; }

        [JsonProperty("Format")]
        [JsonPropertyName("Format")]
        public string Format { get; set; }

        [JsonProperty("Height")]
        [JsonPropertyName("Height")]
        public string Height { get; set; }

        [JsonProperty("Bit_rate")]
        [JsonPropertyName("Bit_rate")]
        public string BitRate { get; set; }

        [JsonProperty("Channels")]
        [JsonPropertyName("Channels")]
        public string Channels { get; set; }

        [JsonProperty("Codec_ID")]
        [JsonPropertyName("Codec_ID")]
        public string CodecID { get; set; }

        [JsonProperty("Duration")]
        [JsonPropertyName("Duration")]
        public string Duration { get; set; }

        [JsonProperty("Bit_depth")]
        [JsonPropertyName("Bit_depth")]
        public string BitDepth { get; set; }

        [JsonProperty("File_size")]
        [JsonPropertyName("File_size")]
        public string FileSize { get; set; }

        [JsonProperty("Scan_type")]
        [JsonPropertyName("Scan_type")]
        public string ScanType { get; set; }

        [JsonProperty("Frame_rate")]
        [JsonPropertyName("Frame_rate")]
        public string FrameRate { get; set; }

        [JsonProperty("Scan_order")]
        [JsonPropertyName("Scan_order")]
        public string ScanOrder { get; set; }

        [JsonProperty("Color_range")]
        [JsonPropertyName("Color_range")]
        public string ColorRange { get; set; }

        [JsonProperty("Color_space")]
        [JsonPropertyName("Color_space")]
        public string ColorSpace { get; set; }

        [JsonProperty("Stream_size")]
        [JsonPropertyName("Stream_size")]
        public string StreamSize { get; set; }

        [JsonProperty("Encoded_date")]
        [JsonPropertyName("Encoded_date")]
        public string EncodedDate { get; set; }

        [JsonProperty("Format_profile")]
        [JsonPropertyName("Format_profile")]
        public string FormatProfile { get; set; }

        [JsonProperty("Format_version")]
        [JsonPropertyName("Format_version")]
        public string FormatVersion { get; set; }

        [JsonProperty("Color_primaries")]
        [JsonPropertyName("Color_primaries")]
        public string ColorPrimaries { get; set; }

        [JsonProperty("Commercial_name")]
        [JsonPropertyName("Commercial_name")]
        public string CommercialName { get; set; }

        [JsonProperty("Format_settings")]
        [JsonPropertyName("Format_settings")]
        public string FormatSettings { get; set; }

        [JsonProperty("Compression_mode")]
        [JsonPropertyName("Compression_mode")]
        public string CompressionMode { get; set; }

        [JsonProperty("GOP__Open_Closed")]
        [JsonPropertyName("GOP__Open_Closed")]
        public string GOPOpenClosed { get; set; }

        [JsonProperty("Overall_bit_rate")]
        [JsonPropertyName("Overall_bit_rate")]
        public string OverallBitRate { get; set; }

        [JsonProperty("Time_code_source")]
        [JsonPropertyName("Time_code_source")]
        public string TimeCodeSource { get; set; }

        [JsonProperty("Channel_positions")]
        [JsonPropertyName("Channel_positions")]
        public string ChannelPositions { get; set; }

        [JsonProperty("Bits__Pixel_Frame_")]
        [JsonPropertyName("Bits__Pixel_Frame_")]
        public string BitsPixelFrame { get; set; }

        [JsonProperty("Chroma_subsampling")]
        [JsonPropertyName("Chroma_subsampling")]
        public string ChromaSubsampling { get; set; }

        [JsonProperty("Matrix_coefficients")]
        [JsonPropertyName("Matrix_coefficients")]
        public string MatrixCoefficients { get; set; }

        [JsonProperty("Writing_application")]
        [JsonPropertyName("Writing_application")]
        public string WritingApplication { get; set; }

        [JsonProperty("Display_aspect_ratio")]
        [JsonPropertyName("Display_aspect_ratio")]
        public string DisplayAspectRatio { get; set; }

        [JsonProperty("Format_settings__GOP")]
        [JsonPropertyName("Format_settings__GOP")]
        public string FormatSettingsGOP { get; set; }

        [JsonProperty("Format_settings__BVOP")]
        [JsonPropertyName("Format_settings__BVOP")]
        public string FormatSettingsBVOP { get; set; }

        [JsonProperty("Format_settings__Matrix")]
        [JsonPropertyName("Format_settings__Matrix")]
        public string FormatSettingsMatrix { get; set; }

        [JsonProperty("Time_code_of_first_frame")]
        [JsonPropertyName("Time_code_of_first_frame")]
        public string TimeCodeOfFirstFrame { get; set; }

        [JsonProperty("Transfer_characteristics")]
        [JsonPropertyName("Transfer_characteristics")]
        public string TransferCharacteristics { get; set; }

        [JsonProperty("Format_settings__Endianness")]
        [JsonPropertyName("Format_settings__Endianness")]
        public string FormatSettingsEndianness { get; set; }

        [JsonProperty("Format_settings__wrapping_mode")]
        [JsonPropertyName("Format_settings__wrapping_mode")]
        public string FormatSettingsWrappingMode { get; set; }

        [JsonProperty("Format_settings__picture_structure")]
        [JsonPropertyName("Format_settings__picture_structure")]
        public string FormatSettingsPictureStructure { get; set; }
    }

    public class Video
    {
        [JsonProperty("resource")]
        [JsonPropertyName("resource")]
        public Resource Resource { get; set; }

        [JsonProperty("filename")]
        [JsonPropertyName("filename")]
        public string Filename { get; set; }
    }

    public class VideoTrack
    {
        [JsonProperty("raw")]
        [JsonPropertyName("raw")]
        public Raw Raw { get; set; }

        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonProperty("bitRate")]
        [JsonPropertyName("bitRate")]
        public int BitRate { get; set; }

        [JsonProperty("startPts")]
        [JsonPropertyName("startPts")]
        public int StartPts { get; set; }

        [JsonProperty("codecName")]
        [JsonPropertyName("codecName")]
        public string CodecName { get; set; }

        [JsonProperty("frameRate")]
        [JsonPropertyName("frameRate")]
        public string FrameRate { get; set; }

        [JsonProperty("startTime")]
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("resolution")]
        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("aspectRatio")]
        [JsonPropertyName("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("codecLongName")]
        [JsonPropertyName("codecLongName")]
        public string CodecLongName { get; set; }

        [JsonProperty("formatProfile")]
        [JsonPropertyName("formatProfile")]
        public string FormatProfile { get; set; }

        [JsonProperty("commercialName")]
        [JsonPropertyName("commercialName")]
        public string CommercialName { get; set; }

        [JsonProperty("endOfFileFrame")]
        [JsonPropertyName("endOfFileFrame")]
        public int EndOfFileFrame { get; set; }

        [JsonProperty("frameRateFloat")]
        [JsonPropertyName("frameRateFloat")]
        public int FrameRateFloat { get; set; }

        [JsonProperty("startOfFileFrame")]
        [JsonPropertyName("startOfFileFrame")]
        public int StartOfFileFrame { get; set; }

        [JsonProperty("durationOfFileFrame")]
        [JsonPropertyName("durationOfFileFrame")]
        public int DurationOfFileFrame { get; set; }

        [JsonProperty("durationOfFileSecond")]
        [JsonPropertyName("durationOfFileSecond")]
        public double DurationOfFileSecond { get; set; }
    }

    public class XMLName
    {
        [JsonProperty("Local")]
        [JsonPropertyName("Local")]
        public string Local { get; set; }

        [JsonProperty("Space")]
        [JsonPropertyName("Space")]
        public string Space { get; set; }
    }


}
