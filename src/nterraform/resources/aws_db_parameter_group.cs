using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_db_parameter_group")]
    public sealed class aws_db_parameter_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "parameter")]
        public sealed class parameter : nterraform.structure
        {
            public parameter(string @name,
                             string @value,
                             string @applyMethod = null)
            {
                @Name = @name;
                @Value = @value;
                @ApplyMethod = @applyMethod;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.TerraformProperty(name: "apply_method", @out: false, min: 0, max: 1)]
            public string @ApplyMethod { get; }
        }

        public aws_db_parameter_group(string @family,
                                      string @description = null,
                                      parameter[] @parameter = null,
                                      Dictionary<string,string> @tags = null)
        {
            @Family = @family;
            @Description = @description;
            @Parameter = @parameter;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
        public string @Family { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: true, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "parameter", @out: false, min: 0, max: 0)]
        public parameter[] @Parameter { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
