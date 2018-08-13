using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_macie_s3_bucket_association")]
    public sealed class aws_macie_s3_bucket_association : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "classification_type")]
        public sealed class classification_type : nterraform.structure
        {
            public classification_type(string @continuous = null,
                                       string @oneTime = null)
            {
                @Continuous = @continuous;
                @OneTime = @oneTime;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "continuous", @out: false, min: 0, max: 1)]
            public string @Continuous { get; }

            [nterraform.TerraformProperty(name: "one_time", @out: false, min: 0, max: 1)]
            public string @OneTime { get; }
        }

        public aws_macie_s3_bucket_association(string @bucketName,
                                               classification_type[] @classificationType = null,
                                               string @memberAccountId = null,
                                               string @prefix = null)
        {
            @BucketName = @bucketName;
            @ClassificationType = @classificationType;
            @MemberAccountId = @memberAccountId;
            @Prefix = @prefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket_name", @out: false, min: 1, max: 1)]
        public string @BucketName { get; }

        [nterraform.TerraformProperty(name: "classification_type", @out: false, min: 0, max: 1)]
        public classification_type[] @ClassificationType { get; }

        [nterraform.TerraformProperty(name: "member_account_id", @out: false, min: 0, max: 1)]
        public string @MemberAccountId { get; }

        [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
        public string @Prefix { get; }
    }

}
