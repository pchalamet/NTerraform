using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_eventhub_authorization_rule")]
    public sealed class azurerm_eventhub_authorization_rule : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "listen", @out: false, min: 0, max: 1)]
        public bool? @Listen { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "manage", @out: false, min: 0, max: 1)]
        public bool? @Manage { get; }

        [nterraform.Core.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "primary_key", @out: true, min: 0, max: 1)]
        public string @PrimaryKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_key", @out: true, min: 0, max: 1)]
        public string @SecondaryKey { get; }

        [nterraform.Core.TerraformProperty(name: "send", @out: false, min: 0, max: 1)]
        public bool? @Send { get; }
    }

}
