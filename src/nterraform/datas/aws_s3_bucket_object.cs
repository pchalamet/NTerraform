using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_s3_bucket_object")]
    public sealed class aws_s3_bucket_object : nterraform.Core.data
    {
        public aws_s3_bucket_object(string @bucket,
                                    string @key,
                                    string @range = null)
        {
            @Bucket = @bucket;
            @Key = @key;
            @Range = @range;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
        public string @Key { get; }

        [nterraform.Core.TerraformProperty(name: "body", @out: true, min: 0, max: 1)]
        public string @Body { get; }

        [nterraform.Core.TerraformProperty(name: "cache_control", @out: true, min: 0, max: 1)]
        public string @CacheControl { get; }

        [nterraform.Core.TerraformProperty(name: "content_disposition", @out: true, min: 0, max: 1)]
        public string @ContentDisposition { get; }

        [nterraform.Core.TerraformProperty(name: "content_encoding", @out: true, min: 0, max: 1)]
        public string @ContentEncoding { get; }

        [nterraform.Core.TerraformProperty(name: "content_language", @out: true, min: 0, max: 1)]
        public string @ContentLanguage { get; }

        [nterraform.Core.TerraformProperty(name: "content_length", @out: true, min: 0, max: 1)]
        public int? @ContentLength { get; }

        [nterraform.Core.TerraformProperty(name: "content_type", @out: true, min: 0, max: 1)]
        public string @ContentType { get; }

        [nterraform.Core.TerraformProperty(name: "etag", @out: true, min: 0, max: 1)]
        public string @Etag { get; }

        [nterraform.Core.TerraformProperty(name: "expiration", @out: true, min: 0, max: 1)]
        public string @Expiration { get; }

        [nterraform.Core.TerraformProperty(name: "expires", @out: true, min: 0, max: 1)]
        public string @Expires { get; }

        [nterraform.Core.TerraformProperty(name: "last_modified", @out: true, min: 0, max: 1)]
        public string @LastModified { get; }

        [nterraform.Core.TerraformProperty(name: "metadata", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Metadata { get; }

        [nterraform.Core.TerraformProperty(name: "range", @out: false, min: 0, max: 1)]
        public string @Range { get; }

        [nterraform.Core.TerraformProperty(name: "server_side_encryption", @out: true, min: 0, max: 1)]
        public string @ServerSideEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "sse_kms_key_id", @out: true, min: 0, max: 1)]
        public string @SseKmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "storage_class", @out: true, min: 0, max: 1)]
        public string @StorageClass { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "version_id", @out: true, min: 0, max: 1)]
        public string @VersionId { get; }

        [nterraform.Core.TerraformProperty(name: "website_redirect_location", @out: true, min: 0, max: 1)]
        public string @WebsiteRedirectLocation { get; }
    }

}
