using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloud9_environment_ec2")]
    public sealed class aws_cloud9_environment_ec2 : nterraform.Core.resource
    {
        public aws_cloud9_environment_ec2(string @instanceType,
                                          string @name,
                                          int? @automaticStopTimeMinutes = null,
                                          string @description = null,
                                          string @subnetId = null)
        {
            @InstanceType = @instanceType;
            @Name = @name;
            @AutomaticStopTimeMinutes = @automaticStopTimeMinutes;
            @Description = @description;
            @SubnetId = @subnetId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "automatic_stop_time_minutes", @out: false, min: 0, max: 1)]
        public int? @AutomaticStopTimeMinutes { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "owner_arn", @out: true, min: 0, max: 1)]
        public string @OwnerArn { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
