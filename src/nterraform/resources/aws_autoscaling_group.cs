using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_autoscaling_group")]
    public sealed class aws_autoscaling_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "initial_lifecycle_hook")]
        public sealed class initial_lifecycle_hook : nterraform.Core.structure
        {
            public initial_lifecycle_hook(string @lifecycleTransition,
                                          string @name,
                                          int? @heartbeatTimeout = null,
                                          string @notificationMetadata = null,
                                          string @notificationTargetArn = null,
                                          string @roleArn = null)
            {
                @LifecycleTransition = @lifecycleTransition;
                @Name = @name;
                @HeartbeatTimeout = @heartbeatTimeout;
                @NotificationMetadata = @notificationMetadata;
                @NotificationTargetArn = @notificationTargetArn;
                @RoleArn = @roleArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "lifecycle_transition", @out: false, min: 1, max: 1)]
            public string @LifecycleTransition { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "default_result", @out: true, min: 0, max: 1)]
            public string @DefaultResult { get; }

            [nterraform.Core.TerraformProperty(name: "heartbeat_timeout", @out: false, min: 0, max: 1)]
            public int? @HeartbeatTimeout { get; }

            [nterraform.Core.TerraformProperty(name: "notification_metadata", @out: false, min: 0, max: 1)]
            public string @NotificationMetadata { get; }

            [nterraform.Core.TerraformProperty(name: "notification_target_arn", @out: false, min: 0, max: 1)]
            public string @NotificationTargetArn { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
            public string @RoleArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "launch_template")]
        public sealed class launch_template : nterraform.Core.structure
        {
            public launch_template(string @version = null)
            {
                @Version = @version;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
            public string @Version { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "tag")]
        public sealed class tag : nterraform.Core.structure
        {
            public tag(string @key,
                       bool @propagateAtLaunch,
                       string @value)
            {
                @Key = @key;
                @PropagateAtLaunch = @propagateAtLaunch;
                @Value = @value;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.Core.TerraformProperty(name: "propagate_at_launch", @out: false, min: 1, max: 1)]
            public bool @PropagateAtLaunch { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_autoscaling_group(int @maxSize,
                                     int @minSize,
                                     string[] @enabledMetrics = null,
                                     bool? @forceDelete = null,
                                     int? @healthCheckGracePeriod = null,
                                     initial_lifecycle_hook[] @initialLifecycleHook = null,
                                     string @launchConfiguration = null,
                                     launch_template[] @launchTemplate = null,
                                     string @metricsGranularity = null,
                                     int? @minElbCapacity = null,
                                     string @namePrefix = null,
                                     string @placementGroup = null,
                                     bool? @protectFromScaleIn = null,
                                     string[] @suspendedProcesses = null,
                                     tag[] @tag = null,
                                     Dictionary<string,string>[] @tags = null,
                                     string[] @terminationPolicies = null,
                                     string @waitForCapacityTimeout = null,
                                     int? @waitForElbCapacity = null)
        {
            @MaxSize = @maxSize;
            @MinSize = @minSize;
            @EnabledMetrics = @enabledMetrics;
            @ForceDelete = @forceDelete;
            @HealthCheckGracePeriod = @healthCheckGracePeriod;
            @InitialLifecycleHook = @initialLifecycleHook;
            @LaunchConfiguration = @launchConfiguration;
            @LaunchTemplate = @launchTemplate;
            @MetricsGranularity = @metricsGranularity;
            @MinElbCapacity = @minElbCapacity;
            @NamePrefix = @namePrefix;
            @PlacementGroup = @placementGroup;
            @ProtectFromScaleIn = @protectFromScaleIn;
            @SuspendedProcesses = @suspendedProcesses;
            @Tag = @tag;
            @Tags = @tags;
            @TerminationPolicies = @terminationPolicies;
            @WaitForCapacityTimeout = @waitForCapacityTimeout;
            @WaitForElbCapacity = @waitForElbCapacity;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "max_size", @out: false, min: 1, max: 1)]
        public int @MaxSize { get; }

        [nterraform.Core.TerraformProperty(name: "min_size", @out: false, min: 1, max: 1)]
        public int @MinSize { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "default_cooldown", @out: true, min: 0, max: 1)]
        public int? @DefaultCooldown { get; }

        [nterraform.Core.TerraformProperty(name: "desired_capacity", @out: true, min: 0, max: 1)]
        public int? @DesiredCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_metrics", @out: false, min: 0, max: 1)]
        public string[] @EnabledMetrics { get; }

        [nterraform.Core.TerraformProperty(name: "force_delete", @out: false, min: 0, max: 1)]
        public bool? @ForceDelete { get; }

        [nterraform.Core.TerraformProperty(name: "health_check_grace_period", @out: false, min: 0, max: 1)]
        public int? @HealthCheckGracePeriod { get; }

        [nterraform.Core.TerraformProperty(name: "health_check_type", @out: true, min: 0, max: 1)]
        public string @HealthCheckType { get; }

        [nterraform.Core.TerraformProperty(name: "initial_lifecycle_hook", @out: false, min: 0, max: 0)]
        public initial_lifecycle_hook[] @InitialLifecycleHook { get; }

        [nterraform.Core.TerraformProperty(name: "launch_configuration", @out: false, min: 0, max: 1)]
        public string @LaunchConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "launch_template", @out: false, min: 0, max: 1)]
        public launch_template[] @LaunchTemplate { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancers", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancers { get; }

        [nterraform.Core.TerraformProperty(name: "metrics_granularity", @out: false, min: 0, max: 1)]
        public string @MetricsGranularity { get; }

        [nterraform.Core.TerraformProperty(name: "min_elb_capacity", @out: false, min: 0, max: 1)]
        public int? @MinElbCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "placement_group", @out: false, min: 0, max: 1)]
        public string @PlacementGroup { get; }

        [nterraform.Core.TerraformProperty(name: "protect_from_scale_in", @out: false, min: 0, max: 1)]
        public bool? @ProtectFromScaleIn { get; }

        [nterraform.Core.TerraformProperty(name: "service_linked_role_arn", @out: true, min: 0, max: 1)]
        public string @ServiceLinkedRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "suspended_processes", @out: false, min: 0, max: 1)]
        public string[] @SuspendedProcesses { get; }

        [nterraform.Core.TerraformProperty(name: "tag", @out: false, min: 0, max: 0)]
        public tag[] @Tag { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string>[] @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "target_group_arns", @out: true, min: 0, max: 1)]
        public string[] @TargetGroupArns { get; }

        [nterraform.Core.TerraformProperty(name: "termination_policies", @out: false, min: 0, max: 1)]
        public string[] @TerminationPolicies { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_zone_identifier", @out: true, min: 0, max: 1)]
        public string[] @VpcZoneIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "wait_for_capacity_timeout", @out: false, min: 0, max: 1)]
        public string @WaitForCapacityTimeout { get; }

        [nterraform.Core.TerraformProperty(name: "wait_for_elb_capacity", @out: false, min: 0, max: 1)]
        public int? @WaitForElbCapacity { get; }
    }

}
