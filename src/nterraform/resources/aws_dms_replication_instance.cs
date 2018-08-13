using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dms_replication_instance")]
    public sealed class aws_dms_replication_instance : nterraform.resource
    {
        public aws_dms_replication_instance(string @replicationInstanceClass,
                                            string @replicationInstanceId,
                                            bool? @applyImmediately = null,
                                            Dictionary<string,string> @tags = null)
        {
            @ReplicationInstanceClass = @replicationInstanceClass;
            @ReplicationInstanceId = @replicationInstanceId;
            @ApplyImmediately = @applyImmediately;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "replication_instance_class", @out: false, min: 1, max: 1)]
        public string @ReplicationInstanceClass { get; }

        [nterraform.TerraformProperty(name: "replication_instance_id", @out: false, min: 1, max: 1)]
        public string @ReplicationInstanceId { get; }

        [nterraform.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.TerraformProperty(name: "apply_immediately", @out: false, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.TerraformProperty(name: "auto_minor_version_upgrade", @out: true, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "kms_key_arn", @out: true, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.TerraformProperty(name: "multi_az", @out: true, min: 0, max: 1)]
        public bool? @MultiAz { get; }

        [nterraform.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "publicly_accessible", @out: true, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.TerraformProperty(name: "replication_instance_arn", @out: true, min: 0, max: 1)]
        public string @ReplicationInstanceArn { get; }

        [nterraform.TerraformProperty(name: "replication_instance_private_ips", @out: true, min: 0, max: 1)]
        public string[] @ReplicationInstancePrivateIps { get; }

        [nterraform.TerraformProperty(name: "replication_instance_public_ips", @out: true, min: 0, max: 1)]
        public string[] @ReplicationInstancePublicIps { get; }

        [nterraform.TerraformProperty(name: "replication_subnet_group_id", @out: true, min: 0, max: 1)]
        public string @ReplicationSubnetGroupId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
