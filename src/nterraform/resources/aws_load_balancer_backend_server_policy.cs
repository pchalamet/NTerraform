using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_load_balancer_backend_server_policy")]
    public sealed class aws_load_balancer_backend_server_policy : nterraform.Core.resource
    {
        public aws_load_balancer_backend_server_policy(int @instancePort,
                                                       string @loadBalancerName,
                                                       string[] @policyNames = null)
        {
            @InstancePort = @instancePort;
            @LoadBalancerName = @loadBalancerName;
            @PolicyNames = @policyNames;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "instance_port", @out: false, min: 1, max: 1)]
        public int @InstancePort { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer_name", @out: false, min: 1, max: 1)]
        public string @LoadBalancerName { get; }

        [nterraform.Core.TerraformProperty(name: "policy_names", @out: false, min: 0, max: 1)]
        public string[] @PolicyNames { get; }
    }

}
