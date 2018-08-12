using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_metric_alertrule")]
    public sealed class azurerm_metric_alertrule : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "email_action")]
        public sealed class email_action : nterraform.Core.structure
        {
            public email_action()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "custom_emails", @out: true, min: 0, max: 1)]
            public FSharpList<string> @CustomEmails { get; }

            [nterraform.Core.TerraformProperty(name: "send_to_service_owners", @out: true, min: 0, max: 1)]
            public bool? @SendToServiceOwners { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "webhook_action")]
        public sealed class webhook_action : nterraform.Core.structure
        {
            public webhook_action(string @serviceUri)
            {
                @ServiceUri = @serviceUri;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "service_uri", @out: false, min: 1, max: 1)]
            public string @ServiceUri { get; }

            [nterraform.Core.TerraformProperty(name: "properties", @out: true, min: 0, max: 1)]
            public FSharpMap<string,string> @Properties { get; }
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
                                        FSharpList<email_action> @emailAction = null,
                                        bool? @enabled = null,
                                        FSharpList<webhook_action> @webhookAction = null)
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
            @EmailAction = @emailAction ?? FSharpList<email_action>.Empty;
            @Enabled = @enabled;
            @WebhookAction = @webhookAction ?? FSharpList<webhook_action>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "aggregation", @out: false, min: 1, max: 1)]
        public string @Aggregation { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "operator", @out: false, min: 1, max: 1)]
        public string @Operator { get; }

        [nterraform.Core.TerraformProperty(name: "period", @out: false, min: 1, max: 1)]
        public string @Period { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
        public int @Threshold { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "email_action", @out: false, min: 0, max: 1)]
        public FSharpList<email_action> @EmailAction { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "webhook_action", @out: false, min: 0, max: 1)]
        public FSharpList<webhook_action> @WebhookAction { get; }
    }

}
