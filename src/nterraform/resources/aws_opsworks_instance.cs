using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_opsworks_instance")]
    public sealed class aws_opsworks_instance : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "root_block_device")]
        public sealed class root_block_device : nterraform.Core.structure
        {
            public root_block_device(bool? @deleteOnTermination = null)
            {
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ephemeral_block_device")]
        public sealed class ephemeral_block_device : nterraform.Core.structure
        {
            public ephemeral_block_device(string @deviceName,
                                          string @virtualName)
            {
                @DeviceName = @deviceName;
                @VirtualName = @virtualName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.Core.TerraformProperty(name: "virtual_name", @out: false, min: 1, max: 1)]
            public string @VirtualName { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_block_device")]
        public sealed class ebs_block_device : nterraform.Core.structure
        {
            public ebs_block_device(string @deviceName,
                                    bool? @deleteOnTermination = null)
            {
                @DeviceName = @deviceName;
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.Core.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
            public string @SnapshotId { get; }

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        public aws_opsworks_instance(string[] @layerIds,
                                     string @stackId,
                                     string @agentVersion = null,
                                     string @architecture = null,
                                     string @autoScalingType = null,
                                     bool? @deleteEbs = null,
                                     bool? @deleteEip = null,
                                     ebs_block_device[] @ebsBlockDevice = null,
                                     bool? @ebsOptimized = null,
                                     ephemeral_block_device[] @ephemeralBlockDevice = null,
                                     bool? @installUpdatesOnBoot = null,
                                     string @instanceType = null,
                                     root_block_device[] @rootBlockDevice = null,
                                     string @state = null)
        {
            @LayerIds = @layerIds;
            @StackId = @stackId;
            @AgentVersion = @agentVersion;
            @Architecture = @architecture;
            @AutoScalingType = @autoScalingType;
            @DeleteEbs = @deleteEbs;
            @DeleteEip = @deleteEip;
            @EbsBlockDevice = @ebsBlockDevice;
            @EbsOptimized = @ebsOptimized;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @InstallUpdatesOnBoot = @installUpdatesOnBoot;
            @InstanceType = @instanceType;
            @RootBlockDevice = @rootBlockDevice;
            @State = @state;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "layer_ids", @out: false, min: 1, max: 1)]
        public string[] @LayerIds { get; }

        [nterraform.Core.TerraformProperty(name: "stack_id", @out: false, min: 1, max: 1)]
        public string @StackId { get; }

        [nterraform.Core.TerraformProperty(name: "agent_version", @out: false, min: 0, max: 1)]
        public string @AgentVersion { get; }

        [nterraform.Core.TerraformProperty(name: "ami_id", @out: true, min: 0, max: 1)]
        public string @AmiId { get; }

        [nterraform.Core.TerraformProperty(name: "architecture", @out: false, min: 0, max: 1)]
        public string @Architecture { get; }

        [nterraform.Core.TerraformProperty(name: "auto_scaling_type", @out: false, min: 0, max: 1)]
        public string @AutoScalingType { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [nterraform.Core.TerraformProperty(name: "delete_ebs", @out: false, min: 0, max: 1)]
        public bool? @DeleteEbs { get; }

        [nterraform.Core.TerraformProperty(name: "delete_eip", @out: false, min: 0, max: 1)]
        public bool? @DeleteEip { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.Core.TerraformProperty(name: "ec2_instance_id", @out: true, min: 0, max: 1)]
        public string @Ec2InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "ecs_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EcsClusterArn { get; }

        [nterraform.Core.TerraformProperty(name: "elastic_ip", @out: true, min: 0, max: 1)]
        public string @ElasticIp { get; }

        [nterraform.Core.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "hostname", @out: true, min: 0, max: 1)]
        public string @Hostname { get; }

        [nterraform.Core.TerraformProperty(name: "infrastructure_class", @out: true, min: 0, max: 1)]
        public string @InfrastructureClass { get; }

        [nterraform.Core.TerraformProperty(name: "install_updates_on_boot", @out: false, min: 0, max: 1)]
        public bool? @InstallUpdatesOnBoot { get; }

        [nterraform.Core.TerraformProperty(name: "instance_profile_arn", @out: true, min: 0, max: 1)]
        public string @InstanceProfileArn { get; }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "last_service_error_id", @out: true, min: 0, max: 1)]
        public string @LastServiceErrorId { get; }

        [nterraform.Core.TerraformProperty(name: "os", @out: true, min: 0, max: 1)]
        public string @Os { get; }

        [nterraform.Core.TerraformProperty(name: "platform", @out: true, min: 0, max: 1)]
        public string @Platform { get; }

        [nterraform.Core.TerraformProperty(name: "private_dns", @out: true, min: 0, max: 1)]
        public string @PrivateDns { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.Core.TerraformProperty(name: "public_dns", @out: true, min: 0, max: 1)]
        public string @PublicDns { get; }

        [nterraform.Core.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.Core.TerraformProperty(name: "registered_by", @out: true, min: 0, max: 1)]
        public string @RegisteredBy { get; }

        [nterraform.Core.TerraformProperty(name: "reported_agent_version", @out: true, min: 0, max: 1)]
        public string @ReportedAgentVersion { get; }

        [nterraform.Core.TerraformProperty(name: "reported_os_family", @out: true, min: 0, max: 1)]
        public string @ReportedOsFamily { get; }

        [nterraform.Core.TerraformProperty(name: "reported_os_name", @out: true, min: 0, max: 1)]
        public string @ReportedOsName { get; }

        [nterraform.Core.TerraformProperty(name: "reported_os_version", @out: true, min: 0, max: 1)]
        public string @ReportedOsVersion { get; }

        [nterraform.Core.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "root_device_type", @out: true, min: 0, max: 1)]
        public string @RootDeviceType { get; }

        [nterraform.Core.TerraformProperty(name: "root_device_volume_id", @out: true, min: 0, max: 1)]
        public string @RootDeviceVolumeId { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "ssh_host_dsa_key_fingerprint", @out: true, min: 0, max: 1)]
        public string @SshHostDsaKeyFingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "ssh_host_rsa_key_fingerprint", @out: true, min: 0, max: 1)]
        public string @SshHostRsaKeyFingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "ssh_key_name", @out: true, min: 0, max: 1)]
        public string @SshKeyName { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "tenancy", @out: true, min: 0, max: 1)]
        public string @Tenancy { get; }

        [nterraform.Core.TerraformProperty(name: "virtualization_type", @out: true, min: 0, max: 1)]
        public string @VirtualizationType { get; }
    }

}
