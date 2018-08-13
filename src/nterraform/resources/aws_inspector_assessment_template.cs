using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_inspector_assessment_template")]
    public sealed class aws_inspector_assessment_template : nterraform.resource
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

        [nterraform.TerraformProperty(name: "duration", @out: false, min: 1, max: 1)]
        public int @Duration { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "rules_package_arns", @out: false, min: 1, max: 1)]
        public string[] @RulesPackageArns { get; }

        [nterraform.TerraformProperty(name: "target_arn", @out: false, min: 1, max: 1)]
        public string @TargetArn { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
