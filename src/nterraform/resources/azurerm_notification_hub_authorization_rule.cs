using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_notification_hub_authorization_rule")]
    public sealed class azurerm_notification_hub_authorization_rule : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.TerraformProperty(name: "notification_hub_name", @out: false, min: 1, max: 1)]
        public string @NotificationHubName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "listen", @out: false, min: 0, max: 1)]
        public bool? @Listen { get; }

        [nterraform.TerraformProperty(name: "manage", @out: false, min: 0, max: 1)]
        public bool? @Manage { get; }

        [nterraform.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [nterraform.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [nterraform.TerraformProperty(name: "send", @out: false, min: 0, max: 1)]
        public bool? @Send { get; }
    }

}
