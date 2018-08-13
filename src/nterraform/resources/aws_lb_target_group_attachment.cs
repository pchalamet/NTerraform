using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lb_target_group_attachment")]
    public sealed class aws_lb_target_group_attachment : nterraform.resource
    {
        public aws_lb_target_group_attachment(string @targetGroupArn,
                                              string @targetId,
                                              string @availabilityZone = null,
                                              int? @port = null)
        {
            @TargetGroupArn = @targetGroupArn;
            @TargetId = @targetId;
            @AvailabilityZone = @availabilityZone;
            @Port = @port;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "target_group_arn", @out: false, min: 1, max: 1)]
        public string @TargetGroupArn { get; }

        [nterraform.TerraformProperty(name: "target_id", @out: false, min: 1, max: 1)]
        public string @TargetId { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: false, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }
    }

}
