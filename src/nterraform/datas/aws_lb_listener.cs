using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_lb_listener")]
    public sealed class aws_lb_listener : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "default_action")]
        public sealed class default_action : nterraform.Core.structure
        {
            public default_action()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "target_group_arn", @out: true, min: 0, max: 1)]
            public string @TargetGroupArn { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_lb_listener(default_action[] @defaultAction = null)
        {
            @DefaultAction = @defaultAction;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_arn", @out: true, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.Core.TerraformProperty(name: "default_action", @out: false, min: 0, max: 0)]
        public default_action[] @DefaultAction { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer_arn", @out: true, min: 0, max: 1)]
        public string @LoadBalancerArn { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "ssl_policy", @out: true, min: 0, max: 1)]
        public string @SslPolicy { get; }
    }

}
