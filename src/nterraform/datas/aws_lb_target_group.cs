using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_lb_target_group")]
    public sealed class aws_lb_target_group : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "health_check")]
        public sealed class health_check : nterraform.structure
        {
            public health_check()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "healthy_threshold", @out: true, min: 0, max: 1)]
            public int? @HealthyThreshold { get; }

            [nterraform.TerraformProperty(name: "interval", @out: true, min: 0, max: 1)]
            public int? @Interval { get; }

            [nterraform.TerraformProperty(name: "matcher", @out: true, min: 0, max: 1)]
            public string @Matcher { get; }

            [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
            public string @Path { get; }

            [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public string @Port { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "timeout", @out: true, min: 0, max: 1)]
            public int? @Timeout { get; }

            [nterraform.TerraformProperty(name: "unhealthy_threshold", @out: true, min: 0, max: 1)]
            public int? @UnhealthyThreshold { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "stickiness")]
        public sealed class stickiness : nterraform.structure
        {
            public stickiness()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cookie_duration", @out: true, min: 0, max: 1)]
            public int? @CookieDuration { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_lb_target_group(health_check[] @healthCheck = null,
                                   stickiness[] @stickiness = null)
        {
            @HealthCheck = @healthCheck;
            @Stickiness = @stickiness;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "arn_suffix", @out: true, min: 0, max: 1)]
        public string @ArnSuffix { get; }

        [nterraform.TerraformProperty(name: "deregistration_delay", @out: true, min: 0, max: 1)]
        public int? @DeregistrationDelay { get; }

        [nterraform.TerraformProperty(name: "health_check", @out: false, min: 0, max: 1)]
        public health_check[] @HealthCheck { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "slow_start", @out: true, min: 0, max: 1)]
        public int? @SlowStart { get; }

        [nterraform.TerraformProperty(name: "stickiness", @out: false, min: 0, max: 1)]
        public stickiness[] @Stickiness { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
