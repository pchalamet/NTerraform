using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dms_replication_task")]
    public sealed class aws_dms_replication_task : nterraform.Core.resource
    {
        public aws_dms_replication_task(string @migrationType,
                                        string @replicationInstanceArn,
                                        string @replicationTaskId,
                                        string @sourceEndpointArn,
                                        string @tableMappings,
                                        string @targetEndpointArn,
                                        string @cdcStartTime = null,
                                        string @replicationTaskSettings = null,
                                        Dictionary<string,string> @tags = null)
        {
            @MigrationType = @migrationType;
            @ReplicationInstanceArn = @replicationInstanceArn;
            @ReplicationTaskId = @replicationTaskId;
            @SourceEndpointArn = @sourceEndpointArn;
            @TableMappings = @tableMappings;
            @TargetEndpointArn = @targetEndpointArn;
            @CdcStartTime = @cdcStartTime;
            @ReplicationTaskSettings = @replicationTaskSettings;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "migration_type", @out: false, min: 1, max: 1)]
        public string @MigrationType { get; }

        [nterraform.Core.TerraformProperty(name: "replication_instance_arn", @out: false, min: 1, max: 1)]
        public string @ReplicationInstanceArn { get; }

        [nterraform.Core.TerraformProperty(name: "replication_task_id", @out: false, min: 1, max: 1)]
        public string @ReplicationTaskId { get; }

        [nterraform.Core.TerraformProperty(name: "source_endpoint_arn", @out: false, min: 1, max: 1)]
        public string @SourceEndpointArn { get; }

        [nterraform.Core.TerraformProperty(name: "table_mappings", @out: false, min: 1, max: 1)]
        public string @TableMappings { get; }

        [nterraform.Core.TerraformProperty(name: "target_endpoint_arn", @out: false, min: 1, max: 1)]
        public string @TargetEndpointArn { get; }

        [nterraform.Core.TerraformProperty(name: "cdc_start_time", @out: false, min: 0, max: 1)]
        public string @CdcStartTime { get; }

        [nterraform.Core.TerraformProperty(name: "replication_task_arn", @out: true, min: 0, max: 1)]
        public string @ReplicationTaskArn { get; }

        [nterraform.Core.TerraformProperty(name: "replication_task_settings", @out: false, min: 0, max: 1)]
        public string @ReplicationTaskSettings { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
