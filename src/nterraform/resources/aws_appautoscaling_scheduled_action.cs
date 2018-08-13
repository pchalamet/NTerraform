using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_appautoscaling_scheduled_action")]
    public sealed class aws_appautoscaling_scheduled_action : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "scalable_target_action")]
        public sealed class scalable_target_action : nterraform.structure
        {
            public scalable_target_action(int? @maxCapacity = null,
                                          int? @minCapacity = null)
            {
                @MaxCapacity = @maxCapacity;
                @MinCapacity = @minCapacity;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "max_capacity", @out: false, min: 0, max: 1)]
            public int? @MaxCapacity { get; }

            [nterraform.TerraformProperty(name: "min_capacity", @out: false, min: 0, max: 1)]
            public int? @MinCapacity { get; }
        }

        public aws_appautoscaling_scheduled_action(string @name,
                                                   string @resourceId,
                                                   string @serviceNamespace,
                                                   string @endTime = null,
                                                   string @scalableDimension = null,
                                                   scalable_target_action[] @scalableTargetAction = null,
                                                   string @schedule = null,
                                                   string @startTime = null)
        {
            @Name = @name;
            @ResourceId = @resourceId;
            @ServiceNamespace = @serviceNamespace;
            @EndTime = @endTime;
            @ScalableDimension = @scalableDimension;
            @ScalableTargetAction = @scalableTargetAction;
            @Schedule = @schedule;
            @StartTime = @startTime;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.TerraformProperty(name: "service_namespace", @out: false, min: 1, max: 1)]
        public string @ServiceNamespace { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "end_time", @out: false, min: 0, max: 1)]
        public string @EndTime { get; }

        [nterraform.TerraformProperty(name: "scalable_dimension", @out: false, min: 0, max: 1)]
        public string @ScalableDimension { get; }

        [nterraform.TerraformProperty(name: "scalable_target_action", @out: false, min: 0, max: 1)]
        public scalable_target_action[] @ScalableTargetAction { get; }

        [nterraform.TerraformProperty(name: "schedule", @out: false, min: 0, max: 1)]
        public string @Schedule { get; }

        [nterraform.TerraformProperty(name: "start_time", @out: false, min: 0, max: 1)]
        public string @StartTime { get; }
    }

}
