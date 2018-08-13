using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_group")]
    public sealed class aws_iam_group : nterraform.Core.resource
    {
        public aws_iam_group(string @name,
                             string @path = null)
        {
            @Name = @name;
            @Path = @path;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
