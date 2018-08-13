using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_region")]
    public sealed class aws_region : nterraform.Core.data
    {
        public aws_region()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "current", @out: true, min: 0, max: 1)]
        public bool? @Current { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }
    }

}
