using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_app_cookie_stickiness_policy")]
    public sealed class aws_app_cookie_stickiness_policy : nterraform.resource
    {
        public aws_app_cookie_stickiness_policy(string @cookieName,
                                                int @lbPort,
                                                string @loadBalancer,
                                                string @name)
        {
            @CookieName = @cookieName;
            @LbPort = @lbPort;
            @LoadBalancer = @loadBalancer;
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cookie_name", @out: false, min: 1, max: 1)]
        public string @CookieName { get; }

        [nterraform.TerraformProperty(name: "lb_port", @out: false, min: 1, max: 1)]
        public int @LbPort { get; }

        [nterraform.TerraformProperty(name: "load_balancer", @out: false, min: 1, max: 1)]
        public string @LoadBalancer { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
