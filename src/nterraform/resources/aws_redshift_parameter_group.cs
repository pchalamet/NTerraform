using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_redshift_parameter_group")]
    public sealed class aws_redshift_parameter_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "parameter")]
        public sealed class parameter : nterraform.structure
        {
            public parameter(string @name,
                             string @value)
            {
                @Name = @name;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_redshift_parameter_group(string @family,
                                            string @name,
                                            string @description = null,
                                            parameter[] @parameter = null)
        {
            @Family = @family;
            @Name = @name;
            @Description = @description;
            @Parameter = @parameter;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
        public string @Family { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "parameter", @out: false, min: 0, max: 0)]
        public parameter[] @Parameter { get; }
    }

}
