using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cognito_user_pool_domain")]
    public sealed class aws_cognito_user_pool_domain : nterraform.resource
    {
        public aws_cognito_user_pool_domain(string @domain,
                                            string @userPoolId)
        {
            @Domain = @domain;
            @UserPoolId = @userPoolId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain", @out: false, min: 1, max: 1)]
        public string @Domain { get; }

        [nterraform.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
        public string @UserPoolId { get; }

        [nterraform.TerraformProperty(name: "aws_account_id", @out: true, min: 0, max: 1)]
        public string @AwsAccountId { get; }

        [nterraform.TerraformProperty(name: "cloudfront_distribution_arn", @out: true, min: 0, max: 1)]
        public string @CloudfrontDistributionArn { get; }

        [nterraform.TerraformProperty(name: "s3_bucket", @out: true, min: 0, max: 1)]
        public string @S3Bucket { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
