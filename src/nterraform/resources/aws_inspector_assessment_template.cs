using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_inspector_assessment_template")]
    public sealed class aws_inspector_assessment_template : nterraform.Core.resource
    {
        public aws_inspector_assessment_template(int @duration,
                                                 string @name,
                                                 string[] @rulesPackageArns,
                                                 string @targetArn)
        {
            @Duration = @duration;
            @Name = @name;
            @RulesPackageArns = @rulesPackageArns;
            @TargetArn = @targetArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "duration", @out: false, min: 1, max: 1)]
        public int @Duration { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "rules_package_arns", @out: false, min: 1, max: 1)]
        public string[] @RulesPackageArns { get; }

        [nterraform.Core.TerraformProperty(name: "target_arn", @out: false, min: 1, max: 1)]
        public string @TargetArn { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
