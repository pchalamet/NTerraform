using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_iothub")]
    public sealed class azurerm_iothub : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "shared_access_policy")]
        public sealed class shared_access_policy
        {
            public shared_access_policy()
            {
            }

            [TerraformProperty(name: "key_name", @out: true, nested: false, min: 0, max: 1)]
            public string @KeyName { get; }

            [TerraformProperty(name: "permissions", @out: true, nested: false, min: 0, max: 1)]
            public string @Permissions { get; }

            [TerraformProperty(name: "primary_key", @out: true, nested: false, min: 0, max: 1)]
            public string @PrimaryKey { get; }

            [TerraformProperty(name: "secondary_key", @out: true, nested: false, min: 0, max: 1)]
            public string @SecondaryKey { get; }
        }

        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(int @capacity,
                       string @name,
                       string @tier)
            {
                @Capacity = @capacity;
                @Name = @name;
                @Tier = @tier;
            }

            [TerraformProperty(name: "capacity", @out: false, nested: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "tier", @out: false, nested: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        public azurerm_iothub(string @location,
                              string @name,
                              string @resourceGroupName,
                              sku[] @sku,
                              shared_access_policy[] @sharedAccessPolicy = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @SharedAccessPolicy = @sharedAccessPolicy;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "hostname", @out: true, nested: true, min: 0, max: 1)]
        public string @Hostname { get; }

        [TerraformProperty(name: "shared_access_policy", @out: false, nested: true, min: 0, max: 0)]
        public shared_access_policy[] @SharedAccessPolicy { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "type", @out: true, nested: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
