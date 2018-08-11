using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "github_user")]
    public sealed class github_user : NTerraform.data
    {
        public github_user(string @username)
        {
            @Username = @username;
            base._validate_();
        }

        [TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
        public string @Username { get; }

        [TerraformProperty(name: "avatar_url", @out: true, min: 0, max: 1)]
        public string @AvatarUrl { get; }

        [TerraformProperty(name: "bio", @out: true, min: 0, max: 1)]
        public string @Bio { get; }

        [TerraformProperty(name: "blog", @out: true, min: 0, max: 1)]
        public string @Blog { get; }

        [TerraformProperty(name: "company", @out: true, min: 0, max: 1)]
        public string @Company { get; }

        [TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [TerraformProperty(name: "email", @out: true, min: 0, max: 1)]
        public string @Email { get; }

        [TerraformProperty(name: "followers", @out: true, min: 0, max: 1)]
        public int? @Followers { get; }

        [TerraformProperty(name: "following", @out: true, min: 0, max: 1)]
        public int? @Following { get; }

        [TerraformProperty(name: "gpg_keys", @out: true, min: 0, max: 1)]
        public string[] @GpgKeys { get; }

        [TerraformProperty(name: "gravatar_id", @out: true, min: 0, max: 1)]
        public string @GravatarId { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "login", @out: true, min: 0, max: 1)]
        public string @Login { get; }

        [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "public_gists", @out: true, min: 0, max: 1)]
        public int? @PublicGists { get; }

        [TerraformProperty(name: "public_repos", @out: true, min: 0, max: 1)]
        public int? @PublicRepos { get; }

        [TerraformProperty(name: "site_admin", @out: true, min: 0, max: 1)]
        public bool? @SiteAdmin { get; }

        [TerraformProperty(name: "ssh_keys", @out: true, min: 0, max: 1)]
        public string[] @SshKeys { get; }

        [TerraformProperty(name: "updated_at", @out: true, min: 0, max: 1)]
        public string @UpdatedAt { get; }
    }

}
