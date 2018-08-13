using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_opsworks_permission")]
    public sealed class aws_opsworks_permission : nterraform.Core.resource
    {
        public aws_opsworks_permission(string @userArn)
        {
            @UserArn = @userArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "user_arn", @out: false, min: 1, max: 1)]
        public string @UserArn { get; }

        [nterraform.Core.TerraformProperty(name: "allow_ssh", @out: true, min: 0, max: 1)]
        public bool? @AllowSsh { get; }

        [nterraform.Core.TerraformProperty(name: "allow_sudo", @out: true, min: 0, max: 1)]
        public bool? @AllowSudo { get; }

        [nterraform.Core.TerraformProperty(name: "level", @out: true, min: 0, max: 1)]
        public string @Level { get; }

        [nterraform.Core.TerraformProperty(name: "stack_id", @out: true, min: 0, max: 1)]
        public string @StackId { get; }
    }

}
