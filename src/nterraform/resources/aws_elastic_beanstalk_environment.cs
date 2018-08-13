using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elastic_beanstalk_environment")]
    public sealed class aws_elastic_beanstalk_environment : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "setting")]
        public sealed class setting : nterraform.Core.structure
        {
            public setting(string @name,
                           string @namespace,
                           string @value,
                           string @resource = null)
            {
                @Name = @name;
                @Namespace = @namespace;
                @Value = @value;
                @Resource = @resource;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
            public string @Namespace { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.Core.TerraformProperty(name: "resource", @out: false, min: 0, max: 1)]
            public string @Resource { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "all_settings")]
        public sealed class all_settings : nterraform.Core.structure
        {
            public all_settings(string @name,
                                string @namespace,
                                string @value,
                                string @resource = null)
            {
                @Name = @name;
                @Namespace = @namespace;
                @Value = @value;
                @Resource = @resource;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
            public string @Namespace { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.Core.TerraformProperty(name: "resource", @out: false, min: 0, max: 1)]
            public string @Resource { get; }
        }

        public aws_elastic_beanstalk_environment(string @application,
                                                 string @name,
                                                 all_settings[] @allSettings = null,
                                                 string @description = null,
                                                 string @pollInterval = null,
                                                 setting[] @setting = null,
                                                 Dictionary<string,string> @tags = null,
                                                 string @templateName = null,
                                                 string @tier = null,
                                                 string @waitForReadyTimeout = null)
        {
            @Application = @application;
            @Name = @name;
            @AllSettings = @allSettings;
            @Description = @description;
            @PollInterval = @pollInterval;
            @Setting = @setting;
            @Tags = @tags;
            @TemplateName = @templateName;
            @Tier = @tier;
            @WaitForReadyTimeout = @waitForReadyTimeout;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "application", @out: false, min: 1, max: 1)]
        public string @Application { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "all_settings", @out: false, min: 0, max: 0)]
        public all_settings[] @AllSettings { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "autoscaling_groups", @out: true, min: 0, max: 1)]
        public string[] @AutoscalingGroups { get; }

        [nterraform.Core.TerraformProperty(name: "cname", @out: true, min: 0, max: 1)]
        public string @Cname { get; }

        [nterraform.Core.TerraformProperty(name: "cname_prefix", @out: true, min: 0, max: 1)]
        public string @CnamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "instances", @out: true, min: 0, max: 1)]
        public string[] @Instances { get; }

        [nterraform.Core.TerraformProperty(name: "launch_configurations", @out: true, min: 0, max: 1)]
        public string[] @LaunchConfigurations { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancers", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancers { get; }

        [nterraform.Core.TerraformProperty(name: "poll_interval", @out: false, min: 0, max: 1)]
        public string @PollInterval { get; }

        [nterraform.Core.TerraformProperty(name: "queues", @out: true, min: 0, max: 1)]
        public string[] @Queues { get; }

        [nterraform.Core.TerraformProperty(name: "setting", @out: false, min: 0, max: 0)]
        public setting[] @Setting { get; }

        [nterraform.Core.TerraformProperty(name: "solution_stack_name", @out: true, min: 0, max: 1)]
        public string @SolutionStackName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "template_name", @out: false, min: 0, max: 1)]
        public string @TemplateName { get; }

        [nterraform.Core.TerraformProperty(name: "tier", @out: false, min: 0, max: 1)]
        public string @Tier { get; }

        [nterraform.Core.TerraformProperty(name: "triggers", @out: true, min: 0, max: 1)]
        public string[] @Triggers { get; }

        [nterraform.Core.TerraformProperty(name: "version_label", @out: true, min: 0, max: 1)]
        public string @VersionLabel { get; }

        [nterraform.Core.TerraformProperty(name: "wait_for_ready_timeout", @out: false, min: 0, max: 1)]
        public string @WaitForReadyTimeout { get; }
    }

}
