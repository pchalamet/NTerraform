using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_membership")]
    public sealed class github_membership : NTerraform.resource
    {
        public github_membership(string @username,
                                 string @role = null)
        {
            @Username = @username;
            @Role = @role;
            base._validate_();
        }

        [TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
        public string @Username { get; }

        [TerraformProperty(name: "role", @out: false, min: 0, max: 1)]
        public string @Role { get; }
    }

}
