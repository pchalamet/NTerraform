using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_organizations_policy")]
    public sealed class aws_organizations_policy : nterraform.Core.resource
    {
        public aws_organizations_policy(string @content,
                                        string @name,
                                        string @description = null,
                                        string @type = null)
        {
            @Content = @content;
            @Name = @name;
            @Description = @description;
            @Type = @type;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "content", @out: false, min: 1, max: 1)]
        public string @Content { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
        public string @Type { get; }
    }

}
