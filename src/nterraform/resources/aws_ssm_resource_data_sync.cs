using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_resource_data_sync")]
    public sealed class aws_ssm_resource_data_sync : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "s3_destination")]
        public sealed class s3_destination : nterraform.structure
        {
            public s3_destination(string @bucketName,
                                  string @region,
                                  string @kmsKeyArn = null,
                                  string @prefix = null,
                                  string @syncFormat = null)
            {
                @BucketName = @bucketName;
                @Region = @region;
                @KmsKeyArn = @kmsKeyArn;
                @Prefix = @prefix;
                @SyncFormat = @syncFormat;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket_name", @out: false, min: 1, max: 1)]
            public string @BucketName { get; }

            [nterraform.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
            public string @Region { get; }

            [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
            public string @KmsKeyArn { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }

            [nterraform.TerraformProperty(name: "sync_format", @out: false, min: 0, max: 1)]
            public string @SyncFormat { get; }
        }

        public aws_ssm_resource_data_sync(string @name,
                                          s3_destination[] @s3Destination)
        {
            @Name = @name;
            @S3Destination = @s3Destination;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "s3_destination", @out: false, min: 1, max: 1)]
        public s3_destination[] @S3Destination { get; }
    }

}
