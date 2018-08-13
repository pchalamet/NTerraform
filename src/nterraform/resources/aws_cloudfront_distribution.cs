using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudfront_distribution")]
    public sealed class aws_cloudfront_distribution : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "logging_config")]
        public sealed class logging_config : nterraform.structure
        {
            public logging_config(string @bucket,
                                  bool? @includeCookies = null,
                                  string @prefix = null)
            {
                @Bucket = @bucket;
                @IncludeCookies = @includeCookies;
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
            public string @Bucket { get; }

            [nterraform.TerraformProperty(name: "include_cookies", @out: false, min: 0, max: 1)]
            public bool? @IncludeCookies { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "origin")]
        public sealed class origin : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "custom_origin_config")]
            public sealed class custom_origin_config : nterraform.structure
            {
                public custom_origin_config(int @httpPort,
                                            int @httpsPort,
                                            string @originProtocolPolicy,
                                            string[] @originSslProtocols,
                                            int? @originKeepaliveTimeout = null,
                                            int? @originReadTimeout = null)
                {
                    @HttpPort = @httpPort;
                    @HttpsPort = @httpsPort;
                    @OriginProtocolPolicy = @originProtocolPolicy;
                    @OriginSslProtocols = @originSslProtocols;
                    @OriginKeepaliveTimeout = @originKeepaliveTimeout;
                    @OriginReadTimeout = @originReadTimeout;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "http_port", @out: false, min: 1, max: 1)]
                public int @HttpPort { get; }

                [nterraform.TerraformProperty(name: "https_port", @out: false, min: 1, max: 1)]
                public int @HttpsPort { get; }

                [nterraform.TerraformProperty(name: "origin_protocol_policy", @out: false, min: 1, max: 1)]
                public string @OriginProtocolPolicy { get; }

                [nterraform.TerraformProperty(name: "origin_ssl_protocols", @out: false, min: 1, max: 1)]
                public string[] @OriginSslProtocols { get; }

                [nterraform.TerraformProperty(name: "origin_keepalive_timeout", @out: false, min: 0, max: 1)]
                public int? @OriginKeepaliveTimeout { get; }

                [nterraform.TerraformProperty(name: "origin_read_timeout", @out: false, min: 0, max: 1)]
                public int? @OriginReadTimeout { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "custom_header")]
            public sealed class custom_header : nterraform.structure
            {
                public custom_header(string @name,
                                     string @value)
                {
                    @Name = @name;
                    @Value = @value;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "s3_origin_config")]
            public sealed class s3_origin_config : nterraform.structure
            {
                public s3_origin_config(string @originAccessIdentity)
                {
                    @OriginAccessIdentity = @originAccessIdentity;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "origin_access_identity", @out: false, min: 1, max: 1)]
                public string @OriginAccessIdentity { get; }
            }

            public origin(string @domainName,
                          string @originId,
                          custom_header[] @customHeader = null,
                          custom_origin_config[] @customOriginConfig = null,
                          string @originPath = null,
                          s3_origin_config[] @s3OriginConfig = null)
            {
                @DomainName = @domainName;
                @OriginId = @originId;
                @CustomHeader = @customHeader;
                @CustomOriginConfig = @customOriginConfig;
                @OriginPath = @originPath;
                @S3OriginConfig = @s3OriginConfig;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
            public string @DomainName { get; }

            [nterraform.TerraformProperty(name: "origin_id", @out: false, min: 1, max: 1)]
            public string @OriginId { get; }

            [nterraform.TerraformProperty(name: "custom_header", @out: false, min: 0, max: 0)]
            public custom_header[] @CustomHeader { get; }

            [nterraform.TerraformProperty(name: "custom_origin_config", @out: false, min: 0, max: 1)]
            public custom_origin_config[] @CustomOriginConfig { get; }

            [nterraform.TerraformProperty(name: "origin_path", @out: false, min: 0, max: 1)]
            public string @OriginPath { get; }

            [nterraform.TerraformProperty(name: "s3_origin_config", @out: false, min: 0, max: 1)]
            public s3_origin_config[] @S3OriginConfig { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "custom_error_response")]
        public sealed class custom_error_response : nterraform.structure
        {
            public custom_error_response(int @errorCode,
                                         int? @errorCachingMinTtl = null,
                                         int? @responseCode = null,
                                         string @responsePagePath = null)
            {
                @ErrorCode = @errorCode;
                @ErrorCachingMinTtl = @errorCachingMinTtl;
                @ResponseCode = @responseCode;
                @ResponsePagePath = @responsePagePath;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "error_code", @out: false, min: 1, max: 1)]
            public int @ErrorCode { get; }

            [nterraform.TerraformProperty(name: "error_caching_min_ttl", @out: false, min: 0, max: 1)]
            public int? @ErrorCachingMinTtl { get; }

            [nterraform.TerraformProperty(name: "response_code", @out: false, min: 0, max: 1)]
            public int? @ResponseCode { get; }

            [nterraform.TerraformProperty(name: "response_page_path", @out: false, min: 0, max: 1)]
            public string @ResponsePagePath { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "restrictions")]
        public sealed class restrictions : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "geo_restriction")]
            public sealed class geo_restriction : nterraform.structure
            {
                public geo_restriction(string @restrictionType,
                                       string[] @locations = null)
                {
                    @RestrictionType = @restrictionType;
                    @Locations = @locations;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "restriction_type", @out: false, min: 1, max: 1)]
                public string @RestrictionType { get; }

                [nterraform.TerraformProperty(name: "locations", @out: false, min: 0, max: 1)]
                public string[] @Locations { get; }
            }

            public restrictions(geo_restriction[] @geoRestriction)
            {
                @GeoRestriction = @geoRestriction;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "geo_restriction", @out: false, min: 1, max: 1)]
            public geo_restriction[] @GeoRestriction { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "default_cache_behavior")]
        public sealed class default_cache_behavior : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "forwarded_values")]
            public sealed class forwarded_values : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "cookies")]
                public sealed class cookies : nterraform.structure
                {
                    public cookies(string @forward,
                                   string[] @whitelistedNames = null)
                    {
                        @Forward = @forward;
                        @WhitelistedNames = @whitelistedNames;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "forward", @out: false, min: 1, max: 1)]
                    public string @Forward { get; }

                    [nterraform.TerraformProperty(name: "whitelisted_names", @out: false, min: 0, max: 1)]
                    public string[] @WhitelistedNames { get; }
                }

                public forwarded_values(cookies[] @cookies,
                                        bool @queryString,
                                        string[] @headers = null,
                                        string[] @queryStringCacheKeys = null)
                {
                    @Cookies = @cookies;
                    @QueryString = @queryString;
                    @Headers = @headers;
                    @QueryStringCacheKeys = @queryStringCacheKeys;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "cookies", @out: false, min: 1, max: 1)]
                public cookies[] @Cookies { get; }

                [nterraform.TerraformProperty(name: "query_string", @out: false, min: 1, max: 1)]
                public bool @QueryString { get; }

                [nterraform.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
                public string[] @Headers { get; }

                [nterraform.TerraformProperty(name: "query_string_cache_keys", @out: false, min: 0, max: 1)]
                public string[] @QueryStringCacheKeys { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "lambda_function_association")]
            public sealed class lambda_function_association : nterraform.structure
            {
                public lambda_function_association(string @eventType,
                                                   string @lambdaArn)
                {
                    @EventType = @eventType;
                    @LambdaArn = @lambdaArn;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "event_type", @out: false, min: 1, max: 1)]
                public string @EventType { get; }

                [nterraform.TerraformProperty(name: "lambda_arn", @out: false, min: 1, max: 1)]
                public string @LambdaArn { get; }
            }

            public default_cache_behavior(string[] @allowedMethods,
                                          string[] @cachedMethods,
                                          forwarded_values[] @forwardedValues,
                                          string @targetOriginId,
                                          string @viewerProtocolPolicy,
                                          bool? @compress = null,
                                          int? @defaultTtl = null,
                                          string @fieldLevelEncryptionId = null,
                                          lambda_function_association[] @lambdaFunctionAssociation = null,
                                          int? @maxTtl = null,
                                          int? @minTtl = null,
                                          bool? @smoothStreaming = null,
                                          string[] @trustedSigners = null)
            {
                @AllowedMethods = @allowedMethods;
                @CachedMethods = @cachedMethods;
                @ForwardedValues = @forwardedValues;
                @TargetOriginId = @targetOriginId;
                @ViewerProtocolPolicy = @viewerProtocolPolicy;
                @Compress = @compress;
                @DefaultTtl = @defaultTtl;
                @FieldLevelEncryptionId = @fieldLevelEncryptionId;
                @LambdaFunctionAssociation = @lambdaFunctionAssociation;
                @MaxTtl = @maxTtl;
                @MinTtl = @minTtl;
                @SmoothStreaming = @smoothStreaming;
                @TrustedSigners = @trustedSigners;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allowed_methods", @out: false, min: 1, max: 1)]
            public string[] @AllowedMethods { get; }

            [nterraform.TerraformProperty(name: "cached_methods", @out: false, min: 1, max: 1)]
            public string[] @CachedMethods { get; }

            [nterraform.TerraformProperty(name: "forwarded_values", @out: false, min: 1, max: 1)]
            public forwarded_values[] @ForwardedValues { get; }

            [nterraform.TerraformProperty(name: "target_origin_id", @out: false, min: 1, max: 1)]
            public string @TargetOriginId { get; }

            [nterraform.TerraformProperty(name: "viewer_protocol_policy", @out: false, min: 1, max: 1)]
            public string @ViewerProtocolPolicy { get; }

            [nterraform.TerraformProperty(name: "compress", @out: false, min: 0, max: 1)]
            public bool? @Compress { get; }

            [nterraform.TerraformProperty(name: "default_ttl", @out: false, min: 0, max: 1)]
            public int? @DefaultTtl { get; }

            [nterraform.TerraformProperty(name: "field_level_encryption_id", @out: false, min: 0, max: 1)]
            public string @FieldLevelEncryptionId { get; }

            [nterraform.TerraformProperty(name: "lambda_function_association", @out: false, min: 0, max: 4)]
            public lambda_function_association[] @LambdaFunctionAssociation { get; }

            [nterraform.TerraformProperty(name: "max_ttl", @out: false, min: 0, max: 1)]
            public int? @MaxTtl { get; }

            [nterraform.TerraformProperty(name: "min_ttl", @out: false, min: 0, max: 1)]
            public int? @MinTtl { get; }

            [nterraform.TerraformProperty(name: "smooth_streaming", @out: false, min: 0, max: 1)]
            public bool? @SmoothStreaming { get; }

            [nterraform.TerraformProperty(name: "trusted_signers", @out: false, min: 0, max: 1)]
            public string[] @TrustedSigners { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ordered_cache_behavior")]
        public sealed class ordered_cache_behavior : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "forwarded_values")]
            public sealed class forwarded_values : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "cookies")]
                public sealed class cookies : nterraform.structure
                {
                    public cookies(string @forward,
                                   string[] @whitelistedNames = null)
                    {
                        @Forward = @forward;
                        @WhitelistedNames = @whitelistedNames;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "forward", @out: false, min: 1, max: 1)]
                    public string @Forward { get; }

                    [nterraform.TerraformProperty(name: "whitelisted_names", @out: false, min: 0, max: 1)]
                    public string[] @WhitelistedNames { get; }
                }

                public forwarded_values(cookies[] @cookies,
                                        bool @queryString,
                                        string[] @headers = null,
                                        string[] @queryStringCacheKeys = null)
                {
                    @Cookies = @cookies;
                    @QueryString = @queryString;
                    @Headers = @headers;
                    @QueryStringCacheKeys = @queryStringCacheKeys;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "cookies", @out: false, min: 1, max: 1)]
                public cookies[] @Cookies { get; }

                [nterraform.TerraformProperty(name: "query_string", @out: false, min: 1, max: 1)]
                public bool @QueryString { get; }

                [nterraform.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
                public string[] @Headers { get; }

                [nterraform.TerraformProperty(name: "query_string_cache_keys", @out: false, min: 0, max: 1)]
                public string[] @QueryStringCacheKeys { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "lambda_function_association")]
            public sealed class lambda_function_association : nterraform.structure
            {
                public lambda_function_association(string @eventType,
                                                   string @lambdaArn)
                {
                    @EventType = @eventType;
                    @LambdaArn = @lambdaArn;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "event_type", @out: false, min: 1, max: 1)]
                public string @EventType { get; }

                [nterraform.TerraformProperty(name: "lambda_arn", @out: false, min: 1, max: 1)]
                public string @LambdaArn { get; }
            }

            public ordered_cache_behavior(string[] @allowedMethods,
                                          string[] @cachedMethods,
                                          forwarded_values[] @forwardedValues,
                                          string @pathPattern,
                                          string @targetOriginId,
                                          string @viewerProtocolPolicy,
                                          bool? @compress = null,
                                          int? @defaultTtl = null,
                                          string @fieldLevelEncryptionId = null,
                                          lambda_function_association[] @lambdaFunctionAssociation = null,
                                          int? @maxTtl = null,
                                          int? @minTtl = null,
                                          bool? @smoothStreaming = null,
                                          string[] @trustedSigners = null)
            {
                @AllowedMethods = @allowedMethods;
                @CachedMethods = @cachedMethods;
                @ForwardedValues = @forwardedValues;
                @PathPattern = @pathPattern;
                @TargetOriginId = @targetOriginId;
                @ViewerProtocolPolicy = @viewerProtocolPolicy;
                @Compress = @compress;
                @DefaultTtl = @defaultTtl;
                @FieldLevelEncryptionId = @fieldLevelEncryptionId;
                @LambdaFunctionAssociation = @lambdaFunctionAssociation;
                @MaxTtl = @maxTtl;
                @MinTtl = @minTtl;
                @SmoothStreaming = @smoothStreaming;
                @TrustedSigners = @trustedSigners;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allowed_methods", @out: false, min: 1, max: 1)]
            public string[] @AllowedMethods { get; }

            [nterraform.TerraformProperty(name: "cached_methods", @out: false, min: 1, max: 1)]
            public string[] @CachedMethods { get; }

            [nterraform.TerraformProperty(name: "forwarded_values", @out: false, min: 1, max: 1)]
            public forwarded_values[] @ForwardedValues { get; }

            [nterraform.TerraformProperty(name: "path_pattern", @out: false, min: 1, max: 1)]
            public string @PathPattern { get; }

            [nterraform.TerraformProperty(name: "target_origin_id", @out: false, min: 1, max: 1)]
            public string @TargetOriginId { get; }

            [nterraform.TerraformProperty(name: "viewer_protocol_policy", @out: false, min: 1, max: 1)]
            public string @ViewerProtocolPolicy { get; }

            [nterraform.TerraformProperty(name: "compress", @out: false, min: 0, max: 1)]
            public bool? @Compress { get; }

            [nterraform.TerraformProperty(name: "default_ttl", @out: false, min: 0, max: 1)]
            public int? @DefaultTtl { get; }

            [nterraform.TerraformProperty(name: "field_level_encryption_id", @out: false, min: 0, max: 1)]
            public string @FieldLevelEncryptionId { get; }

            [nterraform.TerraformProperty(name: "lambda_function_association", @out: false, min: 0, max: 4)]
            public lambda_function_association[] @LambdaFunctionAssociation { get; }

            [nterraform.TerraformProperty(name: "max_ttl", @out: false, min: 0, max: 1)]
            public int? @MaxTtl { get; }

            [nterraform.TerraformProperty(name: "min_ttl", @out: false, min: 0, max: 1)]
            public int? @MinTtl { get; }

            [nterraform.TerraformProperty(name: "smooth_streaming", @out: false, min: 0, max: 1)]
            public bool? @SmoothStreaming { get; }

            [nterraform.TerraformProperty(name: "trusted_signers", @out: false, min: 0, max: 1)]
            public string[] @TrustedSigners { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "cache_behavior")]
        public sealed class cache_behavior : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "forwarded_values")]
            public sealed class forwarded_values : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "cookies")]
                public sealed class cookies : nterraform.structure
                {
                    public cookies(string @forward,
                                   string[] @whitelistedNames = null)
                    {
                        @Forward = @forward;
                        @WhitelistedNames = @whitelistedNames;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "forward", @out: false, min: 1, max: 1)]
                    public string @Forward { get; }

                    [nterraform.TerraformProperty(name: "whitelisted_names", @out: false, min: 0, max: 1)]
                    public string[] @WhitelistedNames { get; }
                }

                public forwarded_values(cookies[] @cookies,
                                        bool @queryString,
                                        string[] @headers = null,
                                        string[] @queryStringCacheKeys = null)
                {
                    @Cookies = @cookies;
                    @QueryString = @queryString;
                    @Headers = @headers;
                    @QueryStringCacheKeys = @queryStringCacheKeys;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "cookies", @out: false, min: 1, max: 1)]
                public cookies[] @Cookies { get; }

                [nterraform.TerraformProperty(name: "query_string", @out: false, min: 1, max: 1)]
                public bool @QueryString { get; }

                [nterraform.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
                public string[] @Headers { get; }

                [nterraform.TerraformProperty(name: "query_string_cache_keys", @out: false, min: 0, max: 1)]
                public string[] @QueryStringCacheKeys { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "lambda_function_association")]
            public sealed class lambda_function_association : nterraform.structure
            {
                public lambda_function_association(string @eventType,
                                                   string @lambdaArn)
                {
                    @EventType = @eventType;
                    @LambdaArn = @lambdaArn;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "event_type", @out: false, min: 1, max: 1)]
                public string @EventType { get; }

                [nterraform.TerraformProperty(name: "lambda_arn", @out: false, min: 1, max: 1)]
                public string @LambdaArn { get; }
            }

            public cache_behavior(string[] @allowedMethods,
                                  string[] @cachedMethods,
                                  forwarded_values[] @forwardedValues,
                                  string @pathPattern,
                                  string @targetOriginId,
                                  string @viewerProtocolPolicy,
                                  bool? @compress = null,
                                  int? @defaultTtl = null,
                                  string @fieldLevelEncryptionId = null,
                                  lambda_function_association[] @lambdaFunctionAssociation = null,
                                  int? @maxTtl = null,
                                  int? @minTtl = null,
                                  bool? @smoothStreaming = null,
                                  string[] @trustedSigners = null)
            {
                @AllowedMethods = @allowedMethods;
                @CachedMethods = @cachedMethods;
                @ForwardedValues = @forwardedValues;
                @PathPattern = @pathPattern;
                @TargetOriginId = @targetOriginId;
                @ViewerProtocolPolicy = @viewerProtocolPolicy;
                @Compress = @compress;
                @DefaultTtl = @defaultTtl;
                @FieldLevelEncryptionId = @fieldLevelEncryptionId;
                @LambdaFunctionAssociation = @lambdaFunctionAssociation;
                @MaxTtl = @maxTtl;
                @MinTtl = @minTtl;
                @SmoothStreaming = @smoothStreaming;
                @TrustedSigners = @trustedSigners;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allowed_methods", @out: false, min: 1, max: 1)]
            public string[] @AllowedMethods { get; }

            [nterraform.TerraformProperty(name: "cached_methods", @out: false, min: 1, max: 1)]
            public string[] @CachedMethods { get; }

            [nterraform.TerraformProperty(name: "forwarded_values", @out: false, min: 1, max: 1)]
            public forwarded_values[] @ForwardedValues { get; }

            [nterraform.TerraformProperty(name: "path_pattern", @out: false, min: 1, max: 1)]
            public string @PathPattern { get; }

            [nterraform.TerraformProperty(name: "target_origin_id", @out: false, min: 1, max: 1)]
            public string @TargetOriginId { get; }

            [nterraform.TerraformProperty(name: "viewer_protocol_policy", @out: false, min: 1, max: 1)]
            public string @ViewerProtocolPolicy { get; }

            [nterraform.TerraformProperty(name: "compress", @out: false, min: 0, max: 1)]
            public bool? @Compress { get; }

            [nterraform.TerraformProperty(name: "default_ttl", @out: false, min: 0, max: 1)]
            public int? @DefaultTtl { get; }

            [nterraform.TerraformProperty(name: "field_level_encryption_id", @out: false, min: 0, max: 1)]
            public string @FieldLevelEncryptionId { get; }

            [nterraform.TerraformProperty(name: "lambda_function_association", @out: false, min: 0, max: 4)]
            public lambda_function_association[] @LambdaFunctionAssociation { get; }

            [nterraform.TerraformProperty(name: "max_ttl", @out: false, min: 0, max: 1)]
            public int? @MaxTtl { get; }

            [nterraform.TerraformProperty(name: "min_ttl", @out: false, min: 0, max: 1)]
            public int? @MinTtl { get; }

            [nterraform.TerraformProperty(name: "smooth_streaming", @out: false, min: 0, max: 1)]
            public bool? @SmoothStreaming { get; }

            [nterraform.TerraformProperty(name: "trusted_signers", @out: false, min: 0, max: 1)]
            public string[] @TrustedSigners { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "viewer_certificate")]
        public sealed class viewer_certificate : nterraform.structure
        {
            public viewer_certificate(string @acmCertificateArn = null,
                                      bool? @cloudfrontDefaultCertificate = null,
                                      string @iamCertificateId = null,
                                      string @minimumProtocolVersion = null,
                                      string @sslSupportMethod = null)
            {
                @AcmCertificateArn = @acmCertificateArn;
                @CloudfrontDefaultCertificate = @cloudfrontDefaultCertificate;
                @IamCertificateId = @iamCertificateId;
                @MinimumProtocolVersion = @minimumProtocolVersion;
                @SslSupportMethod = @sslSupportMethod;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "acm_certificate_arn", @out: false, min: 0, max: 1)]
            public string @AcmCertificateArn { get; }

            [nterraform.TerraformProperty(name: "cloudfront_default_certificate", @out: false, min: 0, max: 1)]
            public bool? @CloudfrontDefaultCertificate { get; }

            [nterraform.TerraformProperty(name: "iam_certificate_id", @out: false, min: 0, max: 1)]
            public string @IamCertificateId { get; }

            [nterraform.TerraformProperty(name: "minimum_protocol_version", @out: false, min: 0, max: 1)]
            public string @MinimumProtocolVersion { get; }

            [nterraform.TerraformProperty(name: "ssl_support_method", @out: false, min: 0, max: 1)]
            public string @SslSupportMethod { get; }
        }

        public aws_cloudfront_distribution(default_cache_behavior[] @defaultCacheBehavior,
                                           bool @enabled,
                                           origin[] @origin,
                                           restrictions[] @restrictions,
                                           viewer_certificate[] @viewerCertificate,
                                           string[] @aliases = null,
                                           cache_behavior[] @cacheBehavior = null,
                                           string @comment = null,
                                           custom_error_response[] @customErrorResponse = null,
                                           string @defaultRootObject = null,
                                           string @httpVersion = null,
                                           bool? @isIpv6Enabled = null,
                                           logging_config[] @loggingConfig = null,
                                           ordered_cache_behavior[] @orderedCacheBehavior = null,
                                           string @priceClass = null,
                                           bool? @retainOnDelete = null,
                                           Dictionary<string,string> @tags = null,
                                           string @webAclId = null)
        {
            @DefaultCacheBehavior = @defaultCacheBehavior;
            @Enabled = @enabled;
            @Origin = @origin;
            @Restrictions = @restrictions;
            @ViewerCertificate = @viewerCertificate;
            @Aliases = @aliases;
            @CacheBehavior = @cacheBehavior;
            @Comment = @comment;
            @CustomErrorResponse = @customErrorResponse;
            @DefaultRootObject = @defaultRootObject;
            @HttpVersion = @httpVersion;
            @IsIpv6Enabled = @isIpv6Enabled;
            @LoggingConfig = @loggingConfig;
            @OrderedCacheBehavior = @orderedCacheBehavior;
            @PriceClass = @priceClass;
            @RetainOnDelete = @retainOnDelete;
            @Tags = @tags;
            @WebAclId = @webAclId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "default_cache_behavior", @out: false, min: 1, max: 1)]
        public default_cache_behavior[] @DefaultCacheBehavior { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
        public bool @Enabled { get; }

        [nterraform.TerraformProperty(name: "origin", @out: false, min: 1, max: 0)]
        public origin[] @Origin { get; }

        [nterraform.TerraformProperty(name: "restrictions", @out: false, min: 1, max: 1)]
        public restrictions[] @Restrictions { get; }

        [nterraform.TerraformProperty(name: "viewer_certificate", @out: false, min: 1, max: 1)]
        public viewer_certificate[] @ViewerCertificate { get; }

        [nterraform.TerraformProperty(name: "active_trusted_signers", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @ActiveTrustedSigners { get; }

        [nterraform.TerraformProperty(name: "aliases", @out: false, min: 0, max: 1)]
        public string[] @Aliases { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "cache_behavior", @out: false, min: 0, max: 0)]
        public cache_behavior[] @CacheBehavior { get; }

        [nterraform.TerraformProperty(name: "caller_reference", @out: true, min: 0, max: 1)]
        public string @CallerReference { get; }

        [nterraform.TerraformProperty(name: "comment", @out: false, min: 0, max: 1)]
        public string @Comment { get; }

        [nterraform.TerraformProperty(name: "custom_error_response", @out: false, min: 0, max: 0)]
        public custom_error_response[] @CustomErrorResponse { get; }

        [nterraform.TerraformProperty(name: "default_root_object", @out: false, min: 0, max: 1)]
        public string @DefaultRootObject { get; }

        [nterraform.TerraformProperty(name: "domain_name", @out: true, min: 0, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "etag", @out: true, min: 0, max: 1)]
        public string @Etag { get; }

        [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.TerraformProperty(name: "http_version", @out: false, min: 0, max: 1)]
        public string @HttpVersion { get; }

        [nterraform.TerraformProperty(name: "in_progress_validation_batches", @out: true, min: 0, max: 1)]
        public int? @InProgressValidationBatches { get; }

        [nterraform.TerraformProperty(name: "is_ipv6_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsIpv6Enabled { get; }

        [nterraform.TerraformProperty(name: "last_modified_time", @out: true, min: 0, max: 1)]
        public string @LastModifiedTime { get; }

        [nterraform.TerraformProperty(name: "logging_config", @out: false, min: 0, max: 1)]
        public logging_config[] @LoggingConfig { get; }

        [nterraform.TerraformProperty(name: "ordered_cache_behavior", @out: false, min: 0, max: 0)]
        public ordered_cache_behavior[] @OrderedCacheBehavior { get; }

        [nterraform.TerraformProperty(name: "price_class", @out: false, min: 0, max: 1)]
        public string @PriceClass { get; }

        [nterraform.TerraformProperty(name: "retain_on_delete", @out: false, min: 0, max: 1)]
        public bool? @RetainOnDelete { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "web_acl_id", @out: false, min: 0, max: 1)]
        public string @WebAclId { get; }
    }

}
