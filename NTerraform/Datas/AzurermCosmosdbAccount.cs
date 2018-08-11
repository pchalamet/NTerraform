using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_cosmosdb_account")]
    public sealed class azurerm_cosmosdb_account : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "consistency_policy")]
        public sealed class consistency_policy
        {
            public consistency_policy()
            {
            }

            [TerraformProperty(name: "consistency_level", @out: true, nested: false, min: 0, max: 1)]
            public string @ConsistencyLevel { get; }

            [TerraformProperty(name: "max_interval_in_seconds", @out: true, nested: false, min: 0, max: 1)]
            public int? @MaxIntervalInSeconds { get; }

            [TerraformProperty(name: "max_staleness_prefix", @out: true, nested: false, min: 0, max: 1)]
            public int? @MaxStalenessPrefix { get; }
        }

        [TerraformStructure(category: "", typeName: "capabilities")]
        public sealed class capabilities
        {
            public capabilities()
            {
            }

            [TerraformProperty(name: "name", @out: true, nested: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [TerraformStructure(category: "", typeName: "geo_location")]
        public sealed class geo_location
        {
            public geo_location()
            {
            }

            [TerraformProperty(name: "failover_priority", @out: true, nested: false, min: 0, max: 1)]
            public int? @FailoverPriority { get; }

            [TerraformProperty(name: "id", @out: true, nested: false, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "location", @out: true, nested: false, min: 0, max: 1)]
            public string @Location { get; }
        }

        public azurerm_cosmosdb_account(string @name,
                                        string @resourceGroupName,
                                        capabilities[] @capabilities = null,
                                        consistency_policy[] @consistencyPolicy = null,
                                        geo_location[] @geoLocation = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Capabilities = @capabilities;
            @ConsistencyPolicy = @consistencyPolicy;
            @GeoLocation = @geoLocation;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "capabilities", @out: false, nested: true, min: 0, max: 0)]
        public capabilities[] @Capabilities { get; }

        [TerraformProperty(name: "consistency_policy", @out: false, nested: true, min: 0, max: 0)]
        public consistency_policy[] @ConsistencyPolicy { get; }

        [TerraformProperty(name: "enable_automatic_failover", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnableAutomaticFailover { get; }

        [TerraformProperty(name: "endpoint", @out: true, nested: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [TerraformProperty(name: "geo_location", @out: false, nested: true, min: 0, max: 0)]
        public geo_location[] @GeoLocation { get; }

        [TerraformProperty(name: "ip_range_filter", @out: true, nested: true, min: 0, max: 1)]
        public string @IpRangeFilter { get; }

        [TerraformProperty(name: "kind", @out: true, nested: true, min: 0, max: 1)]
        public string @Kind { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "offer_type", @out: true, nested: true, min: 0, max: 1)]
        public string @OfferType { get; }

        [TerraformProperty(name: "primary_master_key", @out: true, nested: true, min: 0, max: 1)]
        public string @PrimaryMasterKey { get; }

        [TerraformProperty(name: "primary_readonly_master_key", @out: true, nested: true, min: 0, max: 1)]
        public string @PrimaryReadonlyMasterKey { get; }

        [TerraformProperty(name: "read_endpoints", @out: true, nested: true, min: 0, max: 1)]
        public string[] @ReadEndpoints { get; }

        [TerraformProperty(name: "secondary_master_key", @out: true, nested: true, min: 0, max: 1)]
        public string @SecondaryMasterKey { get; }

        [TerraformProperty(name: "secondary_readonly_master_key", @out: true, nested: true, min: 0, max: 1)]
        public string @SecondaryReadonlyMasterKey { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "write_endpoints", @out: true, nested: true, min: 0, max: 1)]
        public string[] @WriteEndpoints { get; }
    }

}
