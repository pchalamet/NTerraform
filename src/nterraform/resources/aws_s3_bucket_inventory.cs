using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_s3_bucket_inventory")]
    public sealed class aws_s3_bucket_inventory : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "schedule")]
        public sealed class schedule : nterraform.structure
        {
            public schedule(string @frequency)
            {
                @Frequency = @frequency;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
            public string @Frequency { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @prefix = null)
            {
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "destination")]
        public sealed class destination : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "bucket")]
            public sealed class bucket : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "encryption")]
                public sealed class encryption : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "sse_kms")]
                    public sealed class sse_kms : nterraform.structure
                    {
                        public sse_kms(string @keyId)
                        {
                            @KeyId = @keyId;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
                        public string @KeyId { get; }
                    }

                    [nterraform.TerraformStructure(category: "resource", typeName: "sse_s3")]
                    public sealed class sse_s3 : nterraform.structure
                    {
                        public sse_s3()
                        {
                            base._validate_();
                        }
                    }

                    public encryption(sse_kms[] @sseKms = null,
                                      sse_s3[] @sseS3 = null)
                    {
                        @SseKms = @sseKms;
                        @SseS3 = @sseS3;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "sse_kms", @out: false, min: 0, max: 1)]
                    public sse_kms[] @SseKms { get; }

                    [nterraform.TerraformProperty(name: "sse_s3", @out: false, min: 0, max: 1)]
                    public sse_s3[] @SseS3 { get; }
                }

                public bucket(string @bucketArn,
                              string @format,
                              string @accountId = null,
                              encryption[] @encryption = null,
                              string @prefix = null)
                {
                    @BucketArn = @bucketArn;
                    @Format = @format;
                    @AccountId = @accountId;
                    @Encryption = @encryption;
                    @Prefix = @prefix;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "bucket_arn", @out: false, min: 1, max: 1)]
                public string @BucketArn { get; }

                [nterraform.TerraformProperty(name: "format", @out: false, min: 1, max: 1)]
                public string @Format { get; }

                [nterraform.TerraformProperty(name: "account_id", @out: false, min: 0, max: 1)]
                public string @AccountId { get; }

                [nterraform.TerraformProperty(name: "encryption", @out: false, min: 0, max: 1)]
                public encryption[] @Encryption { get; }

                [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
                public string @Prefix { get; }
            }

            public destination(bucket[] @bucket)
            {
                @Bucket = @bucket;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
            public bucket[] @Bucket { get; }
        }

        public aws_s3_bucket_inventory(string @bucket,
                                       destination[] @destination,
                                       string @includedObjectVersions,
                                       string @name,
                                       schedule[] @schedule,
                                       bool? @enabled = null,
                                       filter[] @filter = null,
                                       string[] @optionalFields = null)
        {
            @Bucket = @bucket;
            @Destination = @destination;
            @IncludedObjectVersions = @includedObjectVersions;
            @Name = @name;
            @Schedule = @schedule;
            @Enabled = @enabled;
            @Filter = @filter;
            @OptionalFields = @optionalFields;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
        public destination[] @Destination { get; }

        [nterraform.TerraformProperty(name: "included_object_versions", @out: false, min: 1, max: 1)]
        public string @IncludedObjectVersions { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "schedule", @out: false, min: 1, max: 1)]
        public schedule[] @Schedule { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 1)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "optional_fields", @out: false, min: 0, max: 1)]
        public string[] @OptionalFields { get; }
    }

}
