using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cognito_user_group")]
    public sealed class aws_cognito_user_group : nterraform.Core.resource
    {
        public aws_cognito_user_group(string @name,
                                      string @userPoolId,
                                      string @description = null,
                                      int? @precedence = null,
                                      string @roleArn = null)
        {
            @Name = @name;
            @UserPoolId = @userPoolId;
            @Description = @description;
            @Precedence = @precedence;
            @RoleArn = @roleArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
        public string @UserPoolId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "precedence", @out: false, min: 0, max: 1)]
        public int? @Precedence { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
        public string @RoleArn { get; }
    }

}
