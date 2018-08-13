using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route53_record")]
    public sealed class aws_route53_record : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "latency_routing_policy")]
        public sealed class latency_routing_policy : nterraform.Core.structure
        {
            public latency_routing_policy(string @region)
            {
                @Region = @region;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
            public string @Region { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "geolocation_routing_policy")]
        public sealed class geolocation_routing_policy : nterraform.Core.structure
        {
            public geolocation_routing_policy(string @continent = null,
                                              string @country = null,
                                              string @subdivision = null)
            {
                @Continent = @continent;
                @Country = @country;
                @Subdivision = @subdivision;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "continent", @out: false, min: 0, max: 1)]
            public string @Continent { get; }

            [nterraform.Core.TerraformProperty(name: "country", @out: false, min: 0, max: 1)]
            public string @Country { get; }

            [nterraform.Core.TerraformProperty(name: "subdivision", @out: false, min: 0, max: 1)]
            public string @Subdivision { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "alias")]
        public sealed class alias : nterraform.Core.structure
        {
            public alias(bool @evaluateTargetHealth,
                         string @name,
                         string @zoneId)
            {
                @EvaluateTargetHealth = @evaluateTargetHealth;
                @Name = @name;
                @ZoneId = @zoneId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "evaluate_target_health", @out: false, min: 1, max: 1)]
            public bool @EvaluateTargetHealth { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "zone_id", @out: false, min: 1, max: 1)]
            public string @ZoneId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "failover_routing_policy")]
        public sealed class failover_routing_policy : nterraform.Core.structure
        {
            public failover_routing_policy(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "weighted_routing_policy")]
        public sealed class weighted_routing_policy : nterraform.Core.structure
        {
            public weighted_routing_policy(int @weight)
            {
                @Weight = @weight;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "weight", @out: false, min: 1, max: 1)]
            public int @Weight { get; }
        }

        public aws_route53_record(string @name,
                                  string @type,
                                  string @zoneId,
                                  alias[] @alias = null,
                                  bool? @allowOverwrite = null,
                                  string @failover = null,
                                  failover_routing_policy[] @failoverRoutingPolicy = null,
                                  geolocation_routing_policy[] @geolocationRoutingPolicy = null,
                                  string @healthCheckId = null,
                                  latency_routing_policy[] @latencyRoutingPolicy = null,
                                  bool? @multivalueAnswerRoutingPolicy = null,
                                  string[] @records = null,
                                  string @setIdentifier = null,
                                  int? @ttl = null,
                                  int? @weight = null,
                                  weighted_routing_policy[] @weightedRoutingPolicy = null)
        {
            @Name = @name;
            @Type = @type;
            @ZoneId = @zoneId;
            @Alias = @alias;
            @AllowOverwrite = @allowOverwrite;
            @Failover = @failover;
            @FailoverRoutingPolicy = @failoverRoutingPolicy;
            @GeolocationRoutingPolicy = @geolocationRoutingPolicy;
            @HealthCheckId = @healthCheckId;
            @LatencyRoutingPolicy = @latencyRoutingPolicy;
            @MultivalueAnswerRoutingPolicy = @multivalueAnswerRoutingPolicy;
            @Records = @records;
            @SetIdentifier = @setIdentifier;
            @Ttl = @ttl;
            @Weight = @weight;
            @WeightedRoutingPolicy = @weightedRoutingPolicy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "zone_id", @out: false, min: 1, max: 1)]
        public string @ZoneId { get; }

        [nterraform.Core.TerraformProperty(name: "alias", @out: false, min: 0, max: 0)]
        public alias[] @Alias { get; }

        [nterraform.Core.TerraformProperty(name: "allow_overwrite", @out: false, min: 0, max: 1)]
        public bool? @AllowOverwrite { get; }

        [nterraform.Core.TerraformProperty(name: "failover", @out: false, min: 0, max: 1)]
        public string @Failover { get; }

        [nterraform.Core.TerraformProperty(name: "failover_routing_policy", @out: false, min: 0, max: 0)]
        public failover_routing_policy[] @FailoverRoutingPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "geolocation_routing_policy", @out: false, min: 0, max: 0)]
        public geolocation_routing_policy[] @GeolocationRoutingPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "health_check_id", @out: false, min: 0, max: 1)]
        public string @HealthCheckId { get; }

        [nterraform.Core.TerraformProperty(name: "latency_routing_policy", @out: false, min: 0, max: 0)]
        public latency_routing_policy[] @LatencyRoutingPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "multivalue_answer_routing_policy", @out: false, min: 0, max: 1)]
        public bool? @MultivalueAnswerRoutingPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "records", @out: false, min: 0, max: 1)]
        public string[] @Records { get; }

        [nterraform.Core.TerraformProperty(name: "set_identifier", @out: false, min: 0, max: 1)]
        public string @SetIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 0, max: 1)]
        public int? @Ttl { get; }

        [nterraform.Core.TerraformProperty(name: "weight", @out: false, min: 0, max: 1)]
        public int? @Weight { get; }

        [nterraform.Core.TerraformProperty(name: "weighted_routing_policy", @out: false, min: 0, max: 0)]
        public weighted_routing_policy[] @WeightedRoutingPolicy { get; }
    }

}
