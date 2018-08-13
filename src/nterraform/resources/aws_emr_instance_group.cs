using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_emr_instance_group")]
    public sealed class aws_emr_instance_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ebs_config")]
        public sealed class ebs_config : nterraform.structure
        {
            public ebs_config(int @size,
                              string @type,
                              int? @iops = null,
                              int? @volumesPerInstance = null)
            {
                @Size = @size;
                @Type = @type;
                @Iops = @iops;
                @VolumesPerInstance = @volumesPerInstance;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
            public int @Size { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.TerraformProperty(name: "volumes_per_instance", @out: false, min: 0, max: 1)]
            public int? @VolumesPerInstance { get; }
        }

        public aws_emr_instance_group(string @clusterId,
                                      string @instanceType,
                                      ebs_config[] @ebsConfig = null,
                                      bool? @ebsOptimized = null,
                                      int? @instanceCount = null,
                                      string @name = null)
        {
            @ClusterId = @clusterId;
            @InstanceType = @instanceType;
            @EbsConfig = @ebsConfig;
            @EbsOptimized = @ebsOptimized;
            @InstanceCount = @instanceCount;
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cluster_id", @out: false, min: 1, max: 1)]
        public string @ClusterId { get; }

        [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "ebs_config", @out: false, min: 0, max: 0)]
        public ebs_config[] @EbsConfig { get; }

        [nterraform.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.TerraformProperty(name: "instance_count", @out: false, min: 0, max: 1)]
        public int? @InstanceCount { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "running_instance_count", @out: true, min: 0, max: 1)]
        public int? @RunningInstanceCount { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
