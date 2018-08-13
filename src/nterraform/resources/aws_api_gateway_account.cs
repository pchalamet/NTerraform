using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_account")]
    public sealed class aws_api_gateway_account : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "throttle_settings")]
        public sealed class throttle_settings : nterraform.Core.structure
        {
            public throttle_settings()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "burst_limit", @out: true, min: 0, max: 1)]
            public int? @BurstLimit { get; }

            [nterraform.Core.TerraformProperty(name: "rate_limit", @out: true, min: 0, max: 1)]
            public int? @RateLimit { get; }
        }

        public aws_api_gateway_account(string @cloudwatchRoleArn = null,
                                       throttle_settings[] @throttleSettings = null)
        {
            @CloudwatchRoleArn = @cloudwatchRoleArn;
            @ThrottleSettings = @throttleSettings;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cloudwatch_role_arn", @out: false, min: 0, max: 1)]
        public string @CloudwatchRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "throttle_settings", @out: false, min: 0, max: 1)]
        public throttle_settings[] @ThrottleSettings { get; }
    }

}
