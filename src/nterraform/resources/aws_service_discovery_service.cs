using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_service_discovery_service")]
    public sealed class aws_service_discovery_service : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "health_check_custom_config")]
        public sealed class health_check_custom_config : nterraform.structure
        {
            public health_check_custom_config(int? @failureThreshold = null)
            {
                @FailureThreshold = @failureThreshold;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "failure_threshold", @out: false, min: 0, max: 1)]
            public int? @FailureThreshold { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "dns_config")]
        public sealed class dns_config : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "dns_records")]
            public sealed class dns_records : nterraform.structure
            {
                public dns_records(int @ttl,
                                   string @type)
                {
                    @Ttl = @ttl;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
                public int @Ttl { get; }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            public dns_config(dns_records[] @dnsRecords,
                              string @namespaceId,
                              string @routingPolicy = null)
            {
                @DnsRecords = @dnsRecords;
                @NamespaceId = @namespaceId;
                @RoutingPolicy = @routingPolicy;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns_records", @out: false, min: 1, max: 0)]
            public dns_records[] @DnsRecords { get; }

            [nterraform.TerraformProperty(name: "namespace_id", @out: false, min: 1, max: 1)]
            public string @NamespaceId { get; }

            [nterraform.TerraformProperty(name: "routing_policy", @out: false, min: 0, max: 1)]
            public string @RoutingPolicy { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "health_check_config")]
        public sealed class health_check_config : nterraform.structure
        {
            public health_check_config(int? @failureThreshold = null,
                                       string @resourcePath = null,
                                       string @type = null)
            {
                @FailureThreshold = @failureThreshold;
                @ResourcePath = @resourcePath;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "failure_threshold", @out: false, min: 0, max: 1)]
            public int? @FailureThreshold { get; }

            [nterraform.TerraformProperty(name: "resource_path", @out: false, min: 0, max: 1)]
            public string @ResourcePath { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_service_discovery_service(dns_config[] @dnsConfig,
                                             string @name,
                                             string @description = null,
                                             health_check_config[] @healthCheckConfig = null,
                                             health_check_custom_config[] @healthCheckCustomConfig = null)
        {
            @DnsConfig = @dnsConfig;
            @Name = @name;
            @Description = @description;
            @HealthCheckConfig = @healthCheckConfig;
            @HealthCheckCustomConfig = @healthCheckCustomConfig;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "dns_config", @out: false, min: 1, max: 1)]
        public dns_config[] @DnsConfig { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "health_check_config", @out: false, min: 0, max: 1)]
        public health_check_config[] @HealthCheckConfig { get; }

        [nterraform.TerraformProperty(name: "health_check_custom_config", @out: false, min: 0, max: 1)]
        public health_check_custom_config[] @HealthCheckCustomConfig { get; }
    }

}
