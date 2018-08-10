using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_notification_hub_authorization_rule : NTerraform.resource
    {
        public azurerm_notification_hub_authorization_rule(string @name,
                                                           string @namespaceName,
                                                           string @notificationHubName,
                                                           string @resourceGroupName,
                                                           bool? @listen = null,
                                                           bool? @manage = null,
                                                           bool? @send = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @NotificationHubName = @notificationHubName;
            @ResourceGroupName = @resourceGroupName;
            @Listen = @listen;
            @Manage = @manage;
            @Send = @send;
        }

        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @NotificationHubName { get; }
        public string @ResourceGroupName { get; }
        public bool? @Listen { get; }
        public bool? @Manage { get; }
        public string @PrimaryAccessKey { get; }
        public string @SecondaryAccessKey { get; }
        public bool? @Send { get; }
    }

}
