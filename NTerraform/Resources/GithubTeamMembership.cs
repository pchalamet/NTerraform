using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_team_membership")]
    public sealed class github_team_membership : NTerraform.resource
    {
        public github_team_membership(string @teamId,
                                      string @username,
                                      string @role = null)
        {
            @TeamId = @teamId;
            @Username = @username;
            @Role = @role;
            base._validate_();
        }

        [TerraformProperty(name: "team_id", @out: false, min: 1, max: 1)]
        public string @TeamId { get; }

        [TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
        public string @Username { get; }

        [TerraformProperty(name: "role", @out: false, min: 0, max: 1)]
        public string @Role { get; }
    }

}
