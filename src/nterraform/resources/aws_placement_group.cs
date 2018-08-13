using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_placement_group")]
    public sealed class aws_placement_group : nterraform.resource
    {
        public aws_placement_group(string @name,
                                   string @strategy)
        {
            @Name = @name;
            @Strategy = @strategy;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "strategy", @out: false, min: 1, max: 1)]
        public string @Strategy { get; }
    }

}
