using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_cosmosdb_account : NTerraform.data
    {
        public class geo_location
        {
            public geo_location()
            {
            }

            public int? @FailoverPriority { get; }
            public string @Id { get; }
            public string @Location { get; }
        }

        public class capabilities
        {
            public capabilities()
            {
            }

            public string @Name { get; }
        }

        public class consistency_policy
        {
            public consistency_policy()
            {
            }

            public string @ConsistencyLevel { get; }
            public int? @MaxIntervalInSeconds { get; }
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
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public capabilities[] @Capabilities { get; }
        public consistency_policy[] @ConsistencyPolicy { get; }
        public bool? @EnableAutomaticFailover { get; }
        public string @Endpoint { get; }
        public geo_location[] @GeoLocation { get; }
        public string @IpRangeFilter { get; }
        public string @Kind { get; }
        public string @Location { get; }
        public string @OfferType { get; }
        public string @PrimaryMasterKey { get; }
        public string @PrimaryReadonlyMasterKey { get; }
        public string[] @ReadEndpoints { get; }
        public string @SecondaryMasterKey { get; }
        public string @SecondaryReadonlyMasterKey { get; }
        public Dictionary<string,string> @Tags { get; }
        public string[] @WriteEndpoints { get; }
    }

}
