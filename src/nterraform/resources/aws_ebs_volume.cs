using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ebs_volume")]
    public sealed class aws_ebs_volume : nterraform.resource
    {
        public aws_ebs_volume(string @availabilityZone,
                              Dictionary<string,string> @tags = null)
        {
            @AvailabilityZone = @availabilityZone;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "availability_zone", @out: false, min: 1, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
        public int? @Iops { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "size", @out: true, min: 0, max: 1)]
        public int? @Size { get; }

        [nterraform.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
        public string @SnapshotId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
