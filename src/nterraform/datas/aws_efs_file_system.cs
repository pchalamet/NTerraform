using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_efs_file_system")]
    public sealed class aws_efs_file_system : nterraform.Core.data
    {
        public aws_efs_file_system()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "creation_token", @out: true, min: 0, max: 1)]
        public string @CreationToken { get; }

        [nterraform.Core.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.Core.TerraformProperty(name: "file_system_id", @out: true, min: 0, max: 1)]
        public string @FileSystemId { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "performance_mode", @out: true, min: 0, max: 1)]
        public string @PerformanceMode { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
