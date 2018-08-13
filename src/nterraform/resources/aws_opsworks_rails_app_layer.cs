using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_opsworks_rails_app_layer")]
    public sealed class aws_opsworks_rails_app_layer : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_volume")]
        public sealed class ebs_volume : nterraform.Core.structure
        {
            public ebs_volume(string @mountPoint,
                              int @numberOfDisks,
                              int @size,
                              int? @iops = null,
                              string @raidLevel = null,
                              string @type = null)
            {
                @MountPoint = @mountPoint;
                @NumberOfDisks = @numberOfDisks;
                @Size = @size;
                @Iops = @iops;
                @RaidLevel = @raidLevel;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "mount_point", @out: false, min: 1, max: 1)]
            public string @MountPoint { get; }

            [nterraform.Core.TerraformProperty(name: "number_of_disks", @out: false, min: 1, max: 1)]
            public int @NumberOfDisks { get; }

            [nterraform.Core.TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
            public int @Size { get; }

            [nterraform.Core.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.Core.TerraformProperty(name: "raid_level", @out: false, min: 0, max: 1)]
            public string @RaidLevel { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_opsworks_rails_app_layer(string @stackId,
                                            string @appServer = null,
                                            bool? @autoAssignElasticIps = null,
                                            bool? @autoAssignPublicIps = null,
                                            bool? @autoHealing = null,
                                            string @bundlerVersion = null,
                                            string[] @customConfigureRecipes = null,
                                            string[] @customDeployRecipes = null,
                                            string @customInstanceProfileArn = null,
                                            string @customJson = null,
                                            string[] @customSecurityGroupIds = null,
                                            string[] @customSetupRecipes = null,
                                            string[] @customShutdownRecipes = null,
                                            string[] @customUndeployRecipes = null,
                                            bool? @drainElbOnShutdown = null,
                                            ebs_volume[] @ebsVolume = null,
                                            string @elasticLoadBalancer = null,
                                            bool? @installUpdatesOnBoot = null,
                                            int? @instanceShutdownTimeout = null,
                                            bool? @manageBundler = null,
                                            string @name = null,
                                            string @passengerVersion = null,
                                            string @rubyVersion = null,
                                            string @rubygemsVersion = null,
                                            string[] @systemPackages = null,
                                            bool? @useEbsOptimizedInstances = null)
        {
            @StackId = @stackId;
            @AppServer = @appServer;
            @AutoAssignElasticIps = @autoAssignElasticIps;
            @AutoAssignPublicIps = @autoAssignPublicIps;
            @AutoHealing = @autoHealing;
            @BundlerVersion = @bundlerVersion;
            @CustomConfigureRecipes = @customConfigureRecipes;
            @CustomDeployRecipes = @customDeployRecipes;
            @CustomInstanceProfileArn = @customInstanceProfileArn;
            @CustomJson = @customJson;
            @CustomSecurityGroupIds = @customSecurityGroupIds;
            @CustomSetupRecipes = @customSetupRecipes;
            @CustomShutdownRecipes = @customShutdownRecipes;
            @CustomUndeployRecipes = @customUndeployRecipes;
            @DrainElbOnShutdown = @drainElbOnShutdown;
            @EbsVolume = @ebsVolume;
            @ElasticLoadBalancer = @elasticLoadBalancer;
            @InstallUpdatesOnBoot = @installUpdatesOnBoot;
            @InstanceShutdownTimeout = @instanceShutdownTimeout;
            @ManageBundler = @manageBundler;
            @Name = @name;
            @PassengerVersion = @passengerVersion;
            @RubyVersion = @rubyVersion;
            @RubygemsVersion = @rubygemsVersion;
            @SystemPackages = @systemPackages;
            @UseEbsOptimizedInstances = @useEbsOptimizedInstances;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "stack_id", @out: false, min: 1, max: 1)]
        public string @StackId { get; }

        [nterraform.Core.TerraformProperty(name: "app_server", @out: false, min: 0, max: 1)]
        public string @AppServer { get; }

        [nterraform.Core.TerraformProperty(name: "auto_assign_elastic_ips", @out: false, min: 0, max: 1)]
        public bool? @AutoAssignElasticIps { get; }

        [nterraform.Core.TerraformProperty(name: "auto_assign_public_ips", @out: false, min: 0, max: 1)]
        public bool? @AutoAssignPublicIps { get; }

        [nterraform.Core.TerraformProperty(name: "auto_healing", @out: false, min: 0, max: 1)]
        public bool? @AutoHealing { get; }

        [nterraform.Core.TerraformProperty(name: "bundler_version", @out: false, min: 0, max: 1)]
        public string @BundlerVersion { get; }

        [nterraform.Core.TerraformProperty(name: "custom_configure_recipes", @out: false, min: 0, max: 1)]
        public string[] @CustomConfigureRecipes { get; }

        [nterraform.Core.TerraformProperty(name: "custom_deploy_recipes", @out: false, min: 0, max: 1)]
        public string[] @CustomDeployRecipes { get; }

        [nterraform.Core.TerraformProperty(name: "custom_instance_profile_arn", @out: false, min: 0, max: 1)]
        public string @CustomInstanceProfileArn { get; }

        [nterraform.Core.TerraformProperty(name: "custom_json", @out: false, min: 0, max: 1)]
        public string @CustomJson { get; }

        [nterraform.Core.TerraformProperty(name: "custom_security_group_ids", @out: false, min: 0, max: 1)]
        public string[] @CustomSecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "custom_setup_recipes", @out: false, min: 0, max: 1)]
        public string[] @CustomSetupRecipes { get; }

        [nterraform.Core.TerraformProperty(name: "custom_shutdown_recipes", @out: false, min: 0, max: 1)]
        public string[] @CustomShutdownRecipes { get; }

        [nterraform.Core.TerraformProperty(name: "custom_undeploy_recipes", @out: false, min: 0, max: 1)]
        public string[] @CustomUndeployRecipes { get; }

        [nterraform.Core.TerraformProperty(name: "drain_elb_on_shutdown", @out: false, min: 0, max: 1)]
        public bool? @DrainElbOnShutdown { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_volume", @out: false, min: 0, max: 0)]
        public ebs_volume[] @EbsVolume { get; }

        [nterraform.Core.TerraformProperty(name: "elastic_load_balancer", @out: false, min: 0, max: 1)]
        public string @ElasticLoadBalancer { get; }

        [nterraform.Core.TerraformProperty(name: "install_updates_on_boot", @out: false, min: 0, max: 1)]
        public bool? @InstallUpdatesOnBoot { get; }

        [nterraform.Core.TerraformProperty(name: "instance_shutdown_timeout", @out: false, min: 0, max: 1)]
        public int? @InstanceShutdownTimeout { get; }

        [nterraform.Core.TerraformProperty(name: "manage_bundler", @out: false, min: 0, max: 1)]
        public bool? @ManageBundler { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "passenger_version", @out: false, min: 0, max: 1)]
        public string @PassengerVersion { get; }

        [nterraform.Core.TerraformProperty(name: "ruby_version", @out: false, min: 0, max: 1)]
        public string @RubyVersion { get; }

        [nterraform.Core.TerraformProperty(name: "rubygems_version", @out: false, min: 0, max: 1)]
        public string @RubygemsVersion { get; }

        [nterraform.Core.TerraformProperty(name: "system_packages", @out: false, min: 0, max: 1)]
        public string[] @SystemPackages { get; }

        [nterraform.Core.TerraformProperty(name: "use_ebs_optimized_instances", @out: false, min: 0, max: 1)]
        public bool? @UseEbsOptimizedInstances { get; }
    }

}
