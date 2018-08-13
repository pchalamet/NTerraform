using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_cdn_endpoint")]
    public sealed class azurerm_cdn_endpoint : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "geo_filter")]
        public sealed class geo_filter : nterraform.structure
        {
            public geo_filter(string @action,
                              string[] @countryCodes,
                              string @relativePath)
            {
                @Action = @action;
                @CountryCodes = @countryCodes;
                @RelativePath = @relativePath;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
            public string @Action { get; }

            [nterraform.TerraformProperty(name: "country_codes", @out: false, min: 1, max: 1)]
            public string[] @CountryCodes { get; }

            [nterraform.TerraformProperty(name: "relative_path", @out: false, min: 1, max: 1)]
            public string @RelativePath { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "origin")]
        public sealed class origin : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "host_name", @out: false, min: 1, max: 1)]
            public string @HostName { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "http_port", @out: false, min: 0, max: 1)]
            public int? @HttpPort { get; }

            [nterraform.TerraformProperty(name: "https_port", @out: false, min: 0, max: 1)]
            public int? @HttpsPort { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "origin", @out: false, min: 1, max: 0)]
        public origin[] @Origin { get; }

        [nterraform.TerraformProperty(name: "profile_name", @out: false, min: 1, max: 1)]
        public string @ProfileName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "content_types_to_compress", @out: true, min: 0, max: 1)]
        public string[] @ContentTypesToCompress { get; }

        [nterraform.TerraformProperty(name: "geo_filter", @out: false, min: 0, max: 0)]
        public geo_filter[] @GeoFilter { get; }

        [nterraform.TerraformProperty(name: "host_name", @out: true, min: 0, max: 1)]
        public string @HostName { get; }

        [nterraform.TerraformProperty(name: "is_compression_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsCompressionEnabled { get; }

        [nterraform.TerraformProperty(name: "is_http_allowed", @out: false, min: 0, max: 1)]
        public bool? @IsHttpAllowed { get; }

        [nterraform.TerraformProperty(name: "is_https_allowed", @out: false, min: 0, max: 1)]
        public bool? @IsHttpsAllowed { get; }

        [nterraform.TerraformProperty(name: "optimization_type", @out: false, min: 0, max: 1)]
        public string @OptimizationType { get; }

        [nterraform.TerraformProperty(name: "origin_host_header", @out: true, min: 0, max: 1)]
        public string @OriginHostHeader { get; }

        [nterraform.TerraformProperty(name: "origin_path", @out: true, min: 0, max: 1)]
        public string @OriginPath { get; }

        [nterraform.TerraformProperty(name: "probe_path", @out: true, min: 0, max: 1)]
        public string @ProbePath { get; }

        [nterraform.TerraformProperty(name: "querystring_caching_behaviour", @out: false, min: 0, max: 1)]
        public string @QuerystringCachingBehaviour { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
