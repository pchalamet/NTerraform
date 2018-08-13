using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elastictranscoder_preset")]
    public sealed class aws_elastictranscoder_preset : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "video_watermarks")]
        public sealed class video_watermarks : nterraform.Core.structure
        {
            public video_watermarks(string @horizontalAlign = null,
                                    string @horizontalOffset = null,
                                    string @id = null,
                                    string @maxHeight = null,
                                    string @maxWidth = null,
                                    string @opacity = null,
                                    string @sizingPolicy = null,
                                    string @target = null,
                                    string @verticalAlign = null,
                                    string @verticalOffset = null)
            {
                @HorizontalAlign = @horizontalAlign;
                @HorizontalOffset = @horizontalOffset;
                @Id = @id;
                @MaxHeight = @maxHeight;
                @MaxWidth = @maxWidth;
                @Opacity = @opacity;
                @SizingPolicy = @sizingPolicy;
                @Target = @target;
                @VerticalAlign = @verticalAlign;
                @VerticalOffset = @verticalOffset;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "horizontal_align", @out: false, min: 0, max: 1)]
            public string @HorizontalAlign { get; }

            [nterraform.Core.TerraformProperty(name: "horizontal_offset", @out: false, min: 0, max: 1)]
            public string @HorizontalOffset { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: false, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "max_height", @out: false, min: 0, max: 1)]
            public string @MaxHeight { get; }

            [nterraform.Core.TerraformProperty(name: "max_width", @out: false, min: 0, max: 1)]
            public string @MaxWidth { get; }

            [nterraform.Core.TerraformProperty(name: "opacity", @out: false, min: 0, max: 1)]
            public string @Opacity { get; }

            [nterraform.Core.TerraformProperty(name: "sizing_policy", @out: false, min: 0, max: 1)]
            public string @SizingPolicy { get; }

            [nterraform.Core.TerraformProperty(name: "target", @out: false, min: 0, max: 1)]
            public string @Target { get; }

            [nterraform.Core.TerraformProperty(name: "vertical_align", @out: false, min: 0, max: 1)]
            public string @VerticalAlign { get; }

            [nterraform.Core.TerraformProperty(name: "vertical_offset", @out: false, min: 0, max: 1)]
            public string @VerticalOffset { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "audio")]
        public sealed class audio : nterraform.Core.structure
        {
            public audio(string @audioPackingMode = null,
                         string @bitRate = null,
                         string @channels = null,
                         string @codec = null,
                         string @sampleRate = null)
            {
                @AudioPackingMode = @audioPackingMode;
                @BitRate = @bitRate;
                @Channels = @channels;
                @Codec = @codec;
                @SampleRate = @sampleRate;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "audio_packing_mode", @out: false, min: 0, max: 1)]
            public string @AudioPackingMode { get; }

            [nterraform.Core.TerraformProperty(name: "bit_rate", @out: false, min: 0, max: 1)]
            public string @BitRate { get; }

            [nterraform.Core.TerraformProperty(name: "channels", @out: false, min: 0, max: 1)]
            public string @Channels { get; }

            [nterraform.Core.TerraformProperty(name: "codec", @out: false, min: 0, max: 1)]
            public string @Codec { get; }

            [nterraform.Core.TerraformProperty(name: "sample_rate", @out: false, min: 0, max: 1)]
            public string @SampleRate { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "audio_codec_options")]
        public sealed class audio_codec_options : nterraform.Core.structure
        {
            public audio_codec_options(string @bitDepth = null,
                                       string @bitOrder = null,
                                       string @profile = null,
                                       string @signed = null)
            {
                @BitDepth = @bitDepth;
                @BitOrder = @bitOrder;
                @Profile = @profile;
                @Signed = @signed;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bit_depth", @out: false, min: 0, max: 1)]
            public string @BitDepth { get; }

            [nterraform.Core.TerraformProperty(name: "bit_order", @out: false, min: 0, max: 1)]
            public string @BitOrder { get; }

            [nterraform.Core.TerraformProperty(name: "profile", @out: false, min: 0, max: 1)]
            public string @Profile { get; }

            [nterraform.Core.TerraformProperty(name: "signed", @out: false, min: 0, max: 1)]
            public string @Signed { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "video")]
        public sealed class video : nterraform.Core.structure
        {
            public video(string @aspectRatio = null,
                         string @bitRate = null,
                         string @codec = null,
                         string @displayAspectRatio = null,
                         string @fixedGop = null,
                         string @frameRate = null,
                         string @keyframesMaxDist = null,
                         string @maxFrameRate = null,
                         string @maxHeight = null,
                         string @maxWidth = null,
                         string @paddingPolicy = null,
                         string @resolution = null,
                         string @sizingPolicy = null)
            {
                @AspectRatio = @aspectRatio;
                @BitRate = @bitRate;
                @Codec = @codec;
                @DisplayAspectRatio = @displayAspectRatio;
                @FixedGop = @fixedGop;
                @FrameRate = @frameRate;
                @KeyframesMaxDist = @keyframesMaxDist;
                @MaxFrameRate = @maxFrameRate;
                @MaxHeight = @maxHeight;
                @MaxWidth = @maxWidth;
                @PaddingPolicy = @paddingPolicy;
                @Resolution = @resolution;
                @SizingPolicy = @sizingPolicy;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "aspect_ratio", @out: false, min: 0, max: 1)]
            public string @AspectRatio { get; }

            [nterraform.Core.TerraformProperty(name: "bit_rate", @out: false, min: 0, max: 1)]
            public string @BitRate { get; }

            [nterraform.Core.TerraformProperty(name: "codec", @out: false, min: 0, max: 1)]
            public string @Codec { get; }

            [nterraform.Core.TerraformProperty(name: "display_aspect_ratio", @out: false, min: 0, max: 1)]
            public string @DisplayAspectRatio { get; }

            [nterraform.Core.TerraformProperty(name: "fixed_gop", @out: false, min: 0, max: 1)]
            public string @FixedGop { get; }

            [nterraform.Core.TerraformProperty(name: "frame_rate", @out: false, min: 0, max: 1)]
            public string @FrameRate { get; }

            [nterraform.Core.TerraformProperty(name: "keyframes_max_dist", @out: false, min: 0, max: 1)]
            public string @KeyframesMaxDist { get; }

            [nterraform.Core.TerraformProperty(name: "max_frame_rate", @out: false, min: 0, max: 1)]
            public string @MaxFrameRate { get; }

            [nterraform.Core.TerraformProperty(name: "max_height", @out: false, min: 0, max: 1)]
            public string @MaxHeight { get; }

            [nterraform.Core.TerraformProperty(name: "max_width", @out: false, min: 0, max: 1)]
            public string @MaxWidth { get; }

            [nterraform.Core.TerraformProperty(name: "padding_policy", @out: false, min: 0, max: 1)]
            public string @PaddingPolicy { get; }

            [nterraform.Core.TerraformProperty(name: "resolution", @out: false, min: 0, max: 1)]
            public string @Resolution { get; }

            [nterraform.Core.TerraformProperty(name: "sizing_policy", @out: false, min: 0, max: 1)]
            public string @SizingPolicy { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "thumbnails")]
        public sealed class thumbnails : nterraform.Core.structure
        {
            public thumbnails(string @aspectRatio = null,
                              string @format = null,
                              string @interval = null,
                              string @maxHeight = null,
                              string @maxWidth = null,
                              string @paddingPolicy = null,
                              string @resolution = null,
                              string @sizingPolicy = null)
            {
                @AspectRatio = @aspectRatio;
                @Format = @format;
                @Interval = @interval;
                @MaxHeight = @maxHeight;
                @MaxWidth = @maxWidth;
                @PaddingPolicy = @paddingPolicy;
                @Resolution = @resolution;
                @SizingPolicy = @sizingPolicy;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "aspect_ratio", @out: false, min: 0, max: 1)]
            public string @AspectRatio { get; }

            [nterraform.Core.TerraformProperty(name: "format", @out: false, min: 0, max: 1)]
            public string @Format { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public string @Interval { get; }

            [nterraform.Core.TerraformProperty(name: "max_height", @out: false, min: 0, max: 1)]
            public string @MaxHeight { get; }

            [nterraform.Core.TerraformProperty(name: "max_width", @out: false, min: 0, max: 1)]
            public string @MaxWidth { get; }

            [nterraform.Core.TerraformProperty(name: "padding_policy", @out: false, min: 0, max: 1)]
            public string @PaddingPolicy { get; }

            [nterraform.Core.TerraformProperty(name: "resolution", @out: false, min: 0, max: 1)]
            public string @Resolution { get; }

            [nterraform.Core.TerraformProperty(name: "sizing_policy", @out: false, min: 0, max: 1)]
            public string @SizingPolicy { get; }
        }

        public aws_elastictranscoder_preset(string @container,
                                            audio[] @audio = null,
                                            audio_codec_options[] @audioCodecOptions = null,
                                            string @description = null,
                                            thumbnails[] @thumbnails = null,
                                            video[] @video = null,
                                            Dictionary<string,string> @videoCodecOptions = null,
                                            video_watermarks[] @videoWatermarks = null)
        {
            @Container = @container;
            @Audio = @audio;
            @AudioCodecOptions = @audioCodecOptions;
            @Description = @description;
            @Thumbnails = @thumbnails;
            @Video = @video;
            @VideoCodecOptions = @videoCodecOptions;
            @VideoWatermarks = @videoWatermarks;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "container", @out: false, min: 1, max: 1)]
        public string @Container { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "audio", @out: false, min: 0, max: 1)]
        public audio[] @Audio { get; }

        [nterraform.Core.TerraformProperty(name: "audio_codec_options", @out: false, min: 0, max: 1)]
        public audio_codec_options[] @AudioCodecOptions { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "thumbnails", @out: false, min: 0, max: 1)]
        public thumbnails[] @Thumbnails { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "video", @out: false, min: 0, max: 1)]
        public video[] @Video { get; }

        [nterraform.Core.TerraformProperty(name: "video_codec_options", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @VideoCodecOptions { get; }

        [nterraform.Core.TerraformProperty(name: "video_watermarks", @out: false, min: 0, max: 0)]
        public video_watermarks[] @VideoWatermarks { get; }
    }

}
