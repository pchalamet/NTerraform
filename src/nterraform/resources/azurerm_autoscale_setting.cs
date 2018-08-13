using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_autoscale_setting")]
    public sealed class azurerm_autoscale_setting : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "profile")]
        public sealed class profile : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "capacity")]
            public sealed class capacity : nterraform.structure
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

                [nterraform.TerraformProperty(name: "default", @out: false, min: 1, max: 1)]
                public int @Default { get; }

                [nterraform.TerraformProperty(name: "maximum", @out: false, min: 1, max: 1)]
                public int @Maximum { get; }

                [nterraform.TerraformProperty(name: "minimum", @out: false, min: 1, max: 1)]
                public int @Minimum { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "rule")]
            public sealed class rule : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "metric_trigger")]
                public sealed class metric_trigger : nterraform.structure
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

                    [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
                    public string @MetricName { get; }

                    [nterraform.TerraformProperty(name: "metric_resource_id", @out: false, min: 1, max: 1)]
                    public string @MetricResourceId { get; }

                    [nterraform.TerraformProperty(name: "operator", @out: false, min: 1, max: 1)]
                    public string @Operator { get; }

                    [nterraform.TerraformProperty(name: "statistic", @out: false, min: 1, max: 1)]
                    public string @Statistic { get; }

                    [nterraform.TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
                    public int @Threshold { get; }

                    [nterraform.TerraformProperty(name: "time_aggregation", @out: false, min: 1, max: 1)]
                    public string @TimeAggregation { get; }

                    [nterraform.TerraformProperty(name: "time_grain", @out: false, min: 1, max: 1)]
                    public string @TimeGrain { get; }

                    [nterraform.TerraformProperty(name: "time_window", @out: false, min: 1, max: 1)]
                    public string @TimeWindow { get; }
                }

                [nterraform.TerraformStructure(category: "resource", typeName: "scale_action")]
                public sealed class scale_action : nterraform.structure
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

                    [nterraform.TerraformProperty(name: "cooldown", @out: false, min: 1, max: 1)]
                    public string @Cooldown { get; }

                    [nterraform.TerraformProperty(name: "direction", @out: false, min: 1, max: 1)]
                    public string @Direction { get; }

                    [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                    public int @Value { get; }
                }

                public rule(metric_trigger[] @metricTrigger,
                            scale_action[] @scaleAction)
                {
                    @MetricTrigger = @metricTrigger;
                    @ScaleAction = @scaleAction;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "metric_trigger", @out: false, min: 1, max: 1)]
                public metric_trigger[] @MetricTrigger { get; }

                [nterraform.TerraformProperty(name: "scale_action", @out: false, min: 1, max: 1)]
                public scale_action[] @ScaleAction { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "fixed_date")]
            public sealed class fixed_date : nterraform.structure
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

                [nterraform.TerraformProperty(name: "end", @out: false, min: 1, max: 1)]
                public string @End { get; }

                [nterraform.TerraformProperty(name: "start", @out: false, min: 1, max: 1)]
                public string @Start { get; }

                [nterraform.TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
                public string @Timezone { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "recurrence")]
            public sealed class recurrence : nterraform.structure
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

                [nterraform.TerraformProperty(name: "days", @out: false, min: 1, max: 1)]
                public string[] @Days { get; }

                [nterraform.TerraformProperty(name: "hours", @out: false, min: 1, max: 1)]
                public int[] @Hours { get; }

                [nterraform.TerraformProperty(name: "minutes", @out: false, min: 1, max: 1)]
                public int[] @Minutes { get; }

                [nterraform.TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
                public string @Timezone { get; }
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

            [nterraform.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public capacity[] @Capacity { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "fixed_date", @out: false, min: 0, max: 1)]
            public fixed_date[] @FixedDate { get; }

            [nterraform.TerraformProperty(name: "recurrence", @out: false, min: 0, max: 1)]
            public recurrence[] @Recurrence { get; }

            [nterraform.TerraformProperty(name: "rule", @out: false, min: 0, max: 10)]
            public rule[] @Rule { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "notification")]
        public sealed class notification : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "email")]
            public sealed class email : nterraform.structure
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

                [nterraform.TerraformProperty(name: "custom_emails", @out: false, min: 0, max: 1)]
                public string[] @CustomEmails { get; }

                [nterraform.TerraformProperty(name: "send_to_subscription_administrator", @out: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionAdministrator { get; }

                [nterraform.TerraformProperty(name: "send_to_subscription_co_administrator", @out: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionCoAdministrator { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "webhook")]
            public sealed class webhook : nterraform.structure
            {
                public webhook(string @serviceUri,
                               Dictionary<string,string> @properties = null)
                {
                    @ServiceUri = @serviceUri;
                    @Properties = @properties;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "service_uri", @out: false, min: 1, max: 1)]
                public string @ServiceUri { get; }

                [nterraform.TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Properties { get; }
            }

            public notification(email[] @email = null,
                                webhook[] @webhook = null)
            {
                @Email = @email;
                @Webhook = @webhook;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "email", @out: false, min: 0, max: 1)]
            public email[] @Email { get; }

            [nterraform.TerraformProperty(name: "webhook", @out: false, min: 0, max: 0)]
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

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "profile", @out: false, min: 1, max: 20)]
        public profile[] @Profile { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "target_resource_id", @out: false, min: 1, max: 1)]
        public string @TargetResourceId { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "notification", @out: false, min: 0, max: 1)]
        public notification[] @Notification { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
