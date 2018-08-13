using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_s3_bucket_object")]
    public sealed class aws_s3_bucket_object : nterraform.resource
    {
        public aws_s3_bucket_object(string @bucket,
                                    string @key,
                                    string @acl = null,
                                    string @cacheControl = null,
                                    string @content = null,
                                    string @contentBase64 = null,
                                    string @contentDisposition = null,
                                    string @contentEncoding = null,
                                    string @contentLanguage = null,
                                    string @kmsKeyId = null,
                                    string @source = null,
                                    Dictionary<string,string> @tags = null,
                                    string @websiteRedirect = null)
        {
            @Bucket = @bucket;
            @Key = @key;
            @Acl = @acl;
            @CacheControl = @cacheControl;
            @Content = @content;
            @ContentBase64 = @contentBase64;
            @ContentDisposition = @contentDisposition;
            @ContentEncoding = @contentEncoding;
            @ContentLanguage = @contentLanguage;
            @KmsKeyId = @kmsKeyId;
            @Source = @source;
            @Tags = @tags;
            @WebsiteRedirect = @websiteRedirect;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
        public string @Key { get; }

        [nterraform.TerraformProperty(name: "acl", @out: false, min: 0, max: 1)]
        public string @Acl { get; }

        [nterraform.TerraformProperty(name: "cache_control", @out: false, min: 0, max: 1)]
        public string @CacheControl { get; }

        [nterraform.TerraformProperty(name: "content", @out: false, min: 0, max: 1)]
        public string @Content { get; }

        [nterraform.TerraformProperty(name: "content_base64", @out: false, min: 0, max: 1)]
        public string @ContentBase64 { get; }

        [nterraform.TerraformProperty(name: "content_disposition", @out: false, min: 0, max: 1)]
        public string @ContentDisposition { get; }

        [nterraform.TerraformProperty(name: "content_encoding", @out: false, min: 0, max: 1)]
        public string @ContentEncoding { get; }

        [nterraform.TerraformProperty(name: "content_language", @out: false, min: 0, max: 1)]
        public string @ContentLanguage { get; }

        [nterraform.TerraformProperty(name: "content_type", @out: true, min: 0, max: 1)]
        public string @ContentType { get; }

        [nterraform.TerraformProperty(name: "etag", @out: true, min: 0, max: 1)]
        public string @Etag { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "server_side_encryption", @out: true, min: 0, max: 1)]
        public string @ServerSideEncryption { get; }

        [nterraform.TerraformProperty(name: "source", @out: false, min: 0, max: 1)]
        public string @Source { get; }

        [nterraform.TerraformProperty(name: "storage_class", @out: true, min: 0, max: 1)]
        public string @StorageClass { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "version_id", @out: true, min: 0, max: 1)]
        public string @VersionId { get; }

        [nterraform.TerraformProperty(name: "website_redirect", @out: false, min: 0, max: 1)]
        public string @WebsiteRedirect { get; }
    }

}
