using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_eventhub_authorization_rule : NTerraform.resource
    {
        public azurerm_eventhub_authorization_rule(string @eventhubName,
                                                   string @name,
                                                   string @namespaceName,
                                                   string @resourceGroupName,
                                                   bool? @listen = null,
                                                   string @location = null,
                                                   bool? @manage = null,
                                                   bool? @send = null)
        {
            @EventhubName = @eventhubName;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @Listen = @listen;
            @Location = @location;
            @Manage = @manage;
            @Send = @send;
        }

        public string @EventhubName { get; }
        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public bool? @Listen { get; }
        public string @Location { get; }
        public bool? @Manage { get; }
        public string @PrimaryConnectionString { get; }
        public string @PrimaryKey { get; }
        public string @SecondaryConnectionString { get; }
        public string @SecondaryKey { get; }
        public bool? @Send { get; }
    }

}
