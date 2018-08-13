using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_kinesis_stream")]
    public sealed class aws_kinesis_stream : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "shard_count", @out: false, min: 1, max: 1)]
        public int @ShardCount { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "encryption_type", @out: false, min: 0, max: 1)]
        public string @EncryptionType { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "retention_period", @out: false, min: 0, max: 1)]
        public int? @RetentionPeriod { get; }

        [nterraform.TerraformProperty(name: "shard_level_metrics", @out: false, min: 0, max: 1)]
        public string[] @ShardLevelMetrics { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
