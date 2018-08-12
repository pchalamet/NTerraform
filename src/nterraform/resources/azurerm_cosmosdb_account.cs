using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_cosmosdb_account")]
    public sealed class azurerm_cosmosdb_account : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "failover_policy")]
        public sealed class failover_policy : nterraform.Core.structure
        {
            public failover_policy(string @location,
                                   int @priority)
            {
                @Location = @location;
                @Priority = @priority;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Id { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "capabilities")]
        public sealed class capabilities : nterraform.Core.structure
        {
            public capabilities(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "geo_location")]
        public sealed class geo_location : nterraform.Core.structure
        {
            public geo_location(int @failoverPriority,
                                string @location,
                                FSharpOption<string> @prefix = null)
            {
                @FailoverPriority = @failoverPriority;
                @Location = @location;
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "failover_priority", @out: false, min: 1, max: 1)]
            public int @FailoverPriority { get; }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Id { get; }

            [nterraform.Core.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Prefix { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "consistency_policy")]
        public sealed class consistency_policy : nterraform.Core.structure
        {
            public consistency_policy(string @consistencyLevel,
                                      FSharpOption<int> @maxIntervalInSeconds = null,
                                      FSharpOption<int> @maxStalenessPrefix = null)
            {
                @ConsistencyLevel = @consistencyLevel;
                @MaxIntervalInSeconds = @maxIntervalInSeconds;
                @MaxStalenessPrefix = @maxStalenessPrefix;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "consistency_level", @out: false, min: 1, max: 1)]
            public string @ConsistencyLevel { get; }

            [nterraform.Core.TerraformProperty(name: "max_interval_in_seconds", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @MaxIntervalInSeconds { get; }

            [nterraform.Core.TerraformProperty(name: "max_staleness_prefix", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @MaxStalenessPrefix { get; }
        }

        public azurerm_cosmosdb_account(FSharpList<consistency_policy> @consistencyPolicy,
                                        string @location,
                                        string @name,
                                        string @offerType,
                                        string @resourceGroupName,
                                        FSharpOption<FSharpList<capabilities>> @capabilities = null,
                                        FSharpOption<bool> @enableAutomaticFailover = null,
                                        FSharpOption<FSharpList<failover_policy>> @failoverPolicy = null,
                                        FSharpOption<FSharpList<geo_location>> @geoLocation = null,
                                        FSharpOption<string> @ipRangeFilter = null,
                                        FSharpOption<string> @kind = null)
        {
            @ConsistencyPolicy = @consistencyPolicy;
            @Location = @location;
            @Name = @name;
            @OfferType = @offerType;
            @ResourceGroupName = @resourceGroupName;
            @Capabilities = @capabilities ?? FSharpList<capabilities>.Empty;
            @EnableAutomaticFailover = @enableAutomaticFailover;
            @FailoverPolicy = @failoverPolicy ?? FSharpList<failover_policy>.Empty;
            @GeoLocation = @geoLocation ?? FSharpList<geo_location>.Empty;
            @IpRangeFilter = @ipRangeFilter;
            @Kind = @kind;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "consistency_policy", @out: false, min: 1, max: 1)]
        public FSharpList<consistency_policy> @ConsistencyPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "offer_type", @out: false, min: 1, max: 1)]
        public string @OfferType { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "capabilities", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<capabilities>> @Capabilities { get; }

        [nterraform.Core.TerraformProperty(name: "connection_strings", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @ConnectionStrings { get; }

        [nterraform.Core.TerraformProperty(name: "enable_automatic_failover", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableAutomaticFailover { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "failover_policy", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<failover_policy>> @FailoverPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "geo_location", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<geo_location>> @GeoLocation { get; }

        [nterraform.Core.TerraformProperty(name: "ip_range_filter", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @IpRangeFilter { get; }

        [nterraform.Core.TerraformProperty(name: "kind", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Kind { get; }

        [nterraform.Core.TerraformProperty(name: "primary_master_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "primary_readonly_master_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryReadonlyMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "read_endpoints", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @ReadEndpoints { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_master_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_readonly_master_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryReadonlyMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "write_endpoints", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @WriteEndpoints { get; }
    }

}
