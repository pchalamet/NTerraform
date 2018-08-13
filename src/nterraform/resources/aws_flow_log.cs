using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_flow_log")]
    public sealed class aws_flow_log : nterraform.Core.resource
    {
        public aws_flow_log(string @iamRoleArn,
                            string @logGroupName,
                            string @trafficType,
                            string @eniId = null,
                            string @subnetId = null,
                            string @vpcId = null)
        {
            @IamRoleArn = @iamRoleArn;
            @LogGroupName = @logGroupName;
            @TrafficType = @trafficType;
            @EniId = @eniId;
            @SubnetId = @subnetId;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "iam_role_arn", @out: false, min: 1, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "traffic_type", @out: false, min: 1, max: 1)]
        public string @TrafficType { get; }

        [nterraform.Core.TerraformProperty(name: "eni_id", @out: false, min: 0, max: 1)]
        public string @EniId { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
