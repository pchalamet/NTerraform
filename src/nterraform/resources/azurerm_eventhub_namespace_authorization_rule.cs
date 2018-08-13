using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_eventhub_namespace_authorization_rule")]
    public sealed class azurerm_eventhub_namespace_authorization_rule : nterraform.resource
    {
        public azurerm_eventhub_namespace_authorization_rule(string @name,
                                                             string @namespaceName,
                                                             string @resourceGroupName,
                                                             bool? @listen = null,
                                                             string @location = null,
                                                             bool? @manage = null,
                                                             bool? @send = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @Listen = @listen;
            @Location = @location;
            @Manage = @manage;
            @Send = @send;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "listen", @out: false, min: 0, max: 1)]
        public bool? @Listen { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "manage", @out: false, min: 0, max: 1)]
        public bool? @Manage { get; }

        [nterraform.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "primary_key", @out: true, min: 0, max: 1)]
        public string @PrimaryKey { get; }

        [nterraform.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "secondary_key", @out: true, min: 0, max: 1)]
        public string @SecondaryKey { get; }

        [nterraform.TerraformProperty(name: "send", @out: false, min: 0, max: 1)]
        public bool? @Send { get; }
    }

}
