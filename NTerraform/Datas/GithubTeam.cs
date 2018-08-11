using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "github_team")]
    public sealed class github_team : NTerraform.data
    {
        public github_team(string @slug)
        {
            @Slug = @slug;
            base._validate_();
        }

        [TerraformProperty(name: "slug", @out: false, min: 1, max: 1)]
        public string @Slug { get; }

        [TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "members", @out: true, min: 0, max: 1)]
        public string[] @Members { get; }

        [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "permission", @out: true, min: 0, max: 1)]
        public string @Permission { get; }

        [TerraformProperty(name: "privacy", @out: true, min: 0, max: 1)]
        public string @Privacy { get; }
    }

}
