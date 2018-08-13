using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_gamelift_fleet")]
    public sealed class aws_gamelift_fleet : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "resource_creation_limit_policy")]
        public sealed class resource_creation_limit_policy : nterraform.Core.structure
        {
            public resource_creation_limit_policy(int? @newGameSessionsPerCreator = null,
                                                  int? @policyPeriodInMinutes = null)
            {
                @NewGameSessionsPerCreator = @newGameSessionsPerCreator;
                @PolicyPeriodInMinutes = @policyPeriodInMinutes;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "new_game_sessions_per_creator", @out: false, min: 0, max: 1)]
            public int? @NewGameSessionsPerCreator { get; }

            [nterraform.Core.TerraformProperty(name: "policy_period_in_minutes", @out: false, min: 0, max: 1)]
            public int? @PolicyPeriodInMinutes { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "runtime_configuration")]
        public sealed class runtime_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "server_process")]
            public sealed class server_process : nterraform.Core.structure
            {
                public server_process(int @concurrentExecutions,
                                      string @launchPath,
                                      string @parameters = null)
                {
                    @ConcurrentExecutions = @concurrentExecutions;
                    @LaunchPath = @launchPath;
                    @Parameters = @parameters;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "concurrent_executions", @out: false, min: 1, max: 1)]
                public int @ConcurrentExecutions { get; }

                [nterraform.Core.TerraformProperty(name: "launch_path", @out: false, min: 1, max: 1)]
                public string @LaunchPath { get; }

                [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
                public string @Parameters { get; }
            }

            public runtime_configuration(int? @gameSessionActivationTimeoutSeconds = null,
                                         int? @maxConcurrentGameSessionActivations = null,
                                         server_process[] @serverProcess = null)
            {
                @GameSessionActivationTimeoutSeconds = @gameSessionActivationTimeoutSeconds;
                @MaxConcurrentGameSessionActivations = @maxConcurrentGameSessionActivations;
                @ServerProcess = @serverProcess;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "game_session_activation_timeout_seconds", @out: false, min: 0, max: 1)]
            public int? @GameSessionActivationTimeoutSeconds { get; }

            [nterraform.Core.TerraformProperty(name: "max_concurrent_game_session_activations", @out: false, min: 0, max: 1)]
            public int? @MaxConcurrentGameSessionActivations { get; }

            [nterraform.Core.TerraformProperty(name: "server_process", @out: false, min: 0, max: 50)]
            public server_process[] @ServerProcess { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ec2_inbound_permission")]
        public sealed class ec2_inbound_permission : nterraform.Core.structure
        {
            public ec2_inbound_permission(int @fromPort,
                                          string @ipRange,
                                          string @protocol,
                                          int @toPort)
            {
                @FromPort = @fromPort;
                @IpRange = @ipRange;
                @Protocol = @protocol;
                @ToPort = @toPort;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "from_port", @out: false, min: 1, max: 1)]
            public int @FromPort { get; }

            [nterraform.Core.TerraformProperty(name: "ip_range", @out: false, min: 1, max: 1)]
            public string @IpRange { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "to_port", @out: false, min: 1, max: 1)]
            public int @ToPort { get; }
        }

        public aws_gamelift_fleet(string @buildId,
                                  string @ec2InstanceType,
                                  string @name,
                                  string @description = null,
                                  ec2_inbound_permission[] @ec2InboundPermission = null,
                                  string @newGameSessionProtectionPolicy = null,
                                  resource_creation_limit_policy[] @resourceCreationLimitPolicy = null,
                                  runtime_configuration[] @runtimeConfiguration = null)
        {
            @BuildId = @buildId;
            @Ec2InstanceType = @ec2InstanceType;
            @Name = @name;
            @Description = @description;
            @Ec2InboundPermission = @ec2InboundPermission;
            @NewGameSessionProtectionPolicy = @newGameSessionProtectionPolicy;
            @ResourceCreationLimitPolicy = @resourceCreationLimitPolicy;
            @RuntimeConfiguration = @runtimeConfiguration;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "build_id", @out: false, min: 1, max: 1)]
        public string @BuildId { get; }

        [nterraform.Core.TerraformProperty(name: "ec2_instance_type", @out: false, min: 1, max: 1)]
        public string @Ec2InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "ec2_inbound_permission", @out: false, min: 0, max: 50)]
        public ec2_inbound_permission[] @Ec2InboundPermission { get; }

        [nterraform.Core.TerraformProperty(name: "log_paths", @out: true, min: 0, max: 1)]
        public string[] @LogPaths { get; }

        [nterraform.Core.TerraformProperty(name: "metric_groups", @out: true, min: 0, max: 1)]
        public string[] @MetricGroups { get; }

        [nterraform.Core.TerraformProperty(name: "new_game_session_protection_policy", @out: false, min: 0, max: 1)]
        public string @NewGameSessionProtectionPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "operating_system", @out: true, min: 0, max: 1)]
        public string @OperatingSystem { get; }

        [nterraform.Core.TerraformProperty(name: "resource_creation_limit_policy", @out: false, min: 0, max: 1)]
        public resource_creation_limit_policy[] @ResourceCreationLimitPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "runtime_configuration", @out: false, min: 0, max: 1)]
        public runtime_configuration[] @RuntimeConfiguration { get; }
    }

}
