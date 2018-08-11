using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_servicebus_queue_authorization_rule")]
    public sealed class azurerm_servicebus_queue_authorization_rule : NTerraform.resource
    {
        public azurerm_servicebus_queue_authorization_rule(string @name,
                                                           string @namespaceName,
                                                           string @queueName,
                                                           string @resourceGroupName,
                                                           bool? @listen = null,
                                                           bool? @manage = null,
                                                           bool? @send = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @QueueName = @queueName;
            @ResourceGroupName = @resourceGroupName;
            @Listen = @listen;
            @Manage = @manage;
            @Send = @send;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, nested: true, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "queue_name", @out: false, nested: true, min: 1, max: 1)]
        public string @QueueName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "listen", @out: false, nested: true, min: 0, max: 1)]
        public bool? @Listen { get; }

        [TerraformProperty(name: "manage", @out: false, nested: true, min: 0, max: 1)]
        public bool? @Manage { get; }

        [TerraformProperty(name: "primary_connection_string", @out: true, nested: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [TerraformProperty(name: "primary_key", @out: true, nested: true, min: 0, max: 1)]
        public string @PrimaryKey { get; }

        [TerraformProperty(name: "secondary_connection_string", @out: true, nested: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [TerraformProperty(name: "secondary_key", @out: true, nested: true, min: 0, max: 1)]
        public string @SecondaryKey { get; }

        [TerraformProperty(name: "send", @out: false, nested: true, min: 0, max: 1)]
        public bool? @Send { get; }
    }

}
