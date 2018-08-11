using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_eventhub_consumer_group")]
    public sealed class azurerm_eventhub_consumer_group : NTerraform.resource
    {
        public azurerm_eventhub_consumer_group(string @eventhubName,
                                               string @name,
                                               string @namespaceName,
                                               string @resourceGroupName,
                                               string @location = null,
                                               string @userMetadata = null)
        {
            @EventhubName = @eventhubName;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @Location = @location;
            @UserMetadata = @userMetadata;
        }

        [TerraformProperty(name: "eventhub_name", @out: false, nested: true, min: 1, max: 1)]
        public string @EventhubName { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, nested: true, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "user_metadata", @out: false, nested: true, min: 0, max: 1)]
        public string @UserMetadata { get; }
    }

}
