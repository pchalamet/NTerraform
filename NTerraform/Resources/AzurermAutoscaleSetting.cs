using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_autoscale_setting : NTerraform.resource
    {
        public class profile
        {
            public class recurrence
            {
                public recurrence(List<string> @days,
                                  List<int> @hours,
                                  List<int> @minutes,
                                  string @timezone = null)
                {
                    @Days = @days;
                    @Hours = @hours;
                    @Minutes = @minutes;
                    @Timezone = @timezone;
                }

                public List<string> @Days { get; }
                public List<int> @Hours { get; }
                public List<int> @Minutes { get; }
                public string @Timezone { get; }
            }

            public class capacity
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

            public class rule
            {
                public class metric_trigger
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

                public class scale_action
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

                public rule(List<metric_trigger> @metricTrigger,
                            List<scale_action> @scaleAction)
                {
                    @MetricTrigger = @metricTrigger;
                    @ScaleAction = @scaleAction;
                }

                public List<metric_trigger> @MetricTrigger { get; }
                public List<scale_action> @ScaleAction { get; }
            }

            public class fixed_date
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

            public profile(List<capacity> @capacity,
                           string @name,
                           List<fixed_date> @fixedDate = null,
                           List<recurrence> @recurrence = null,
                           List<rule> @rule = null)
            {
                @Capacity = @capacity;
                @Name = @name;
                @FixedDate = @fixedDate;
                @Recurrence = @recurrence;
                @Rule = @rule;
            }

            public List<capacity> @Capacity { get; }
            public string @Name { get; }
            public List<fixed_date> @FixedDate { get; }
            public List<recurrence> @Recurrence { get; }
            public List<rule> @Rule { get; }
        }

        public class notification
        {
            public class email
            {
                public email(List<string> @customEmails = null,
                             bool? @sendToSubscriptionAdministrator = null,
                             bool? @sendToSubscriptionCoAdministrator = null)
                {
                    @CustomEmails = @customEmails;
                    @SendToSubscriptionAdministrator = @sendToSubscriptionAdministrator;
                    @SendToSubscriptionCoAdministrator = @sendToSubscriptionCoAdministrator;
                }

                public List<string> @CustomEmails { get; }
                public bool? @SendToSubscriptionAdministrator { get; }
                public bool? @SendToSubscriptionCoAdministrator { get; }
            }

            public class webhook
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

            public notification(List<email> @email = null,
                                List<webhook> @webhook = null)
            {
                @Email = @email;
                @Webhook = @webhook;
            }

            public List<email> @Email { get; }
            public List<webhook> @Webhook { get; }
        }

        public azurerm_autoscale_setting(string @location,
                                         string @name,
                                         List<profile> @profile,
                                         string @resourceGroupName,
                                         string @targetResourceId,
                                         bool? @enabled = null,
                                         List<notification> @notification = null)
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
        public List<profile> @Profile { get; }
        public string @ResourceGroupName { get; }
        public string @TargetResourceId { get; }
        public bool? @Enabled { get; }
        public List<notification> @Notification { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
