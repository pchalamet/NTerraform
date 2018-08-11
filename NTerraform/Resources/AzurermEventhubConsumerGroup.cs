using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @EventhubName { get; }
        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public string @Location { get; }
        public string @UserMetadata { get; }
    }

}
