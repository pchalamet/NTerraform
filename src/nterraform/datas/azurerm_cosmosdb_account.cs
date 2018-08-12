using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_cosmosdb_account")]
    public sealed class azurerm_cosmosdb_account : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "geo_location")]
        public sealed class geo_location : nterraform.Core.structure
        {
            public geo_location()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "failover_priority", @out: true, min: 0, max: 1)]
            public int? @FailoverPriority { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
            public string @Location { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "capabilities")]
        public sealed class capabilities : nterraform.Core.structure
        {
            public capabilities()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "consistency_policy")]
        public sealed class consistency_policy : nterraform.Core.structure
        {
            public consistency_policy()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "consistency_level", @out: true, min: 0, max: 1)]
            public string @ConsistencyLevel { get; }

            [nterraform.Core.TerraformProperty(name: "max_interval_in_seconds", @out: true, min: 0, max: 1)]
            public int? @MaxIntervalInSeconds { get; }

            [nterraform.Core.TerraformProperty(name: "max_staleness_prefix", @out: true, min: 0, max: 1)]
            public int? @MaxStalenessPrefix { get; }
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "capabilities", @out: false, min: 0, max: 0)]
        public capabilities[] @Capabilities { get; }

        [nterraform.Core.TerraformProperty(name: "consistency_policy", @out: false, min: 0, max: 0)]
        public consistency_policy[] @ConsistencyPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "enable_automatic_failover", @out: true, min: 0, max: 1)]
        public bool? @EnableAutomaticFailover { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "geo_location", @out: false, min: 0, max: 0)]
        public geo_location[] @GeoLocation { get; }

        [nterraform.Core.TerraformProperty(name: "ip_range_filter", @out: true, min: 0, max: 1)]
        public string @IpRangeFilter { get; }

        [nterraform.Core.TerraformProperty(name: "kind", @out: true, min: 0, max: 1)]
        public string @Kind { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "offer_type", @out: true, min: 0, max: 1)]
        public string @OfferType { get; }

        [nterraform.Core.TerraformProperty(name: "primary_master_key", @out: true, min: 0, max: 1)]
        public string @PrimaryMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "primary_readonly_master_key", @out: true, min: 0, max: 1)]
        public string @PrimaryReadonlyMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "read_endpoints", @out: true, min: 0, max: 1)]
        public string[] @ReadEndpoints { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_master_key", @out: true, min: 0, max: 1)]
        public string @SecondaryMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_readonly_master_key", @out: true, min: 0, max: 1)]
        public string @SecondaryReadonlyMasterKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "write_endpoints", @out: true, min: 0, max: 1)]
        public string[] @WriteEndpoints { get; }
    }

}
