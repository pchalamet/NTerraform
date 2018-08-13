using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_partition")]
    public sealed class aws_partition : nterraform.Core.data
    {
        public aws_partition()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "partition", @out: true, min: 0, max: 1)]
        public string @Partition { get; }
    }

}
