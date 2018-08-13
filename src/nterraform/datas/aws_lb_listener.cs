using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_lb_listener")]
    public sealed class aws_lb_listener : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "default_action")]
        public sealed class default_action : nterraform.structure
        {
            public default_action()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "target_group_arn", @out: true, min: 0, max: 1)]
            public string @TargetGroupArn { get; }

            [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_lb_listener(default_action[] @defaultAction = null)
        {
            @DefaultAction = @defaultAction;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: true, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "default_action", @out: false, min: 0, max: 0)]
        public default_action[] @DefaultAction { get; }

        [nterraform.TerraformProperty(name: "load_balancer_arn", @out: true, min: 0, max: 1)]
        public string @LoadBalancerArn { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "ssl_policy", @out: true, min: 0, max: 1)]
        public string @SslPolicy { get; }
    }

}
