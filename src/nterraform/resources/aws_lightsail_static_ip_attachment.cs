using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lightsail_static_ip_attachment")]
    public sealed class aws_lightsail_static_ip_attachment : nterraform.Core.resource
    {
        public aws_lightsail_static_ip_attachment(string @instanceName,
                                                  string @staticIpName)
        {
            @InstanceName = @instanceName;
            @StaticIpName = @staticIpName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "instance_name", @out: false, min: 1, max: 1)]
        public string @InstanceName { get; }

        [nterraform.Core.TerraformProperty(name: "static_ip_name", @out: false, min: 1, max: 1)]
        public string @StaticIpName { get; }
    }

}
