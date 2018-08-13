using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cognito_user_group")]
    public sealed class aws_cognito_user_group : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
        public string @UserPoolId { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "precedence", @out: false, min: 0, max: 1)]
        public int? @Precedence { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
        public string @RoleArn { get; }
    }

}
