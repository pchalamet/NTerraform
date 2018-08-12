using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_eventhub_consumer_group")]
    public sealed class azurerm_eventhub_consumer_group : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "eventhub_name", @out: false, min: 1, max: 1)]
        public string @EventhubName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "user_metadata", @out: false, min: 0, max: 1)]
        public string @UserMetadata { get; }
    }

}
