using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_prefix_list")]
    public sealed class aws_prefix_list : nterraform.Core.data
    {
        public aws_prefix_list(string @prefixListId = null)
        {
            @PrefixListId = @prefixListId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cidr_blocks", @out: true, min: 0, max: 1)]
        public string[] @CidrBlocks { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "prefix_list_id", @out: false, min: 0, max: 1)]
        public string @PrefixListId { get; }
    }

}
