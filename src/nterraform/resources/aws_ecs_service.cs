using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ecs_service")]
    public sealed class aws_ecs_service : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "service_registries")]
        public sealed class service_registries : nterraform.Core.structure
        {
            public service_registries(string @registryArn,
                                      string @containerName = null,
                                      int? @containerPort = null,
                                      int? @port = null)
            {
                @RegistryArn = @registryArn;
                @ContainerName = @containerName;
                @ContainerPort = @containerPort;
                @Port = @port;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "registry_arn", @out: false, min: 1, max: 1)]
            public string @RegistryArn { get; }

            [nterraform.Core.TerraformProperty(name: "container_name", @out: false, min: 0, max: 1)]
            public string @ContainerName { get; }

            [nterraform.Core.TerraformProperty(name: "container_port", @out: false, min: 0, max: 1)]
            public int? @ContainerPort { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public int? @Port { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "load_balancer")]
        public sealed class load_balancer : nterraform.Core.structure
        {
            public load_balancer(string @containerName,
                                 int @containerPort,
                                 string @elbName = null,
                                 string @targetGroupArn = null)
            {
                @ContainerName = @containerName;
                @ContainerPort = @containerPort;
                @ElbName = @elbName;
                @TargetGroupArn = @targetGroupArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "container_name", @out: false, min: 1, max: 1)]
            public string @ContainerName { get; }

            [nterraform.Core.TerraformProperty(name: "container_port", @out: false, min: 1, max: 1)]
            public int @ContainerPort { get; }

            [nterraform.Core.TerraformProperty(name: "elb_name", @out: false, min: 0, max: 1)]
            public string @ElbName { get; }

            [nterraform.Core.TerraformProperty(name: "target_group_arn", @out: false, min: 0, max: 1)]
            public string @TargetGroupArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "placement_constraints")]
        public sealed class placement_constraints : nterraform.Core.structure
        {
            public placement_constraints(string @type,
                                         string @expression = null)
            {
                @Type = @type;
                @Expression = @expression;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "expression", @out: false, min: 0, max: 1)]
            public string @Expression { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "network_configuration")]
        public sealed class network_configuration : nterraform.Core.structure
        {
            public network_configuration(string[] @subnets,
                                         bool? @assignPublicIp = null,
                                         string[] @securityGroups = null)
            {
                @Subnets = @subnets;
                @AssignPublicIp = @assignPublicIp;
                @SecurityGroups = @securityGroups;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "subnets", @out: false, min: 1, max: 1)]
            public string[] @Subnets { get; }

            [nterraform.Core.TerraformProperty(name: "assign_public_ip", @out: false, min: 0, max: 1)]
            public bool? @AssignPublicIp { get; }

            [nterraform.Core.TerraformProperty(name: "security_groups", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroups { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ordered_placement_strategy")]
        public sealed class ordered_placement_strategy : nterraform.Core.structure
        {
            public ordered_placement_strategy(string @type,
                                              string @field = null)
            {
                @Type = @type;
                @Field = @field;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "field", @out: false, min: 0, max: 1)]
            public string @Field { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "placement_strategy")]
        public sealed class placement_strategy : nterraform.Core.structure
        {
            public placement_strategy(string @type,
                                      string @field = null)
            {
                @Type = @type;
                @Field = @field;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "field", @out: false, min: 0, max: 1)]
            public string @Field { get; }
        }

        public aws_ecs_service(string @name,
                               string @taskDefinition,
                               int? @deploymentMaximumPercent = null,
                               int? @deploymentMinimumHealthyPercent = null,
                               int? @desiredCount = null,
                               int? @healthCheckGracePeriodSeconds = null,
                               string @launchType = null,
                               load_balancer[] @loadBalancer = null,
                               network_configuration[] @networkConfiguration = null,
                               ordered_placement_strategy[] @orderedPlacementStrategy = null,
                               placement_constraints[] @placementConstraints = null,
                               placement_strategy[] @placementStrategy = null,
                               string @schedulingStrategy = null,
                               service_registries[] @serviceRegistries = null)
        {
            @Name = @name;
            @TaskDefinition = @taskDefinition;
            @DeploymentMaximumPercent = @deploymentMaximumPercent;
            @DeploymentMinimumHealthyPercent = @deploymentMinimumHealthyPercent;
            @DesiredCount = @desiredCount;
            @HealthCheckGracePeriodSeconds = @healthCheckGracePeriodSeconds;
            @LaunchType = @launchType;
            @LoadBalancer = @loadBalancer;
            @NetworkConfiguration = @networkConfiguration;
            @OrderedPlacementStrategy = @orderedPlacementStrategy;
            @PlacementConstraints = @placementConstraints;
            @PlacementStrategy = @placementStrategy;
            @SchedulingStrategy = @schedulingStrategy;
            @ServiceRegistries = @serviceRegistries;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "task_definition", @out: false, min: 1, max: 1)]
        public string @TaskDefinition { get; }

        [nterraform.Core.TerraformProperty(name: "cluster", @out: true, min: 0, max: 1)]
        public string @Cluster { get; }

        [nterraform.Core.TerraformProperty(name: "deployment_maximum_percent", @out: false, min: 0, max: 1)]
        public int? @DeploymentMaximumPercent { get; }

        [nterraform.Core.TerraformProperty(name: "deployment_minimum_healthy_percent", @out: false, min: 0, max: 1)]
        public int? @DeploymentMinimumHealthyPercent { get; }

        [nterraform.Core.TerraformProperty(name: "desired_count", @out: false, min: 0, max: 1)]
        public int? @DesiredCount { get; }

        [nterraform.Core.TerraformProperty(name: "health_check_grace_period_seconds", @out: false, min: 0, max: 1)]
        public int? @HealthCheckGracePeriodSeconds { get; }

        [nterraform.Core.TerraformProperty(name: "iam_role", @out: true, min: 0, max: 1)]
        public string @IamRole { get; }

        [nterraform.Core.TerraformProperty(name: "launch_type", @out: false, min: 0, max: 1)]
        public string @LaunchType { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer", @out: false, min: 0, max: 1)]
        public load_balancer[] @LoadBalancer { get; }

        [nterraform.Core.TerraformProperty(name: "network_configuration", @out: false, min: 0, max: 1)]
        public network_configuration[] @NetworkConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "ordered_placement_strategy", @out: false, min: 0, max: 5)]
        public ordered_placement_strategy[] @OrderedPlacementStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "placement_constraints", @out: false, min: 0, max: 10)]
        public placement_constraints[] @PlacementConstraints { get; }

        [nterraform.Core.TerraformProperty(name: "placement_strategy", @out: false, min: 0, max: 5)]
        public placement_strategy[] @PlacementStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "scheduling_strategy", @out: false, min: 0, max: 1)]
        public string @SchedulingStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "service_registries", @out: false, min: 0, max: 1)]
        public service_registries[] @ServiceRegistries { get; }
    }

}
