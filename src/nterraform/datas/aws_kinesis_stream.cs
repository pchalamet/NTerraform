using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_kinesis_stream")]
    public sealed class aws_kinesis_stream : nterraform.Core.data
    {
        public aws_kinesis_stream(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "closed_shards", @out: true, min: 0, max: 1)]
        public string[] @ClosedShards { get; }

        [nterraform.Core.TerraformProperty(name: "creation_timestamp", @out: true, min: 0, max: 1)]
        public int? @CreationTimestamp { get; }

        [nterraform.Core.TerraformProperty(name: "open_shards", @out: true, min: 0, max: 1)]
        public string[] @OpenShards { get; }

        [nterraform.Core.TerraformProperty(name: "retention_period", @out: true, min: 0, max: 1)]
        public int? @RetentionPeriod { get; }

        [nterraform.Core.TerraformProperty(name: "shard_level_metrics", @out: true, min: 0, max: 1)]
        public string[] @ShardLevelMetrics { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
