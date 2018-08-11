using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @QueueName { get; }
        public string @ResourceGroupName { get; }
        public bool? @Listen { get; }
        public bool? @Manage { get; }
        public string @PrimaryConnectionString { get; }
        public string @PrimaryKey { get; }
        public string @SecondaryConnectionString { get; }
        public string @SecondaryKey { get; }
        public bool? @Send { get; }
    }

}
