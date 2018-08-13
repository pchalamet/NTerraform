using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_security_group_rule")]
    public sealed class aws_security_group_rule : nterraform.resource
    {
        public aws_security_group_rule(int @fromPort,
                                       string @protocol,
                                       string @securityGroupId,
                                       int @toPort,
                                       string @type,
                                       string[] @cidrBlocks = null,
                                       string @description = null,
                                       string[] @ipv6CidrBlocks = null,
                                       string[] @prefixListIds = null,
                                       bool? @self = null)
        {
            @FromPort = @fromPort;
            @Protocol = @protocol;
            @SecurityGroupId = @securityGroupId;
            @ToPort = @toPort;
            @Type = @type;
            @CidrBlocks = @cidrBlocks;
            @Description = @description;
            @Ipv6CidrBlocks = @ipv6CidrBlocks;
            @PrefixListIds = @prefixListIds;
            @Self = @self;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "from_port", @out: false, min: 1, max: 1)]
        public int @FromPort { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "security_group_id", @out: false, min: 1, max: 1)]
        public string @SecurityGroupId { get; }

        [nterraform.TerraformProperty(name: "to_port", @out: false, min: 1, max: 1)]
        public int @ToPort { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "cidr_blocks", @out: false, min: 0, max: 1)]
        public string[] @CidrBlocks { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "ipv6_cidr_blocks", @out: false, min: 0, max: 1)]
        public string[] @Ipv6CidrBlocks { get; }

        [nterraform.TerraformProperty(name: "prefix_list_ids", @out: false, min: 0, max: 1)]
        public string[] @PrefixListIds { get; }

        [nterraform.TerraformProperty(name: "self", @out: false, min: 0, max: 1)]
        public bool? @Self { get; }

        [nterraform.TerraformProperty(name: "source_security_group_id", @out: true, min: 0, max: 1)]
        public string @SourceSecurityGroupId { get; }
    }

}
