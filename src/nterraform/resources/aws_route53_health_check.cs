using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route53_health_check")]
    public sealed class aws_route53_health_check : nterraform.Core.resource
    {
        public aws_route53_health_check(string @type,
                                        int? @childHealthThreshold = null,
                                        string[] @childHealthchecks = null,
                                        string @cloudwatchAlarmName = null,
                                        string @cloudwatchAlarmRegion = null,
                                        int? @failureThreshold = null,
                                        string @fqdn = null,
                                        string @insufficientDataHealthStatus = null,
                                        bool? @invertHealthcheck = null,
                                        string @ipAddress = null,
                                        bool? @measureLatency = null,
                                        int? @port = null,
                                        string @referenceName = null,
                                        string[] @regions = null,
                                        int? @requestInterval = null,
                                        string @resourcePath = null,
                                        string @searchString = null,
                                        Dictionary<string,string> @tags = null)
        {
            @Type = @type;
            @ChildHealthThreshold = @childHealthThreshold;
            @ChildHealthchecks = @childHealthchecks;
            @CloudwatchAlarmName = @cloudwatchAlarmName;
            @CloudwatchAlarmRegion = @cloudwatchAlarmRegion;
            @FailureThreshold = @failureThreshold;
            @Fqdn = @fqdn;
            @InsufficientDataHealthStatus = @insufficientDataHealthStatus;
            @InvertHealthcheck = @invertHealthcheck;
            @IpAddress = @ipAddress;
            @MeasureLatency = @measureLatency;
            @Port = @port;
            @ReferenceName = @referenceName;
            @Regions = @regions;
            @RequestInterval = @requestInterval;
            @ResourcePath = @resourcePath;
            @SearchString = @searchString;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "child_health_threshold", @out: false, min: 0, max: 1)]
        public int? @ChildHealthThreshold { get; }

        [nterraform.Core.TerraformProperty(name: "child_healthchecks", @out: false, min: 0, max: 1)]
        public string[] @ChildHealthchecks { get; }

        [nterraform.Core.TerraformProperty(name: "cloudwatch_alarm_name", @out: false, min: 0, max: 1)]
        public string @CloudwatchAlarmName { get; }

        [nterraform.Core.TerraformProperty(name: "cloudwatch_alarm_region", @out: false, min: 0, max: 1)]
        public string @CloudwatchAlarmRegion { get; }

        [nterraform.Core.TerraformProperty(name: "enable_sni", @out: true, min: 0, max: 1)]
        public bool? @EnableSni { get; }

        [nterraform.Core.TerraformProperty(name: "failure_threshold", @out: false, min: 0, max: 1)]
        public int? @FailureThreshold { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: false, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "insufficient_data_health_status", @out: false, min: 0, max: 1)]
        public string @InsufficientDataHealthStatus { get; }

        [nterraform.Core.TerraformProperty(name: "invert_healthcheck", @out: false, min: 0, max: 1)]
        public bool? @InvertHealthcheck { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address", @out: false, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "measure_latency", @out: false, min: 0, max: 1)]
        public bool? @MeasureLatency { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "reference_name", @out: false, min: 0, max: 1)]
        public string @ReferenceName { get; }

        [nterraform.Core.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
        public string[] @Regions { get; }

        [nterraform.Core.TerraformProperty(name: "request_interval", @out: false, min: 0, max: 1)]
        public int? @RequestInterval { get; }

        [nterraform.Core.TerraformProperty(name: "resource_path", @out: false, min: 0, max: 1)]
        public string @ResourcePath { get; }

        [nterraform.Core.TerraformProperty(name: "search_string", @out: false, min: 0, max: 1)]
        public string @SearchString { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
