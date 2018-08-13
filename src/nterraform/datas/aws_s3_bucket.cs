using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_s3_bucket")]
    public sealed class aws_s3_bucket : nterraform.data
    {
        public aws_s3_bucket(string @bucket)
        {
            @Bucket = @bucket;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "bucket_domain_name", @out: true, min: 0, max: 1)]
        public string @BucketDomainName { get; }

        [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "website_domain", @out: true, min: 0, max: 1)]
        public string @WebsiteDomain { get; }

        [nterraform.TerraformProperty(name: "website_endpoint", @out: true, min: 0, max: 1)]
        public string @WebsiteEndpoint { get; }
    }

}
