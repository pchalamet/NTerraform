using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_s3_bucket_inventory")]
    public sealed class aws_s3_bucket_inventory : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "schedule")]
        public sealed class schedule : nterraform.Core.structure
        {
            public schedule(string @frequency)
            {
                @Frequency = @frequency;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
            public string @Frequency { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @prefix = null)
            {
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "destination")]
        public sealed class destination : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "bucket")]
            public sealed class bucket : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "encryption")]
                public sealed class encryption : nterraform.Core.structure
                {
                    [nterraform.Core.TerraformStructure(category: "resource", typeName: "sse_s3")]
                    public sealed class sse_s3 : nterraform.Core.structure
                    {
                        public sse_s3()
                        {
                            base._validate_();
                        }
                    }

                    [nterraform.Core.TerraformStructure(category: "resource", typeName: "sse_kms")]
                    public sealed class sse_kms : nterraform.Core.structure
                    {
                        public sse_kms(string @keyId)
                        {
                            @KeyId = @keyId;
                            base._validate_();
                        }

                        [nterraform.Core.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
                        public string @KeyId { get; }
                    }

                    public encryption(sse_kms[] @sseKms = null,
                                      sse_s3[] @sseS3 = null)
                    {
                        @SseKms = @sseKms;
                        @SseS3 = @sseS3;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "sse_kms", @out: false, min: 0, max: 1)]
                    public sse_kms[] @SseKms { get; }

                    [nterraform.Core.TerraformProperty(name: "sse_s3", @out: false, min: 0, max: 1)]
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

                [nterraform.Core.TerraformProperty(name: "bucket_arn", @out: false, min: 1, max: 1)]
                public string @BucketArn { get; }

                [nterraform.Core.TerraformProperty(name: "format", @out: false, min: 1, max: 1)]
                public string @Format { get; }

                [nterraform.Core.TerraformProperty(name: "account_id", @out: false, min: 0, max: 1)]
                public string @AccountId { get; }

                [nterraform.Core.TerraformProperty(name: "encryption", @out: false, min: 0, max: 1)]
                public encryption[] @Encryption { get; }

                [nterraform.Core.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
                public string @Prefix { get; }
            }

            public destination(bucket[] @bucket)
            {
                @Bucket = @bucket;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.Core.TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
        public destination[] @Destination { get; }

        [nterraform.Core.TerraformProperty(name: "included_object_versions", @out: false, min: 1, max: 1)]
        public string @IncludedObjectVersions { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "schedule", @out: false, min: 1, max: 1)]
        public schedule[] @Schedule { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 1)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "optional_fields", @out: false, min: 0, max: 1)]
        public string[] @OptionalFields { get; }
    }

}
