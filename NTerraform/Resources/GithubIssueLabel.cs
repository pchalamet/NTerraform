using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_issue_label")]
    public sealed class github_issue_label : NTerraform.resource
    {
        public github_issue_label(string @color,
                                  string @name,
                                  string @repository)
        {
            @Color = @color;
            @Name = @name;
            @Repository = @repository;
            base._validate_();
        }

        [TerraformProperty(name: "color", @out: false, min: 1, max: 1)]
        public string @Color { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public string @Url { get; }
    }

}
