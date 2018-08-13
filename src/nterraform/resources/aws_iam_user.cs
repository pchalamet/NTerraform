using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_user")]
    public sealed class aws_iam_user : nterraform.Core.resource
    {
        public aws_iam_user(string @name,
                            bool? @forceDestroy = null,
                            string @path = null,
                            string @permissionsBoundary = null)
        {
            @Name = @name;
            @ForceDestroy = @forceDestroy;
            @Path = @path;
            @PermissionsBoundary = @permissionsBoundary;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "permissions_boundary", @out: false, min: 0, max: 1)]
        public string @PermissionsBoundary { get; }

        [nterraform.Core.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
