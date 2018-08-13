using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_eventhub_consumer_group")]
    public sealed class azurerm_eventhub_consumer_group : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "eventhub_name", @out: false, min: 1, max: 1)]
        public string @EventhubName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "user_metadata", @out: false, min: 0, max: 1)]
        public string @UserMetadata { get; }
    }

}
