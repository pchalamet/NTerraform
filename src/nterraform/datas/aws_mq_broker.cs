using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_mq_broker")]
    public sealed class aws_mq_broker : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "user")]
        public sealed class user : nterraform.Core.structure
        {
            public user(string @username)
            {
                @Username = @username;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
            public string @Username { get; }

            [nterraform.Core.TerraformProperty(name: "console_access", @out: true, min: 0, max: 1)]
            public bool? @ConsoleAccess { get; }

            [nterraform.Core.TerraformProperty(name: "groups", @out: true, min: 0, max: 1)]
            public string[] @Groups { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "configuration")]
        public sealed class configuration : nterraform.Core.structure
        {
            public configuration()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
            public int? @Revision { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "instances")]
        public sealed class instances : nterraform.Core.structure
        {
            public instances()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "console_url", @out: true, min: 0, max: 1)]
            public string @ConsoleUrl { get; }

            [nterraform.Core.TerraformProperty(name: "endpoints", @out: true, min: 0, max: 1)]
            public string[] @Endpoints { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "maintenance_window_start_time")]
        public sealed class maintenance_window_start_time : nterraform.Core.structure
        {
            public maintenance_window_start_time()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "day_of_week", @out: true, min: 0, max: 1)]
            public string @DayOfWeek { get; }

            [nterraform.Core.TerraformProperty(name: "time_of_day", @out: true, min: 0, max: 1)]
            public string @TimeOfDay { get; }

            [nterraform.Core.TerraformProperty(name: "time_zone", @out: true, min: 0, max: 1)]
            public string @TimeZone { get; }
        }

        public aws_mq_broker(configuration[] @configuration = null,
                             instances[] @instances = null,
                             maintenance_window_start_time[] @maintenanceWindowStartTime = null,
                             user[] @user = null)
        {
            @Configuration = @configuration;
            @Instances = @instances;
            @MaintenanceWindowStartTime = @maintenanceWindowStartTime;
            @User = @user;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "auto_minor_version_upgrade", @out: true, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.Core.TerraformProperty(name: "broker_id", @out: true, min: 0, max: 1)]
        public string @BrokerId { get; }

        [nterraform.Core.TerraformProperty(name: "broker_name", @out: true, min: 0, max: 1)]
        public string @BrokerName { get; }

        [nterraform.Core.TerraformProperty(name: "configuration", @out: false, min: 0, max: 1)]
        public configuration[] @Configuration { get; }

        [nterraform.Core.TerraformProperty(name: "deployment_mode", @out: true, min: 0, max: 1)]
        public string @DeploymentMode { get; }

        [nterraform.Core.TerraformProperty(name: "engine_type", @out: true, min: 0, max: 1)]
        public string @EngineType { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "host_instance_type", @out: true, min: 0, max: 1)]
        public string @HostInstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "instances", @out: false, min: 0, max: 0)]
        public instances[] @Instances { get; }

        [nterraform.Core.TerraformProperty(name: "maintenance_window_start_time", @out: false, min: 0, max: 1)]
        public maintenance_window_start_time[] @MaintenanceWindowStartTime { get; }

        [nterraform.Core.TerraformProperty(name: "publicly_accessible", @out: true, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.Core.TerraformProperty(name: "user", @out: false, min: 0, max: 0)]
        public user[] @User { get; }
    }

}
