using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_team")]
    public sealed class github_team : NTerraform.resource
    {
        public github_team(string @name,
                           string @description = null,
                           string @ldapDn = null,
                           int? @parentTeamId = null,
                           string @privacy = null)
        {
            @Name = @name;
            @Description = @description;
            @LdapDn = @ldapDn;
            @ParentTeamId = @parentTeamId;
            @Privacy = @privacy;
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "ldap_dn", @out: false, min: 0, max: 1)]
        public string @LdapDn { get; }

        [TerraformProperty(name: "parent_team_id", @out: false, min: 0, max: 1)]
        public int? @ParentTeamId { get; }

        [TerraformProperty(name: "privacy", @out: false, min: 0, max: 1)]
        public string @Privacy { get; }
    }

}
