using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_metric_alertrule")]
    public sealed class azurerm_metric_alertrule : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "webhook_action")]
        public sealed class webhook_action
        {
            public webhook_action(string @serviceUri)
            {
                @ServiceUri = @serviceUri;
            }

            [TerraformProperty(name: "service_uri", @out: false, nested: false, min: 1, max: 1)]
            public string @ServiceUri { get; }

            [TerraformProperty(name: "properties", @out: true, nested: false, min: 0, max: 1)]
            public Dictionary<string,string> @Properties { get; }
        }

        [TerraformStructure(category: "", typeName: "email_action")]
        public sealed class email_action
        {
            public email_action()
            {
            }

            [TerraformProperty(name: "custom_emails", @out: true, nested: false, min: 0, max: 1)]
            public string[] @CustomEmails { get; }

            [TerraformProperty(name: "send_to_service_owners", @out: true, nested: false, min: 0, max: 1)]
            public bool? @SendToServiceOwners { get; }
        }

        public azurerm_metric_alertrule(string @aggregation,
                                        string @location,
                                        string @metricName,
                                        string @name,
                                        string @operator,
                                        string @period,
                                        string @resourceGroupName,
                                        string @resourceId,
                                        int @threshold,
                                        email_action[] @emailAction = null,
                                        bool? @enabled = null,
                                        webhook_action[] @webhookAction = null)
        {
            @Aggregation = @aggregation;
            @Location = @location;
            @MetricName = @metricName;
            @Name = @name;
            @Operator = @operator;
            @Period = @period;
            @ResourceGroupName = @resourceGroupName;
            @ResourceId = @resourceId;
            @Threshold = @threshold;
            @EmailAction = @emailAction;
            @Enabled = @enabled;
            @WebhookAction = @webhookAction;
        }

        [TerraformProperty(name: "aggregation", @out: false, nested: true, min: 1, max: 1)]
        public string @Aggregation { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "metric_name", @out: false, nested: true, min: 1, max: 1)]
        public string @MetricName { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "operator", @out: false, nested: true, min: 1, max: 1)]
        public string @Operator { get; }

        [TerraformProperty(name: "period", @out: false, nested: true, min: 1, max: 1)]
        public string @Period { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "resource_id", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceId { get; }

        [TerraformProperty(name: "threshold", @out: false, nested: true, min: 1, max: 1)]
        public int @Threshold { get; }

        [TerraformProperty(name: "description", @out: true, nested: true, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "email_action", @out: false, nested: true, min: 0, max: 1)]
        public email_action[] @EmailAction { get; }

        [TerraformProperty(name: "enabled", @out: false, nested: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "webhook_action", @out: false, nested: true, min: 0, max: 1)]
        public webhook_action[] @WebhookAction { get; }
    }

}
