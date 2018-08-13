using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sfn_activity")]
    public sealed class aws_sfn_activity : nterraform.Core.resource
    {
        public aws_sfn_activity(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }
    }

}
