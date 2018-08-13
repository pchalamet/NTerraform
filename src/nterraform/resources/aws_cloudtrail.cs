using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudtrail")]
    public sealed class aws_cloudtrail : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "event_selector")]
        public sealed class event_selector : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "data_resource")]
            public sealed class data_resource : nterraform.Core.structure
            {
                public data_resource(string @type,
                                     string[] @values)
                {
                    @Type = @type;
                    @Values = @values;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }

                [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
                public string[] @Values { get; }
            }

            public event_selector(data_resource[] @dataResource = null,
                                  bool? @includeManagementEvents = null,
                                  string @readWriteType = null)
            {
                @DataResource = @dataResource;
                @IncludeManagementEvents = @includeManagementEvents;
                @ReadWriteType = @readWriteType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "data_resource", @out: false, min: 0, max: 0)]
            public data_resource[] @DataResource { get; }

            [nterraform.Core.TerraformProperty(name: "include_management_events", @out: false, min: 0, max: 1)]
            public bool? @IncludeManagementEvents { get; }

            [nterraform.Core.TerraformProperty(name: "read_write_type", @out: false, min: 0, max: 1)]
            public string @ReadWriteType { get; }
        }

        public aws_cloudtrail(string @name,
                              string @s3BucketName,
                              string @cloudWatchLogsGroupArn = null,
                              string @cloudWatchLogsRoleArn = null,
                              bool? @enableLogFileValidation = null,
                              bool? @enableLogging = null,
                              event_selector[] @eventSelector = null,
                              bool? @includeGlobalServiceEvents = null,
                              bool? @isMultiRegionTrail = null,
                              string @kmsKeyId = null,
                              string @s3KeyPrefix = null,
                              string @snsTopicName = null,
                              Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @S3BucketName = @s3BucketName;
            @CloudWatchLogsGroupArn = @cloudWatchLogsGroupArn;
            @CloudWatchLogsRoleArn = @cloudWatchLogsRoleArn;
            @EnableLogFileValidation = @enableLogFileValidation;
            @EnableLogging = @enableLogging;
            @EventSelector = @eventSelector;
            @IncludeGlobalServiceEvents = @includeGlobalServiceEvents;
            @IsMultiRegionTrail = @isMultiRegionTrail;
            @KmsKeyId = @kmsKeyId;
            @S3KeyPrefix = @s3KeyPrefix;
            @SnsTopicName = @snsTopicName;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "s3_bucket_name", @out: false, min: 1, max: 1)]
        public string @S3BucketName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cloud_watch_logs_group_arn", @out: false, min: 0, max: 1)]
        public string @CloudWatchLogsGroupArn { get; }

        [nterraform.Core.TerraformProperty(name: "cloud_watch_logs_role_arn", @out: false, min: 0, max: 1)]
        public string @CloudWatchLogsRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "enable_log_file_validation", @out: false, min: 0, max: 1)]
        public bool? @EnableLogFileValidation { get; }

        [nterraform.Core.TerraformProperty(name: "enable_logging", @out: false, min: 0, max: 1)]
        public bool? @EnableLogging { get; }

        [nterraform.Core.TerraformProperty(name: "event_selector", @out: false, min: 0, max: 5)]
        public event_selector[] @EventSelector { get; }

        [nterraform.Core.TerraformProperty(name: "home_region", @out: true, min: 0, max: 1)]
        public string @HomeRegion { get; }

        [nterraform.Core.TerraformProperty(name: "include_global_service_events", @out: false, min: 0, max: 1)]
        public bool? @IncludeGlobalServiceEvents { get; }

        [nterraform.Core.TerraformProperty(name: "is_multi_region_trail", @out: false, min: 0, max: 1)]
        public bool? @IsMultiRegionTrail { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "s3_key_prefix", @out: false, min: 0, max: 1)]
        public string @S3KeyPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "sns_topic_name", @out: false, min: 0, max: 1)]
        public string @SnsTopicName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
