using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_appautoscaling_policy")]
    public sealed class aws_appautoscaling_policy : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "target_tracking_scaling_policy_configuration")]
        public sealed class target_tracking_scaling_policy_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "customized_metric_specification")]
            public sealed class customized_metric_specification : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "dimensions")]
                public sealed class dimensions : nterraform.structure
                {
                    public dimensions(string @name,
                                      string @value)
                    {
                        @Name = @name;
                        @Value = @value;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                    public string @Name { get; }

                    [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
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

                [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
                public string @MetricName { get; }

                [nterraform.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
                public string @Namespace { get; }

                [nterraform.TerraformProperty(name: "statistic", @out: false, min: 1, max: 1)]
                public string @Statistic { get; }

                [nterraform.TerraformProperty(name: "dimensions", @out: false, min: 0, max: 0)]
                public dimensions[] @Dimensions { get; }

                [nterraform.TerraformProperty(name: "unit", @out: false, min: 0, max: 1)]
                public string @Unit { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "predefined_metric_specification")]
            public sealed class predefined_metric_specification : nterraform.structure
            {
                public predefined_metric_specification(string @predefinedMetricType,
                                                       string @resourceLabel = null)
                {
                    @PredefinedMetricType = @predefinedMetricType;
                    @ResourceLabel = @resourceLabel;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "predefined_metric_type", @out: false, min: 1, max: 1)]
                public string @PredefinedMetricType { get; }

                [nterraform.TerraformProperty(name: "resource_label", @out: false, min: 0, max: 1)]
                public string @ResourceLabel { get; }
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

            [nterraform.TerraformProperty(name: "target_value", @out: false, min: 1, max: 1)]
            public int @TargetValue { get; }

            [nterraform.TerraformProperty(name: "customized_metric_specification", @out: false, min: 0, max: 1)]
            public customized_metric_specification[] @CustomizedMetricSpecification { get; }

            [nterraform.TerraformProperty(name: "disable_scale_in", @out: false, min: 0, max: 1)]
            public bool? @DisableScaleIn { get; }

            [nterraform.TerraformProperty(name: "predefined_metric_specification", @out: false, min: 0, max: 1)]
            public predefined_metric_specification[] @PredefinedMetricSpecification { get; }

            [nterraform.TerraformProperty(name: "scale_in_cooldown", @out: false, min: 0, max: 1)]
            public int? @ScaleInCooldown { get; }

            [nterraform.TerraformProperty(name: "scale_out_cooldown", @out: false, min: 0, max: 1)]
            public int? @ScaleOutCooldown { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "step_adjustment")]
        public sealed class step_adjustment : nterraform.structure
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

            [nterraform.TerraformProperty(name: "scaling_adjustment", @out: false, min: 1, max: 1)]
            public int @ScalingAdjustment { get; }

            [nterraform.TerraformProperty(name: "metric_interval_lower_bound", @out: false, min: 0, max: 1)]
            public string @MetricIntervalLowerBound { get; }

            [nterraform.TerraformProperty(name: "metric_interval_upper_bound", @out: false, min: 0, max: 1)]
            public string @MetricIntervalUpperBound { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "step_scaling_policy_configuration")]
        public sealed class step_scaling_policy_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "step_adjustment")]
            public sealed class step_adjustment : nterraform.structure
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

                [nterraform.TerraformProperty(name: "scaling_adjustment", @out: false, min: 1, max: 1)]
                public int @ScalingAdjustment { get; }

                [nterraform.TerraformProperty(name: "metric_interval_lower_bound", @out: false, min: 0, max: 1)]
                public int? @MetricIntervalLowerBound { get; }

                [nterraform.TerraformProperty(name: "metric_interval_upper_bound", @out: false, min: 0, max: 1)]
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

            [nterraform.TerraformProperty(name: "adjustment_type", @out: false, min: 0, max: 1)]
            public string @AdjustmentType { get; }

            [nterraform.TerraformProperty(name: "cooldown", @out: false, min: 0, max: 1)]
            public int? @Cooldown { get; }

            [nterraform.TerraformProperty(name: "metric_aggregation_type", @out: false, min: 0, max: 1)]
            public string @MetricAggregationType { get; }

            [nterraform.TerraformProperty(name: "min_adjustment_magnitude", @out: false, min: 0, max: 1)]
            public int? @MinAdjustmentMagnitude { get; }

            [nterraform.TerraformProperty(name: "step_adjustment", @out: false, min: 0, max: 0)]
            public step_adjustment[] @StepAdjustment { get; }
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.TerraformProperty(name: "scalable_dimension", @out: false, min: 1, max: 1)]
        public string @ScalableDimension { get; }

        [nterraform.TerraformProperty(name: "service_namespace", @out: false, min: 1, max: 1)]
        public string @ServiceNamespace { get; }

        [nterraform.TerraformProperty(name: "adjustment_type", @out: false, min: 0, max: 1)]
        public string @AdjustmentType { get; }

        [nterraform.TerraformProperty(name: "alarms", @out: false, min: 0, max: 1)]
        public string[] @Alarms { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "cooldown", @out: false, min: 0, max: 1)]
        public int? @Cooldown { get; }

        [nterraform.TerraformProperty(name: "metric_aggregation_type", @out: false, min: 0, max: 1)]
        public string @MetricAggregationType { get; }

        [nterraform.TerraformProperty(name: "min_adjustment_magnitude", @out: false, min: 0, max: 1)]
        public int? @MinAdjustmentMagnitude { get; }

        [nterraform.TerraformProperty(name: "policy_type", @out: false, min: 0, max: 1)]
        public string @PolicyType { get; }

        [nterraform.TerraformProperty(name: "step_adjustment", @out: false, min: 0, max: 0)]
        public step_adjustment[] @StepAdjustment { get; }

        [nterraform.TerraformProperty(name: "step_scaling_policy_configuration", @out: false, min: 0, max: 0)]
        public step_scaling_policy_configuration[] @StepScalingPolicyConfiguration { get; }

        [nterraform.TerraformProperty(name: "target_tracking_scaling_policy_configuration", @out: false, min: 0, max: 1)]
        public target_tracking_scaling_policy_configuration[] @TargetTrackingScalingPolicyConfiguration { get; }
    }

}
