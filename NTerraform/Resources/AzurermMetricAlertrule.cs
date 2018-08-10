using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_metric_alertrule : NTerraform.resource
    {
        public class webhook_action
        {
            public webhook_action(string @serviceUri)
            {
                @ServiceUri = @serviceUri;
            }

            public string @ServiceUri { get; }
            public Dictionary<string,string> @Properties { get; }
        }

        public class email_action
        {
            public email_action()
            {
            }

            public List<string> @CustomEmails { get; }
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
                                        List<email_action> @emailAction = null,
                                        bool? @enabled = null,
                                        List<webhook_action> @webhookAction = null)
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

        public string @Aggregation { get; }
        public string @Location { get; }
        public string @MetricName { get; }
        public string @Name { get; }
        public string @Operator { get; }
        public string @Period { get; }
        public string @ResourceGroupName { get; }
        public string @ResourceId { get; }
        public int @Threshold { get; }
        public string @Description { get; }
        public List<email_action> @EmailAction { get; }
        public bool? @Enabled { get; }
        public Dictionary<string,string> @Tags { get; }
        public List<webhook_action> @WebhookAction { get; }
    }

}
