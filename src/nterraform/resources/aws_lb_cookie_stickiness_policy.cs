using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lb_cookie_stickiness_policy")]
    public sealed class aws_lb_cookie_stickiness_policy : nterraform.resource
    {
        public aws_lb_cookie_stickiness_policy(int @lbPort,
                                               string @loadBalancer,
                                               string @name,
                                               int? @cookieExpirationPeriod = null)
        {
            @LbPort = @lbPort;
            @LoadBalancer = @loadBalancer;
            @Name = @name;
            @CookieExpirationPeriod = @cookieExpirationPeriod;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "lb_port", @out: false, min: 1, max: 1)]
        public int @LbPort { get; }

        [nterraform.TerraformProperty(name: "load_balancer", @out: false, min: 1, max: 1)]
        public string @LoadBalancer { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "cookie_expiration_period", @out: false, min: 0, max: 1)]
        public int? @CookieExpirationPeriod { get; }
    }

}
