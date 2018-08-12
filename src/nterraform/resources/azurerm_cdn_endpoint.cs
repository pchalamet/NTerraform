using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_cdn_endpoint")]
    public sealed class azurerm_cdn_endpoint : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "origin")]
        public sealed class origin : nterraform.Core.structure
        {
            public origin(string @hostName,
                          string @name,
                          FSharpOption<int> @httpPort = null,
                          FSharpOption<int> @httpsPort = null)
            {
                @HostName = @hostName;
                @Name = @name;
                @HttpPort = @httpPort;
                @HttpsPort = @httpsPort;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "host_name", @out: false, min: 1, max: 1)]
            public string @HostName { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "http_port", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @HttpPort { get; }

            [nterraform.Core.TerraformProperty(name: "https_port", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @HttpsPort { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "geo_filter")]
        public sealed class geo_filter : nterraform.Core.structure
        {
            public geo_filter(string @action,
                              FSharpList<string> @countryCodes,
                              string @relativePath)
            {
                @Action = @action;
                @CountryCodes = @countryCodes;
                @RelativePath = @relativePath;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
            public string @Action { get; }

            [nterraform.Core.TerraformProperty(name: "country_codes", @out: false, min: 1, max: 1)]
            public FSharpList<string> @CountryCodes { get; }

            [nterraform.Core.TerraformProperty(name: "relative_path", @out: false, min: 1, max: 1)]
            public string @RelativePath { get; }
        }

        public azurerm_cdn_endpoint(string @location,
                                    string @name,
                                    FSharpList<origin> @origin,
                                    string @profileName,
                                    string @resourceGroupName,
                                    FSharpOption<FSharpList<geo_filter>> @geoFilter = null,
                                    FSharpOption<bool> @isCompressionEnabled = null,
                                    FSharpOption<bool> @isHttpAllowed = null,
                                    FSharpOption<bool> @isHttpsAllowed = null,
                                    FSharpOption<string> @optimizationType = null,
                                    FSharpOption<string> @querystringCachingBehaviour = null)
        {
            @Location = @location;
            @Name = @name;
            @Origin = @origin;
            @ProfileName = @profileName;
            @ResourceGroupName = @resourceGroupName;
            @GeoFilter = @geoFilter ?? FSharpList<geo_filter>.Empty;
            @IsCompressionEnabled = @isCompressionEnabled;
            @IsHttpAllowed = @isHttpAllowed;
            @IsHttpsAllowed = @isHttpsAllowed;
            @OptimizationType = @optimizationType;
            @QuerystringCachingBehaviour = @querystringCachingBehaviour;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "origin", @out: false, min: 1, max: 0)]
        public FSharpList<origin> @Origin { get; }

        [nterraform.Core.TerraformProperty(name: "profile_name", @out: false, min: 1, max: 1)]
        public string @ProfileName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "content_types_to_compress", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @ContentTypesToCompress { get; }

        [nterraform.Core.TerraformProperty(name: "geo_filter", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<geo_filter>> @GeoFilter { get; }

        [nterraform.Core.TerraformProperty(name: "host_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @HostName { get; }

        [nterraform.Core.TerraformProperty(name: "is_compression_enabled", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @IsCompressionEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "is_http_allowed", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @IsHttpAllowed { get; }

        [nterraform.Core.TerraformProperty(name: "is_https_allowed", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @IsHttpsAllowed { get; }

        [nterraform.Core.TerraformProperty(name: "optimization_type", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @OptimizationType { get; }

        [nterraform.Core.TerraformProperty(name: "origin_host_header", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @OriginHostHeader { get; }

        [nterraform.Core.TerraformProperty(name: "origin_path", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @OriginPath { get; }

        [nterraform.Core.TerraformProperty(name: "probe_path", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ProbePath { get; }

        [nterraform.Core.TerraformProperty(name: "querystring_caching_behaviour", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @QuerystringCachingBehaviour { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
