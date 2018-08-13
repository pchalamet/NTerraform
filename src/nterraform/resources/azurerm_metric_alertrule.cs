using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_metric_alertrule")]
    public sealed class azurerm_metric_alertrule : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "email_action")]
        public sealed class email_action : nterraform.structure
        {
            public email_action()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "custom_emails", @out: true, min: 0, max: 1)]
            public string[] @CustomEmails { get; }

            [nterraform.TerraformProperty(name: "send_to_service_owners", @out: true, min: 0, max: 1)]
            public bool? @SendToServiceOwners { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "webhook_action")]
        public sealed class webhook_action : nterraform.structure
        {
            public webhook_action(string @serviceUri)
            {
                @ServiceUri = @serviceUri;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "service_uri", @out: false, min: 1, max: 1)]
            public string @ServiceUri { get; }

            [nterraform.TerraformProperty(name: "properties", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @Properties { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "aggregation", @out: false, min: 1, max: 1)]
        public string @Aggregation { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "operator", @out: false, min: 1, max: 1)]
        public string @Operator { get; }

        [nterraform.TerraformProperty(name: "period", @out: false, min: 1, max: 1)]
        public string @Period { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
        public int @Threshold { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "email_action", @out: false, min: 0, max: 1)]
        public email_action[] @EmailAction { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "webhook_action", @out: false, min: 0, max: 1)]
        public webhook_action[] @WebhookAction { get; }
    }

}
