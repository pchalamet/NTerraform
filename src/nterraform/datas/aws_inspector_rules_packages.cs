using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_inspector_rules_packages")]
    public sealed class aws_inspector_rules_packages : nterraform.Core.data
    {
        public aws_inspector_rules_packages()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arns", @out: true, min: 0, max: 1)]
        public string[] @Arns { get; }
    }

}
