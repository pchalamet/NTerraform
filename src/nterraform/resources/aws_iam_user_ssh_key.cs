using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_user_ssh_key")]
    public sealed class aws_iam_user_ssh_key : nterraform.Core.resource
    {
        public aws_iam_user_ssh_key(string @encoding,
                                    string @publicKey,
                                    string @username)
        {
            @Encoding = @encoding;
            @PublicKey = @publicKey;
            @Username = @username;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "encoding", @out: false, min: 1, max: 1)]
        public string @Encoding { get; }

        [nterraform.Core.TerraformProperty(name: "public_key", @out: false, min: 1, max: 1)]
        public string @PublicKey { get; }

        [nterraform.Core.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
        public string @Username { get; }

        [nterraform.Core.TerraformProperty(name: "fingerprint", @out: true, min: 0, max: 1)]
        public string @Fingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "ssh_public_key_id", @out: true, min: 0, max: 1)]
        public string @SshPublicKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
