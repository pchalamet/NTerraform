using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_network_acl_rule")]
    public sealed class aws_network_acl_rule : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "network_acl_id", @out: false, min: 1, max: 1)]
        public string @NetworkAclId { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "rule_action", @out: false, min: 1, max: 1)]
        public string @RuleAction { get; }

        [nterraform.Core.TerraformProperty(name: "rule_number", @out: false, min: 1, max: 1)]
        public int @RuleNumber { get; }

        [nterraform.Core.TerraformProperty(name: "cidr_block", @out: false, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "egress", @out: false, min: 0, max: 1)]
        public bool? @Egress { get; }

        [nterraform.Core.TerraformProperty(name: "from_port", @out: false, min: 0, max: 1)]
        public int? @FromPort { get; }

        [nterraform.Core.TerraformProperty(name: "icmp_code", @out: false, min: 0, max: 1)]
        public string @IcmpCode { get; }

        [nterraform.Core.TerraformProperty(name: "icmp_type", @out: false, min: 0, max: 1)]
        public string @IcmpType { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_cidr_block", @out: false, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "to_port", @out: false, min: 0, max: 1)]
        public int? @ToPort { get; }
    }

}
