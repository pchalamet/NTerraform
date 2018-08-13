using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_lb")]
    public sealed class aws_lb : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "subnet_mapping")]
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

        [nterraform.TerraformStructure(category: "data", typeName: "access_logs")]
        public sealed class access_logs : nterraform.structure
        {
            public access_logs()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket", @out: true, min: 0, max: 1)]
            public string @Bucket { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: true, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        public aws_lb(access_logs[] @accessLogs = null,
                      subnet_mapping[] @subnetMapping = null)
        {
            @AccessLogs = @accessLogs;
            @SubnetMapping = @subnetMapping;
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

        [nterraform.TerraformProperty(name: "enable_deletion_protection", @out: true, min: 0, max: 1)]
        public bool? @EnableDeletionProtection { get; }

        [nterraform.TerraformProperty(name: "idle_timeout", @out: true, min: 0, max: 1)]
        public int? @IdleTimeout { get; }

        [nterraform.TerraformProperty(name: "internal", @out: true, min: 0, max: 1)]
        public bool? @Internal { get; }

        [nterraform.TerraformProperty(name: "load_balancer_type", @out: true, min: 0, max: 1)]
        public string @LoadBalancerType { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "subnet_mapping", @out: false, min: 0, max: 0)]
        public subnet_mapping[] @SubnetMapping { get; }

        [nterraform.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "zone_id", @out: true, min: 0, max: 1)]
        public string @ZoneId { get; }
    }

}
