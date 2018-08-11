using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "github_ip_ranges")]
    public sealed class github_ip_ranges : NTerraform.data
    {
        public github_ip_ranges()
        {
            base._validate_();
        }

        [TerraformProperty(name: "git", @out: true, min: 0, max: 1)]
        public string[] @Git { get; }

        [TerraformProperty(name: "hooks", @out: true, min: 0, max: 1)]
        public string[] @Hooks { get; }

        [TerraformProperty(name: "pages", @out: true, min: 0, max: 1)]
        public string[] @Pages { get; }
    }

}
