using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_partition")]
    public sealed class aws_partition : nterraform.data
    {
        public aws_partition()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "partition", @out: true, min: 0, max: 1)]
        public string @Partition { get; }
    }

}
