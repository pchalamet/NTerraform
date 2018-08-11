using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_autoscale_setting")]
    public sealed class azurerm_autoscale_setting : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "profile")]
        public sealed class profile: NTerraform.structure
        {
            [TerraformStructure(category: "", typeName: "fixed_date")]
            public sealed class fixed_date: NTerraform.structure
            {
                public fixed_date(string @end,
                                  string @start,
                                  string @timezone = null)
                {
                    @End = @end;
                    @Start = @start;
                    @Timezone = @timezone;
                    base._validate_();
                }

                [TerraformProperty(name: "end", @out: false, min: 1, max: 1)]
                public string @End { get; }

                [TerraformProperty(name: "start", @out: false, min: 1, max: 1)]
                public string @Start { get; }

                [TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
                public string @Timezone { get; }
            }

            [TerraformStructure(category: "", typeName: "recurrence")]
            public sealed class recurrence: NTerraform.structure
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
                    base._validate_();
                }

                [TerraformProperty(name: "days", @out: false, min: 1, max: 1)]
                public string[] @Days { get; }

                [TerraformProperty(name: "hours", @out: false, min: 1, max: 1)]
                public int[] @Hours { get; }

                [TerraformProperty(name: "minutes", @out: false, min: 1, max: 1)]
                public int[] @Minutes { get; }

                [TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
                public string @Timezone { get; }
            }

            [TerraformStructure(category: "", typeName: "capacity")]
            public sealed class capacity: NTerraform.structure
            {
                public capacity(int @default,
                                int @maximum,
                                int @minimum)
                {
                    @Default = @default;
                    @Maximum = @maximum;
                    @Minimum = @minimum;
                    base._validate_();
                }

                [TerraformProperty(name: "default", @out: false, min: 1, max: 1)]
                public int @Default { get; }

                [TerraformProperty(name: "maximum", @out: false, min: 1, max: 1)]
                public int @Maximum { get; }

                [TerraformProperty(name: "minimum", @out: false, min: 1, max: 1)]
                public int @Minimum { get; }
            }

            [TerraformStructure(category: "", typeName: "rule")]
            public sealed class rule: NTerraform.structure
            {
                [TerraformStructure(category: "", typeName: "scale_action")]
                public sealed class scale_action: NTerraform.structure
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
                        base._validate_();
                    }

                    [TerraformProperty(name: "cooldown", @out: false, min: 1, max: 1)]
                    public string @Cooldown { get; }

                    [TerraformProperty(name: "direction", @out: false, min: 1, max: 1)]
                    public string @Direction { get; }

                    [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                    public int @Value { get; }
                }

                [TerraformStructure(category: "", typeName: "metric_trigger")]
                public sealed class metric_trigger: NTerraform.structure
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
                        base._validate_();
                    }

                    [TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
                    public string @MetricName { get; }

                    [TerraformProperty(name: "metric_resource_id", @out: false, min: 1, max: 1)]
                    public string @MetricResourceId { get; }

                    [TerraformProperty(name: "operator", @out: false, min: 1, max: 1)]
                    public string @Operator { get; }

                    [TerraformProperty(name: "statistic", @out: false, min: 1, max: 1)]
                    public string @Statistic { get; }

                    [TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
                    public int @Threshold { get; }

                    [TerraformProperty(name: "time_aggregation", @out: false, min: 1, max: 1)]
                    public string @TimeAggregation { get; }

                    [TerraformProperty(name: "time_grain", @out: false, min: 1, max: 1)]
                    public string @TimeGrain { get; }

                    [TerraformProperty(name: "time_window", @out: false, min: 1, max: 1)]
                    public string @TimeWindow { get; }
                }

                public rule(metric_trigger[] @metricTrigger,
                            scale_action[] @scaleAction)
                {
                    @MetricTrigger = @metricTrigger;
                    @ScaleAction = @scaleAction;
                    base._validate_();
                }

                [TerraformProperty(name: "metric_trigger", @out: false, min: 1, max: 1)]
                public metric_trigger[] @MetricTrigger { get; }

                [TerraformProperty(name: "scale_action", @out: false, min: 1, max: 1)]
                public scale_action[] @ScaleAction { get; }
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
                base._validate_();
            }

            [TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public capacity[] @Capacity { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "fixed_date", @out: false, min: 0, max: 1)]
            public fixed_date[] @FixedDate { get; }

            [TerraformProperty(name: "recurrence", @out: false, min: 0, max: 1)]
            public recurrence[] @Recurrence { get; }

            [TerraformProperty(name: "rule", @out: false, min: 0, max: 10)]
            public rule[] @Rule { get; }
        }

        [TerraformStructure(category: "", typeName: "notification")]
        public sealed class notification: NTerraform.structure
        {
            [TerraformStructure(category: "", typeName: "email")]
            public sealed class email: NTerraform.structure
            {
                public email(string[] @customEmails = null,
                             bool? @sendToSubscriptionAdministrator = null,
                             bool? @sendToSubscriptionCoAdministrator = null)
                {
                    @CustomEmails = @customEmails;
                    @SendToSubscriptionAdministrator = @sendToSubscriptionAdministrator;
                    @SendToSubscriptionCoAdministrator = @sendToSubscriptionCoAdministrator;
                    base._validate_();
                }

                [TerraformProperty(name: "custom_emails", @out: false, min: 0, max: 1)]
                public string[] @CustomEmails { get; }

                [TerraformProperty(name: "send_to_subscription_administrator", @out: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionAdministrator { get; }

                [TerraformProperty(name: "send_to_subscription_co_administrator", @out: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionCoAdministrator { get; }
            }

            [TerraformStructure(category: "", typeName: "webhook")]
            public sealed class webhook: NTerraform.structure
            {
                public webhook(string @serviceUri,
                               Dictionary<string,string> @properties = null)
                {
                    @ServiceUri = @serviceUri;
                    @Properties = @properties;
                    base._validate_();
                }

                [TerraformProperty(name: "service_uri", @out: false, min: 1, max: 1)]
                public string @ServiceUri { get; }

                [TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Properties { get; }
            }

            public notification(email[] @email = null,
                                webhook[] @webhook = null)
            {
                @Email = @email;
                @Webhook = @webhook;
                base._validate_();
            }

            [TerraformProperty(name: "email", @out: false, min: 0, max: 1)]
            public email[] @Email { get; }

            [TerraformProperty(name: "webhook", @out: false, min: 0, max: 0)]
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
            base._validate_();
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "profile", @out: false, min: 1, max: 20)]
        public profile[] @Profile { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "target_resource_id", @out: false, min: 1, max: 1)]
        public string @TargetResourceId { get; }

        [TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "notification", @out: false, min: 0, max: 1)]
        public notification[] @Notification { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
