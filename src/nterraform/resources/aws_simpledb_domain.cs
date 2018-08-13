using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_simpledb_domain")]
    public sealed class aws_simpledb_domain : nterraform.Core.resource
    {
        public aws_simpledb_domain(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
