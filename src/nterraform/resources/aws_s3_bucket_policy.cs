using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_s3_bucket_policy")]
    public sealed class aws_s3_bucket_policy : nterraform.Core.resource
    {
        public aws_s3_bucket_policy(string @bucket,
                                    string @policy)
        {
            @Bucket = @bucket;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }
    }

}
