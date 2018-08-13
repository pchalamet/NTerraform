using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_default_security_group")]
    public sealed class aws_default_security_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ingress")]
        public sealed class ingress : nterraform.Core.structure
        {
            public ingress(int @fromPort,
                           string @protocol,
                           int @toPort,
                           string[] @cidrBlocks = null,
                           string @description = null,
                           string[] @ipv6CidrBlocks = null,
                           string[] @securityGroups = null,
                           bool? @self = null)
            {
                @FromPort = @fromPort;
                @Protocol = @protocol;
                @ToPort = @toPort;
                @CidrBlocks = @cidrBlocks;
                @Description = @description;
                @Ipv6CidrBlocks = @ipv6CidrBlocks;
                @SecurityGroups = @securityGroups;
                @Self = @self;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "from_port", @out: false, min: 1, max: 1)]
            public int @FromPort { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "to_port", @out: false, min: 1, max: 1)]
            public int @ToPort { get; }

            [nterraform.Core.TerraformProperty(name: "cidr_blocks", @out: false, min: 0, max: 1)]
            public string[] @CidrBlocks { get; }

            [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.Core.TerraformProperty(name: "ipv6_cidr_blocks", @out: false, min: 0, max: 1)]
            public string[] @Ipv6CidrBlocks { get; }

            [nterraform.Core.TerraformProperty(name: "security_groups", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroups { get; }

            [nterraform.Core.TerraformProperty(name: "self", @out: false, min: 0, max: 1)]
            public bool? @Self { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "egress")]
        public sealed class egress : nterraform.Core.structure
        {
            public egress(int @fromPort,
                          string @protocol,
                          int @toPort,
                          string[] @cidrBlocks = null,
                          string @description = null,
                          string[] @ipv6CidrBlocks = null,
                          string[] @prefixListIds = null,
                          string[] @securityGroups = null,
                          bool? @self = null)
            {
                @FromPort = @fromPort;
                @Protocol = @protocol;
                @ToPort = @toPort;
                @CidrBlocks = @cidrBlocks;
                @Description = @description;
                @Ipv6CidrBlocks = @ipv6CidrBlocks;
                @PrefixListIds = @prefixListIds;
                @SecurityGroups = @securityGroups;
                @Self = @self;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "from_port", @out: false, min: 1, max: 1)]
            public int @FromPort { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "to_port", @out: false, min: 1, max: 1)]
            public int @ToPort { get; }

            [nterraform.Core.TerraformProperty(name: "cidr_blocks", @out: false, min: 0, max: 1)]
            public string[] @CidrBlocks { get; }

            [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.Core.TerraformProperty(name: "ipv6_cidr_blocks", @out: false, min: 0, max: 1)]
            public string[] @Ipv6CidrBlocks { get; }

            [nterraform.Core.TerraformProperty(name: "prefix_list_ids", @out: false, min: 0, max: 1)]
            public string[] @PrefixListIds { get; }

            [nterraform.Core.TerraformProperty(name: "security_groups", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroups { get; }

            [nterraform.Core.TerraformProperty(name: "self", @out: false, min: 0, max: 1)]
            public bool? @Self { get; }
        }

        public aws_default_security_group(egress[] @egress = null,
                                          ingress[] @ingress = null,
                                          bool? @revokeRulesOnDelete = null,
                                          Dictionary<string,string> @tags = null)
        {
            @Egress = @egress;
            @Ingress = @ingress;
            @RevokeRulesOnDelete = @revokeRulesOnDelete;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "egress", @out: false, min: 0, max: 0)]
        public egress[] @Egress { get; }

        [nterraform.Core.TerraformProperty(name: "ingress", @out: false, min: 0, max: 0)]
        public ingress[] @Ingress { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "revoke_rules_on_delete", @out: false, min: 0, max: 1)]
        public bool? @RevokeRulesOnDelete { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
