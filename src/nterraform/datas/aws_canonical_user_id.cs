using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_canonical_user_id")]
    public sealed class aws_canonical_user_id : nterraform.Core.data
    {
        public aws_canonical_user_id()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public string @DisplayName { get; }
    }

}
