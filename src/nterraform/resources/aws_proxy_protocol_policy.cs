using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_proxy_protocol_policy")]
    public sealed class aws_proxy_protocol_policy : nterraform.resource
    {
        public aws_proxy_protocol_policy(string[] @instancePorts,
                                         string @loadBalancer)
        {
            @InstancePorts = @instancePorts;
            @LoadBalancer = @loadBalancer;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "instance_ports", @out: false, min: 1, max: 1)]
        public string[] @InstancePorts { get; }

        [nterraform.TerraformProperty(name: "load_balancer", @out: false, min: 1, max: 1)]
        public string @LoadBalancer { get; }
    }

}
