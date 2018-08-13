using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_region")]
    public sealed class aws_region : nterraform.data
    {
        public aws_region()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "current", @out: true, min: 0, max: 1)]
        public bool? @Current { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }
    }

}
