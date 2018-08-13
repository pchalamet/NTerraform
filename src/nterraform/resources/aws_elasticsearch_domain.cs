using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elasticsearch_domain")]
    public sealed class aws_elasticsearch_domain : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "encrypt_at_rest")]
        public sealed class encrypt_at_rest : nterraform.Core.structure
        {
            public encrypt_at_rest(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
            public string @KmsKeyId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_options")]
        public sealed class ebs_options : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "ebs_enabled", @out: false, min: 1, max: 1)]
            public bool @EbsEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: false, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cluster_config")]
        public sealed class cluster_config : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "dedicated_master_count", @out: false, min: 0, max: 1)]
            public int? @DedicatedMasterCount { get; }

            [nterraform.Core.TerraformProperty(name: "dedicated_master_enabled", @out: false, min: 0, max: 1)]
            public bool? @DedicatedMasterEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "dedicated_master_type", @out: false, min: 0, max: 1)]
            public string @DedicatedMasterType { get; }

            [nterraform.Core.TerraformProperty(name: "instance_count", @out: false, min: 0, max: 1)]
            public int? @InstanceCount { get; }

            [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 0, max: 1)]
            public string @InstanceType { get; }

            [nterraform.Core.TerraformProperty(name: "zone_awareness_enabled", @out: false, min: 0, max: 1)]
            public bool? @ZoneAwarenessEnabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cognito_options")]
        public sealed class cognito_options : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "identity_pool_id", @out: false, min: 1, max: 1)]
            public string @IdentityPoolId { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
            public string @UserPoolId { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "snapshot_options")]
        public sealed class snapshot_options : nterraform.Core.structure
        {
            public snapshot_options(int @automatedSnapshotStartHour)
            {
                @AutomatedSnapshotStartHour = @automatedSnapshotStartHour;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "automated_snapshot_start_hour", @out: false, min: 1, max: 1)]
            public int @AutomatedSnapshotStartHour { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "vpc_options")]
        public sealed class vpc_options : nterraform.Core.structure
        {
            public vpc_options(string[] @securityGroupIds = null,
                               string[] @subnetIds = null)
            {
                @SecurityGroupIds = @securityGroupIds;
                @SubnetIds = @subnetIds;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
            public string[] @AvailabilityZones { get; }

            [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: false, min: 0, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "log_publishing_options")]
        public sealed class log_publishing_options : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "cloudwatch_log_group_arn", @out: false, min: 1, max: 1)]
            public string @CloudwatchLogGroupArn { get; }

            [nterraform.Core.TerraformProperty(name: "log_type", @out: false, min: 1, max: 1)]
            public string @LogType { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.Core.TerraformProperty(name: "access_policies", @out: true, min: 0, max: 1)]
        public string @AccessPolicies { get; }

        [nterraform.Core.TerraformProperty(name: "advanced_options", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @AdvancedOptions { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_config", @out: false, min: 0, max: 0)]
        public cluster_config[] @ClusterConfig { get; }

        [nterraform.Core.TerraformProperty(name: "cognito_options", @out: false, min: 0, max: 1)]
        public cognito_options[] @CognitoOptions { get; }

        [nterraform.Core.TerraformProperty(name: "domain_id", @out: true, min: 0, max: 1)]
        public string @DomainId { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_options", @out: false, min: 0, max: 0)]
        public ebs_options[] @EbsOptions { get; }

        [nterraform.Core.TerraformProperty(name: "elasticsearch_version", @out: false, min: 0, max: 1)]
        public string @ElasticsearchVersion { get; }

        [nterraform.Core.TerraformProperty(name: "encrypt_at_rest", @out: false, min: 0, max: 1)]
        public encrypt_at_rest[] @EncryptAtRest { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "kibana_endpoint", @out: true, min: 0, max: 1)]
        public string @KibanaEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "log_publishing_options", @out: false, min: 0, max: 0)]
        public log_publishing_options[] @LogPublishingOptions { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_options", @out: false, min: 0, max: 0)]
        public snapshot_options[] @SnapshotOptions { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_options", @out: false, min: 0, max: 1)]
        public vpc_options[] @VpcOptions { get; }
    }

}
