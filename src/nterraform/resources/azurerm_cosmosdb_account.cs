using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_cosmosdb_account")]
    public sealed class azurerm_cosmosdb_account : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "failover_policy")]
        public sealed class failover_policy : nterraform.structure
        {
            public failover_policy(string @location,
                                   int @priority)
            {
                @Location = @location;
                @Priority = @priority;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [nterraform.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "capabilities")]
        public sealed class capabilities : nterraform.structure
        {
            public capabilities(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "consistency_policy")]
        public sealed class consistency_policy : nterraform.structure
        {
            public consistency_policy(string @consistencyLevel,
                                      int? @maxIntervalInSeconds = null,
                                      int? @maxStalenessPrefix = null)
            {
                @ConsistencyLevel = @consistencyLevel;
                @MaxIntervalInSeconds = @maxIntervalInSeconds;
                @MaxStalenessPrefix = @maxStalenessPrefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "consistency_level", @out: false, min: 1, max: 1)]
            public string @ConsistencyLevel { get; }

            [nterraform.TerraformProperty(name: "max_interval_in_seconds", @out: false, min: 0, max: 1)]
            public int? @MaxIntervalInSeconds { get; }

            [nterraform.TerraformProperty(name: "max_staleness_prefix", @out: false, min: 0, max: 1)]
            public int? @MaxStalenessPrefix { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "geo_location")]
        public sealed class geo_location : nterraform.structure
        {
            public geo_location(int @failoverPriority,
                                string @location,
                                string @prefix = null)
            {
                @FailoverPriority = @failoverPriority;
                @Location = @location;
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "failover_priority", @out: false, min: 1, max: 1)]
            public int @FailoverPriority { get; }

            [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        public azurerm_cosmosdb_account(consistency_policy[] @consistencyPolicy,
                                        string @location,
                                        string @name,
                                        string @offerType,
                                        string @resourceGroupName,
                                        capabilities[] @capabilities = null,
                                        bool? @enableAutomaticFailover = null,
                                        failover_policy[] @failoverPolicy = null,
                                        geo_location[] @geoLocation = null,
                                        string @ipRangeFilter = null,
                                        string @kind = null)
        {
            @ConsistencyPolicy = @consistencyPolicy;
            @Location = @location;
            @Name = @name;
            @OfferType = @offerType;
            @ResourceGroupName = @resourceGroupName;
            @Capabilities = @capabilities;
            @EnableAutomaticFailover = @enableAutomaticFailover;
            @FailoverPolicy = @failoverPolicy;
            @GeoLocation = @geoLocation;
            @IpRangeFilter = @ipRangeFilter;
            @Kind = @kind;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "consistency_policy", @out: false, min: 1, max: 1)]
        public consistency_policy[] @ConsistencyPolicy { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "offer_type", @out: false, min: 1, max: 1)]
        public string @OfferType { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "capabilities", @out: false, min: 0, max: 0)]
        public capabilities[] @Capabilities { get; }

        [nterraform.TerraformProperty(name: "connection_strings", @out: true, min: 0, max: 1)]
        public string[] @ConnectionStrings { get; }

        [nterraform.TerraformProperty(name: "enable_automatic_failover", @out: false, min: 0, max: 1)]
        public bool? @EnableAutomaticFailover { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "failover_policy", @out: false, min: 0, max: 0)]
        public failover_policy[] @FailoverPolicy { get; }

        [nterraform.TerraformProperty(name: "geo_location", @out: false, min: 0, max: 0)]
        public geo_location[] @GeoLocation { get; }

        [nterraform.TerraformProperty(name: "ip_range_filter", @out: false, min: 0, max: 1)]
        public string @IpRangeFilter { get; }

        [nterraform.TerraformProperty(name: "kind", @out: false, min: 0, max: 1)]
        public string @Kind { get; }

        [nterraform.TerraformProperty(name: "primary_master_key", @out: true, min: 0, max: 1)]
        public string @PrimaryMasterKey { get; }

        [nterraform.TerraformProperty(name: "primary_readonly_master_key", @out: true, min: 0, max: 1)]
        public string @PrimaryReadonlyMasterKey { get; }

        [nterraform.TerraformProperty(name: "read_endpoints", @out: true, min: 0, max: 1)]
        public string[] @ReadEndpoints { get; }

        [nterraform.TerraformProperty(name: "secondary_master_key", @out: true, min: 0, max: 1)]
        public string @SecondaryMasterKey { get; }

        [nterraform.TerraformProperty(name: "secondary_readonly_master_key", @out: true, min: 0, max: 1)]
        public string @SecondaryReadonlyMasterKey { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "write_endpoints", @out: true, min: 0, max: 1)]
        public string[] @WriteEndpoints { get; }
    }

}
