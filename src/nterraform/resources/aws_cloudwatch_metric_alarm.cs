using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_metric_alarm")]
    public sealed class aws_cloudwatch_metric_alarm : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "alarm_name", @out: false, min: 1, max: 1)]
        public string @AlarmName { get; }

        [nterraform.Core.TerraformProperty(name: "comparison_operator", @out: false, min: 1, max: 1)]
        public string @ComparisonOperator { get; }

        [nterraform.Core.TerraformProperty(name: "evaluation_periods", @out: false, min: 1, max: 1)]
        public int @EvaluationPeriods { get; }

        [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.Core.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
        public string @Namespace { get; }

        [nterraform.Core.TerraformProperty(name: "period", @out: false, min: 1, max: 1)]
        public int @Period { get; }

        [nterraform.Core.TerraformProperty(name: "threshold", @out: false, min: 1, max: 1)]
        public int @Threshold { get; }

        [nterraform.Core.TerraformProperty(name: "actions_enabled", @out: false, min: 0, max: 1)]
        public bool? @ActionsEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "alarm_actions", @out: false, min: 0, max: 1)]
        public string[] @AlarmActions { get; }

        [nterraform.Core.TerraformProperty(name: "alarm_description", @out: false, min: 0, max: 1)]
        public string @AlarmDescription { get; }

        [nterraform.Core.TerraformProperty(name: "datapoints_to_alarm", @out: false, min: 0, max: 1)]
        public int? @DatapointsToAlarm { get; }

        [nterraform.Core.TerraformProperty(name: "dimensions", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Dimensions { get; }

        [nterraform.Core.TerraformProperty(name: "evaluate_low_sample_count_percentiles", @out: true, min: 0, max: 1)]
        public string @EvaluateLowSampleCountPercentiles { get; }

        [nterraform.Core.TerraformProperty(name: "extended_statistic", @out: false, min: 0, max: 1)]
        public string @ExtendedStatistic { get; }

        [nterraform.Core.TerraformProperty(name: "insufficient_data_actions", @out: false, min: 0, max: 1)]
        public string[] @InsufficientDataActions { get; }

        [nterraform.Core.TerraformProperty(name: "ok_actions", @out: false, min: 0, max: 1)]
        public string[] @OkActions { get; }

        [nterraform.Core.TerraformProperty(name: "statistic", @out: false, min: 0, max: 1)]
        public string @Statistic { get; }

        [nterraform.Core.TerraformProperty(name: "treat_missing_data", @out: false, min: 0, max: 1)]
        public string @TreatMissingData { get; }

        [nterraform.Core.TerraformProperty(name: "unit", @out: false, min: 0, max: 1)]
        public string @Unit { get; }
    }

}
