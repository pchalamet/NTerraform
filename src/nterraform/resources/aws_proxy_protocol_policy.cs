using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_proxy_protocol_policy")]
    public sealed class aws_proxy_protocol_policy : nterraform.Core.resource
    {
        public aws_proxy_protocol_policy(string[] @instancePorts,
                                         string @loadBalancer)
        {
            @InstancePorts = @instancePorts;
            @LoadBalancer = @loadBalancer;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "instance_ports", @out: false, min: 1, max: 1)]
        public string[] @InstancePorts { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer", @out: false, min: 1, max: 1)]
        public string @LoadBalancer { get; }
    }

}
