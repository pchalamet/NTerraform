using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_load_balancer_listener_policy")]
    public sealed class aws_load_balancer_listener_policy : nterraform.Core.resource
    {
        public aws_load_balancer_listener_policy(string @loadBalancerName,
                                                 int @loadBalancerPort,
                                                 string[] @policyNames = null)
        {
            @LoadBalancerName = @loadBalancerName;
            @LoadBalancerPort = @loadBalancerPort;
            @PolicyNames = @policyNames;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "load_balancer_name", @out: false, min: 1, max: 1)]
        public string @LoadBalancerName { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer_port", @out: false, min: 1, max: 1)]
        public int @LoadBalancerPort { get; }

        [nterraform.Core.TerraformProperty(name: "policy_names", @out: false, min: 0, max: 1)]
        public string[] @PolicyNames { get; }
    }

}
