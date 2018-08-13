using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dax_parameter_group")]
    public sealed class aws_dax_parameter_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "parameters")]
        public sealed class parameters : nterraform.Core.structure
        {
            public parameters(string @name,
                              string @value)
            {
                @Name = @name;
                @Value = @value;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_dax_parameter_group(string @name,
                                       string @description = null,
                                       parameters[] @parameters = null)
        {
            @Name = @name;
            @Description = @description;
            @Parameters = @parameters;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 0)]
        public parameters[] @Parameters { get; }
    }

}
