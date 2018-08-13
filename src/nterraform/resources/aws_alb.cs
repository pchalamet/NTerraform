using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_alb")]
    public sealed class aws_alb : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "subnet_mapping")]
        public sealed class subnet_mapping : nterraform.structure
        {
            public subnet_mapping(string @subnetId,
                                  string @allocationId = null)
            {
                @SubnetId = @subnetId;
                @AllocationId = @allocationId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
            public string @SubnetId { get; }

            [nterraform.TerraformProperty(name: "allocation_id", @out: false, min: 0, max: 1)]
            public string @AllocationId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "access_logs")]
        public sealed class access_logs : nterraform.structure
        {
            public access_logs(string @bucket,
                               bool? @enabled = null,
                               string @prefix = null)
            {
                @Bucket = @bucket;
                @Enabled = @enabled;
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
            public string @Bucket { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        public aws_alb(access_logs[] @accessLogs = null,
                       bool? @enableCrossZoneLoadBalancing = null,
                       bool? @enableDeletionProtection = null,
                       bool? @enableHttp2 = null,
                       int? @idleTimeout = null,
                       string @loadBalancerType = null,
                       string @namePrefix = null,
                       subnet_mapping[] @subnetMapping = null,
                       Dictionary<string,string> @tags = null)
        {
            @AccessLogs = @accessLogs;
            @EnableCrossZoneLoadBalancing = @enableCrossZoneLoadBalancing;
            @EnableDeletionProtection = @enableDeletionProtection;
            @EnableHttp2 = @enableHttp2;
            @IdleTimeout = @idleTimeout;
            @LoadBalancerType = @loadBalancerType;
            @NamePrefix = @namePrefix;
            @SubnetMapping = @subnetMapping;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "access_logs", @out: false, min: 0, max: 1)]
        public access_logs[] @AccessLogs { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "arn_suffix", @out: true, min: 0, max: 1)]
        public string @ArnSuffix { get; }

        [nterraform.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
        public string @DnsName { get; }

        [nterraform.TerraformProperty(name: "enable_cross_zone_load_balancing", @out: false, min: 0, max: 1)]
        public bool? @EnableCrossZoneLoadBalancing { get; }

        [nterraform.TerraformProperty(name: "enable_deletion_protection", @out: false, min: 0, max: 1)]
        public bool? @EnableDeletionProtection { get; }

        [nterraform.TerraformProperty(name: "enable_http2", @out: false, min: 0, max: 1)]
        public bool? @EnableHttp2 { get; }

        [nterraform.TerraformProperty(name: "idle_timeout", @out: false, min: 0, max: 1)]
        public int? @IdleTimeout { get; }

        [nterraform.TerraformProperty(name: "internal", @out: true, min: 0, max: 1)]
        public bool? @Internal { get; }

        [nterraform.TerraformProperty(name: "ip_address_type", @out: true, min: 0, max: 1)]
        public string @IpAddressType { get; }

        [nterraform.TerraformProperty(name: "load_balancer_type", @out: false, min: 0, max: 1)]
        public string @LoadBalancerType { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "subnet_mapping", @out: false, min: 0, max: 0)]
        public subnet_mapping[] @SubnetMapping { get; }

        [nterraform.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "zone_id", @out: true, min: 0, max: 1)]
        public string @ZoneId { get; }
    }

}
