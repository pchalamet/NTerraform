using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_inspector_assessment_target")]
    public sealed class aws_inspector_assessment_target : nterraform.resource
    {
        public aws_inspector_assessment_target(string @name,
                                               string @resourceGroupArn)
        {
            @Name = @name;
            @ResourceGroupArn = @resourceGroupArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_arn", @out: false, min: 1, max: 1)]
        public string @ResourceGroupArn { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
