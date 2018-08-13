using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_canonical_user_id")]
    public sealed class aws_canonical_user_id : nterraform.data
    {
        public aws_canonical_user_id()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public string @DisplayName { get; }
    }

}
