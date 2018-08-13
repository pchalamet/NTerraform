using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_s3_bucket")]
    public sealed class aws_s3_bucket : nterraform.Core.data
    {
        public aws_s3_bucket(string @bucket)
        {
            @Bucket = @bucket;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "bucket_domain_name", @out: true, min: 0, max: 1)]
        public string @BucketDomainName { get; }

        [nterraform.Core.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "website_domain", @out: true, min: 0, max: 1)]
        public string @WebsiteDomain { get; }

        [nterraform.Core.TerraformProperty(name: "website_endpoint", @out: true, min: 0, max: 1)]
        public string @WebsiteEndpoint { get; }
    }

}
