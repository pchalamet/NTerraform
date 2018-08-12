using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_notification_hub_authorization_rule")]
    public sealed class azurerm_notification_hub_authorization_rule : nterraform.Core.resource
    {
        public azurerm_notification_hub_authorization_rule(string @name,
                                                           string @namespaceName,
                                                           string @notificationHubName,
                                                           string @resourceGroupName,
                                                           FSharpOption<bool> @listen = null,
                                                           FSharpOption<bool> @manage = null,
                                                           FSharpOption<bool> @send = null)
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "notification_hub_name", @out: false, min: 1, max: 1)]
        public string @NotificationHubName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "listen", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Listen { get; }

        [nterraform.Core.TerraformProperty(name: "manage", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Manage { get; }

        [nterraform.Core.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "send", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Send { get; }
    }

}
