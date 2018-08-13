using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_eip")]
    public sealed class aws_eip : nterraform.Core.data
    {
        public aws_eip()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.Core.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }
    }

}
