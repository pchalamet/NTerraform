using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_wafregional_web_acl_association")]
    public sealed class aws_wafregional_web_acl_association : nterraform.Core.resource
    {
        public aws_wafregional_web_acl_association(string @resourceArn,
                                                   string @webAclId)
        {
            @ResourceArn = @resourceArn;
            @WebAclId = @webAclId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "resource_arn", @out: false, min: 1, max: 1)]
        public string @ResourceArn { get; }

        [nterraform.Core.TerraformProperty(name: "web_acl_id", @out: false, min: 1, max: 1)]
        public string @WebAclId { get; }
    }

}
