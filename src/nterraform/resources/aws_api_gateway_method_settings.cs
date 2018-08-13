using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_method_settings")]
    public sealed class aws_api_gateway_method_settings : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "settings")]
        public sealed class settings : nterraform.structure
        {
            public settings(bool? @cacheDataEncrypted = null,
                            int? @cacheTtlInSeconds = null,
                            bool? @cachingEnabled = null,
                            bool? @dataTraceEnabled = null,
                            string @loggingLevel = null,
                            bool? @metricsEnabled = null,
                            bool? @requireAuthorizationForCacheControl = null,
                            int? @throttlingBurstLimit = null,
                            int? @throttlingRateLimit = null,
                            string @unauthorizedCacheControlHeaderStrategy = null)
            {
                @CacheDataEncrypted = @cacheDataEncrypted;
                @CacheTtlInSeconds = @cacheTtlInSeconds;
                @CachingEnabled = @cachingEnabled;
                @DataTraceEnabled = @dataTraceEnabled;
                @LoggingLevel = @loggingLevel;
                @MetricsEnabled = @metricsEnabled;
                @RequireAuthorizationForCacheControl = @requireAuthorizationForCacheControl;
                @ThrottlingBurstLimit = @throttlingBurstLimit;
                @ThrottlingRateLimit = @throttlingRateLimit;
                @UnauthorizedCacheControlHeaderStrategy = @unauthorizedCacheControlHeaderStrategy;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cache_data_encrypted", @out: false, min: 0, max: 1)]
            public bool? @CacheDataEncrypted { get; }

            [nterraform.TerraformProperty(name: "cache_ttl_in_seconds", @out: false, min: 0, max: 1)]
            public int? @CacheTtlInSeconds { get; }

            [nterraform.TerraformProperty(name: "caching_enabled", @out: false, min: 0, max: 1)]
            public bool? @CachingEnabled { get; }

            [nterraform.TerraformProperty(name: "data_trace_enabled", @out: false, min: 0, max: 1)]
            public bool? @DataTraceEnabled { get; }

            [nterraform.TerraformProperty(name: "logging_level", @out: false, min: 0, max: 1)]
            public string @LoggingLevel { get; }

            [nterraform.TerraformProperty(name: "metrics_enabled", @out: false, min: 0, max: 1)]
            public bool? @MetricsEnabled { get; }

            [nterraform.TerraformProperty(name: "require_authorization_for_cache_control", @out: false, min: 0, max: 1)]
            public bool? @RequireAuthorizationForCacheControl { get; }

            [nterraform.TerraformProperty(name: "throttling_burst_limit", @out: false, min: 0, max: 1)]
            public int? @ThrottlingBurstLimit { get; }

            [nterraform.TerraformProperty(name: "throttling_rate_limit", @out: false, min: 0, max: 1)]
            public int? @ThrottlingRateLimit { get; }

            [nterraform.TerraformProperty(name: "unauthorized_cache_control_header_strategy", @out: false, min: 0, max: 1)]
            public string @UnauthorizedCacheControlHeaderStrategy { get; }
        }

        public aws_api_gateway_method_settings(string @methodPath,
                                               string @restApiId,
                                               settings[] @settings,
                                               string @stageName)
        {
            @MethodPath = @methodPath;
            @RestApiId = @restApiId;
            @Settings = @settings;
            @StageName = @stageName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "method_path", @out: false, min: 1, max: 1)]
        public string @MethodPath { get; }

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.TerraformProperty(name: "settings", @out: false, min: 1, max: 1)]
        public settings[] @Settings { get; }

        [nterraform.TerraformProperty(name: "stage_name", @out: false, min: 1, max: 1)]
        public string @StageName { get; }
    }

}
