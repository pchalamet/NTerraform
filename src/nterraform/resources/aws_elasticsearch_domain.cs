using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elasticsearch_domain")]
    public sealed class aws_elasticsearch_domain : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "vpc_options")]
        public sealed class vpc_options : nterraform.structure
        {
            public vpc_options(string[] @securityGroupIds = null,
                               string[] @subnetIds = null)
            {
                @SecurityGroupIds = @securityGroupIds;
                @SubnetIds = @subnetIds;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
            public string[] @AvailabilityZones { get; }

            [nterraform.TerraformProperty(name: "security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "subnet_ids", @out: false, min: 0, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "log_publishing_options")]
        public sealed class log_publishing_options : nterraform.structure
        {
            public log_publishing_options(string @cloudwatchLogGroupArn,
                                          string @logType,
                                          bool? @enabled = null)
            {
                @CloudwatchLogGroupArn = @cloudwatchLogGroupArn;
                @LogType = @logType;
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cloudwatch_log_group_arn", @out: false, min: 1, max: 1)]
            public string @CloudwatchLogGroupArn { get; }

            [nterraform.TerraformProperty(name: "log_type", @out: false, min: 1, max: 1)]
            public string @LogType { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "encrypt_at_rest")]
        public sealed class encrypt_at_rest : nterraform.structure
        {
            public encrypt_at_rest(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
            public string @KmsKeyId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "cluster_config")]
        public sealed class cluster_config : nterraform.structure
        {
            public cluster_config(int? @dedicatedMasterCount = null,
                                  bool? @dedicatedMasterEnabled = null,
                                  string @dedicatedMasterType = null,
                                  int? @instanceCount = null,
                                  string @instanceType = null,
                                  bool? @zoneAwarenessEnabled = null)
            {
                @DedicatedMasterCount = @dedicatedMasterCount;
                @DedicatedMasterEnabled = @dedicatedMasterEnabled;
                @DedicatedMasterType = @dedicatedMasterType;
                @InstanceCount = @instanceCount;
                @InstanceType = @instanceType;
                @ZoneAwarenessEnabled = @zoneAwarenessEnabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dedicated_master_count", @out: false, min: 0, max: 1)]
            public int? @DedicatedMasterCount { get; }

            [nterraform.TerraformProperty(name: "dedicated_master_enabled", @out: false, min: 0, max: 1)]
            public bool? @DedicatedMasterEnabled { get; }

            [nterraform.TerraformProperty(name: "dedicated_master_type", @out: false, min: 0, max: 1)]
            public string @DedicatedMasterType { get; }

            [nterraform.TerraformProperty(name: "instance_count", @out: false, min: 0, max: 1)]
            public int? @InstanceCount { get; }

            [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 0, max: 1)]
            public string @InstanceType { get; }

            [nterraform.TerraformProperty(name: "zone_awareness_enabled", @out: false, min: 0, max: 1)]
            public bool? @ZoneAwarenessEnabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ebs_options")]
        public sealed class ebs_options : nterraform.structure
        {
            public ebs_options(bool @ebsEnabled,
                               int? @iops = null,
                               int? @volumeSize = null)
            {
                @EbsEnabled = @ebsEnabled;
                @Iops = @iops;
                @VolumeSize = @volumeSize;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "ebs_enabled", @out: false, min: 1, max: 1)]
            public bool @EbsEnabled { get; }

            [nterraform.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.TerraformProperty(name: "volume_size", @out: false, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "snapshot_options")]
        public sealed class snapshot_options : nterraform.structure
        {
            public snapshot_options(int @automatedSnapshotStartHour)
            {
                @AutomatedSnapshotStartHour = @automatedSnapshotStartHour;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "automated_snapshot_start_hour", @out: false, min: 1, max: 1)]
            public int @AutomatedSnapshotStartHour { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "cognito_options")]
        public sealed class cognito_options : nterraform.structure
        {
            public cognito_options(string @identityPoolId,
                                   string @roleArn,
                                   string @userPoolId,
                                   bool? @enabled = null)
            {
                @IdentityPoolId = @identityPoolId;
                @RoleArn = @roleArn;
                @UserPoolId = @userPoolId;
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "identity_pool_id", @out: false, min: 1, max: 1)]
            public string @IdentityPoolId { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
            public string @UserPoolId { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        public aws_elasticsearch_domain(string @domainName,
                                        cluster_config[] @clusterConfig = null,
                                        cognito_options[] @cognitoOptions = null,
                                        ebs_options[] @ebsOptions = null,
                                        string @elasticsearchVersion = null,
                                        encrypt_at_rest[] @encryptAtRest = null,
                                        log_publishing_options[] @logPublishingOptions = null,
                                        snapshot_options[] @snapshotOptions = null,
                                        Dictionary<string,string> @tags = null,
                                        vpc_options[] @vpcOptions = null)
        {
            @DomainName = @domainName;
            @ClusterConfig = @clusterConfig;
            @CognitoOptions = @cognitoOptions;
            @EbsOptions = @ebsOptions;
            @ElasticsearchVersion = @elasticsearchVersion;
            @EncryptAtRest = @encryptAtRest;
            @LogPublishingOptions = @logPublishingOptions;
            @SnapshotOptions = @snapshotOptions;
            @Tags = @tags;
            @VpcOptions = @vpcOptions;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "access_policies", @out: true, min: 0, max: 1)]
        public string @AccessPolicies { get; }

        [nterraform.TerraformProperty(name: "advanced_options", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @AdvancedOptions { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "cluster_config", @out: false, min: 0, max: 0)]
        public cluster_config[] @ClusterConfig { get; }

        [nterraform.TerraformProperty(name: "cognito_options", @out: false, min: 0, max: 1)]
        public cognito_options[] @CognitoOptions { get; }

        [nterraform.TerraformProperty(name: "domain_id", @out: true, min: 0, max: 1)]
        public string @DomainId { get; }

        [nterraform.TerraformProperty(name: "ebs_options", @out: false, min: 0, max: 0)]
        public ebs_options[] @EbsOptions { get; }

        [nterraform.TerraformProperty(name: "elasticsearch_version", @out: false, min: 0, max: 1)]
        public string @ElasticsearchVersion { get; }

        [nterraform.TerraformProperty(name: "encrypt_at_rest", @out: false, min: 0, max: 1)]
        public encrypt_at_rest[] @EncryptAtRest { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "kibana_endpoint", @out: true, min: 0, max: 1)]
        public string @KibanaEndpoint { get; }

        [nterraform.TerraformProperty(name: "log_publishing_options", @out: false, min: 0, max: 0)]
        public log_publishing_options[] @LogPublishingOptions { get; }

        [nterraform.TerraformProperty(name: "snapshot_options", @out: false, min: 0, max: 0)]
        public snapshot_options[] @SnapshotOptions { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_options", @out: false, min: 0, max: 1)]
        public vpc_options[] @VpcOptions { get; }
    }

}
