using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_efs_file_system")]
    public sealed class aws_efs_file_system : nterraform.resource
    {
        public aws_efs_file_system(int? @provisionedThroughputInMibps = null,
                                   Dictionary<string,string> @tags = null,
                                   string @throughputMode = null)
        {
            @ProvisionedThroughputInMibps = @provisionedThroughputInMibps;
            @Tags = @tags;
            @ThroughputMode = @throughputMode;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "creation_token", @out: true, min: 0, max: 1)]
        public string @CreationToken { get; }

        [nterraform.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "performance_mode", @out: true, min: 0, max: 1)]
        public string @PerformanceMode { get; }

        [nterraform.TerraformProperty(name: "provisioned_throughput_in_mibps", @out: false, min: 0, max: 1)]
        public int? @ProvisionedThroughputInMibps { get; }

        [nterraform.TerraformProperty(name: "reference_name", @out: true, min: 0, max: 1)]
        public string @ReferenceName { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "throughput_mode", @out: false, min: 0, max: 1)]
        public string @ThroughputMode { get; }
    }

}
