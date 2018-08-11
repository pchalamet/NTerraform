using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_cosmosdb_account")]
    public sealed class azurerm_cosmosdb_account : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "consistency_policy")]
        public sealed class consistency_policy: NTerraform.structure
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

            [TerraformProperty(name: "consistency_level", @out: false, min: 1, max: 1)]
            public string @ConsistencyLevel { get; }

            [TerraformProperty(name: "max_interval_in_seconds", @out: false, min: 0, max: 1)]
            public int? @MaxIntervalInSeconds { get; }

            [TerraformProperty(name: "max_staleness_prefix", @out: false, min: 0, max: 1)]
            public int? @MaxStalenessPrefix { get; }
        }

        [TerraformStructure(category: "", typeName: "geo_location")]
        public sealed class geo_location: NTerraform.structure
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

            [TerraformProperty(name: "failover_priority", @out: false, min: 1, max: 1)]
            public int @FailoverPriority { get; }

            [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        [TerraformStructure(category: "", typeName: "failover_policy")]
        public sealed class failover_policy: NTerraform.structure
        {
            public failover_policy(string @location,
                                   int @priority)
            {
                @Location = @location;
                @Priority = @priority;
                base._validate_();
            }

            [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [TerraformStructure(category: "", typeName: "capabilities")]
        public sealed class capabilities: NTerraform.structure
        {
            public capabilities(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
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

        [TerraformProperty(name: "consistency_policy", @out: false, min: 1, max: 1)]
        public consistency_policy[] @ConsistencyPolicy { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "offer_type", @out: false, min: 1, max: 1)]
        public string @OfferType { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "capabilities", @out: false, min: 0, max: 0)]
        public capabilities[] @Capabilities { get; }

        [TerraformProperty(name: "connection_strings", @out: true, min: 0, max: 1)]
        public string[] @ConnectionStrings { get; }

        [TerraformProperty(name: "enable_automatic_failover", @out: false, min: 0, max: 1)]
        public bool? @EnableAutomaticFailover { get; }

        [TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [TerraformProperty(name: "failover_policy", @out: false, min: 0, max: 0)]
        public failover_policy[] @FailoverPolicy { get; }

        [TerraformProperty(name: "geo_location", @out: false, min: 0, max: 0)]
        public geo_location[] @GeoLocation { get; }

        [TerraformProperty(name: "ip_range_filter", @out: false, min: 0, max: 1)]
        public string @IpRangeFilter { get; }

        [TerraformProperty(name: "kind", @out: false, min: 0, max: 1)]
        public string @Kind { get; }

        [TerraformProperty(name: "primary_master_key", @out: true, min: 0, max: 1)]
        public string @PrimaryMasterKey { get; }

        [TerraformProperty(name: "primary_readonly_master_key", @out: true, min: 0, max: 1)]
        public string @PrimaryReadonlyMasterKey { get; }

        [TerraformProperty(name: "read_endpoints", @out: true, min: 0, max: 1)]
        public string[] @ReadEndpoints { get; }

        [TerraformProperty(name: "secondary_master_key", @out: true, min: 0, max: 1)]
        public string @SecondaryMasterKey { get; }

        [TerraformProperty(name: "secondary_readonly_master_key", @out: true, min: 0, max: 1)]
        public string @SecondaryReadonlyMasterKey { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "write_endpoints", @out: true, min: 0, max: 1)]
        public string[] @WriteEndpoints { get; }
    }

}
