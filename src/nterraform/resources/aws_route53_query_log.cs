using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route53_query_log")]
    public sealed class aws_route53_query_log : nterraform.Core.resource
    {
        public aws_route53_query_log(string @cloudwatchLogGroupArn,
                                     string @zoneId)
        {
            @CloudwatchLogGroupArn = @cloudwatchLogGroupArn;
            @ZoneId = @zoneId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cloudwatch_log_group_arn", @out: false, min: 1, max: 1)]
        public string @CloudwatchLogGroupArn { get; }

        [nterraform.Core.TerraformProperty(name: "zone_id", @out: false, min: 1, max: 1)]
        public string @ZoneId { get; }
    }

}
