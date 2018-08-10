using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_cdn_endpoint : NTerraform.resource
    {
        public class geo_filter
        {
            public geo_filter(string @action,
                              List<string> @countryCodes,
                              string @relativePath)
            {
                @Action = @action;
                @CountryCodes = @countryCodes;
                @RelativePath = @relativePath;
            }

            public string @Action { get; }
            public List<string> @CountryCodes { get; }
            public string @RelativePath { get; }
        }

        public class origin
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

            public string @HostName { get; }
            public string @Name { get; }
            public int? @HttpPort { get; }
            public int? @HttpsPort { get; }
        }

        public azurerm_cdn_endpoint(string @location,
                                    string @name,
                                    HashSet<origin> @origin,
                                    string @profileName,
                                    string @resourceGroupName,
                                    List<geo_filter> @geoFilter = null,
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

        public string @Location { get; }
        public string @Name { get; }
        public HashSet<origin> @Origin { get; }
        public string @ProfileName { get; }
        public string @ResourceGroupName { get; }
        public HashSet<string> @ContentTypesToCompress { get; }
        public List<geo_filter> @GeoFilter { get; }
        public string @HostName { get; }
        public bool? @IsCompressionEnabled { get; }
        public bool? @IsHttpAllowed { get; }
        public bool? @IsHttpsAllowed { get; }
        public string @OptimizationType { get; }
        public string @OriginHostHeader { get; }
        public string @OriginPath { get; }
        public string @ProbePath { get; }
        public string @QuerystringCachingBehaviour { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
