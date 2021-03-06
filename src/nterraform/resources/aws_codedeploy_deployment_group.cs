using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_codedeploy_deployment_group")]
    public sealed class aws_codedeploy_deployment_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "deployment_style")]
        public sealed class deployment_style : nterraform.structure
        {
            public deployment_style(string @deploymentOption = null,
                                    string @deploymentType = null)
            {
                @DeploymentOption = @deploymentOption;
                @DeploymentType = @deploymentType;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "deployment_option", @out: false, min: 0, max: 1)]
            public string @DeploymentOption { get; }

            [nterraform.TerraformProperty(name: "deployment_type", @out: false, min: 0, max: 1)]
            public string @DeploymentType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "auto_rollback_configuration")]
        public sealed class auto_rollback_configuration : nterraform.structure
        {
            public auto_rollback_configuration(bool? @enabled = null,
                                               string[] @events = null)
            {
                @Enabled = @enabled;
                @Events = @events;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "events", @out: false, min: 0, max: 1)]
            public string[] @Events { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "load_balancer_info")]
        public sealed class load_balancer_info : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "elb_info")]
            public sealed class elb_info : nterraform.structure
            {
                public elb_info(string @name = null)
                {
                    @Name = @name;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
                public string @Name { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "target_group_info")]
            public sealed class target_group_info : nterraform.structure
            {
                public target_group_info(string @name = null)
                {
                    @Name = @name;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
                public string @Name { get; }
            }

            public load_balancer_info(elb_info[] @elbInfo = null,
                                      target_group_info[] @targetGroupInfo = null)
            {
                @ElbInfo = @elbInfo;
                @TargetGroupInfo = @targetGroupInfo;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "elb_info", @out: false, min: 0, max: 0)]
            public elb_info[] @ElbInfo { get; }

            [nterraform.TerraformProperty(name: "target_group_info", @out: false, min: 0, max: 0)]
            public target_group_info[] @TargetGroupInfo { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ec2_tag_filter")]
        public sealed class ec2_tag_filter : nterraform.structure
        {
            public ec2_tag_filter(string @key = null,
                                  string @type = null,
                                  string @value = null)
            {
                @Key = @key;
                @Type = @type;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key", @out: false, min: 0, max: 1)]
            public string @Key { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 0, max: 1)]
            public string @Value { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "blue_green_deployment_config")]
        public sealed class blue_green_deployment_config : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "green_fleet_provisioning_option")]
            public sealed class green_fleet_provisioning_option : nterraform.structure
            {
                public green_fleet_provisioning_option(string @action = null)
                {
                    @Action = @action;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
                public string @Action { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "terminate_blue_instances_on_deployment_success")]
            public sealed class terminate_blue_instances_on_deployment_success : nterraform.structure
            {
                public terminate_blue_instances_on_deployment_success(string @action = null,
                                                                      int? @terminationWaitTimeInMinutes = null)
                {
                    @Action = @action;
                    @TerminationWaitTimeInMinutes = @terminationWaitTimeInMinutes;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
                public string @Action { get; }

                [nterraform.TerraformProperty(name: "termination_wait_time_in_minutes", @out: false, min: 0, max: 1)]
                public int? @TerminationWaitTimeInMinutes { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "deployment_ready_option")]
            public sealed class deployment_ready_option : nterraform.structure
            {
                public deployment_ready_option(string @actionOnTimeout = null,
                                               int? @waitTimeInMinutes = null)
                {
                    @ActionOnTimeout = @actionOnTimeout;
                    @WaitTimeInMinutes = @waitTimeInMinutes;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "action_on_timeout", @out: false, min: 0, max: 1)]
                public string @ActionOnTimeout { get; }

                [nterraform.TerraformProperty(name: "wait_time_in_minutes", @out: false, min: 0, max: 1)]
                public int? @WaitTimeInMinutes { get; }
            }

            public blue_green_deployment_config(deployment_ready_option[] @deploymentReadyOption = null,
                                                green_fleet_provisioning_option[] @greenFleetProvisioningOption = null,
                                                terminate_blue_instances_on_deployment_success[] @terminateBlueInstancesOnDeploymentSuccess = null)
            {
                @DeploymentReadyOption = @deploymentReadyOption;
                @GreenFleetProvisioningOption = @greenFleetProvisioningOption;
                @TerminateBlueInstancesOnDeploymentSuccess = @terminateBlueInstancesOnDeploymentSuccess;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "deployment_ready_option", @out: false, min: 0, max: 1)]
            public deployment_ready_option[] @DeploymentReadyOption { get; }

            [nterraform.TerraformProperty(name: "green_fleet_provisioning_option", @out: false, min: 0, max: 1)]
            public green_fleet_provisioning_option[] @GreenFleetProvisioningOption { get; }

            [nterraform.TerraformProperty(name: "terminate_blue_instances_on_deployment_success", @out: false, min: 0, max: 1)]
            public terminate_blue_instances_on_deployment_success[] @TerminateBlueInstancesOnDeploymentSuccess { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "trigger_configuration")]
        public sealed class trigger_configuration : nterraform.structure
        {
            public trigger_configuration(string[] @triggerEvents,
                                         string @triggerName,
                                         string @triggerTargetArn)
            {
                @TriggerEvents = @triggerEvents;
                @TriggerName = @triggerName;
                @TriggerTargetArn = @triggerTargetArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "trigger_events", @out: false, min: 1, max: 1)]
            public string[] @TriggerEvents { get; }

            [nterraform.TerraformProperty(name: "trigger_name", @out: false, min: 1, max: 1)]
            public string @TriggerName { get; }

            [nterraform.TerraformProperty(name: "trigger_target_arn", @out: false, min: 1, max: 1)]
            public string @TriggerTargetArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "alarm_configuration")]
        public sealed class alarm_configuration : nterraform.structure
        {
            public alarm_configuration(string[] @alarms = null,
                                       bool? @enabled = null,
                                       bool? @ignorePollAlarmFailure = null)
            {
                @Alarms = @alarms;
                @Enabled = @enabled;
                @IgnorePollAlarmFailure = @ignorePollAlarmFailure;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "alarms", @out: false, min: 0, max: 1)]
            public string[] @Alarms { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "ignore_poll_alarm_failure", @out: false, min: 0, max: 1)]
            public bool? @IgnorePollAlarmFailure { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "on_premises_instance_tag_filter")]
        public sealed class on_premises_instance_tag_filter : nterraform.structure
        {
            public on_premises_instance_tag_filter(string @key = null,
                                                   string @type = null,
                                                   string @value = null)
            {
                @Key = @key;
                @Type = @type;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key", @out: false, min: 0, max: 1)]
            public string @Key { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 0, max: 1)]
            public string @Value { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ec2_tag_set")]
        public sealed class ec2_tag_set : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "ec2_tag_filter")]
            public sealed class ec2_tag_filter : nterraform.structure
            {
                public ec2_tag_filter(string @key = null,
                                      string @type = null,
                                      string @value = null)
                {
                    @Key = @key;
                    @Type = @type;
                    @Value = @value;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key", @out: false, min: 0, max: 1)]
                public string @Key { get; }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
                public string @Type { get; }

                [nterraform.TerraformProperty(name: "value", @out: false, min: 0, max: 1)]
                public string @Value { get; }
            }

            public ec2_tag_set(ec2_tag_filter[] @ec2TagFilter = null)
            {
                @Ec2TagFilter = @ec2TagFilter;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "ec2_tag_filter", @out: false, min: 0, max: 0)]
            public ec2_tag_filter[] @Ec2TagFilter { get; }
        }

        public aws_codedeploy_deployment_group(string @appName,
                                               string @deploymentGroupName,
                                               string @serviceRoleArn,
                                               alarm_configuration[] @alarmConfiguration = null,
                                               auto_rollback_configuration[] @autoRollbackConfiguration = null,
                                               string[] @autoscalingGroups = null,
                                               blue_green_deployment_config[] @blueGreenDeploymentConfig = null,
                                               string @deploymentConfigName = null,
                                               deployment_style[] @deploymentStyle = null,
                                               ec2_tag_filter[] @ec2TagFilter = null,
                                               ec2_tag_set[] @ec2TagSet = null,
                                               load_balancer_info[] @loadBalancerInfo = null,
                                               on_premises_instance_tag_filter[] @onPremisesInstanceTagFilter = null,
                                               trigger_configuration[] @triggerConfiguration = null)
        {
            @AppName = @appName;
            @DeploymentGroupName = @deploymentGroupName;
            @ServiceRoleArn = @serviceRoleArn;
            @AlarmConfiguration = @alarmConfiguration;
            @AutoRollbackConfiguration = @autoRollbackConfiguration;
            @AutoscalingGroups = @autoscalingGroups;
            @BlueGreenDeploymentConfig = @blueGreenDeploymentConfig;
            @DeploymentConfigName = @deploymentConfigName;
            @DeploymentStyle = @deploymentStyle;
            @Ec2TagFilter = @ec2TagFilter;
            @Ec2TagSet = @ec2TagSet;
            @LoadBalancerInfo = @loadBalancerInfo;
            @OnPremisesInstanceTagFilter = @onPremisesInstanceTagFilter;
            @TriggerConfiguration = @triggerConfiguration;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "app_name", @out: false, min: 1, max: 1)]
        public string @AppName { get; }

        [nterraform.TerraformProperty(name: "deployment_group_name", @out: false, min: 1, max: 1)]
        public string @DeploymentGroupName { get; }

        [nterraform.TerraformProperty(name: "service_role_arn", @out: false, min: 1, max: 1)]
        public string @ServiceRoleArn { get; }

        [nterraform.TerraformProperty(name: "alarm_configuration", @out: false, min: 0, max: 1)]
        public alarm_configuration[] @AlarmConfiguration { get; }

        [nterraform.TerraformProperty(name: "auto_rollback_configuration", @out: false, min: 0, max: 1)]
        public auto_rollback_configuration[] @AutoRollbackConfiguration { get; }

        [nterraform.TerraformProperty(name: "autoscaling_groups", @out: false, min: 0, max: 1)]
        public string[] @AutoscalingGroups { get; }

        [nterraform.TerraformProperty(name: "blue_green_deployment_config", @out: false, min: 0, max: 1)]
        public blue_green_deployment_config[] @BlueGreenDeploymentConfig { get; }

        [nterraform.TerraformProperty(name: "deployment_config_name", @out: false, min: 0, max: 1)]
        public string @DeploymentConfigName { get; }

        [nterraform.TerraformProperty(name: "deployment_style", @out: false, min: 0, max: 1)]
        public deployment_style[] @DeploymentStyle { get; }

        [nterraform.TerraformProperty(name: "ec2_tag_filter", @out: false, min: 0, max: 0)]
        public ec2_tag_filter[] @Ec2TagFilter { get; }

        [nterraform.TerraformProperty(name: "ec2_tag_set", @out: false, min: 0, max: 0)]
        public ec2_tag_set[] @Ec2TagSet { get; }

        [nterraform.TerraformProperty(name: "load_balancer_info", @out: false, min: 0, max: 1)]
        public load_balancer_info[] @LoadBalancerInfo { get; }

        [nterraform.TerraformProperty(name: "on_premises_instance_tag_filter", @out: false, min: 0, max: 0)]
        public on_premises_instance_tag_filter[] @OnPremisesInstanceTagFilter { get; }

        [nterraform.TerraformProperty(name: "trigger_configuration", @out: false, min: 0, max: 0)]
        public trigger_configuration[] @TriggerConfiguration { get; }
    }

}
