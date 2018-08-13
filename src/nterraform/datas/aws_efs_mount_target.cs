using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_efs_mount_target")]
    public sealed class aws_efs_mount_target : nterraform.data
    {
        public aws_efs_mount_target(string @mountTargetId)
        {
            @MountTargetId = @mountTargetId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "mount_target_id", @out: false, min: 1, max: 1)]
        public string @MountTargetId { get; }

        [nterraform.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.TerraformProperty(name: "file_system_id", @out: true, min: 0, max: 1)]
        public string @FileSystemId { get; }

        [nterraform.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }
    }

}
