using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ecs_service")]
    public sealed class aws_ecs_service : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "load_balancer")]
        public sealed class load_balancer : nterraform.structure
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

            [nterraform.TerraformProperty(name: "container_name", @out: false, min: 1, max: 1)]
            public string @ContainerName { get; }

            [nterraform.TerraformProperty(name: "container_port", @out: false, min: 1, max: 1)]
            public int @ContainerPort { get; }

            [nterraform.TerraformProperty(name: "elb_name", @out: false, min: 0, max: 1)]
            public string @ElbName { get; }

            [nterraform.TerraformProperty(name: "target_group_arn", @out: false, min: 0, max: 1)]
            public string @TargetGroupArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ordered_placement_strategy")]
        public sealed class ordered_placement_strategy : nterraform.structure
        {
            public ordered_placement_strategy(string @type,
                                              string @field = null)
            {
                @Type = @type;
                @Field = @field;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "field", @out: false, min: 0, max: 1)]
            public string @Field { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "network_configuration")]
        public sealed class network_configuration : nterraform.structure
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

            [nterraform.TerraformProperty(name: "subnets", @out: false, min: 1, max: 1)]
            public string[] @Subnets { get; }

            [nterraform.TerraformProperty(name: "assign_public_ip", @out: false, min: 0, max: 1)]
            public bool? @AssignPublicIp { get; }

            [nterraform.TerraformProperty(name: "security_groups", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroups { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "placement_strategy")]
        public sealed class placement_strategy : nterraform.structure
        {
            public placement_strategy(string @type,
                                      string @field = null)
            {
                @Type = @type;
                @Field = @field;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "field", @out: false, min: 0, max: 1)]
            public string @Field { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "service_registries")]
        public sealed class service_registries : nterraform.structure
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

            [nterraform.TerraformProperty(name: "registry_arn", @out: false, min: 1, max: 1)]
            public string @RegistryArn { get; }

            [nterraform.TerraformProperty(name: "container_name", @out: false, min: 0, max: 1)]
            public string @ContainerName { get; }

            [nterraform.TerraformProperty(name: "container_port", @out: false, min: 0, max: 1)]
            public int? @ContainerPort { get; }

            [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public int? @Port { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "placement_constraints")]
        public sealed class placement_constraints : nterraform.structure
        {
            public placement_constraints(string @type,
                                         string @expression = null)
            {
                @Type = @type;
                @Expression = @expression;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "expression", @out: false, min: 0, max: 1)]
            public string @Expression { get; }
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "task_definition", @out: false, min: 1, max: 1)]
        public string @TaskDefinition { get; }

        [nterraform.TerraformProperty(name: "cluster", @out: true, min: 0, max: 1)]
        public string @Cluster { get; }

        [nterraform.TerraformProperty(name: "deployment_maximum_percent", @out: false, min: 0, max: 1)]
        public int? @DeploymentMaximumPercent { get; }

        [nterraform.TerraformProperty(name: "deployment_minimum_healthy_percent", @out: false, min: 0, max: 1)]
        public int? @DeploymentMinimumHealthyPercent { get; }

        [nterraform.TerraformProperty(name: "desired_count", @out: false, min: 0, max: 1)]
        public int? @DesiredCount { get; }

        [nterraform.TerraformProperty(name: "health_check_grace_period_seconds", @out: false, min: 0, max: 1)]
        public int? @HealthCheckGracePeriodSeconds { get; }

        [nterraform.TerraformProperty(name: "iam_role", @out: true, min: 0, max: 1)]
        public string @IamRole { get; }

        [nterraform.TerraformProperty(name: "launch_type", @out: false, min: 0, max: 1)]
        public string @LaunchType { get; }

        [nterraform.TerraformProperty(name: "load_balancer", @out: false, min: 0, max: 1)]
        public load_balancer[] @LoadBalancer { get; }

        [nterraform.TerraformProperty(name: "network_configuration", @out: false, min: 0, max: 1)]
        public network_configuration[] @NetworkConfiguration { get; }

        [nterraform.TerraformProperty(name: "ordered_placement_strategy", @out: false, min: 0, max: 5)]
        public ordered_placement_strategy[] @OrderedPlacementStrategy { get; }

        [nterraform.TerraformProperty(name: "placement_constraints", @out: false, min: 0, max: 10)]
        public placement_constraints[] @PlacementConstraints { get; }

        [nterraform.TerraformProperty(name: "placement_strategy", @out: false, min: 0, max: 5)]
        public placement_strategy[] @PlacementStrategy { get; }

        [nterraform.TerraformProperty(name: "scheduling_strategy", @out: false, min: 0, max: 1)]
        public string @SchedulingStrategy { get; }

        [nterraform.TerraformProperty(name: "service_registries", @out: false, min: 0, max: 1)]
        public service_registries[] @ServiceRegistries { get; }
    }

}
