using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_iothub")]
    public sealed class azurerm_iothub : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.structure
        {
            public sku(int @capacity,
                       string @name,
                       string @tier)
            {
                @Capacity = @capacity;
                @Name = @name;
                @Tier = @tier;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "shared_access_policy")]
        public sealed class shared_access_policy : nterraform.structure
        {
            public shared_access_policy()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
            public string @KeyName { get; }

            [nterraform.TerraformProperty(name: "permissions", @out: true, min: 0, max: 1)]
            public string @Permissions { get; }

            [nterraform.TerraformProperty(name: "primary_key", @out: true, min: 0, max: 1)]
            public string @PrimaryKey { get; }

            [nterraform.TerraformProperty(name: "secondary_key", @out: true, min: 0, max: 1)]
            public string @SecondaryKey { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.TerraformProperty(name: "hostname", @out: true, min: 0, max: 1)]
        public string @Hostname { get; }

        [nterraform.TerraformProperty(name: "shared_access_policy", @out: false, min: 0, max: 0)]
        public shared_access_policy[] @SharedAccessPolicy { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
