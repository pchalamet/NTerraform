using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_instance_profile")]
    public sealed class aws_iam_instance_profile : nterraform.Core.resource
    {
        public aws_iam_instance_profile(string @namePrefix = null,
                                        string @path = null)
        {
            @NamePrefix = @namePrefix;
            @Path = @path;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "role", @out: true, min: 0, max: 1)]
        public string @Role { get; }

        [nterraform.Core.TerraformProperty(name: "roles", @out: true, min: 0, max: 1)]
        public string[] @Roles { get; }

        [nterraform.Core.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
