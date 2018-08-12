using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_autoscale_setting")]
    public sealed class azurerm_autoscale_setting : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "notification")]
        public sealed class notification : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "webhook")]
            public sealed class webhook : nterraform.Core.structure
            {
                public webhook(string @serviceUri,
                               Dictionary<string,string> @properties = null)
                {
                    @ServiceUri = @serviceUri;
                    @Properties = @properties;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "service_uri", @out: false, min: 1, max: 1)]
                public string @ServiceUri { get; }

                [nterraform.Core.TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Properties { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "email")]
            public sealed class email : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "custom_emails", @out: false, min: 0, max: 1)]
                public string[] @CustomEmails { get; }

                [nterraform.Core.TerraformProperty(name: "send_to_subscription_administrator", @out: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionAdministrator { get; }

                [nterraform.Core.TerraformProperty(name: "send_to_subscription_co_administrator", @out: false, min: 0, max: 1)]
                public bool? @SendToSubscriptionCoAdministrator { get; }
            }

            public notification(email[] @email = null,
                                webhook[] @webhook = null)
            {
                @Email = @email;
                @Webhook = @webhook;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "email", @out: false, min: 0, max: 1)]
            public email[] @Email { get; }

            [nterraform.Core.TerraformProperty(name: "webhook", @out: false, min: 0, max: 0)]
            public webhook[] @Webhook { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "profile")]
        public sealed class profile : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "capacity")]
            public sealed class capacity : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "default", @out: false, min: 1, max: 1)]
                public int @Default { get; }

                [nterraform.Core.TerraformProperty(name: "maximum", @out: false, min: 1, max: 1)]
                public int @Maximum { get; }

                [nterraform.Core.TerraformProperty(name: "minimum", @out: false, min: 1, max: 1)]
                public int @Minimum { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "rule")]
            public sealed class rule : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "metric_trigger")]
                public sealed class metric_trigger : nterraform.Core.structure
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

                    [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
                    public string @MetricName { get; }

                    [nterraform.Core.TerraformProperty(name: "metric_resource_id", @out: false, min: 1, max: 1)]
                    public string @MetricResourceId { get; }

                    [nterraform.Core.TerraformProperty(name: "operator", @out: false, min: 1, max: 1)]
                    public string @Operator { get; }

                    [nterraform.Core.TerraformProperty(name: "statistic", @out: false, min: 1, max: 1)]
                    public string @Statistic { get; }

                    [nterraform.Core.TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
                    public int @Threshold { get; }

                    [nterraform.Core.TerraformProperty(name: "time_aggregation", @out: false, min: 1, max: 1)]
                    public string @TimeAggregation { get; }

                    [nterraform.Core.TerraformProperty(name: "time_grain", @out: false, min: 1, max: 1)]
                    public string @TimeGrain { get; }

                    [nterraform.Core.TerraformProperty(name: "time_window", @out: false, min: 1, max: 1)]
                    public string @TimeWindow { get; }
                }

                [nterraform.Core.TerraformStructure(category: "resource", typeName: "scale_action")]
                public sealed class scale_action : nterraform.Core.structure
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

                    [nterraform.Core.TerraformProperty(name: "cooldown", @out: false, min: 1, max: 1)]
                    public string @Cooldown { get; }

                    [nterraform.Core.TerraformProperty(name: "direction", @out: false, min: 1, max: 1)]
                    public string @Direction { get; }

                    [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                    public int @Value { get; }
                }

                public rule(metric_trigger[] @metricTrigger,
                            scale_action[] @scaleAction)
                {
                    @MetricTrigger = @metricTrigger;
                    @ScaleAction = @scaleAction;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "metric_trigger", @out: false, min: 1, max: 1)]
                public metric_trigger[] @MetricTrigger { get; }

                [nterraform.Core.TerraformProperty(name: "scale_action", @out: false, min: 1, max: 1)]
                public scale_action[] @ScaleAction { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "fixed_date")]
            public sealed class fixed_date : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "end", @out: false, min: 1, max: 1)]
                public string @End { get; }

                [nterraform.Core.TerraformProperty(name: "start", @out: false, min: 1, max: 1)]
                public string @Start { get; }

                [nterraform.Core.TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
                public string @Timezone { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "recurrence")]
            public sealed class recurrence : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "days", @out: false, min: 1, max: 1)]
                public string[] @Days { get; }

                [nterraform.Core.TerraformProperty(name: "hours", @out: false, min: 1, max: 1)]
                public int[] @Hours { get; }

                [nterraform.Core.TerraformProperty(name: "minutes", @out: false, min: 1, max: 1)]
                public int[] @Minutes { get; }

                [nterraform.Core.TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
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

            [nterraform.Core.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public capacity[] @Capacity { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "fixed_date", @out: false, min: 0, max: 1)]
            public fixed_date[] @FixedDate { get; }

            [nterraform.Core.TerraformProperty(name: "recurrence", @out: false, min: 0, max: 1)]
            public recurrence[] @Recurrence { get; }

            [nterraform.Core.TerraformProperty(name: "rule", @out: false, min: 0, max: 10)]
            public rule[] @Rule { get; }
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

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "profile", @out: false, min: 1, max: 20)]
        public profile[] @Profile { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "target_resource_id", @out: false, min: 1, max: 1)]
        public string @TargetResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "notification", @out: false, min: 0, max: 1)]
        public notification[] @Notification { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}