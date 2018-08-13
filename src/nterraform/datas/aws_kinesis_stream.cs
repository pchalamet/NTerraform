using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_kinesis_stream")]
    public sealed class aws_kinesis_stream : nterraform.data
    {
        public aws_kinesis_stream(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "closed_shards", @out: true, min: 0, max: 1)]
        public string[] @ClosedShards { get; }

        [nterraform.TerraformProperty(name: "creation_timestamp", @out: true, min: 0, max: 1)]
        public int? @CreationTimestamp { get; }

        [nterraform.TerraformProperty(name: "open_shards", @out: true, min: 0, max: 1)]
        public string[] @OpenShards { get; }

        [nterraform.TerraformProperty(name: "retention_period", @out: true, min: 0, max: 1)]
        public int? @RetentionPeriod { get; }

        [nterraform.TerraformProperty(name: "shard_level_metrics", @out: true, min: 0, max: 1)]
        public string[] @ShardLevelMetrics { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
