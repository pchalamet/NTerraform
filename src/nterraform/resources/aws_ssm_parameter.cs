using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_parameter")]
    public sealed class aws_ssm_parameter : nterraform.resource
    {
        public aws_ssm_parameter(string @name,
                                 string @type,
                                 string @value,
                                 string @allowedPattern = null,
                                 string @description = null,
                                 bool? @overwrite = null,
                                 Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @Type = @type;
            @Value = @value;
            @AllowedPattern = @allowedPattern;
            @Description = @description;
            @Overwrite = @overwrite;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [nterraform.TerraformProperty(name: "allowed_pattern", @out: false, min: 0, max: 1)]
        public string @AllowedPattern { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
        public string @KeyId { get; }

        [nterraform.TerraformProperty(name: "overwrite", @out: false, min: 0, max: 1)]
        public bool? @Overwrite { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
