using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_dx_gateway")]
    public sealed class aws_dx_gateway : nterraform.data
    {
        public aws_dx_gateway(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "amazon_side_asn", @out: true, min: 0, max: 1)]
        public string @AmazonSideAsn { get; }
    }

}
