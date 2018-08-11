using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_team_repository")]
    public sealed class github_team_repository : NTerraform.resource
    {
        public github_team_repository(string @repository,
                                      string @teamId,
                                      string @permission = null)
        {
            @Repository = @repository;
            @TeamId = @teamId;
            @Permission = @permission;
            base._validate_();
        }

        [TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [TerraformProperty(name: "team_id", @out: false, min: 1, max: 1)]
        public string @TeamId { get; }

        [TerraformProperty(name: "permission", @out: false, min: 0, max: 1)]
        public string @Permission { get; }
    }

}
