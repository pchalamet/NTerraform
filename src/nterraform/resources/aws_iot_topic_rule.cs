using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iot_topic_rule")]
    public sealed class aws_iot_topic_rule : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cloudwatch_alarm")]
        public sealed class cloudwatch_alarm : nterraform.Core.structure
        {
            public cloudwatch_alarm(string @alarmName,
                                    string @roleArn,
                                    string @stateReason,
                                    string @stateValue)
            {
                @AlarmName = @alarmName;
                @RoleArn = @roleArn;
                @StateReason = @stateReason;
                @StateValue = @stateValue;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "alarm_name", @out: false, min: 1, max: 1)]
            public string @AlarmName { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "state_reason", @out: false, min: 1, max: 1)]
            public string @StateReason { get; }

            [nterraform.Core.TerraformProperty(name: "state_value", @out: false, min: 1, max: 1)]
            public string @StateValue { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "s3")]
        public sealed class s3 : nterraform.Core.structure
        {
            public s3(string @bucketName,
                      string @key,
                      string @roleArn)
            {
                @BucketName = @bucketName;
                @Key = @key;
                @RoleArn = @roleArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket_name", @out: false, min: 1, max: 1)]
            public string @BucketName { get; }

            [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "kinesis")]
        public sealed class kinesis : nterraform.Core.structure
        {
            public kinesis(string @roleArn,
                           string @streamName,
                           string @partitionKey = null)
            {
                @RoleArn = @roleArn;
                @StreamName = @streamName;
                @PartitionKey = @partitionKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "stream_name", @out: false, min: 1, max: 1)]
            public string @StreamName { get; }

            [nterraform.Core.TerraformProperty(name: "partition_key", @out: false, min: 0, max: 1)]
            public string @PartitionKey { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sqs")]
        public sealed class sqs : nterraform.Core.structure
        {
            public sqs(string @queueUrl,
                       string @roleArn,
                       bool @useBase64)
            {
                @QueueUrl = @queueUrl;
                @RoleArn = @roleArn;
                @UseBase64 = @useBase64;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "queue_url", @out: false, min: 1, max: 1)]
            public string @QueueUrl { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "use_base64", @out: false, min: 1, max: 1)]
            public bool @UseBase64 { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "firehose")]
        public sealed class firehose : nterraform.Core.structure
        {
            public firehose(string @deliveryStreamName,
                            string @roleArn)
            {
                @DeliveryStreamName = @deliveryStreamName;
                @RoleArn = @roleArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "delivery_stream_name", @out: false, min: 1, max: 1)]
            public string @DeliveryStreamName { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "republish")]
        public sealed class republish : nterraform.Core.structure
        {
            public republish(string @roleArn,
                             string @topic)
            {
                @RoleArn = @roleArn;
                @Topic = @topic;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "topic", @out: false, min: 1, max: 1)]
            public string @Topic { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "lambda")]
        public sealed class lambda : nterraform.Core.structure
        {
            public lambda(string @functionArn)
            {
                @FunctionArn = @functionArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "function_arn", @out: false, min: 1, max: 1)]
            public string @FunctionArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cloudwatch_metric")]
        public sealed class cloudwatch_metric : nterraform.Core.structure
        {
            public cloudwatch_metric(string @metricName,
                                     string @metricNamespace,
                                     string @metricUnit,
                                     string @metricValue,
                                     string @roleArn,
                                     string @metricTimestamp = null)
            {
                @MetricName = @metricName;
                @MetricNamespace = @metricNamespace;
                @MetricUnit = @metricUnit;
                @MetricValue = @metricValue;
                @RoleArn = @roleArn;
                @MetricTimestamp = @metricTimestamp;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
            public string @MetricName { get; }

            [nterraform.Core.TerraformProperty(name: "metric_namespace", @out: false, min: 1, max: 1)]
            public string @MetricNamespace { get; }

            [nterraform.Core.TerraformProperty(name: "metric_unit", @out: false, min: 1, max: 1)]
            public string @MetricUnit { get; }

            [nterraform.Core.TerraformProperty(name: "metric_value", @out: false, min: 1, max: 1)]
            public string @MetricValue { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "metric_timestamp", @out: false, min: 0, max: 1)]
            public string @MetricTimestamp { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sns")]
        public sealed class sns : nterraform.Core.structure
        {
            public sns(string @roleArn,
                       string @targetArn,
                       string @messageFormat = null)
            {
                @RoleArn = @roleArn;
                @TargetArn = @targetArn;
                @MessageFormat = @messageFormat;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "target_arn", @out: false, min: 1, max: 1)]
            public string @TargetArn { get; }

            [nterraform.Core.TerraformProperty(name: "message_format", @out: false, min: 0, max: 1)]
            public string @MessageFormat { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "elasticsearch")]
        public sealed class elasticsearch : nterraform.Core.structure
        {
            public elasticsearch(string @endpoint,
                                 string @id,
                                 string @index,
                                 string @roleArn,
                                 string @type)
            {
                @Endpoint = @endpoint;
                @Id = @id;
                @Index = @index;
                @RoleArn = @roleArn;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "endpoint", @out: false, min: 1, max: 1)]
            public string @Endpoint { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: false, min: 1, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "index", @out: false, min: 1, max: 1)]
            public string @Index { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "dynamodb")]
        public sealed class dynamodb : nterraform.Core.structure
        {
            public dynamodb(string @hashKeyField,
                            string @hashKeyValue,
                            string @rangeKeyField,
                            string @rangeKeyValue,
                            string @roleArn,
                            string @tableName,
                            string @hashKeyType = null,
                            string @payloadField = null,
                            string @rangeKeyType = null)
            {
                @HashKeyField = @hashKeyField;
                @HashKeyValue = @hashKeyValue;
                @RangeKeyField = @rangeKeyField;
                @RangeKeyValue = @rangeKeyValue;
                @RoleArn = @roleArn;
                @TableName = @tableName;
                @HashKeyType = @hashKeyType;
                @PayloadField = @payloadField;
                @RangeKeyType = @rangeKeyType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "hash_key_field", @out: false, min: 1, max: 1)]
            public string @HashKeyField { get; }

            [nterraform.Core.TerraformProperty(name: "hash_key_value", @out: false, min: 1, max: 1)]
            public string @HashKeyValue { get; }

            [nterraform.Core.TerraformProperty(name: "range_key_field", @out: false, min: 1, max: 1)]
            public string @RangeKeyField { get; }

            [nterraform.Core.TerraformProperty(name: "range_key_value", @out: false, min: 1, max: 1)]
            public string @RangeKeyValue { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "table_name", @out: false, min: 1, max: 1)]
            public string @TableName { get; }

            [nterraform.Core.TerraformProperty(name: "hash_key_type", @out: false, min: 0, max: 1)]
            public string @HashKeyType { get; }

            [nterraform.Core.TerraformProperty(name: "payload_field", @out: false, min: 0, max: 1)]
            public string @PayloadField { get; }

            [nterraform.Core.TerraformProperty(name: "range_key_type", @out: false, min: 0, max: 1)]
            public string @RangeKeyType { get; }
        }

        public aws_iot_topic_rule(bool @enabled,
                                  string @name,
                                  string @sql,
                                  string @sqlVersion,
                                  cloudwatch_alarm[] @cloudwatchAlarm = null,
                                  cloudwatch_metric[] @cloudwatchMetric = null,
                                  string @description = null,
                                  dynamodb[] @dynamodb = null,
                                  elasticsearch[] @elasticsearch = null,
                                  firehose[] @firehose = null,
                                  kinesis[] @kinesis = null,
                                  lambda[] @lambda = null,
                                  republish[] @republish = null,
                                  s3[] @s3 = null,
                                  sns[] @sns = null,
                                  sqs[] @sqs = null)
        {
            @Enabled = @enabled;
            @Name = @name;
            @Sql = @sql;
            @SqlVersion = @sqlVersion;
            @CloudwatchAlarm = @cloudwatchAlarm;
            @CloudwatchMetric = @cloudwatchMetric;
            @Description = @description;
            @Dynamodb = @dynamodb;
            @Elasticsearch = @elasticsearch;
            @Firehose = @firehose;
            @Kinesis = @kinesis;
            @Lambda = @lambda;
            @Republish = @republish;
            @S3 = @s3;
            @Sns = @sns;
            @Sqs = @sqs;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
        public bool @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "sql", @out: false, min: 1, max: 1)]
        public string @Sql { get; }

        [nterraform.Core.TerraformProperty(name: "sql_version", @out: false, min: 1, max: 1)]
        public string @SqlVersion { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cloudwatch_alarm", @out: false, min: 0, max: 0)]
        public cloudwatch_alarm[] @CloudwatchAlarm { get; }

        [nterraform.Core.TerraformProperty(name: "cloudwatch_metric", @out: false, min: 0, max: 0)]
        public cloudwatch_metric[] @CloudwatchMetric { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "dynamodb", @out: false, min: 0, max: 0)]
        public dynamodb[] @Dynamodb { get; }

        [nterraform.Core.TerraformProperty(name: "elasticsearch", @out: false, min: 0, max: 0)]
        public elasticsearch[] @Elasticsearch { get; }

        [nterraform.Core.TerraformProperty(name: "firehose", @out: false, min: 0, max: 0)]
        public firehose[] @Firehose { get; }

        [nterraform.Core.TerraformProperty(name: "kinesis", @out: false, min: 0, max: 0)]
        public kinesis[] @Kinesis { get; }

        [nterraform.Core.TerraformProperty(name: "lambda", @out: false, min: 0, max: 0)]
        public lambda[] @Lambda { get; }

        [nterraform.Core.TerraformProperty(name: "republish", @out: false, min: 0, max: 0)]
        public republish[] @Republish { get; }

        [nterraform.Core.TerraformProperty(name: "s3", @out: false, min: 0, max: 0)]
        public s3[] @S3 { get; }

        [nterraform.Core.TerraformProperty(name: "sns", @out: false, min: 0, max: 0)]
        public sns[] @Sns { get; }

        [nterraform.Core.TerraformProperty(name: "sqs", @out: false, min: 0, max: 0)]
        public sqs[] @Sqs { get; }
    }

}
