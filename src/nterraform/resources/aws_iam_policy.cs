using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_policy")]
    public sealed class aws_iam_policy : nterraform.Core.resource
    {
        public aws_iam_policy(string @policy,
                              string @description = null,
                              string @namePrefix = null,
                              string @path = null)
        {
            @Policy = @policy;
            @Description = @description;
            @NamePrefix = @namePrefix;
            @Path = @path;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
        public string @Path { get; }
    }

}
