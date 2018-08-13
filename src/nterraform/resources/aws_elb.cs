using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elb")]
    public sealed class aws_elb : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "access_logs")]
        public sealed class access_logs : nterraform.Core.structure
        {
            public access_logs(string @bucket,
                               string @bucketPrefix = null,
                               bool? @enabled = null,
                               int? @interval = null)
            {
                @Bucket = @bucket;
                @BucketPrefix = @bucketPrefix;
                @Enabled = @enabled;
                @Interval = @interval;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
            public string @Bucket { get; }

            [nterraform.Core.TerraformProperty(name: "bucket_prefix", @out: false, min: 0, max: 1)]
            public string @BucketPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public int? @Interval { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "listener")]
        public sealed class listener : nterraform.Core.structure
        {
            public listener(int @instancePort,
                            string @instanceProtocol,
                            int @lbPort,
                            string @lbProtocol,
                            string @sslCertificateId = null)
            {
                @InstancePort = @instancePort;
                @InstanceProtocol = @instanceProtocol;
                @LbPort = @lbPort;
                @LbProtocol = @lbProtocol;
                @SslCertificateId = @sslCertificateId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "instance_port", @out: false, min: 1, max: 1)]
            public int @InstancePort { get; }

            [nterraform.Core.TerraformProperty(name: "instance_protocol", @out: false, min: 1, max: 1)]
            public string @InstanceProtocol { get; }

            [nterraform.Core.TerraformProperty(name: "lb_port", @out: false, min: 1, max: 1)]
            public int @LbPort { get; }

            [nterraform.Core.TerraformProperty(name: "lb_protocol", @out: false, min: 1, max: 1)]
            public string @LbProtocol { get; }

            [nterraform.Core.TerraformProperty(name: "ssl_certificate_id", @out: false, min: 0, max: 1)]
            public string @SslCertificateId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "health_check")]
        public sealed class health_check : nterraform.Core.structure
        {
            public health_check(int @healthyThreshold,
                                int @interval,
                                string @target,
                                int @timeout,
                                int @unhealthyThreshold)
            {
                @HealthyThreshold = @healthyThreshold;
                @Interval = @interval;
                @Target = @target;
                @Timeout = @timeout;
                @UnhealthyThreshold = @unhealthyThreshold;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "healthy_threshold", @out: false, min: 1, max: 1)]
            public int @HealthyThreshold { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 1, max: 1)]
            public int @Interval { get; }

            [nterraform.Core.TerraformProperty(name: "target", @out: false, min: 1, max: 1)]
            public string @Target { get; }

            [nterraform.Core.TerraformProperty(name: "timeout", @out: false, min: 1, max: 1)]
            public int @Timeout { get; }

            [nterraform.Core.TerraformProperty(name: "unhealthy_threshold", @out: false, min: 1, max: 1)]
            public int @UnhealthyThreshold { get; }
        }

        public aws_elb(listener[] @listener,
                       access_logs[] @accessLogs = null,
                       bool? @connectionDraining = null,
                       int? @connectionDrainingTimeout = null,
                       bool? @crossZoneLoadBalancing = null,
                       health_check[] @healthCheck = null,
                       int? @idleTimeout = null,
                       string @namePrefix = null,
                       Dictionary<string,string> @tags = null)
        {
            @Listener = @listener;
            @AccessLogs = @accessLogs;
            @ConnectionDraining = @connectionDraining;
            @ConnectionDrainingTimeout = @connectionDrainingTimeout;
            @CrossZoneLoadBalancing = @crossZoneLoadBalancing;
            @HealthCheck = @healthCheck;
            @IdleTimeout = @idleTimeout;
            @NamePrefix = @namePrefix;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "listener", @out: false, min: 1, max: 0)]
        public listener[] @Listener { get; }

        [nterraform.Core.TerraformProperty(name: "access_logs", @out: false, min: 0, max: 1)]
        public access_logs[] @AccessLogs { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "connection_draining", @out: false, min: 0, max: 1)]
        public bool? @ConnectionDraining { get; }

        [nterraform.Core.TerraformProperty(name: "connection_draining_timeout", @out: false, min: 0, max: 1)]
        public int? @ConnectionDrainingTimeout { get; }

        [nterraform.Core.TerraformProperty(name: "cross_zone_load_balancing", @out: false, min: 0, max: 1)]
        public bool? @CrossZoneLoadBalancing { get; }

        [nterraform.Core.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.Core.TerraformProperty(name: "health_check", @out: false, min: 0, max: 1)]
        public health_check[] @HealthCheck { get; }

        [nterraform.Core.TerraformProperty(name: "idle_timeout", @out: false, min: 0, max: 1)]
        public int? @IdleTimeout { get; }

        [nterraform.Core.TerraformProperty(name: "instances", @out: true, min: 0, max: 1)]
        public string[] @Instances { get; }

        [nterraform.Core.TerraformProperty(name: "internal", @out: true, min: 0, max: 1)]
        public bool? @Internal { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "source_security_group", @out: true, min: 0, max: 1)]
        public string @SourceSecurityGroup { get; }

        [nterraform.Core.TerraformProperty(name: "source_security_group_id", @out: true, min: 0, max: 1)]
        public string @SourceSecurityGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zone_id", @out: true, min: 0, max: 1)]
        public string @ZoneId { get; }
    }

}
