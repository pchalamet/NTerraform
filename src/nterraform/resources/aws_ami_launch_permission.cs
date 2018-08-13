using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ami_launch_permission")]
    public sealed class aws_ami_launch_permission : nterraform.resource
    {
        public aws_ami_launch_permission(string @accountId,
                                         string @imageId)
        {
            @AccountId = @accountId;
            @ImageId = @imageId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_id", @out: false, min: 1, max: 1)]
        public string @AccountId { get; }

        [nterraform.TerraformProperty(name: "image_id", @out: false, min: 1, max: 1)]
        public string @ImageId { get; }
    }

}
