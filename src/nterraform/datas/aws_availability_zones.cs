using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_availability_zones")]
    public sealed class aws_availability_zones : nterraform.Core.data
    {
        public aws_availability_zones(string @state = null)
        {
            @State = @state;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "names", @out: true, min: 0, max: 1)]
        public string[] @Names { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }
    }

}
