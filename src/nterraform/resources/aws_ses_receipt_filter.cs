using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ses_receipt_filter")]
    public sealed class aws_ses_receipt_filter : nterraform.Core.resource
    {
        public aws_ses_receipt_filter(string @cidr,
                                      string @name,
                                      string @policy)
        {
            @Cidr = @cidr;
            @Name = @name;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cidr", @out: false, min: 1, max: 1)]
        public string @Cidr { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }
    }

}
