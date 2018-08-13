using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_appautoscaling_policy")]
    public sealed class aws_appautoscaling_policy : nterraform.Core.resource
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

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "step_scaling_policy_configuration")]
        public sealed class step_scaling_policy_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "step_adjustment")]
            public sealed class step_adjustment : nterraform.Core.structure
            {
                public step_adjustment(int @scalingAdjustment,
                                       int? @metricIntervalLowerBound = null,
                                       int? @metricIntervalUpperBound = null)
                {
                    @ScalingAdjustment = @scalingAdjustment;
                    @MetricIntervalLowerBound = @metricIntervalLowerBound;
                    @MetricIntervalUpperBound = @metricIntervalUpperBound;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "scaling_adjustment", @out: false, min: 1, max: 1)]
                public int @ScalingAdjustment { get; }

                [nterraform.Core.TerraformProperty(name: "metric_interval_lower_bound", @out: false, min: 0, max: 1)]
                public int? @MetricIntervalLowerBound { get; }

                [nterraform.Core.TerraformProperty(name: "metric_interval_upper_bound", @out: false, min: 0, max: 1)]
                public int? @MetricIntervalUpperBound { get; }
            }

            public step_scaling_policy_configuration(string @adjustmentType = null,
                                                     int? @cooldown = null,
                                                     string @metricAggregationType = null,
                                                     int? @minAdjustmentMagnitude = null,
                                                     step_adjustment[] @stepAdjustment = null)
            {
                @AdjustmentType = @adjustmentType;
                @Cooldown = @cooldown;
                @MetricAggregationType = @metricAggregationType;
                @MinAdjustmentMagnitude = @minAdjustmentMagnitude;
                @StepAdjustment = @stepAdjustment;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "adjustment_type", @out: false, min: 0, max: 1)]
            public string @AdjustmentType { get; }

            [nterraform.Core.TerraformProperty(name: "cooldown", @out: false, min: 0, max: 1)]
            public int? @Cooldown { get; }

            [nterraform.Core.TerraformProperty(name: "metric_aggregation_type", @out: false, min: 0, max: 1)]
            public string @MetricAggregationType { get; }

            [nterraform.Core.TerraformProperty(name: "min_adjustment_magnitude", @out: false, min: 0, max: 1)]
            public int? @MinAdjustmentMagnitude { get; }

            [nterraform.Core.TerraformProperty(name: "step_adjustment", @out: false, min: 0, max: 0)]
            public step_adjustment[] @StepAdjustment { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "target_tracking_scaling_policy_configuration")]
        public sealed class target_tracking_scaling_policy_configuration : nterraform.Core.structure
        {
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

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "customized_metric_specification")]
            public sealed class customized_metric_specification : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "dimensions")]
                public sealed class dimensions : nterraform.Core.structure
                {
                    public dimensions(string @name,
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
                                                       dimensions[] @dimensions = null,
                                                       string @unit = null)
                {
                    @MetricName = @metricName;
                    @Namespace = @namespace;
                    @Statistic = @statistic;
                    @Dimensions = @dimensions;
                    @Unit = @unit;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
                public string @MetricName { get; }

                [nterraform.Core.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
                public string @Namespace { get; }

                [nterraform.Core.TerraformProperty(name: "statistic", @out: false, min: 1, max: 1)]
                public string @Statistic { get; }

                [nterraform.Core.TerraformProperty(name: "dimensions", @out: false, min: 0, max: 0)]
                public dimensions[] @Dimensions { get; }

                [nterraform.Core.TerraformProperty(name: "unit", @out: false, min: 0, max: 1)]
                public string @Unit { get; }
            }

            public target_tracking_scaling_policy_configuration(int @targetValue,
                                                                customized_metric_specification[] @customizedMetricSpecification = null,
                                                                bool? @disableScaleIn = null,
                                                                predefined_metric_specification[] @predefinedMetricSpecification = null,
                                                                int? @scaleInCooldown = null,
                                                                int? @scaleOutCooldown = null)
            {
                @TargetValue = @targetValue;
                @CustomizedMetricSpecification = @customizedMetricSpecification;
                @DisableScaleIn = @disableScaleIn;
                @PredefinedMetricSpecification = @predefinedMetricSpecification;
                @ScaleInCooldown = @scaleInCooldown;
                @ScaleOutCooldown = @scaleOutCooldown;
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

            [nterraform.Core.TerraformProperty(name: "scale_in_cooldown", @out: false, min: 0, max: 1)]
            public int? @ScaleInCooldown { get; }

            [nterraform.Core.TerraformProperty(name: "scale_out_cooldown", @out: false, min: 0, max: 1)]
            public int? @ScaleOutCooldown { get; }
        }

        public aws_appautoscaling_policy(string @name,
                                         string @resourceId,
                                         string @scalableDimension,
                                         string @serviceNamespace,
                                         string @adjustmentType = null,
                                         string[] @alarms = null,
                                         int? @cooldown = null,
                                         string @metricAggregationType = null,
                                         int? @minAdjustmentMagnitude = null,
                                         string @policyType = null,
                                         step_adjustment[] @stepAdjustment = null,
                                         step_scaling_policy_configuration[] @stepScalingPolicyConfiguration = null,
                                         target_tracking_scaling_policy_configuration[] @targetTrackingScalingPolicyConfiguration = null)
        {
            @Name = @name;
            @ResourceId = @resourceId;
            @ScalableDimension = @scalableDimension;
            @ServiceNamespace = @serviceNamespace;
            @AdjustmentType = @adjustmentType;
            @Alarms = @alarms;
            @Cooldown = @cooldown;
            @MetricAggregationType = @metricAggregationType;
            @MinAdjustmentMagnitude = @minAdjustmentMagnitude;
            @PolicyType = @policyType;
            @StepAdjustment = @stepAdjustment;
            @StepScalingPolicyConfiguration = @stepScalingPolicyConfiguration;
            @TargetTrackingScalingPolicyConfiguration = @targetTrackingScalingPolicyConfiguration;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "scalable_dimension", @out: false, min: 1, max: 1)]
        public string @ScalableDimension { get; }

        [nterraform.Core.TerraformProperty(name: "service_namespace", @out: false, min: 1, max: 1)]
        public string @ServiceNamespace { get; }

        [nterraform.Core.TerraformProperty(name: "adjustment_type", @out: false, min: 0, max: 1)]
        public string @AdjustmentType { get; }

        [nterraform.Core.TerraformProperty(name: "alarms", @out: false, min: 0, max: 1)]
        public string[] @Alarms { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cooldown", @out: false, min: 0, max: 1)]
        public int? @Cooldown { get; }

        [nterraform.Core.TerraformProperty(name: "metric_aggregation_type", @out: false, min: 0, max: 1)]
        public string @MetricAggregationType { get; }

        [nterraform.Core.TerraformProperty(name: "min_adjustment_magnitude", @out: false, min: 0, max: 1)]
        public int? @MinAdjustmentMagnitude { get; }

        [nterraform.Core.TerraformProperty(name: "policy_type", @out: false, min: 0, max: 1)]
        public string @PolicyType { get; }

        [nterraform.Core.TerraformProperty(name: "step_adjustment", @out: false, min: 0, max: 0)]
        public step_adjustment[] @StepAdjustment { get; }

        [nterraform.Core.TerraformProperty(name: "step_scaling_policy_configuration", @out: false, min: 0, max: 0)]
        public step_scaling_policy_configuration[] @StepScalingPolicyConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "target_tracking_scaling_policy_configuration", @out: false, min: 0, max: 1)]
        public target_tracking_scaling_policy_configuration[] @TargetTrackingScalingPolicyConfiguration { get; }
    }

}
