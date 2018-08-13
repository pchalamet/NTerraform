using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_eip_association")]
    public sealed class aws_eip_association : nterraform.Core.resource
    {
        public aws_eip_association(bool? @allowReassociation = null)
        {
            @AllowReassociation = @allowReassociation;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "allocation_id", @out: true, min: 0, max: 1)]
        public string @AllocationId { get; }

        [nterraform.Core.TerraformProperty(name: "allow_reassociation", @out: false, min: 0, max: 1)]
        public bool? @AllowReassociation { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
        public string @PrivateIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }
    }

}