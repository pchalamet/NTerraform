using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_lb_target_group")]
    public sealed class aws_lb_target_group : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "stickiness")]
        public sealed class stickiness : nterraform.Core.structure
        {
            public stickiness()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "cookie_duration", @out: true, min: 0, max: 1)]
            public int? @CookieDuration { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "health_check")]
        public sealed class health_check : nterraform.Core.structure
        {
            public health_check()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "healthy_threshold", @out: true, min: 0, max: 1)]
            public int? @HealthyThreshold { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: true, min: 0, max: 1)]
            public int? @Interval { get; }

            [nterraform.Core.TerraformProperty(name: "matcher", @out: true, min: 0, max: 1)]
            public string @Matcher { get; }

            [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
            public string @Path { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public string @Port { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "timeout", @out: true, min: 0, max: 1)]
            public int? @Timeout { get; }

            [nterraform.Core.TerraformProperty(name: "unhealthy_threshold", @out: true, min: 0, max: 1)]
            public int? @UnhealthyThreshold { get; }
        }

        public aws_lb_target_group(health_check[] @healthCheck = null,
                                   stickiness[] @stickiness = null)
        {
            @HealthCheck = @healthCheck;
            @Stickiness = @stickiness;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "arn_suffix", @out: true, min: 0, max: 1)]
        public string @ArnSuffix { get; }

        [nterraform.Core.TerraformProperty(name: "deregistration_delay", @out: true, min: 0, max: 1)]
        public int? @DeregistrationDelay { get; }

        [nterraform.Core.TerraformProperty(name: "health_check", @out: false, min: 0, max: 1)]
        public health_check[] @HealthCheck { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "slow_start", @out: true, min: 0, max: 1)]
        public int? @SlowStart { get; }

        [nterraform.Core.TerraformProperty(name: "stickiness", @out: false, min: 0, max: 1)]
        public stickiness[] @Stickiness { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
