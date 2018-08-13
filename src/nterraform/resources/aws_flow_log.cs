using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_flow_log")]
    public sealed class aws_flow_log : nterraform.resource
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

        [nterraform.TerraformProperty(name: "iam_role_arn", @out: false, min: 1, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.TerraformProperty(name: "traffic_type", @out: false, min: 1, max: 1)]
        public string @TrafficType { get; }

        [nterraform.TerraformProperty(name: "eni_id", @out: false, min: 0, max: 1)]
        public string @EniId { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
