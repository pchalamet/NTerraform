using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dms_replication_subnet_group")]
    public sealed class aws_dms_replication_subnet_group : nterraform.Core.resource
    {
        public aws_dms_replication_subnet_group(string @replicationSubnetGroupDescription,
                                                string @replicationSubnetGroupId,
                                                string[] @subnetIds,
                                                Dictionary<string,string> @tags = null)
        {
            @ReplicationSubnetGroupDescription = @replicationSubnetGroupDescription;
            @ReplicationSubnetGroupId = @replicationSubnetGroupId;
            @SubnetIds = @subnetIds;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "replication_subnet_group_description", @out: false, min: 1, max: 1)]
        public string @ReplicationSubnetGroupDescription { get; }

        [nterraform.Core.TerraformProperty(name: "replication_subnet_group_id", @out: false, min: 1, max: 1)]
        public string @ReplicationSubnetGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.Core.TerraformProperty(name: "replication_subnet_group_arn", @out: true, min: 0, max: 1)]
        public string @ReplicationSubnetGroupArn { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
