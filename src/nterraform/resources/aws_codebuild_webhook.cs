using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_codebuild_webhook")]
    public sealed class aws_codebuild_webhook : nterraform.resource
    {
        public aws_codebuild_webhook(string @projectName,
                                     string @branchFilter = null)
        {
            @ProjectName = @projectName;
            @BranchFilter = @branchFilter;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "project_name", @out: false, min: 1, max: 1)]
        public string @ProjectName { get; }

        [nterraform.TerraformProperty(name: "branch_filter", @out: false, min: 0, max: 1)]
        public string @BranchFilter { get; }

        [nterraform.TerraformProperty(name: "payload_url", @out: true, min: 0, max: 1)]
        public string @PayloadUrl { get; }

        [nterraform.TerraformProperty(name: "secret", @out: true, min: 0, max: 1)]
        public string @Secret { get; }

        [nterraform.TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public string @Url { get; }
    }

}
