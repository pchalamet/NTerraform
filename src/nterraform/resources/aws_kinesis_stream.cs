using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_kinesis_stream")]
    public sealed class aws_kinesis_stream : nterraform.Core.resource
    {
        public aws_kinesis_stream(string @name,
                                  int @shardCount,
                                  string @encryptionType = null,
                                  string @kmsKeyId = null,
                                  int? @retentionPeriod = null,
                                  string[] @shardLevelMetrics = null,
                                  Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @ShardCount = @shardCount;
            @EncryptionType = @encryptionType;
            @KmsKeyId = @kmsKeyId;
            @RetentionPeriod = @retentionPeriod;
            @ShardLevelMetrics = @shardLevelMetrics;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "shard_count", @out: false, min: 1, max: 1)]
        public int @ShardCount { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_type", @out: false, min: 0, max: 1)]
        public string @EncryptionType { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "retention_period", @out: false, min: 0, max: 1)]
        public int? @RetentionPeriod { get; }

        [nterraform.Core.TerraformProperty(name: "shard_level_metrics", @out: false, min: 0, max: 1)]
        public string[] @ShardLevelMetrics { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
