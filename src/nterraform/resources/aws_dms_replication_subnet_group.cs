using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dms_replication_subnet_group")]
    public sealed class aws_dms_replication_subnet_group : nterraform.resource
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

        [nterraform.TerraformProperty(name: "replication_subnet_group_description", @out: false, min: 1, max: 1)]
        public string @ReplicationSubnetGroupDescription { get; }

        [nterraform.TerraformProperty(name: "replication_subnet_group_id", @out: false, min: 1, max: 1)]
        public string @ReplicationSubnetGroupId { get; }

        [nterraform.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.TerraformProperty(name: "replication_subnet_group_arn", @out: true, min: 0, max: 1)]
        public string @ReplicationSubnetGroupArn { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
