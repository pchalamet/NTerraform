using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_nat_gateway")]
    public sealed class aws_nat_gateway : nterraform.resource
    {
        public aws_nat_gateway(string @allocationId,
                               string @subnetId,
                               Dictionary<string,string> @tags = null)
        {
            @AllocationId = @allocationId;
            @SubnetId = @subnetId;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "allocation_id", @out: false, min: 1, max: 1)]
        public string @AllocationId { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
