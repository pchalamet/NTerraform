using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lb_ssl_negotiation_policy")]
    public sealed class aws_lb_ssl_negotiation_policy : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "attribute")]
        public sealed class attribute : nterraform.structure
        {
            public attribute(string @name,
                             string @value)
            {
                @Name = @name;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_lb_ssl_negotiation_policy(int @lbPort,
                                             string @loadBalancer,
                                             string @name,
                                             attribute[] @attribute = null)
        {
            @LbPort = @lbPort;
            @LoadBalancer = @loadBalancer;
            @Name = @name;
            @Attribute = @attribute;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "lb_port", @out: false, min: 1, max: 1)]
        public int @LbPort { get; }

        [nterraform.TerraformProperty(name: "load_balancer", @out: false, min: 1, max: 1)]
        public string @LoadBalancer { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "attribute", @out: false, min: 0, max: 0)]
        public attribute[] @Attribute { get; }
    }

}
