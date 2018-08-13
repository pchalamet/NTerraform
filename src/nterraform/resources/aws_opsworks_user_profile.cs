using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_opsworks_user_profile")]
    public sealed class aws_opsworks_user_profile : nterraform.Core.resource
    {
        public aws_opsworks_user_profile(string @sshUsername,
                                         string @userArn,
                                         bool? @allowSelfManagement = null,
                                         string @sshPublicKey = null)
        {
            @SshUsername = @sshUsername;
            @UserArn = @userArn;
            @AllowSelfManagement = @allowSelfManagement;
            @SshPublicKey = @sshPublicKey;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "ssh_username", @out: false, min: 1, max: 1)]
        public string @SshUsername { get; }

        [nterraform.Core.TerraformProperty(name: "user_arn", @out: false, min: 1, max: 1)]
        public string @UserArn { get; }

        [nterraform.Core.TerraformProperty(name: "allow_self_management", @out: false, min: 0, max: 1)]
        public bool? @AllowSelfManagement { get; }

        [nterraform.Core.TerraformProperty(name: "ssh_public_key", @out: false, min: 0, max: 1)]
        public string @SshPublicKey { get; }
    }

}
