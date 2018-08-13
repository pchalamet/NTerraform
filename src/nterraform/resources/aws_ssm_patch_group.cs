using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ssm_patch_group")]
    public sealed class aws_ssm_patch_group : nterraform.Core.resource
    {
        public aws_ssm_patch_group(string @baselineId,
                                   string @patchGroup)
        {
            @BaselineId = @baselineId;
            @PatchGroup = @patchGroup;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "baseline_id", @out: false, min: 1, max: 1)]
        public string @BaselineId { get; }

        [nterraform.Core.TerraformProperty(name: "patch_group", @out: false, min: 1, max: 1)]
        public string @PatchGroup { get; }
    }

}
