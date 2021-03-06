using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_wafregional_web_acl_association")]
    public sealed class aws_wafregional_web_acl_association : nterraform.resource
    {
        public aws_wafregional_web_acl_association(string @resourceArn,
                                                   string @webAclId)
        {
            @ResourceArn = @resourceArn;
            @WebAclId = @webAclId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "resource_arn", @out: false, min: 1, max: 1)]
        public string @ResourceArn { get; }

        [nterraform.TerraformProperty(name: "web_acl_id", @out: false, min: 1, max: 1)]
        public string @WebAclId { get; }
    }

}
