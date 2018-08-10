using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_cosmosdb_account : NTerraform.resource
    {
        public class geo_location
        {
            public geo_location(int @failoverPriority,
                                string @location,
                                string @prefix = null)
            {
                @FailoverPriority = @failoverPriority;
                @Location = @location;
                @Prefix = @prefix;
            }

            public int @FailoverPriority { get; }
            public string @Location { get; }
            public string @Id { get; }
            public string @Prefix { get; }
        }

        public class capabilities
        {
            public capabilities(string @name)
            {
                @Name = @name;
            }

            public string @Name { get; }
        }

        public class failover_policy
        {
            public failover_policy(string @location,
                                   int @priority)
            {
                @Location = @location;
                @Priority = @priority;
            }

            public string @Location { get; }
            public int @Priority { get; }
            public string @Id { get; }
        }

        public class consistency_policy
        {
            public consistency_policy(string @consistencyLevel,
                                      int? @maxIntervalInSeconds = null,
                                      int? @maxStalenessPrefix = null)
            {
                @ConsistencyLevel = @consistencyLevel;
                @MaxIntervalInSeconds = @maxIntervalInSeconds;
                @MaxStalenessPrefix = @maxStalenessPrefix;
            }

            public string @ConsistencyLevel { get; }
            public int? @MaxIntervalInSeconds { get; }
            public int? @MaxStalenessPrefix { get; }
        }

        public azurerm_cosmosdb_account(List<consistency_policy> @consistencyPolicy,
                                        string @location,
                                        string @name,
                                        string @offerType,
                                        string @resourceGroupName,
                                        HashSet<capabilities> @capabilities = null,
                                        bool? @enableAutomaticFailover = null,
                                        HashSet<failover_policy> @failoverPolicy = null,
                                        HashSet<geo_location> @geoLocation = null,
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
        }

        public List<consistency_policy> @ConsistencyPolicy { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @OfferType { get; }
        public string @ResourceGroupName { get; }
        public HashSet<capabilities> @Capabilities { get; }
        public List<string> @ConnectionStrings { get; }
        public bool? @EnableAutomaticFailover { get; }
        public string @Endpoint { get; }
        public HashSet<failover_policy> @FailoverPolicy { get; }
        public HashSet<geo_location> @GeoLocation { get; }
        public string @IpRangeFilter { get; }
        public string @Kind { get; }
        public string @PrimaryMasterKey { get; }
        public string @PrimaryReadonlyMasterKey { get; }
        public List<string> @ReadEndpoints { get; }
        public string @SecondaryMasterKey { get; }
        public string @SecondaryReadonlyMasterKey { get; }
        public Dictionary<string,string> @Tags { get; }
        public List<string> @WriteEndpoints { get; }
    }

}
