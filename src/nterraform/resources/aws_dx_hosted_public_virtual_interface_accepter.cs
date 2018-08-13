using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dx_hosted_public_virtual_interface_accepter")]
    public sealed class aws_dx_hosted_public_virtual_interface_accepter : nterraform.resource
    {
        public aws_dx_hosted_public_virtual_interface_accepter(string @virtualInterfaceId,
                                                               Dictionary<string,string> @tags = null)
        {
            @VirtualInterfaceId = @virtualInterfaceId;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "virtual_interface_id", @out: false, min: 1, max: 1)]
        public string @VirtualInterfaceId { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
