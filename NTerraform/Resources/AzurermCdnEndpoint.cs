using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_cdn_endpoint")]
    public sealed class azurerm_cdn_endpoint : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "origin")]
        public sealed class origin
        {
            public origin(string @hostName,
                          string @name,
                          int? @httpPort = null,
                          int? @httpsPort = null)
            {
                @HostName = @hostName;
                @Name = @name;
                @HttpPort = @httpPort;
                @HttpsPort = @httpsPort;
            }

            [TerraformProperty(name: "host_name", @out: false, min: 1, max: 1)]
            public string @HostName { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "http_port", @out: false, min: 0, max: 1)]
            public int? @HttpPort { get; }

            [TerraformProperty(name: "https_port", @out: false, min: 0, max: 1)]
            public int? @HttpsPort { get; }
        }

        [TerraformStructure(category: "", typeName: "geo_filter")]
        public sealed class geo_filter
        {
            public geo_filter(string @action,
                              string[] @countryCodes,
                              string @relativePath)
            {
                @Action = @action;
                @CountryCodes = @countryCodes;
                @RelativePath = @relativePath;
            }

            [TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
            public string @Action { get; }

            [TerraformProperty(name: "country_codes", @out: false, min: 1, max: 1)]
            public string[] @CountryCodes { get; }

            [TerraformProperty(name: "relative_path", @out: false, min: 1, max: 1)]
            public string @RelativePath { get; }
        }

        public azurerm_cdn_endpoint(string @location,
                                    string @name,
                                    origin[] @origin,
                                    string @profileName,
                                    string @resourceGroupName,
                                    geo_filter[] @geoFilter = null,
                                    bool? @isCompressionEnabled = null,
                                    bool? @isHttpAllowed = null,
                                    bool? @isHttpsAllowed = null,
                                    string @optimizationType = null,
                                    string @querystringCachingBehaviour = null)
        {
            @Location = @location;
            @Name = @name;
            @Origin = @origin;
            @ProfileName = @profileName;
            @ResourceGroupName = @resourceGroupName;
            @GeoFilter = @geoFilter;
            @IsCompressionEnabled = @isCompressionEnabled;
            @IsHttpAllowed = @isHttpAllowed;
            @IsHttpsAllowed = @isHttpsAllowed;
            @OptimizationType = @optimizationType;
            @QuerystringCachingBehaviour = @querystringCachingBehaviour;
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "origin", @out: false, min: 1, max: 0)]
        public origin[] @Origin { get; }

        [TerraformProperty(name: "profile_name", @out: false, min: 1, max: 1)]
        public string @ProfileName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "content_types_to_compress", @out: true, min: 0, max: 1)]
        public string[] @ContentTypesToCompress { get; }

        [TerraformProperty(name: "geo_filter", @out: false, min: 0, max: 0)]
        public geo_filter[] @GeoFilter { get; }

        [TerraformProperty(name: "host_name", @out: true, min: 0, max: 1)]
        public string @HostName { get; }

        [TerraformProperty(name: "is_compression_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsCompressionEnabled { get; }

        [TerraformProperty(name: "is_http_allowed", @out: false, min: 0, max: 1)]
        public bool? @IsHttpAllowed { get; }

        [TerraformProperty(name: "is_https_allowed", @out: false, min: 0, max: 1)]
        public bool? @IsHttpsAllowed { get; }

        [TerraformProperty(name: "optimization_type", @out: false, min: 0, max: 1)]
        public string @OptimizationType { get; }

        [TerraformProperty(name: "origin_host_header", @out: true, min: 0, max: 1)]
        public string @OriginHostHeader { get; }

        [TerraformProperty(name: "origin_path", @out: true, min: 0, max: 1)]
        public string @OriginPath { get; }

        [TerraformProperty(name: "probe_path", @out: true, min: 0, max: 1)]
        public string @ProbePath { get; }

        [TerraformProperty(name: "querystring_caching_behaviour", @out: false, min: 0, max: 1)]
        public string @QuerystringCachingBehaviour { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
