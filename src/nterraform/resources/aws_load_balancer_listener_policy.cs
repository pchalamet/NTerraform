using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_load_balancer_listener_policy")]
    public sealed class aws_load_balancer_listener_policy : nterraform.resource
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

        [nterraform.TerraformProperty(name: "load_balancer_name", @out: false, min: 1, max: 1)]
        public string @LoadBalancerName { get; }

        [nterraform.TerraformProperty(name: "load_balancer_port", @out: false, min: 1, max: 1)]
        public int @LoadBalancerPort { get; }

        [nterraform.TerraformProperty(name: "policy_names", @out: false, min: 0, max: 1)]
        public string[] @PolicyNames { get; }
    }

}
