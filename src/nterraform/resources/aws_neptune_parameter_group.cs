using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_neptune_parameter_group")]
    public sealed class aws_neptune_parameter_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "parameter")]
        public sealed class parameter : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.Core.TerraformProperty(name: "apply_method", @out: false, min: 0, max: 1)]
            public string @ApplyMethod { get; }
        }

        public aws_neptune_parameter_group(string @family,
                                           string @name,
                                           string @description = null,
                                           parameter[] @parameter = null,
                                           Dictionary<string,string> @tags = null)
        {
            @Family = @family;
            @Name = @name;
            @Description = @description;
            @Parameter = @parameter;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
        public string @Family { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "parameter", @out: false, min: 0, max: 0)]
        public parameter[] @Parameter { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
