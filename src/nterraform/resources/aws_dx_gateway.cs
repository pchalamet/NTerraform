using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dx_gateway")]
    public sealed class aws_dx_gateway : nterraform.Core.resource
    {
        public aws_dx_gateway(string @amazonSideAsn,
                              string @name)
        {
            @AmazonSideAsn = @amazonSideAsn;
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "amazon_side_asn", @out: false, min: 1, max: 1)]
        public string @AmazonSideAsn { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
