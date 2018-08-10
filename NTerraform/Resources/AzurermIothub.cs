using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_iothub : NTerraform.resource
    {
        public class sku
        {
            public sku(int @capacity,
                       string @name,
                       string @tier)
            {
                @Capacity = @capacity;
                @Name = @name;
                @Tier = @tier;
            }

            public int @Capacity { get; }
            public string @Name { get; }
            public string @Tier { get; }
        }

        public class shared_access_policy
        {
            public shared_access_policy()
            {
            }

            public string @KeyName { get; }
            public string @Permissions { get; }
            public string @PrimaryKey { get; }
            public string @SecondaryKey { get; }
        }

        public azurerm_iothub(string @location,
                              string @name,
                              string @resourceGroupName,
                              List<sku> @sku,
                              List<shared_access_policy> @sharedAccessPolicy = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @SharedAccessPolicy = @sharedAccessPolicy;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public List<sku> @Sku { get; }
        public string @Hostname { get; }
        public List<shared_access_policy> @SharedAccessPolicy { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Type { get; }
    }

}
