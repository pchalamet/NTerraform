using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_destination")]
    public sealed class aws_cloudwatch_log_destination : nterraform.resource
    {
        public aws_cloudwatch_log_destination(string @name,
                                              string @roleArn,
                                              string @targetArn)
        {
            @Name = @name;
            @RoleArn = @roleArn;
            @TargetArn = @targetArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "target_arn", @out: false, min: 1, max: 1)]
        public string @TargetArn { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
