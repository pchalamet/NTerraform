using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_servicebus_topic_authorization_rule : NTerraform.resource
    {
        public azurerm_servicebus_topic_authorization_rule(string @name,
                                                           string @namespaceName,
                                                           string @resourceGroupName,
                                                           string @topicName,
                                                           bool? @listen = null,
                                                           bool? @manage = null,
                                                           bool? @send = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @TopicName = @topicName;
            @Listen = @listen;
            @Manage = @manage;
            @Send = @send;
        }

        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public string @TopicName { get; }
        public bool? @Listen { get; }
        public bool? @Manage { get; }
        public string @PrimaryConnectionString { get; }
        public string @PrimaryKey { get; }
        public string @SecondaryConnectionString { get; }
        public string @SecondaryKey { get; }
        public bool? @Send { get; }
    }

}
