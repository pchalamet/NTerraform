using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_elb")]
    public sealed class aws_elb : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "access_logs")]
        public sealed class access_logs : nterraform.structure
        {
            public access_logs()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket", @out: true, min: 0, max: 1)]
            public string @Bucket { get; }

            [nterraform.TerraformProperty(name: "bucket_prefix", @out: true, min: 0, max: 1)]
            public string @BucketPrefix { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "interval", @out: true, min: 0, max: 1)]
            public int? @Interval { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "health_check")]
        public sealed class health_check : nterraform.structure
        {
            public health_check()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "healthy_threshold", @out: true, min: 0, max: 1)]
            public int? @HealthyThreshold { get; }

            [nterraform.TerraformProperty(name: "interval", @out: true, min: 0, max: 1)]
            public int? @Interval { get; }

            [nterraform.TerraformProperty(name: "target", @out: true, min: 0, max: 1)]
            public string @Target { get; }

            [nterraform.TerraformProperty(name: "timeout", @out: true, min: 0, max: 1)]
            public int? @Timeout { get; }

            [nterraform.TerraformProperty(name: "unhealthy_threshold", @out: true, min: 0, max: 1)]
            public int? @UnhealthyThreshold { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "listener")]
        public sealed class listener : nterraform.structure
        {
            public listener()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "instance_port", @out: true, min: 0, max: 1)]
            public int? @InstancePort { get; }

            [nterraform.TerraformProperty(name: "instance_protocol", @out: true, min: 0, max: 1)]
            public string @InstanceProtocol { get; }

            [nterraform.TerraformProperty(name: "lb_port", @out: true, min: 0, max: 1)]
            public int? @LbPort { get; }

            [nterraform.TerraformProperty(name: "lb_protocol", @out: true, min: 0, max: 1)]
            public string @LbProtocol { get; }

            [nterraform.TerraformProperty(name: "ssl_certificate_id", @out: true, min: 0, max: 1)]
            public string @SslCertificateId { get; }
        }

        public aws_elb(string @name,
                       access_logs[] @accessLogs = null,
                       health_check[] @healthCheck = null,
                       listener[] @listener = null)
        {
            @Name = @name;
            @AccessLogs = @accessLogs;
            @HealthCheck = @healthCheck;
            @Listener = @listener;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "access_logs", @out: false, min: 0, max: 1)]
        public access_logs[] @AccessLogs { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "connection_draining", @out: true, min: 0, max: 1)]
        public bool? @ConnectionDraining { get; }

        [nterraform.TerraformProperty(name: "connection_draining_timeout", @out: true, min: 0, max: 1)]
        public int? @ConnectionDrainingTimeout { get; }

        [nterraform.TerraformProperty(name: "cross_zone_load_balancing", @out: true, min: 0, max: 1)]
        public bool? @CrossZoneLoadBalancing { get; }

        [nterraform.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.TerraformProperty(name: "health_check", @out: false, min: 0, max: 1)]
        public health_check[] @HealthCheck { get; }

        [nterraform.TerraformProperty(name: "idle_timeout", @out: true, min: 0, max: 1)]
        public int? @IdleTimeout { get; }

        [nterraform.TerraformProperty(name: "instances", @out: true, min: 0, max: 1)]
        public string[] @Instances { get; }

        [nterraform.TerraformProperty(name: "internal", @out: true, min: 0, max: 1)]
        public bool? @Internal { get; }

        [nterraform.TerraformProperty(name: "listener", @out: false, min: 0, max: 0)]
        public listener[] @Listener { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "source_security_group", @out: true, min: 0, max: 1)]
        public string @SourceSecurityGroup { get; }

        [nterraform.TerraformProperty(name: "source_security_group_id", @out: true, min: 0, max: 1)]
        public string @SourceSecurityGroupId { get; }

        [nterraform.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "zone_id", @out: true, min: 0, max: 1)]
        public string @ZoneId { get; }
    }

}
