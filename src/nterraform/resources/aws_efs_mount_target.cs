using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_efs_mount_target")]
    public sealed class aws_efs_mount_target : nterraform.Core.resource
    {
        public aws_efs_mount_target(string @fileSystemId,
                                    string @subnetId)
        {
            @FileSystemId = @fileSystemId;
            @SubnetId = @subnetId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "file_system_id", @out: false, min: 1, max: 1)]
        public string @FileSystemId { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }
    }

}
