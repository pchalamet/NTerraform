using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_sfn_state_machine")]
    public sealed class aws_sfn_state_machine : nterraform.resource
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

        [nterraform.TerraformProperty(name: "definition", @out: false, min: 1, max: 1)]
        public string @Definition { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
