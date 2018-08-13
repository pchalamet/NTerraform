using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloud9_environment_ec2")]
    public sealed class aws_cloud9_environment_ec2 : nterraform.resource
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

        [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "automatic_stop_time_minutes", @out: false, min: 0, max: 1)]
        public int? @AutomaticStopTimeMinutes { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "owner_arn", @out: true, min: 0, max: 1)]
        public string @OwnerArn { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
