using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_alb_target_group")]
    public sealed class aws_alb_target_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "health_check")]
        public sealed class health_check : nterraform.Core.structure
        {
            public health_check(int? @healthyThreshold = null,
                                int? @interval = null,
                                string @port = null,
                                string @protocol = null,
                                int? @unhealthyThreshold = null)
            {
                @HealthyThreshold = @healthyThreshold;
                @Interval = @interval;
                @Port = @port;
                @Protocol = @protocol;
                @UnhealthyThreshold = @unhealthyThreshold;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "healthy_threshold", @out: false, min: 0, max: 1)]
            public int? @HealthyThreshold { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public int? @Interval { get; }

            [nterraform.Core.TerraformProperty(name: "matcher", @out: true, min: 0, max: 1)]
            public string @Matcher { get; }

            [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
            public string @Path { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public string @Port { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 0, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "timeout", @out: true, min: 0, max: 1)]
            public int? @Timeout { get; }

            [nterraform.Core.TerraformProperty(name: "unhealthy_threshold", @out: false, min: 0, max: 1)]
            public int? @UnhealthyThreshold { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "stickiness")]
        public sealed class stickiness : nterraform.Core.structure
        {
            public stickiness(string @type,
                              int? @cookieDuration = null,
                              bool? @enabled = null)
            {
                @Type = @type;
                @CookieDuration = @cookieDuration;
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "cookie_duration", @out: false, min: 0, max: 1)]
            public int? @CookieDuration { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        public aws_alb_target_group(int @port,
                                    string @protocol,
                                    string @vpcId,
                                    int? @deregistrationDelay = null,
                                    health_check[] @healthCheck = null,
                                    string @namePrefix = null,
                                    bool? @proxyProtocolV2 = null,
                                    int? @slowStart = null,
                                    stickiness[] @stickiness = null,
                                    Dictionary<string,string> @tags = null,
                                    string @targetType = null)
        {
            @Port = @port;
            @Protocol = @protocol;
            @VpcId = @vpcId;
            @DeregistrationDelay = @deregistrationDelay;
            @HealthCheck = @healthCheck;
            @NamePrefix = @namePrefix;
            @ProxyProtocolV2 = @proxyProtocolV2;
            @SlowStart = @slowStart;
            @Stickiness = @stickiness;
            @Tags = @tags;
            @TargetType = @targetType;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
        public int @Port { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "arn_suffix", @out: true, min: 0, max: 1)]
        public string @ArnSuffix { get; }

        [nterraform.Core.TerraformProperty(name: "deregistration_delay", @out: false, min: 0, max: 1)]
        public int? @DeregistrationDelay { get; }

        [nterraform.Core.TerraformProperty(name: "health_check", @out: false, min: 0, max: 1)]
        public health_check[] @HealthCheck { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "proxy_protocol_v2", @out: false, min: 0, max: 1)]
        public bool? @ProxyProtocolV2 { get; }

        [nterraform.Core.TerraformProperty(name: "slow_start", @out: false, min: 0, max: 1)]
        public int? @SlowStart { get; }

        [nterraform.Core.TerraformProperty(name: "stickiness", @out: false, min: 0, max: 1)]
        public stickiness[] @Stickiness { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "target_type", @out: false, min: 0, max: 1)]
        public string @TargetType { get; }
    }

}
