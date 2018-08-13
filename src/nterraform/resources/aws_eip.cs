using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_eip")]
    public sealed class aws_eip : nterraform.resource
    {
        public aws_eip(string @associateWithPrivateIp = null,
                       Dictionary<string,string> @tags = null)
        {
            @AssociateWithPrivateIp = @associateWithPrivateIp;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "allocation_id", @out: true, min: 0, max: 1)]
        public string @AllocationId { get; }

        [nterraform.TerraformProperty(name: "associate_with_private_ip", @out: false, min: 0, max: 1)]
        public string @AssociateWithPrivateIp { get; }

        [nterraform.TerraformProperty(name: "association_id", @out: true, min: 0, max: 1)]
        public string @AssociationId { get; }

        [nterraform.TerraformProperty(name: "domain", @out: true, min: 0, max: 1)]
        public string @Domain { get; }

        [nterraform.TerraformProperty(name: "instance", @out: true, min: 0, max: 1)]
        public string @Instance { get; }

        [nterraform.TerraformProperty(name: "network_interface", @out: true, min: 0, max: 1)]
        public string @NetworkInterface { get; }

        [nterraform.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc", @out: true, min: 0, max: 1)]
        public bool? @Vpc { get; }
    }

}
