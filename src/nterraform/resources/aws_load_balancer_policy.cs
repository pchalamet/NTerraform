using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_load_balancer_policy")]
    public sealed class aws_load_balancer_policy : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "policy_attribute")]
        public sealed class policy_attribute : nterraform.Core.structure
        {
            public policy_attribute(string @name = null,
                                    string @value = null)
            {
                @Name = @name;
                @Value = @value;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 0, max: 1)]
            public string @Value { get; }
        }

        public aws_load_balancer_policy(string @loadBalancerName,
                                        string @policyName,
                                        string @policyTypeName,
                                        policy_attribute[] @policyAttribute = null)
        {
            @LoadBalancerName = @loadBalancerName;
            @PolicyName = @policyName;
            @PolicyTypeName = @policyTypeName;
            @PolicyAttribute = @policyAttribute;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "load_balancer_name", @out: false, min: 1, max: 1)]
        public string @LoadBalancerName { get; }

        [nterraform.Core.TerraformProperty(name: "policy_name", @out: false, min: 1, max: 1)]
        public string @PolicyName { get; }

        [nterraform.Core.TerraformProperty(name: "policy_type_name", @out: false, min: 1, max: 1)]
        public string @PolicyTypeName { get; }

        [nterraform.Core.TerraformProperty(name: "policy_attribute", @out: false, min: 0, max: 0)]
        public policy_attribute[] @PolicyAttribute { get; }
    }

}
