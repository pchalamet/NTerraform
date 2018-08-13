using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_autoscaling_policy")]
    public sealed class aws_autoscaling_policy : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "step_adjustment")]
        public sealed class step_adjustment : nterraform.Core.structure
        {
            public step_adjustment(int @scalingAdjustment,
                                   string @metricIntervalLowerBound = null,
                                   string @metricIntervalUpperBound = null)
            {
                @ScalingAdjustment = @scalingAdjustment;
                @MetricIntervalLowerBound = @metricIntervalLowerBound;
                @MetricIntervalUpperBound = @metricIntervalUpperBound;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "scaling_adjustment", @out: false, min: 1, max: 1)]
            public int @ScalingAdjustment { get; }

            [nterraform.Core.TerraformProperty(name: "metric_interval_lower_bound", @out: false, min: 0, max: 1)]
            public string @MetricIntervalLowerBound { get; }

            [nterraform.Core.TerraformProperty(name: "metric_interval_upper_bound", @out: false, min: 0, max: 1)]
            public string @MetricIntervalUpperBound { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "target_tracking_configuration")]
        public sealed class target_tracking_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "customized_metric_specification")]
            public sealed class customized_metric_specification : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "metric_dimension")]
                public sealed class metric_dimension : nterraform.Core.structure
                {
                    public metric_dimension(string @name,
                                            string @value)
                    {
                        @Name = @name;
                        @Value = @value;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                    public string @Name { get; }

                    [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                    public string @Value { get; }
                }

                public customized_metric_specification(string @metricName,
                                                       string @namespace,
                                                       string @statistic,
                                                       metric_dimension[] @metricDimension = null,
                                                       string @unit = null)
                {
                    @MetricName = @metricName;
                    @Namespace = @namespace;
                    @Statistic = @statistic;
                    @MetricDimension = @metricDimension;
                    @Unit = @unit;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
                public string @MetricName { get; }

                [nterraform.Core.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
                public string @Namespace { get; }

                [nterraform.Core.TerraformProperty(name: "statistic", @out: false, min: 1, max: 1)]
                public string @Statistic { get; }

                [nterraform.Core.TerraformProperty(name: "metric_dimension", @out: false, min: 0, max: 0)]
                public metric_dimension[] @MetricDimension { get; }

                [nterraform.Core.TerraformProperty(name: "unit", @out: false, min: 0, max: 1)]
                public string @Unit { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "predefined_metric_specification")]
            public sealed class predefined_metric_specification : nterraform.Core.structure
            {
                public predefined_metric_specification(string @predefinedMetricType,
                                                       string @resourceLabel = null)
                {
                    @PredefinedMetricType = @predefinedMetricType;
                    @ResourceLabel = @resourceLabel;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "predefined_metric_type", @out: false, min: 1, max: 1)]
                public string @PredefinedMetricType { get; }

                [nterraform.Core.TerraformProperty(name: "resource_label", @out: false, min: 0, max: 1)]
                public string @ResourceLabel { get; }
            }

            public target_tracking_configuration(int @targetValue,
                                                 customized_metric_specification[] @customizedMetricSpecification = null,
                                                 bool? @disableScaleIn = null,
                                                 predefined_metric_specification[] @predefinedMetricSpecification = null)
            {
                @TargetValue = @targetValue;
                @CustomizedMetricSpecification = @customizedMetricSpecification;
                @DisableScaleIn = @disableScaleIn;
                @PredefinedMetricSpecification = @predefinedMetricSpecification;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "target_value", @out: false, min: 1, max: 1)]
            public int @TargetValue { get; }

            [nterraform.Core.TerraformProperty(name: "customized_metric_specification", @out: false, min: 0, max: 1)]
            public customized_metric_specification[] @CustomizedMetricSpecification { get; }

            [nterraform.Core.TerraformProperty(name: "disable_scale_in", @out: false, min: 0, max: 1)]
            public bool? @DisableScaleIn { get; }

            [nterraform.Core.TerraformProperty(name: "predefined_metric_specification", @out: false, min: 0, max: 1)]
            public predefined_metric_specification[] @PredefinedMetricSpecification { get; }
        }

        public aws_autoscaling_policy(string @autoscalingGroupName,
                                      string @name,
                                      string @adjustmentType = null,
                                      int? @cooldown = null,
                                      int? @estimatedInstanceWarmup = null,
                                      int? @minAdjustmentMagnitude = null,
                                      int? @minAdjustmentStep = null,
                                      string @policyType = null,
                                      int? @scalingAdjustment = null,
                                      step_adjustment[] @stepAdjustment = null,
                                      target_tracking_configuration[] @targetTrackingConfiguration = null)
        {
            @AutoscalingGroupName = @autoscalingGroupName;
            @Name = @name;
            @AdjustmentType = @adjustmentType;
            @Cooldown = @cooldown;
            @EstimatedInstanceWarmup = @estimatedInstanceWarmup;
            @MinAdjustmentMagnitude = @minAdjustmentMagnitude;
            @MinAdjustmentStep = @minAdjustmentStep;
            @PolicyType = @policyType;
            @ScalingAdjustment = @scalingAdjustment;
            @StepAdjustment = @stepAdjustment;
            @TargetTrackingConfiguration = @targetTrackingConfiguration;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "autoscaling_group_name", @out: false, min: 1, max: 1)]
        public string @AutoscalingGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "adjustment_type", @out: false, min: 0, max: 1)]
        public string @AdjustmentType { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cooldown", @out: false, min: 0, max: 1)]
        public int? @Cooldown { get; }

        [nterraform.Core.TerraformProperty(name: "estimated_instance_warmup", @out: false, min: 0, max: 1)]
        public int? @EstimatedInstanceWarmup { get; }

        [nterraform.Core.TerraformProperty(name: "metric_aggregation_type", @out: true, min: 0, max: 1)]
        public string @MetricAggregationType { get; }

        [nterraform.Core.TerraformProperty(name: "min_adjustment_magnitude", @out: false, min: 0, max: 1)]
        public int? @MinAdjustmentMagnitude { get; }

        [nterraform.Core.TerraformProperty(name: "min_adjustment_step", @out: false, min: 0, max: 1)]
        public int? @MinAdjustmentStep { get; }

        [nterraform.Core.TerraformProperty(name: "policy_type", @out: false, min: 0, max: 1)]
        public string @PolicyType { get; }

        [nterraform.Core.TerraformProperty(name: "scaling_adjustment", @out: false, min: 0, max: 1)]
        public int? @ScalingAdjustment { get; }

        [nterraform.Core.TerraformProperty(name: "step_adjustment", @out: false, min: 0, max: 0)]
        public step_adjustment[] @StepAdjustment { get; }

        [nterraform.Core.TerraformProperty(name: "target_tracking_configuration", @out: false, min: 0, max: 1)]
        public target_tracking_configuration[] @TargetTrackingConfiguration { get; }
    }

}