using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_mq_broker")]
    public sealed class aws_mq_broker : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "configuration")]
        public sealed class configuration : nterraform.structure
        {
            public configuration()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
            public int? @Revision { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "instances")]
        public sealed class instances : nterraform.structure
        {
            public instances()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "console_url", @out: true, min: 0, max: 1)]
            public string @ConsoleUrl { get; }

            [nterraform.TerraformProperty(name: "endpoints", @out: true, min: 0, max: 1)]
            public string[] @Endpoints { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "user")]
        public sealed class user : nterraform.structure
        {
            public user(string @password,
                        string @username,
                        bool? @consoleAccess = null,
                        string[] @groups = null)
            {
                @Password = @password;
                @Username = @username;
                @ConsoleAccess = @consoleAccess;
                @Groups = @groups;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
            public string @Username { get; }

            [nterraform.TerraformProperty(name: "console_access", @out: false, min: 0, max: 1)]
            public bool? @ConsoleAccess { get; }

            [nterraform.TerraformProperty(name: "groups", @out: false, min: 0, max: 1)]
            public string[] @Groups { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "maintenance_window_start_time")]
        public sealed class maintenance_window_start_time : nterraform.structure
        {
            public maintenance_window_start_time(string @dayOfWeek,
                                                 string @timeOfDay,
                                                 string @timeZone)
            {
                @DayOfWeek = @dayOfWeek;
                @TimeOfDay = @timeOfDay;
                @TimeZone = @timeZone;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "day_of_week", @out: false, min: 1, max: 1)]
            public string @DayOfWeek { get; }

            [nterraform.TerraformProperty(name: "time_of_day", @out: false, min: 1, max: 1)]
            public string @TimeOfDay { get; }

            [nterraform.TerraformProperty(name: "time_zone", @out: false, min: 1, max: 1)]
            public string @TimeZone { get; }
        }

        public aws_mq_broker(string @brokerName,
                             string @engineType,
                             string @engineVersion,
                             string @hostInstanceType,
                             string[] @securityGroups,
                             user[] @user,
                             bool? @applyImmediately = null,
                             bool? @autoMinorVersionUpgrade = null,
                             configuration[] @configuration = null,
                             string @deploymentMode = null,
                             instances[] @instances = null,
                             maintenance_window_start_time[] @maintenanceWindowStartTime = null,
                             bool? @publiclyAccessible = null)
        {
            @BrokerName = @brokerName;
            @EngineType = @engineType;
            @EngineVersion = @engineVersion;
            @HostInstanceType = @hostInstanceType;
            @SecurityGroups = @securityGroups;
            @User = @user;
            @ApplyImmediately = @applyImmediately;
            @AutoMinorVersionUpgrade = @autoMinorVersionUpgrade;
            @Configuration = @configuration;
            @DeploymentMode = @deploymentMode;
            @Instances = @instances;
            @MaintenanceWindowStartTime = @maintenanceWindowStartTime;
            @PubliclyAccessible = @publiclyAccessible;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "broker_name", @out: false, min: 1, max: 1)]
        public string @BrokerName { get; }

        [nterraform.TerraformProperty(name: "engine_type", @out: false, min: 1, max: 1)]
        public string @EngineType { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: false, min: 1, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "host_instance_type", @out: false, min: 1, max: 1)]
        public string @HostInstanceType { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: false, min: 1, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "user", @out: false, min: 1, max: 0)]
        public user[] @User { get; }

        [nterraform.TerraformProperty(name: "apply_immediately", @out: false, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "auto_minor_version_upgrade", @out: false, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.TerraformProperty(name: "configuration", @out: false, min: 0, max: 1)]
        public configuration[] @Configuration { get; }

        [nterraform.TerraformProperty(name: "deployment_mode", @out: false, min: 0, max: 1)]
        public string @DeploymentMode { get; }

        [nterraform.TerraformProperty(name: "instances", @out: false, min: 0, max: 0)]
        public instances[] @Instances { get; }

        [nterraform.TerraformProperty(name: "maintenance_window_start_time", @out: false, min: 0, max: 1)]
        public maintenance_window_start_time[] @MaintenanceWindowStartTime { get; }

        [nterraform.TerraformProperty(name: "publicly_accessible", @out: false, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
        public string[] @SubnetIds { get; }
    }

}
