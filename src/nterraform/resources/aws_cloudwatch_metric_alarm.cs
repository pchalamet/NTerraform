using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_metric_alarm")]
    public sealed class aws_cloudwatch_metric_alarm : nterraform.resource
    {
        public aws_cloudwatch_metric_alarm(string @alarmName,
                                           string @comparisonOperator,
                                           int @evaluationPeriods,
                                           string @metricName,
                                           string @namespace,
                                           int @period,
                                           int @threshold,
                                           bool? @actionsEnabled = null,
                                           string[] @alarmActions = null,
                                           string @alarmDescription = null,
                                           int? @datapointsToAlarm = null,
                                           Dictionary<string,string> @dimensions = null,
                                           string @extendedStatistic = null,
                                           string[] @insufficientDataActions = null,
                                           string[] @okActions = null,
                                           string @statistic = null,
                                           string @treatMissingData = null,
                                           string @unit = null)
        {
            @AlarmName = @alarmName;
            @ComparisonOperator = @comparisonOperator;
            @EvaluationPeriods = @evaluationPeriods;
            @MetricName = @metricName;
            @Namespace = @namespace;
            @Period = @period;
            @Threshold = @threshold;
            @ActionsEnabled = @actionsEnabled;
            @AlarmActions = @alarmActions;
            @AlarmDescription = @alarmDescription;
            @DatapointsToAlarm = @datapointsToAlarm;
            @Dimensions = @dimensions;
            @ExtendedStatistic = @extendedStatistic;
            @InsufficientDataActions = @insufficientDataActions;
            @OkActions = @okActions;
            @Statistic = @statistic;
            @TreatMissingData = @treatMissingData;
            @Unit = @unit;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "alarm_name", @out: false, min: 1, max: 1)]
        public string @AlarmName { get; }

        [nterraform.TerraformProperty(name: "comparison_operator", @out: false, min: 1, max: 1)]
        public string @ComparisonOperator { get; }

        [nterraform.TerraformProperty(name: "evaluation_periods", @out: false, min: 1, max: 1)]
        public int @EvaluationPeriods { get; }

        [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
        public string @Namespace { get; }

        [nterraform.TerraformProperty(name: "period", @out: false, min: 1, max: 1)]
        public int @Period { get; }

        [nterraform.TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
        public int @Threshold { get; }

        [nterraform.TerraformProperty(name: "actions_enabled", @out: false, min: 0, max: 1)]
        public bool? @ActionsEnabled { get; }

        [nterraform.TerraformProperty(name: "alarm_actions", @out: false, min: 0, max: 1)]
        public string[] @AlarmActions { get; }

        [nterraform.TerraformProperty(name: "alarm_description", @out: false, min: 0, max: 1)]
        public string @AlarmDescription { get; }

        [nterraform.TerraformProperty(name: "datapoints_to_alarm", @out: false, min: 0, max: 1)]
        public int? @DatapointsToAlarm { get; }

        [nterraform.TerraformProperty(name: "dimensions", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Dimensions { get; }

        [nterraform.TerraformProperty(name: "evaluate_low_sample_count_percentiles", @out: true, min: 0, max: 1)]
        public string @EvaluateLowSampleCountPercentiles { get; }

        [nterraform.TerraformProperty(name: "extended_statistic", @out: false, min: 0, max: 1)]
        public string @ExtendedStatistic { get; }

        [nterraform.TerraformProperty(name: "insufficient_data_actions", @out: false, min: 0, max: 1)]
        public string[] @InsufficientDataActions { get; }

        [nterraform.TerraformProperty(name: "ok_actions", @out: false, min: 0, max: 1)]
        public string[] @OkActions { get; }

        [nterraform.TerraformProperty(name: "statistic", @out: false, min: 0, max: 1)]
        public string @Statistic { get; }

        [nterraform.TerraformProperty(name: "treat_missing_data", @out: false, min: 0, max: 1)]
        public string @TreatMissingData { get; }

        [nterraform.TerraformProperty(name: "unit", @out: false, min: 0, max: 1)]
        public string @Unit { get; }
    }

}
