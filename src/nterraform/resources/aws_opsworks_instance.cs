using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_opsworks_instance")]
    public sealed class aws_opsworks_instance : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "root_block_device")]
        public sealed class root_block_device : nterraform.structure
        {
            public root_block_device(bool? @deleteOnTermination = null)
            {
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ebs_block_device")]
        public sealed class ebs_block_device : nterraform.structure
        {
            public ebs_block_device(string @deviceName,
                                    bool? @deleteOnTermination = null)
            {
                @DeviceName = @deviceName;
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
            public string @SnapshotId { get; }

            [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ephemeral_block_device")]
        public sealed class ephemeral_block_device : nterraform.structure
        {
            public ephemeral_block_device(string @deviceName,
                                          string @virtualName)
            {
                @DeviceName = @deviceName;
                @VirtualName = @virtualName;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "virtual_name", @out: false, min: 1, max: 1)]
            public string @VirtualName { get; }
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

        [nterraform.TerraformProperty(name: "layer_ids", @out: false, min: 1, max: 1)]
        public string[] @LayerIds { get; }

        [nterraform.TerraformProperty(name: "stack_id", @out: false, min: 1, max: 1)]
        public string @StackId { get; }

        [nterraform.TerraformProperty(name: "agent_version", @out: false, min: 0, max: 1)]
        public string @AgentVersion { get; }

        [nterraform.TerraformProperty(name: "ami_id", @out: true, min: 0, max: 1)]
        public string @AmiId { get; }

        [nterraform.TerraformProperty(name: "architecture", @out: false, min: 0, max: 1)]
        public string @Architecture { get; }

        [nterraform.TerraformProperty(name: "auto_scaling_type", @out: false, min: 0, max: 1)]
        public string @AutoScalingType { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [nterraform.TerraformProperty(name: "delete_ebs", @out: false, min: 0, max: 1)]
        public bool? @DeleteEbs { get; }

        [nterraform.TerraformProperty(name: "delete_eip", @out: false, min: 0, max: 1)]
        public bool? @DeleteEip { get; }

        [nterraform.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.TerraformProperty(name: "ec2_instance_id", @out: true, min: 0, max: 1)]
        public string @Ec2InstanceId { get; }

        [nterraform.TerraformProperty(name: "ecs_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EcsClusterArn { get; }

        [nterraform.TerraformProperty(name: "elastic_ip", @out: true, min: 0, max: 1)]
        public string @ElasticIp { get; }

        [nterraform.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.TerraformProperty(name: "hostname", @out: true, min: 0, max: 1)]
        public string @Hostname { get; }

        [nterraform.TerraformProperty(name: "infrastructure_class", @out: true, min: 0, max: 1)]
        public string @InfrastructureClass { get; }

        [nterraform.TerraformProperty(name: "install_updates_on_boot", @out: false, min: 0, max: 1)]
        public bool? @InstallUpdatesOnBoot { get; }

        [nterraform.TerraformProperty(name: "instance_profile_arn", @out: true, min: 0, max: 1)]
        public string @InstanceProfileArn { get; }

        [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "last_service_error_id", @out: true, min: 0, max: 1)]
        public string @LastServiceErrorId { get; }

        [nterraform.TerraformProperty(name: "os", @out: true, min: 0, max: 1)]
        public string @Os { get; }

        [nterraform.TerraformProperty(name: "platform", @out: true, min: 0, max: 1)]
        public string @Platform { get; }

        [nterraform.TerraformProperty(name: "private_dns", @out: true, min: 0, max: 1)]
        public string @PrivateDns { get; }

        [nterraform.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.TerraformProperty(name: "public_dns", @out: true, min: 0, max: 1)]
        public string @PublicDns { get; }

        [nterraform.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.TerraformProperty(name: "registered_by", @out: true, min: 0, max: 1)]
        public string @RegisteredBy { get; }

        [nterraform.TerraformProperty(name: "reported_agent_version", @out: true, min: 0, max: 1)]
        public string @ReportedAgentVersion { get; }

        [nterraform.TerraformProperty(name: "reported_os_family", @out: true, min: 0, max: 1)]
        public string @ReportedOsFamily { get; }

        [nterraform.TerraformProperty(name: "reported_os_name", @out: true, min: 0, max: 1)]
        public string @ReportedOsName { get; }

        [nterraform.TerraformProperty(name: "reported_os_version", @out: true, min: 0, max: 1)]
        public string @ReportedOsVersion { get; }

        [nterraform.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.TerraformProperty(name: "root_device_type", @out: true, min: 0, max: 1)]
        public string @RootDeviceType { get; }

        [nterraform.TerraformProperty(name: "root_device_volume_id", @out: true, min: 0, max: 1)]
        public string @RootDeviceVolumeId { get; }

        [nterraform.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.TerraformProperty(name: "ssh_host_dsa_key_fingerprint", @out: true, min: 0, max: 1)]
        public string @SshHostDsaKeyFingerprint { get; }

        [nterraform.TerraformProperty(name: "ssh_host_rsa_key_fingerprint", @out: true, min: 0, max: 1)]
        public string @SshHostRsaKeyFingerprint { get; }

        [nterraform.TerraformProperty(name: "ssh_key_name", @out: true, min: 0, max: 1)]
        public string @SshKeyName { get; }

        [nterraform.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "tenancy", @out: true, min: 0, max: 1)]
        public string @Tenancy { get; }

        [nterraform.TerraformProperty(name: "virtualization_type", @out: true, min: 0, max: 1)]
        public string @VirtualizationType { get; }
    }

}
