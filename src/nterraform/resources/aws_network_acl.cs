using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_network_acl")]
    public sealed class aws_network_acl : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ingress")]
        public sealed class ingress : nterraform.structure
        {
            public ingress(string @action,
                           int @fromPort,
                           string @protocol,
                           int @ruleNo,
                           int @toPort,
                           string @cidrBlock = null,
                           int? @icmpCode = null,
                           int? @icmpType = null,
                           string @ipv6CidrBlock = null)
            {
                @Action = @action;
                @FromPort = @fromPort;
                @Protocol = @protocol;
                @RuleNo = @ruleNo;
                @ToPort = @toPort;
                @CidrBlock = @cidrBlock;
                @IcmpCode = @icmpCode;
                @IcmpType = @icmpType;
                @Ipv6CidrBlock = @ipv6CidrBlock;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
            public string @Action { get; }

            [nterraform.TerraformProperty(name: "from_port", @out: false, min: 1, max: 1)]
            public int @FromPort { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "rule_no", @out: false, min: 1, max: 1)]
            public int @RuleNo { get; }

            [nterraform.TerraformProperty(name: "to_port", @out: false, min: 1, max: 1)]
            public int @ToPort { get; }

            [nterraform.TerraformProperty(name: "cidr_block", @out: false, min: 0, max: 1)]
            public string @CidrBlock { get; }

            [nterraform.TerraformProperty(name: "icmp_code", @out: false, min: 0, max: 1)]
            public int? @IcmpCode { get; }

            [nterraform.TerraformProperty(name: "icmp_type", @out: false, min: 0, max: 1)]
            public int? @IcmpType { get; }

            [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: false, min: 0, max: 1)]
            public string @Ipv6CidrBlock { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "egress")]
        public sealed class egress : nterraform.structure
        {
            public egress(string @action,
                          int @fromPort,
                          string @protocol,
                          int @ruleNo,
                          int @toPort,
                          string @cidrBlock = null,
                          int? @icmpCode = null,
                          int? @icmpType = null,
                          string @ipv6CidrBlock = null)
            {
                @Action = @action;
                @FromPort = @fromPort;
                @Protocol = @protocol;
                @RuleNo = @ruleNo;
                @ToPort = @toPort;
                @CidrBlock = @cidrBlock;
                @IcmpCode = @icmpCode;
                @IcmpType = @icmpType;
                @Ipv6CidrBlock = @ipv6CidrBlock;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
            public string @Action { get; }

            [nterraform.TerraformProperty(name: "from_port", @out: false, min: 1, max: 1)]
            public int @FromPort { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "rule_no", @out: false, min: 1, max: 1)]
            public int @RuleNo { get; }

            [nterraform.TerraformProperty(name: "to_port", @out: false, min: 1, max: 1)]
            public int @ToPort { get; }

            [nterraform.TerraformProperty(name: "cidr_block", @out: false, min: 0, max: 1)]
            public string @CidrBlock { get; }

            [nterraform.TerraformProperty(name: "icmp_code", @out: false, min: 0, max: 1)]
            public int? @IcmpCode { get; }

            [nterraform.TerraformProperty(name: "icmp_type", @out: false, min: 0, max: 1)]
            public int? @IcmpType { get; }

            [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: false, min: 0, max: 1)]
            public string @Ipv6CidrBlock { get; }
        }

        public aws_network_acl(string @vpcId,
                               egress[] @egress = null,
                               ingress[] @ingress = null,
                               string @subnetId = null,
                               Dictionary<string,string> @tags = null)
        {
            @VpcId = @vpcId;
            @Egress = @egress;
            @Ingress = @ingress;
            @SubnetId = @subnetId;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "egress", @out: false, min: 0, max: 0)]
        public egress[] @Egress { get; }

        [nterraform.TerraformProperty(name: "ingress", @out: false, min: 0, max: 0)]
        public ingress[] @Ingress { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
