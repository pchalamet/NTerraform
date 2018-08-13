using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_redshift_cluster")]
    public sealed class aws_redshift_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "snapshot_copy")]
        public sealed class snapshot_copy : nterraform.Core.structure
        {
            public snapshot_copy(string @destinationRegion,
                                 string @grantName = null,
                                 int? @retentionPeriod = null)
            {
                @DestinationRegion = @destinationRegion;
                @GrantName = @grantName;
                @RetentionPeriod = @retentionPeriod;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "destination_region", @out: false, min: 1, max: 1)]
            public string @DestinationRegion { get; }

            [nterraform.Core.TerraformProperty(name: "grant_name", @out: false, min: 0, max: 1)]
            public string @GrantName { get; }

            [nterraform.Core.TerraformProperty(name: "retention_period", @out: false, min: 0, max: 1)]
            public int? @RetentionPeriod { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "logging")]
        public sealed class logging : nterraform.Core.structure
        {
            public logging(bool @enable)
            {
                @Enable = @enable;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enable", @out: false, min: 1, max: 1)]
            public bool @Enable { get; }

            [nterraform.Core.TerraformProperty(name: "bucket_name", @out: true, min: 0, max: 1)]
            public string @BucketName { get; }

            [nterraform.Core.TerraformProperty(name: "s3_key_prefix", @out: true, min: 0, max: 1)]
            public string @S3KeyPrefix { get; }
        }

        public aws_redshift_cluster(string @clusterIdentifier,
                                    string @nodeType,
                                    bool? @allowVersionUpgrade = null,
                                    int? @automatedSnapshotRetentionPeriod = null,
                                    string @clusterVersion = null,
                                    string @elasticIp = null,
                                    string @finalSnapshotIdentifier = null,
                                    logging[] @logging = null,
                                    string @masterPassword = null,
                                    string @masterUsername = null,
                                    int? @numberOfNodes = null,
                                    string @ownerAccount = null,
                                    int? @port = null,
                                    bool? @publiclyAccessible = null,
                                    bool? @skipFinalSnapshot = null,
                                    string @snapshotClusterIdentifier = null,
                                    snapshot_copy[] @snapshotCopy = null,
                                    string @snapshotIdentifier = null,
                                    Dictionary<string,string> @tags = null)
        {
            @ClusterIdentifier = @clusterIdentifier;
            @NodeType = @nodeType;
            @AllowVersionUpgrade = @allowVersionUpgrade;
            @AutomatedSnapshotRetentionPeriod = @automatedSnapshotRetentionPeriod;
            @ClusterVersion = @clusterVersion;
            @ElasticIp = @elasticIp;
            @FinalSnapshotIdentifier = @finalSnapshotIdentifier;
            @Logging = @logging;
            @MasterPassword = @masterPassword;
            @MasterUsername = @masterUsername;
            @NumberOfNodes = @numberOfNodes;
            @OwnerAccount = @ownerAccount;
            @Port = @port;
            @PubliclyAccessible = @publiclyAccessible;
            @SkipFinalSnapshot = @skipFinalSnapshot;
            @SnapshotClusterIdentifier = @snapshotClusterIdentifier;
            @SnapshotCopy = @snapshotCopy;
            @SnapshotIdentifier = @snapshotIdentifier;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cluster_identifier", @out: false, min: 1, max: 1)]
        public string @ClusterIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "node_type", @out: false, min: 1, max: 1)]
        public string @NodeType { get; }

        [nterraform.Core.TerraformProperty(name: "allow_version_upgrade", @out: false, min: 0, max: 1)]
        public bool? @AllowVersionUpgrade { get; }

        [nterraform.Core.TerraformProperty(name: "automated_snapshot_retention_period", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "cluster_version", @out: false, min: 0, max: 1)]
        public string @ClusterVersion { get; }

        [nterraform.Core.TerraformProperty(name: "database_name", @out: true, min: 0, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.Core.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.Core.TerraformProperty(name: "elastic_ip", @out: false, min: 0, max: 1)]
        public string @ElasticIp { get; }

        [nterraform.Core.TerraformProperty(name: "enable_logging", @out: true, min: 0, max: 1)]
        public bool? @EnableLogging { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "enhanced_vpc_routing", @out: true, min: 0, max: 1)]
        public bool? @EnhancedVpcRouting { get; }

        [nterraform.Core.TerraformProperty(name: "final_snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @FinalSnapshotIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "iam_roles", @out: true, min: 0, max: 1)]
        public string[] @IamRoles { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "logging", @out: false, min: 0, max: 1)]
        public logging[] @Logging { get; }

        [nterraform.Core.TerraformProperty(name: "master_password", @out: false, min: 0, max: 1)]
        public string @MasterPassword { get; }

        [nterraform.Core.TerraformProperty(name: "master_username", @out: false, min: 0, max: 1)]
        public string @MasterUsername { get; }

        [nterraform.Core.TerraformProperty(name: "number_of_nodes", @out: false, min: 0, max: 1)]
        public int? @NumberOfNodes { get; }

        [nterraform.Core.TerraformProperty(name: "owner_account", @out: false, min: 0, max: 1)]
        public string @OwnerAccount { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "publicly_accessible", @out: false, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.Core.TerraformProperty(name: "s3_key_prefix", @out: true, min: 0, max: 1)]
        public string @S3KeyPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "skip_final_snapshot", @out: false, min: 0, max: 1)]
        public bool? @SkipFinalSnapshot { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_cluster_identifier", @out: false, min: 0, max: 1)]
        public string @SnapshotClusterIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_copy", @out: false, min: 0, max: 1)]
        public snapshot_copy[] @SnapshotCopy { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @SnapshotIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
