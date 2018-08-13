using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_redshift_cluster")]
    public sealed class aws_redshift_cluster : nterraform.Core.data
    {
        public aws_redshift_cluster(string @clusterIdentifier,
                                    Dictionary<string,string> @tags = null)
        {
            @ClusterIdentifier = @clusterIdentifier;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cluster_identifier", @out: false, min: 1, max: 1)]
        public string @ClusterIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "allow_version_upgrade", @out: true, min: 0, max: 1)]
        public bool? @AllowVersionUpgrade { get; }

        [nterraform.Core.TerraformProperty(name: "automated_snapshot_retention_period", @out: true, min: 0, max: 1)]
        public int? @AutomatedSnapshotRetentionPeriod { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "bucket_name", @out: true, min: 0, max: 1)]
        public string @BucketName { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ClusterParameterGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_public_key", @out: true, min: 0, max: 1)]
        public string @ClusterPublicKey { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_revision_number", @out: true, min: 0, max: 1)]
        public string @ClusterRevisionNumber { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_security_groups", @out: true, min: 0, max: 1)]
        public string[] @ClusterSecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_subnet_group_name", @out: true, min: 0, max: 1)]
        public string @ClusterSubnetGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_type", @out: true, min: 0, max: 1)]
        public string @ClusterType { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_version", @out: true, min: 0, max: 1)]
        public string @ClusterVersion { get; }

        [nterraform.Core.TerraformProperty(name: "database_name", @out: true, min: 0, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.Core.TerraformProperty(name: "elastic_ip", @out: true, min: 0, max: 1)]
        public string @ElasticIp { get; }

        [nterraform.Core.TerraformProperty(name: "enable_logging", @out: true, min: 0, max: 1)]
        public bool? @EnableLogging { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "enhanced_vpc_routing", @out: true, min: 0, max: 1)]
        public bool? @EnhancedVpcRouting { get; }

        [nterraform.Core.TerraformProperty(name: "iam_roles", @out: true, min: 0, max: 1)]
        public string[] @IamRoles { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "master_username", @out: true, min: 0, max: 1)]
        public string @MasterUsername { get; }

        [nterraform.Core.TerraformProperty(name: "node_type", @out: true, min: 0, max: 1)]
        public string @NodeType { get; }

        [nterraform.Core.TerraformProperty(name: "number_of_nodes", @out: true, min: 0, max: 1)]
        public int? @NumberOfNodes { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "publicly_accessible", @out: true, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.Core.TerraformProperty(name: "s3_key_prefix", @out: true, min: 0, max: 1)]
        public string @S3KeyPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
