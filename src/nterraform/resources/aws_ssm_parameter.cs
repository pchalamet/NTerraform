using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ssm_parameter")]
    public sealed class aws_ssm_parameter : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [nterraform.Core.TerraformProperty(name: "allowed_pattern", @out: false, min: 0, max: 1)]
        public string @AllowedPattern { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
        public string @KeyId { get; }

        [nterraform.Core.TerraformProperty(name: "overwrite", @out: false, min: 0, max: 1)]
        public bool? @Overwrite { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
