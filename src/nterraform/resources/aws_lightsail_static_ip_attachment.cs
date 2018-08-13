using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lightsail_static_ip_attachment")]
    public sealed class aws_lightsail_static_ip_attachment : nterraform.resource
    {
        public aws_lightsail_static_ip_attachment(string @instanceName,
                                                  string @staticIpName)
        {
            @InstanceName = @instanceName;
            @StaticIpName = @staticIpName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "instance_name", @out: false, min: 1, max: 1)]
        public string @InstanceName { get; }

        [nterraform.TerraformProperty(name: "static_ip_name", @out: false, min: 1, max: 1)]
        public string @StaticIpName { get; }
    }

}
