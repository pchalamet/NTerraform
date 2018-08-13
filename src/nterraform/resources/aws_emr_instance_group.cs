using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_emr_instance_group")]
    public sealed class aws_emr_instance_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_config")]
        public sealed class ebs_config : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
            public int @Size { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.Core.TerraformProperty(name: "volumes_per_instance", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "cluster_id", @out: false, min: 1, max: 1)]
        public string @ClusterId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_config", @out: false, min: 0, max: 0)]
        public ebs_config[] @EbsConfig { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.Core.TerraformProperty(name: "instance_count", @out: false, min: 0, max: 1)]
        public int? @InstanceCount { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "running_instance_count", @out: true, min: 0, max: 1)]
        public int? @RunningInstanceCount { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
