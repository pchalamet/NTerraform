using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudfront_origin_access_identity")]
    public sealed class aws_cloudfront_origin_access_identity : nterraform.Core.resource
    {
        public aws_cloudfront_origin_access_identity(string @comment = null)
        {
            @Comment = @comment;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "caller_reference", @out: true, min: 0, max: 1)]
        public string @CallerReference { get; }

        [nterraform.Core.TerraformProperty(name: "cloudfront_access_identity_path", @out: true, min: 0, max: 1)]
        public string @CloudfrontAccessIdentityPath { get; }

        [nterraform.Core.TerraformProperty(name: "comment", @out: false, min: 0, max: 1)]
        public string @Comment { get; }

        [nterraform.Core.TerraformProperty(name: "etag", @out: true, min: 0, max: 1)]
        public string @Etag { get; }

        [nterraform.Core.TerraformProperty(name: "iam_arn", @out: true, min: 0, max: 1)]
        public string @IamArn { get; }

        [nterraform.Core.TerraformProperty(name: "s3_canonical_user_id", @out: true, min: 0, max: 1)]
        public string @S3CanonicalUserId { get; }
    }

}
