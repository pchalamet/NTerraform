using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sqs_queue")]
    public sealed class aws_sqs_queue : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "content_based_deduplication", @out: false, min: 0, max: 1)]
        public bool? @ContentBasedDeduplication { get; }

        [nterraform.Core.TerraformProperty(name: "delay_seconds", @out: false, min: 0, max: 1)]
        public int? @DelaySeconds { get; }

        [nterraform.Core.TerraformProperty(name: "fifo_queue", @out: false, min: 0, max: 1)]
        public bool? @FifoQueue { get; }

        [nterraform.Core.TerraformProperty(name: "kms_data_key_reuse_period_seconds", @out: true, min: 0, max: 1)]
        public int? @KmsDataKeyReusePeriodSeconds { get; }

        [nterraform.Core.TerraformProperty(name: "kms_master_key_id", @out: false, min: 0, max: 1)]
        public string @KmsMasterKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "max_message_size", @out: false, min: 0, max: 1)]
        public int? @MaxMessageSize { get; }

        [nterraform.Core.TerraformProperty(name: "message_retention_seconds", @out: false, min: 0, max: 1)]
        public int? @MessageRetentionSeconds { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "receive_wait_time_seconds", @out: false, min: 0, max: 1)]
        public int? @ReceiveWaitTimeSeconds { get; }

        [nterraform.Core.TerraformProperty(name: "redrive_policy", @out: false, min: 0, max: 1)]
        public string @RedrivePolicy { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "visibility_timeout_seconds", @out: false, min: 0, max: 1)]
        public int? @VisibilityTimeoutSeconds { get; }
    }

}
