using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lb_cookie_stickiness_policy")]
    public sealed class aws_lb_cookie_stickiness_policy : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "lb_port", @out: false, min: 1, max: 1)]
        public int @LbPort { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer", @out: false, min: 1, max: 1)]
        public string @LoadBalancer { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "cookie_expiration_period", @out: false, min: 0, max: 1)]
        public int? @CookieExpirationPeriod { get; }
    }

}
