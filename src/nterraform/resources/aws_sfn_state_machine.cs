using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sfn_state_machine")]
    public sealed class aws_sfn_state_machine : nterraform.Core.resource
    {
        public aws_sfn_state_machine(string @definition,
                                     string @name,
                                     string @roleArn)
        {
            @Definition = @definition;
            @Name = @name;
            @RoleArn = @roleArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "definition", @out: false, min: 1, max: 1)]
        public string @Definition { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
