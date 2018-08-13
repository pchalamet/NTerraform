using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_network_acl_rule")]
    public sealed class aws_network_acl_rule : nterraform.resource
    {
        public aws_network_acl_rule(string @networkAclId,
                                    string @protocol,
                                    string @ruleAction,
                                    int @ruleNumber,
                                    string @cidrBlock = null,
                                    bool? @egress = null,
                                    int? @fromPort = null,
                                    string @icmpCode = null,
                                    string @icmpType = null,
                                    string @ipv6CidrBlock = null,
                                    int? @toPort = null)
        {
            @NetworkAclId = @networkAclId;
            @Protocol = @protocol;
            @RuleAction = @ruleAction;
            @RuleNumber = @ruleNumber;
            @CidrBlock = @cidrBlock;
            @Egress = @egress;
            @FromPort = @fromPort;
            @IcmpCode = @icmpCode;
            @IcmpType = @icmpType;
            @Ipv6CidrBlock = @ipv6CidrBlock;
            @ToPort = @toPort;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "network_acl_id", @out: false, min: 1, max: 1)]
        public string @NetworkAclId { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "rule_action", @out: false, min: 1, max: 1)]
        public string @RuleAction { get; }

        [nterraform.TerraformProperty(name: "rule_number", @out: false, min: 1, max: 1)]
        public int @RuleNumber { get; }

        [nterraform.TerraformProperty(name: "cidr_block", @out: false, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.TerraformProperty(name: "egress", @out: false, min: 0, max: 1)]
        public bool? @Egress { get; }

        [nterraform.TerraformProperty(name: "from_port", @out: false, min: 0, max: 1)]
        public int? @FromPort { get; }

        [nterraform.TerraformProperty(name: "icmp_code", @out: false, min: 0, max: 1)]
        public string @IcmpCode { get; }

        [nterraform.TerraformProperty(name: "icmp_type", @out: false, min: 0, max: 1)]
        public string @IcmpType { get; }

        [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: false, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.TerraformProperty(name: "to_port", @out: false, min: 0, max: 1)]
        public int? @ToPort { get; }
    }

}
