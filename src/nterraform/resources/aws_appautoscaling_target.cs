using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_appautoscaling_target")]
    public sealed class aws_appautoscaling_target : nterraform.resource
    {
        public aws_appautoscaling_target(int @maxCapacity,
                                         int @minCapacity,
                                         string @resourceId,
                                         string @scalableDimension,
                                         string @serviceNamespace)
        {
            @MaxCapacity = @maxCapacity;
            @MinCapacity = @minCapacity;
            @ResourceId = @resourceId;
            @ScalableDimension = @scalableDimension;
            @ServiceNamespace = @serviceNamespace;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "max_capacity", @out: false, min: 1, max: 1)]
        public int @MaxCapacity { get; }

        [nterraform.TerraformProperty(name: "min_capacity", @out: false, min: 1, max: 1)]
        public int @MinCapacity { get; }

        [nterraform.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.TerraformProperty(name: "scalable_dimension", @out: false, min: 1, max: 1)]
        public string @ScalableDimension { get; }

        [nterraform.TerraformProperty(name: "service_namespace", @out: false, min: 1, max: 1)]
        public string @ServiceNamespace { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: true, min: 0, max: 1)]
        public string @RoleArn { get; }
    }

}
