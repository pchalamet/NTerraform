using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_topic_authorization_rule")]
    public sealed class azurerm_servicebus_topic_authorization_rule : nterraform.Core.resource
    {
        public azurerm_servicebus_topic_authorization_rule(string @name,
                                                           string @namespaceName,
                                                           string @resourceGroupName,
                                                           string @topicName,
                                                           FSharpOption<bool> @listen = null,
                                                           FSharpOption<bool> @manage = null,
                                                           FSharpOption<bool> @send = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @TopicName = @topicName;
            @Listen = @listen;
            @Manage = @manage;
            @Send = @send;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "topic_name", @out: false, min: 1, max: 1)]
        public string @TopicName { get; }

        [nterraform.Core.TerraformProperty(name: "listen", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Listen { get; }

        [nterraform.Core.TerraformProperty(name: "manage", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Manage { get; }

        [nterraform.Core.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "primary_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryKey { get; }

        [nterraform.Core.TerraformProperty(name: "send", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Send { get; }
    }

}
