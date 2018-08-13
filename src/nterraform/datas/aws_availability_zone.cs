using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_availability_zone")]
    public sealed class aws_availability_zone : nterraform.Core.data
    {
        public aws_availability_zone()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_suffix", @out: true, min: 0, max: 1)]
        public string @NameSuffix { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }
    }

}
