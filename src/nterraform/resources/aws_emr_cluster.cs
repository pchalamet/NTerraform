using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_emr_cluster")]
    public sealed class aws_emr_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "step")]
        public sealed class step : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "hadoop_jar_step")]
            public sealed class hadoop_jar_step : nterraform.Core.structure
            {
                public hadoop_jar_step(string @jar,
                                       string[] @args = null,
                                       string @mainClass = null,
                                       Dictionary<string,string> @properties = null)
                {
                    @Jar = @jar;
                    @Args = @args;
                    @MainClass = @mainClass;
                    @Properties = @properties;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "jar", @out: false, min: 1, max: 1)]
                public string @Jar { get; }

                [nterraform.Core.TerraformProperty(name: "args", @out: false, min: 0, max: 1)]
                public string[] @Args { get; }

                [nterraform.Core.TerraformProperty(name: "main_class", @out: false, min: 0, max: 1)]
                public string @MainClass { get; }

                [nterraform.Core.TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Properties { get; }
            }

            public step(string @actionOnFailure,
                        hadoop_jar_step[] @hadoopJarStep,
                        string @name)
            {
                @ActionOnFailure = @actionOnFailure;
                @HadoopJarStep = @hadoopJarStep;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "action_on_failure", @out: false, min: 1, max: 1)]
            public string @ActionOnFailure { get; }

            [nterraform.Core.TerraformProperty(name: "hadoop_jar_step", @out: false, min: 1, max: 1)]
            public hadoop_jar_step[] @HadoopJarStep { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ec2_attributes")]
        public sealed class ec2_attributes : nterraform.Core.structure
        {
            public ec2_attributes(string @instanceProfile,
                                  string @additionalMasterSecurityGroups = null,
                                  string @additionalSlaveSecurityGroups = null,
                                  string @emrManagedMasterSecurityGroup = null,
                                  string @emrManagedSlaveSecurityGroup = null,
                                  string @keyName = null,
                                  string @serviceAccessSecurityGroup = null,
                                  string @subnetId = null)
            {
                @InstanceProfile = @instanceProfile;
                @AdditionalMasterSecurityGroups = @additionalMasterSecurityGroups;
                @AdditionalSlaveSecurityGroups = @additionalSlaveSecurityGroups;
                @EmrManagedMasterSecurityGroup = @emrManagedMasterSecurityGroup;
                @EmrManagedSlaveSecurityGroup = @emrManagedSlaveSecurityGroup;
                @KeyName = @keyName;
                @ServiceAccessSecurityGroup = @serviceAccessSecurityGroup;
                @SubnetId = @subnetId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "instance_profile", @out: false, min: 1, max: 1)]
            public string @InstanceProfile { get; }

            [nterraform.Core.TerraformProperty(name: "additional_master_security_groups", @out: false, min: 0, max: 1)]
            public string @AdditionalMasterSecurityGroups { get; }

            [nterraform.Core.TerraformProperty(name: "additional_slave_security_groups", @out: false, min: 0, max: 1)]
            public string @AdditionalSlaveSecurityGroups { get; }

            [nterraform.Core.TerraformProperty(name: "emr_managed_master_security_group", @out: false, min: 0, max: 1)]
            public string @EmrManagedMasterSecurityGroup { get; }

            [nterraform.Core.TerraformProperty(name: "emr_managed_slave_security_group", @out: false, min: 0, max: 1)]
            public string @EmrManagedSlaveSecurityGroup { get; }

            [nterraform.Core.TerraformProperty(name: "key_name", @out: false, min: 0, max: 1)]
            public string @KeyName { get; }

            [nterraform.Core.TerraformProperty(name: "service_access_security_group", @out: false, min: 0, max: 1)]
            public string @ServiceAccessSecurityGroup { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "instance_group")]
        public sealed class instance_group : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_config")]
            public sealed class ebs_config : nterraform.Core.structure
            {
                public ebs_config(int @size,
                                  string @type,
                                  int? @iops = null,
                                  int? @volumesPerInstance = null)
                {
                    @Size = @size;
                    @Type = @type;
                    @Iops = @iops;
                    @VolumesPerInstance = @volumesPerInstance;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
                public int @Size { get; }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }

                [nterraform.Core.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
                public int? @Iops { get; }

                [nterraform.Core.TerraformProperty(name: "volumes_per_instance", @out: false, min: 0, max: 1)]
                public int? @VolumesPerInstance { get; }
            }

            public instance_group(string @instanceRole,
                                  string @instanceType,
                                  string @autoscalingPolicy = null,
                                  string @bidPrice = null,
                                  ebs_config[] @ebsConfig = null,
                                  int? @instanceCount = null,
                                  string @name = null)
            {
                @InstanceRole = @instanceRole;
                @InstanceType = @instanceType;
                @AutoscalingPolicy = @autoscalingPolicy;
                @BidPrice = @bidPrice;
                @EbsConfig = @ebsConfig;
                @InstanceCount = @instanceCount;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "instance_role", @out: false, min: 1, max: 1)]
            public string @InstanceRole { get; }

            [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
            public string @InstanceType { get; }

            [nterraform.Core.TerraformProperty(name: "autoscaling_policy", @out: false, min: 0, max: 1)]
            public string @AutoscalingPolicy { get; }

            [nterraform.Core.TerraformProperty(name: "bid_price", @out: false, min: 0, max: 1)]
            public string @BidPrice { get; }

            [nterraform.Core.TerraformProperty(name: "ebs_config", @out: false, min: 0, max: 0)]
            public ebs_config[] @EbsConfig { get; }

            [nterraform.Core.TerraformProperty(name: "instance_count", @out: false, min: 0, max: 1)]
            public int? @InstanceCount { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "bootstrap_action")]
        public sealed class bootstrap_action : nterraform.Core.structure
        {
            public bootstrap_action(string @name,
                                    string @path,
                                    string[] @args = null)
            {
                @Name = @name;
                @Path = @path;
                @Args = @args;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [nterraform.Core.TerraformProperty(name: "args", @out: false, min: 0, max: 1)]
            public string[] @Args { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "kerberos_attributes")]
        public sealed class kerberos_attributes : nterraform.Core.structure
        {
            public kerberos_attributes(string @kdcAdminPassword,
                                       string @realm,
                                       string @adDomainJoinPassword = null,
                                       string @adDomainJoinUser = null,
                                       string @crossRealmTrustPrincipalPassword = null)
            {
                @KdcAdminPassword = @kdcAdminPassword;
                @Realm = @realm;
                @AdDomainJoinPassword = @adDomainJoinPassword;
                @AdDomainJoinUser = @adDomainJoinUser;
                @CrossRealmTrustPrincipalPassword = @crossRealmTrustPrincipalPassword;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "kdc_admin_password", @out: false, min: 1, max: 1)]
            public string @KdcAdminPassword { get; }

            [nterraform.Core.TerraformProperty(name: "realm", @out: false, min: 1, max: 1)]
            public string @Realm { get; }

            [nterraform.Core.TerraformProperty(name: "ad_domain_join_password", @out: false, min: 0, max: 1)]
            public string @AdDomainJoinPassword { get; }

            [nterraform.Core.TerraformProperty(name: "ad_domain_join_user", @out: false, min: 0, max: 1)]
            public string @AdDomainJoinUser { get; }

            [nterraform.Core.TerraformProperty(name: "cross_realm_trust_principal_password", @out: false, min: 0, max: 1)]
            public string @CrossRealmTrustPrincipalPassword { get; }
        }

        public aws_emr_cluster(string @name,
                               string @releaseLabel,
                               string @serviceRole,
                               string @additionalInfo = null,
                               string[] @applications = null,
                               string @autoscalingRole = null,
                               bootstrap_action[] @bootstrapAction = null,
                               string @configurations = null,
                               string @configurationsJson = null,
                               int? @coreInstanceCount = null,
                               string @customAmiId = null,
                               int? @ebsRootVolumeSize = null,
                               ec2_attributes[] @ec2Attributes = null,
                               instance_group[] @instanceGroup = null,
                               kerberos_attributes[] @kerberosAttributes = null,
                               string @logUri = null,
                               string @masterInstanceType = null,
                               string @securityConfiguration = null,
                               step[] @step = null,
                               Dictionary<string,string> @tags = null,
                               bool? @visibleToAllUsers = null)
        {
            @Name = @name;
            @ReleaseLabel = @releaseLabel;
            @ServiceRole = @serviceRole;
            @AdditionalInfo = @additionalInfo;
            @Applications = @applications;
            @AutoscalingRole = @autoscalingRole;
            @BootstrapAction = @bootstrapAction;
            @Configurations = @configurations;
            @ConfigurationsJson = @configurationsJson;
            @CoreInstanceCount = @coreInstanceCount;
            @CustomAmiId = @customAmiId;
            @EbsRootVolumeSize = @ebsRootVolumeSize;
            @Ec2Attributes = @ec2Attributes;
            @InstanceGroup = @instanceGroup;
            @KerberosAttributes = @kerberosAttributes;
            @LogUri = @logUri;
            @MasterInstanceType = @masterInstanceType;
            @SecurityConfiguration = @securityConfiguration;
            @Step = @step;
            @Tags = @tags;
            @VisibleToAllUsers = @visibleToAllUsers;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "release_label", @out: false, min: 1, max: 1)]
        public string @ReleaseLabel { get; }

        [nterraform.Core.TerraformProperty(name: "service_role", @out: false, min: 1, max: 1)]
        public string @ServiceRole { get; }

        [nterraform.Core.TerraformProperty(name: "additional_info", @out: false, min: 0, max: 1)]
        public string @AdditionalInfo { get; }

        [nterraform.Core.TerraformProperty(name: "applications", @out: false, min: 0, max: 1)]
        public string[] @Applications { get; }

        [nterraform.Core.TerraformProperty(name: "autoscaling_role", @out: false, min: 0, max: 1)]
        public string @AutoscalingRole { get; }

        [nterraform.Core.TerraformProperty(name: "bootstrap_action", @out: false, min: 0, max: 0)]
        public bootstrap_action[] @BootstrapAction { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_state", @out: true, min: 0, max: 1)]
        public string @ClusterState { get; }

        [nterraform.Core.TerraformProperty(name: "configurations", @out: false, min: 0, max: 1)]
        public string @Configurations { get; }

        [nterraform.Core.TerraformProperty(name: "configurations_json", @out: false, min: 0, max: 1)]
        public string @ConfigurationsJson { get; }

        [nterraform.Core.TerraformProperty(name: "core_instance_count", @out: false, min: 0, max: 1)]
        public int? @CoreInstanceCount { get; }

        [nterraform.Core.TerraformProperty(name: "core_instance_type", @out: true, min: 0, max: 1)]
        public string @CoreInstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "custom_ami_id", @out: false, min: 0, max: 1)]
        public string @CustomAmiId { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_root_volume_size", @out: false, min: 0, max: 1)]
        public int? @EbsRootVolumeSize { get; }

        [nterraform.Core.TerraformProperty(name: "ec2_attributes", @out: false, min: 0, max: 1)]
        public ec2_attributes[] @Ec2Attributes { get; }

        [nterraform.Core.TerraformProperty(name: "instance_group", @out: false, min: 0, max: 0)]
        public instance_group[] @InstanceGroup { get; }

        [nterraform.Core.TerraformProperty(name: "keep_job_flow_alive_when_no_steps", @out: true, min: 0, max: 1)]
        public bool? @KeepJobFlowAliveWhenNoSteps { get; }

        [nterraform.Core.TerraformProperty(name: "kerberos_attributes", @out: false, min: 0, max: 1)]
        public kerberos_attributes[] @KerberosAttributes { get; }

        [nterraform.Core.TerraformProperty(name: "log_uri", @out: false, min: 0, max: 1)]
        public string @LogUri { get; }

        [nterraform.Core.TerraformProperty(name: "master_instance_type", @out: false, min: 0, max: 1)]
        public string @MasterInstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "master_public_dns", @out: true, min: 0, max: 1)]
        public string @MasterPublicDns { get; }

        [nterraform.Core.TerraformProperty(name: "scale_down_behavior", @out: true, min: 0, max: 1)]
        public string @ScaleDownBehavior { get; }

        [nterraform.Core.TerraformProperty(name: "security_configuration", @out: false, min: 0, max: 1)]
        public string @SecurityConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "step", @out: false, min: 0, max: 0)]
        public step[] @Step { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "termination_protection", @out: true, min: 0, max: 1)]
        public bool? @TerminationProtection { get; }

        [nterraform.Core.TerraformProperty(name: "visible_to_all_users", @out: false, min: 0, max: 1)]
        public bool? @VisibleToAllUsers { get; }
    }

}
