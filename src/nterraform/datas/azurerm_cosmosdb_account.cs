using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_cosmosdb_account")]
    public sealed class azurerm_cosmosdb_account : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "capabilities")]
        public sealed class capabilities : nterraform.structure
        {
            public capabilities()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "consistency_policy")]
        public sealed class consistency_policy : nterraform.structure
        {
            public consistency_policy()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "consistency_level", @out: true, min: 0, max: 1)]
            public string @ConsistencyLevel { get; }

            [nterraform.TerraformProperty(name: "max_interval_in_seconds", @out: true, min: 0, max: 1)]
            public int? @MaxIntervalInSeconds { get; }

            [nterraform.TerraformProperty(name: "max_staleness_prefix", @out: true, min: 0, max: 1)]
            public int? @MaxStalenessPrefix { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "geo_location")]
        public sealed class geo_location : nterraform.structure
        {
            public geo_location()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "failover_priority", @out: true, min: 0, max: 1)]
            public int? @FailoverPriority { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "capabilities", @out: false, min: 0, max: 0)]
        public capabilities[] @Capabilities { get; }

        [nterraform.TerraformProperty(name: "consistency_policy", @out: false, min: 0, max: 0)]
        public consistency_policy[] @ConsistencyPolicy { get; }

        [nterraform.TerraformProperty(name: "enable_automatic_failover", @out: true, min: 0, max: 1)]
        public bool? @EnableAutomaticFailover { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "geo_location", @out: false, min: 0, max: 0)]
        public geo_location[] @GeoLocation { get; }

        [nterraform.TerraformProperty(name: "ip_range_filter", @out: true, min: 0, max: 1)]
        public string @IpRangeFilter { get; }

        [nterraform.TerraformProperty(name: "kind", @out: true, min: 0, max: 1)]
        public string @Kind { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "offer_type", @out: true, min: 0, max: 1)]
        public string @OfferType { get; }

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
