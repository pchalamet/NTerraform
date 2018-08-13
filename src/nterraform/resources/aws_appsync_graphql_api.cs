using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_appsync_graphql_api")]
    public sealed class aws_appsync_graphql_api : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "user_pool_config")]
        public sealed class user_pool_config : nterraform.Core.structure
        {
            public user_pool_config(string @awsRegion,
                                    string @defaultAction,
                                    string @userPoolId,
                                    string @appIdClientRegex = null)
            {
                @AwsRegion = @awsRegion;
                @DefaultAction = @defaultAction;
                @UserPoolId = @userPoolId;
                @AppIdClientRegex = @appIdClientRegex;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "aws_region", @out: false, min: 1, max: 1)]
            public string @AwsRegion { get; }

            [nterraform.Core.TerraformProperty(name: "default_action", @out: false, min: 1, max: 1)]
            public string @DefaultAction { get; }

            [nterraform.Core.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
            public string @UserPoolId { get; }

            [nterraform.Core.TerraformProperty(name: "app_id_client_regex", @out: false, min: 0, max: 1)]
            public string @AppIdClientRegex { get; }
        }

        public aws_appsync_graphql_api(string @authenticationType,
                                       string @name,
                                       user_pool_config[] @userPoolConfig = null)
        {
            @AuthenticationType = @authenticationType;
            @Name = @name;
            @UserPoolConfig = @userPoolConfig;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "authentication_type", @out: false, min: 1, max: 1)]
        public string @AuthenticationType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "user_pool_config", @out: false, min: 0, max: 1)]
        public user_pool_config[] @UserPoolConfig { get; }
    }

}
