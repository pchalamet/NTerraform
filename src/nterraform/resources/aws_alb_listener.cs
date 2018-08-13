using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_alb_listener")]
    public sealed class aws_alb_listener : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "default_action")]
        public sealed class default_action : nterraform.Core.structure
        {
            public default_action(string @targetGroupArn,
                                  string @type)
            {
                @TargetGroupArn = @targetGroupArn;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "target_group_arn", @out: false, min: 1, max: 1)]
            public string @TargetGroupArn { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_alb_listener(default_action[] @defaultAction,
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

        [nterraform.Core.TerraformProperty(name: "default_action", @out: false, min: 1, max: 0)]
        public default_action[] @DefaultAction { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer_arn", @out: false, min: 1, max: 1)]
        public string @LoadBalancerArn { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
        public int @Port { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_arn", @out: false, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "ssl_policy", @out: true, min: 0, max: 1)]
        public string @SslPolicy { get; }
    }

}
