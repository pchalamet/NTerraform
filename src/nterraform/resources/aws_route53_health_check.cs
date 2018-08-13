using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_route53_health_check")]
    public sealed class aws_route53_health_check : nterraform.resource
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

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "child_health_threshold", @out: false, min: 0, max: 1)]
        public int? @ChildHealthThreshold { get; }

        [nterraform.TerraformProperty(name: "child_healthchecks", @out: false, min: 0, max: 1)]
        public string[] @ChildHealthchecks { get; }

        [nterraform.TerraformProperty(name: "cloudwatch_alarm_name", @out: false, min: 0, max: 1)]
        public string @CloudwatchAlarmName { get; }

        [nterraform.TerraformProperty(name: "cloudwatch_alarm_region", @out: false, min: 0, max: 1)]
        public string @CloudwatchAlarmRegion { get; }

        [nterraform.TerraformProperty(name: "enable_sni", @out: true, min: 0, max: 1)]
        public bool? @EnableSni { get; }

        [nterraform.TerraformProperty(name: "failure_threshold", @out: false, min: 0, max: 1)]
        public int? @FailureThreshold { get; }

        [nterraform.TerraformProperty(name: "fqdn", @out: false, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.TerraformProperty(name: "insufficient_data_health_status", @out: false, min: 0, max: 1)]
        public string @InsufficientDataHealthStatus { get; }

        [nterraform.TerraformProperty(name: "invert_healthcheck", @out: false, min: 0, max: 1)]
        public bool? @InvertHealthcheck { get; }

        [nterraform.TerraformProperty(name: "ip_address", @out: false, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.TerraformProperty(name: "measure_latency", @out: false, min: 0, max: 1)]
        public bool? @MeasureLatency { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "reference_name", @out: false, min: 0, max: 1)]
        public string @ReferenceName { get; }

        [nterraform.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
        public string[] @Regions { get; }

        [nterraform.TerraformProperty(name: "request_interval", @out: false, min: 0, max: 1)]
        public int? @RequestInterval { get; }

        [nterraform.TerraformProperty(name: "resource_path", @out: false, min: 0, max: 1)]
        public string @ResourcePath { get; }

        [nterraform.TerraformProperty(name: "search_string", @out: false, min: 0, max: 1)]
        public string @SearchString { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
