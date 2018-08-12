using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_iothub")]
    public sealed class azurerm_iothub : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "shared_access_policy")]
        public sealed class shared_access_policy : nterraform.Core.structure
        {
            public shared_access_policy()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
            public string @KeyName { get; }

            [nterraform.Core.TerraformProperty(name: "permissions", @out: true, min: 0, max: 1)]
            public string @Permissions { get; }

            [nterraform.Core.TerraformProperty(name: "primary_key", @out: true, min: 0, max: 1)]
            public string @PrimaryKey { get; }

            [nterraform.Core.TerraformProperty(name: "secondary_key", @out: true, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "hostname", @out: true, min: 0, max: 1)]
        public string @Hostname { get; }

        [nterraform.Core.TerraformProperty(name: "shared_access_policy", @out: false, min: 0, max: 0)]
        public shared_access_policy[] @SharedAccessPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
