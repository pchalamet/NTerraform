using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lb_listener_certificate")]
    public sealed class aws_lb_listener_certificate : nterraform.Core.resource
    {
        public aws_lb_listener_certificate(string @certificateArn,
                                           string @listenerArn)
        {
            @CertificateArn = @certificateArn;
            @ListenerArn = @listenerArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "certificate_arn", @out: false, min: 1, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.Core.TerraformProperty(name: "listener_arn", @out: false, min: 1, max: 1)]
        public string @ListenerArn { get; }
    }

}
