using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_repository_deploy_key")]
    public sealed class github_repository_deploy_key : NTerraform.resource
    {
        public github_repository_deploy_key(string @key,
                                            string @repository,
                                            string @title,
                                            bool? @readOnly = null)
        {
            @Key = @key;
            @Repository = @repository;
            @Title = @title;
            @ReadOnly = @readOnly;
            base._validate_();
        }

        [TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
        public string @Key { get; }

        [TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [TerraformProperty(name: "title", @out: false, min: 1, max: 1)]
        public string @Title { get; }

        [TerraformProperty(name: "read_only", @out: false, min: 0, max: 1)]
        public bool? @ReadOnly { get; }
    }

}
