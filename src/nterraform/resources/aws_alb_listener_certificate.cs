using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_alb_listener_certificate")]
    public sealed class aws_alb_listener_certificate : nterraform.resource
    {
        public aws_alb_listener_certificate(string @certificateArn,
                                            string @listenerArn)
        {
            @CertificateArn = @certificateArn;
            @ListenerArn = @listenerArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: false, min: 1, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "listener_arn", @out: false, min: 1, max: 1)]
        public string @ListenerArn { get; }
    }

}
