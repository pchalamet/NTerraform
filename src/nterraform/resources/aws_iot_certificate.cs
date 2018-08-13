using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iot_certificate")]
    public sealed class aws_iot_certificate : nterraform.Core.resource
    {
        public aws_iot_certificate(bool @active,
                                   string @csr)
        {
            @Active = @active;
            @Csr = @csr;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "active", @out: false, min: 1, max: 1)]
        public bool @Active { get; }

        [nterraform.Core.TerraformProperty(name: "csr", @out: false, min: 1, max: 1)]
        public string @Csr { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
