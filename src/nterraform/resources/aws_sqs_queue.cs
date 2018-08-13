using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_sqs_queue")]
    public sealed class aws_sqs_queue : nterraform.resource
    {
        public aws_sqs_queue(bool? @contentBasedDeduplication = null,
                             int? @delaySeconds = null,
                             bool? @fifoQueue = null,
                             string @kmsMasterKeyId = null,
                             int? @maxMessageSize = null,
                             int? @messageRetentionSeconds = null,
                             string @namePrefix = null,
                             int? @receiveWaitTimeSeconds = null,
                             string @redrivePolicy = null,
                             Dictionary<string,string> @tags = null,
                             int? @visibilityTimeoutSeconds = null)
        {
            @ContentBasedDeduplication = @contentBasedDeduplication;
            @DelaySeconds = @delaySeconds;
            @FifoQueue = @fifoQueue;
            @KmsMasterKeyId = @kmsMasterKeyId;
            @MaxMessageSize = @maxMessageSize;
            @MessageRetentionSeconds = @messageRetentionSeconds;
            @NamePrefix = @namePrefix;
            @ReceiveWaitTimeSeconds = @receiveWaitTimeSeconds;
            @RedrivePolicy = @redrivePolicy;
            @Tags = @tags;
            @VisibilityTimeoutSeconds = @visibilityTimeoutSeconds;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "content_based_deduplication", @out: false, min: 0, max: 1)]
        public bool? @ContentBasedDeduplication { get; }

        [nterraform.TerraformProperty(name: "delay_seconds", @out: false, min: 0, max: 1)]
        public int? @DelaySeconds { get; }

        [nterraform.TerraformProperty(name: "fifo_queue", @out: false, min: 0, max: 1)]
        public bool? @FifoQueue { get; }

        [nterraform.TerraformProperty(name: "kms_data_key_reuse_period_seconds", @out: true, min: 0, max: 1)]
        public int? @KmsDataKeyReusePeriodSeconds { get; }

        [nterraform.TerraformProperty(name: "kms_master_key_id", @out: false, min: 0, max: 1)]
        public string @KmsMasterKeyId { get; }

        [nterraform.TerraformProperty(name: "max_message_size", @out: false, min: 0, max: 1)]
        public int? @MaxMessageSize { get; }

        [nterraform.TerraformProperty(name: "message_retention_seconds", @out: false, min: 0, max: 1)]
        public int? @MessageRetentionSeconds { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "receive_wait_time_seconds", @out: false, min: 0, max: 1)]
        public int? @ReceiveWaitTimeSeconds { get; }

        [nterraform.TerraformProperty(name: "redrive_policy", @out: false, min: 0, max: 1)]
        public string @RedrivePolicy { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "visibility_timeout_seconds", @out: false, min: 0, max: 1)]
        public int? @VisibilityTimeoutSeconds { get; }
    }

}
