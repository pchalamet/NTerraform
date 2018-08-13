using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_network_interface_sg_attachment")]
    public sealed class aws_network_interface_sg_attachment : nterraform.Core.resource
    {
        public aws_network_interface_sg_attachment(string @networkInterfaceId,
                                                   string @securityGroupId)
        {
            @NetworkInterfaceId = @networkInterfaceId;
            @SecurityGroupId = @securityGroupId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: false, min: 1, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_id", @out: false, min: 1, max: 1)]
        public string @SecurityGroupId { get; }
    }

}
