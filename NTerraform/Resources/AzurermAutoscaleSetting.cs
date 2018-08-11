using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_autoscale_setting")]
    public sealed class azurerm_autoscale_setting : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "profile")]
        public sealed class profile
        {
            [TerraformStructure(category: "", typeName: "rule")]
            public sealed class rule
            {
                [TerraformStructure(category: "", typeName: "metric_trigger")]
                public sealed class metric_trigger
                {
                    public metric_trigger(string @metricName,
                                          string @metricResourceId,
                                          string @operator,
                                          string @statistic,
                                          int @threshold,
                                          string @timeAggregation,
                                          string @timeGrain,
                                          string @timeWindow)
                    {
                        @MetricName = @metricName;
                        @MetricResourceId = @metricResourceId;
                        @Operator = @operator;
                        @Statistic = @statistic;
                        @Threshold = @threshold;
                        @TimeAggregation = @timeAggregation;
                        @TimeGrain = @timeGrain;
                        @TimeWindow = @timeWindow;
                    }

                    [TerraformProperty(name: "metric_name", @out: false, nested: false, min: 1, max: 1)]
                    public string @MetricName { get; }

                    [TerraformProperty(name: "metric_resource_id", @out: false, nested: false, min: 1, max: 1)]
                    public string @MetricResourceId { get; }

                    [TerraformProperty(name: "operator", @out: false, nested: false, min: 1, max: 1)]
                    public string @Operator { get; }

                    [TerraformProperty(name: "statistic", @out: false, nested: false, min: 1, max: 1)]
                    public string @Statistic { get; }

                    [TerraformProperty(name: "threshold", @out: false, nested: false, min: 1, max: 1)]
                    public int @Threshold { get; }

                    [TerraformProperty(name: "time_aggregation", @out: false, nested: false, min: 1, max: 1)]
                    public string @TimeAggregation { get; }

                    [TerraformProperty(name: "time_grain", @out: false, nested: false, min: 1, max: 1)]
                    public string @TimeGrain { get; }

                    [TerraformProperty(name: "time_window", @out: false, nested: false, min: 1, max: 1)]
                    public string @TimeWindow { get; }
                }

                [TerraformStructure(category: "", typeName: "scale_action")]
                public sealed class scale_action
                {
                    public scale_action(string @cooldown,
                                        string @direction,
                                        string @type,
                                        int @value)
                    {
                        @Cooldown = @cooldown;
                        @Direction = @direction;
                        @Type = @type;
                        @Value = @value;
                    }

                    [TerraformProperty(name: "cooldown", @out: false, nested: false, min: 1, max: 1)]
                    public string @Cooldown { get; }

                    [TerraformProperty(name: "direction", @out: false, nested: false, min: 1, max: 1)]
                    public string @Direction { get; }

                    [TerraformProperty(name: "type", @out: false, nested: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [TerraformProperty(name: "value", @out: false, nested: false, min: 1, max: 1)]
                    public int @Value { get; }
                }

                public rule(metric_trigger[] @metricTrigger,
                            scale_action[] @scaleAction)
                {
                    @MetricTrigger = @metricTrigger;
                    @ScaleAction = @scaleAction;
                }

                [TerraformProperty(name: "metric_trigger", @out: false, nested: false, min: 1, max: 1)]
                public metric_trigger[] @MetricTrigger { get; }

                [TerraformProperty(name: "scale_action", @out: false, nested: false, min: 1, max: 1)]
                public scale_action[] @ScaleAction { get; }
            }

            [TerraformStructure(category: "", typeName: "fixed_date")]
            public sealed class fixed_date
            {
                public fixed_date(string @end,
                                  string @start,
                                  string @timezone = null)
                {
                    @End = @end;
                    @Start = @start;
                    @Timezone = @timezone;
                }

                [TerraformProperty(name: "end", @out: false, nested: false, min: 1, max: 1)]
                public string @End { get; }

                [TerraformProperty(name: "start", @out: false, nested: false, min: 1, max: 1)]
                public string @Start { get; }

                [TerraformProperty(name: "timezone", @out: false, nested: false, min: 0, max: 1)]
                public string @Timezone { get; }
            }

            [TerraformStructure(category: "", typeName: "recurrence")]
            public sealed class recurrence
            {
                public recurrence(string[] @days,
                                  int[] @hours,
                                  int[] @minutes,
                                  string @timezone = null)
                {
                    @Days = @days;
                    @Hours = @hours;
                    @Minutes = @minutes;
                    @Timezone = @timezone;
                }

                [TerraformProperty(name: "days", @out: false, nested: false, min: 1, max: 1)]
                public string[] @Days { get; }

                [TerraformProperty(name: "hours", @out: false, nested: false, min: 1, max: 1)]
                public int[] @Hours { get; }

                [TerraformProperty(name: "minutes", @out: false, nested: false, min: 1, max: 1)]
                public int[] @Minutes { get; }

                [TerraformProperty(name: "timezone", @out: false, nested: false, min: 0, max: 1)]
                public string @Timezone { get; }
            }

            [TerraformStructure(category: "", typeName: "capacity")]
            public sealed class capacity
            {
                public capacity(int @default,
                                int @maximum,
                                int @minimum)
                {
                    @Default = @default;
                    @Maximum = @maximum;
                    @Minimum = @minimum;
                }

                [TerraformProperty(name: "default", @out: false, nested: false, min: 1, max: 1)]
                public int @Default { get; }

                [TerraformProperty(name: "maximum", @out: false, nested: false, min: 1, max: 1)]
                public int @Maximum { get; }

                [TerraformProperty(name: "minimum", @out: false, nested: false, min: 1, max: 1)]
                public int @Minimum { get; }
            }

            public profile(capacity[] @capacity,
                           string @name,
                           fixed_date[] @fixedDate = null,
                           recurrence[] @recurrence = null,
                           rule[] @rule = null)
            {
                @Capacity = @capacity;
                @Name = @name;
                @FixedDate = @fixedDate;
                @Recurrence = @recurrence;
                @Rule = @rule;
            }

            [TerraformProperty(name: "capacity", @out: false, nested: false, min: 1, max: 1)]
            public capacity[] @Capacity { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "fixed_date", @out: false, nested: false, min: 0, max: 1)]
            public fixed_date[] @FixedDate { get; }

            [TerraformProperty(name: "recurrence", @out: false, nested: false, min: 0, max: 1)]
            public recurrence[] @Recurrence { get; }

            [TerraformProperty(name: "rule", @out: false, nested: false, min: 0, max: 10)]
            public rule[] @Rule { get; }
        }

        [TerraformStructure(category: "", typeName: "notification")]
        public sealed class notification
        {
            [TerraformStructure(category: "", typeName: "webhook")]
            public sealed class webhook
            {
                public webhook(string @serviceUri,
                               Dictionary<string,string> @properties = null)
                {
                    @ServiceUri = @serviceUri;
                    @Properties = @properties;
                }

                [TerraformProperty(name: "service_uri", @out: false, nested: false, min: 1, max: 1)]
                public string @ServiceUri { get; }

                [TerraformProperty(name: "properties", @out: false, nested: false, min: 0, max: 1)]
                public Dictionary<string,string> @Properties { get; }
            }

            [TerraformStructure(category: "", typeName: "email")]
            public sealed class email
            {
                public email(string[] @customEmails = null,
                             bool? @sendToSubscriptionAdministrator = null,
                             bool? @sendToSubscriptionCoAdministrator = null)
                {
                    @CustomEmails = @customEmails;
                    @SendToSubscriptionAdministrator = @sendToSubscriptionAdministrator;
                    @SendToSubscriptionCoAdministrator = @sendToSubscriptionCoAdministrator;
                }

                [TerraformProperty(name: "custom_emails", @out: false, nested: false, min: 0, max: 1)]
                public string[] @CustomEmails { get; }

                [TerraformProperty(name: "send_to_subscription_administrator", @out: false, nested: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionAdministrator { get; }

                [TerraformProperty(name: "send_to_subscription_co_administrator", @out: false, nested: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionCoAdministrator { get; }
            }

            public notification(email[] @email = null,
                                webhook[] @webhook = null)
            {
                @Email = @email;
                @Webhook = @webhook;
            }

            [TerraformProperty(name: "email", @out: false, nested: false, min: 0, max: 1)]
            public email[] @Email { get; }

            [TerraformProperty(name: "webhook", @out: false, nested: false, min: 0, max: 0)]
            public webhook[] @Webhook { get; }
        }

        public azurerm_autoscale_setting(string @location,
                                         string @name,
                                         profile[] @profile,
                                         string @resourceGroupName,
                                         string @targetResourceId,
                                         bool? @enabled = null,
                                         notification[] @notification = null)
        {
            @Location = @location;
            @Name = @name;
            @Profile = @profile;
            @ResourceGroupName = @resourceGroupName;
            @TargetResourceId = @targetResourceId;
            @Enabled = @enabled;
            @Notification = @notification;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "profile", @out: false, nested: true, min: 1, max: 20)]
        public profile[] @Profile { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "target_resource_id", @out: false, nested: true, min: 1, max: 1)]
        public string @TargetResourceId { get; }

        [TerraformProperty(name: "enabled", @out: false, nested: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "notification", @out: false, nested: true, min: 0, max: 1)]
        public notification[] @Notification { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
