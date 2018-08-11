using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_autoscale_setting : NTerraform.resource
    {
        public sealed class notification
        {
            public sealed class webhook
            {
                public webhook(string @serviceUri,
                               Dictionary<string,string> @properties = null)
                {
                    @ServiceUri = @serviceUri;
                    @Properties = @properties;
                }

                public string @ServiceUri { get; }
                public Dictionary<string,string> @Properties { get; }
            }

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

                public string[] @CustomEmails { get; }
                public bool? @SendToSubscriptionAdministrator { get; }
                public bool? @SendToSubscriptionCoAdministrator { get; }
            }

            public notification(email[] @email = null,
                                webhook[] @webhook = null)
            {
                @Email = @email;
                @Webhook = @webhook;
            }

            public email[] @Email { get; }
            public webhook[] @Webhook { get; }
        }

        public sealed class profile
        {
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

                public string @End { get; }
                public string @Start { get; }
                public string @Timezone { get; }
            }

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

                public string[] @Days { get; }
                public int[] @Hours { get; }
                public int[] @Minutes { get; }
                public string @Timezone { get; }
            }

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

                public int @Default { get; }
                public int @Maximum { get; }
                public int @Minimum { get; }
            }

            public sealed class rule
            {
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

                    public string @MetricName { get; }
                    public string @MetricResourceId { get; }
                    public string @Operator { get; }
                    public string @Statistic { get; }
                    public int @Threshold { get; }
                    public string @TimeAggregation { get; }
                    public string @TimeGrain { get; }
                    public string @TimeWindow { get; }
                }

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

                    public string @Cooldown { get; }
                    public string @Direction { get; }
                    public string @Type { get; }
                    public int @Value { get; }
                }

                public rule(metric_trigger[] @metricTrigger,
                            scale_action[] @scaleAction)
                {
                    @MetricTrigger = @metricTrigger;
                    @ScaleAction = @scaleAction;
                }

                public metric_trigger[] @MetricTrigger { get; }
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
            }

            public capacity[] @Capacity { get; }
            public string @Name { get; }
            public fixed_date[] @FixedDate { get; }
            public recurrence[] @Recurrence { get; }
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
        }

        public string @Location { get; }
        public string @Name { get; }
        public profile[] @Profile { get; }
        public string @ResourceGroupName { get; }
        public string @TargetResourceId { get; }
        public bool? @Enabled { get; }
        public notification[] @Notification { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
