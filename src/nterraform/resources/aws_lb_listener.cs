using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lb_listener")]
    public sealed class aws_lb_listener : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "default_action")]
        public sealed class default_action : nterraform.structure
        {
            public default_action(string @targetGroupArn,
                                  string @type)
            {
                @TargetGroupArn = @targetGroupArn;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "target_group_arn", @out: false, min: 1, max: 1)]
            public string @TargetGroupArn { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_lb_listener(default_action[] @defaultAction,
                               string @loadBalancerArn,
                               int @port,
                               string @certificateArn = null,
                               string @protocol = null)
        {
            @DefaultAction = @defaultAction;
            @LoadBalancerArn = @loadBalancerArn;
            @Port = @port;
            @CertificateArn = @certificateArn;
            @Protocol = @protocol;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "default_action", @out: false, min: 1, max: 0)]
        public default_action[] @DefaultAction { get; }

        [nterraform.TerraformProperty(name: "load_balancer_arn", @out: false, min: 1, max: 1)]
        public string @LoadBalancerArn { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
        public int @Port { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: false, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: false, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "ssl_policy", @out: true, min: 0, max: 1)]
        public string @SslPolicy { get; }
    }

}
