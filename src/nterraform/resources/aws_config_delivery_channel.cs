using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_config_delivery_channel")]
    public sealed class aws_config_delivery_channel : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "snapshot_delivery_properties")]
        public sealed class snapshot_delivery_properties : nterraform.structure
        {
            public snapshot_delivery_properties(string @deliveryFrequency = null)
            {
                @DeliveryFrequency = @deliveryFrequency;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "delivery_frequency", @out: false, min: 0, max: 1)]
            public string @DeliveryFrequency { get; }
        }

        public aws_config_delivery_channel(string @s3BucketName,
                                           string @name = null,
                                           string @s3KeyPrefix = null,
                                           snapshot_delivery_properties[] @snapshotDeliveryProperties = null,
                                           string @snsTopicArn = null)
        {
            @S3BucketName = @s3BucketName;
            @Name = @name;
            @S3KeyPrefix = @s3KeyPrefix;
            @SnapshotDeliveryProperties = @snapshotDeliveryProperties;
            @SnsTopicArn = @snsTopicArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "s3_bucket_name", @out: false, min: 1, max: 1)]
        public string @S3BucketName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "s3_key_prefix", @out: false, min: 0, max: 1)]
        public string @S3KeyPrefix { get; }

        [nterraform.TerraformProperty(name: "snapshot_delivery_properties", @out: false, min: 0, max: 1)]
        public snapshot_delivery_properties[] @SnapshotDeliveryProperties { get; }

        [nterraform.TerraformProperty(name: "sns_topic_arn", @out: false, min: 0, max: 1)]
        public string @SnsTopicArn { get; }
    }

}
