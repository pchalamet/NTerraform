using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ebs_volume")]
    public sealed class aws_ebs_volume : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ebs_volume(filter[] @filter = null,
                              bool? @mostRecent = null)
        {
            @Filter = @filter;
            @MostRecent = @mostRecent;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
        public int? @Iops { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.TerraformProperty(name: "size", @out: true, min: 0, max: 1)]
        public int? @Size { get; }

        [nterraform.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
        public string @SnapshotId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "volume_id", @out: true, min: 0, max: 1)]
        public string @VolumeId { get; }

        [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
        public string @VolumeType { get; }
    }

}
