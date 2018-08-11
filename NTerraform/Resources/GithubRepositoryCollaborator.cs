using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_repository_collaborator")]
    public sealed class github_repository_collaborator : NTerraform.resource
    {
        public github_repository_collaborator(string @repository,
                                              string @username,
                                              string @permission = null)
        {
            @Repository = @repository;
            @Username = @username;
            @Permission = @permission;
            base._validate_();
        }

        [TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
        public string @Username { get; }

        [TerraformProperty(name: "permission", @out: false, min: 0, max: 1)]
        public string @Permission { get; }
    }

}
