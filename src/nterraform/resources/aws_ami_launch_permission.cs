using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ami_launch_permission")]
    public sealed class aws_ami_launch_permission : nterraform.Core.resource
    {
        public aws_ami_launch_permission(string @accountId,
                                         string @imageId)
        {
            @AccountId = @accountId;
            @ImageId = @imageId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_id", @out: false, min: 1, max: 1)]
        public string @AccountId { get; }

        [nterraform.Core.TerraformProperty(name: "image_id", @out: false, min: 1, max: 1)]
        public string @ImageId { get; }
    }

}
