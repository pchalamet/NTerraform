using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_kms_grant")]
    public sealed class aws_kms_grant : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "constraints")]
        public sealed class constraints : nterraform.structure
        {
            public constraints(Dictionary<string,string> @encryptionContextEquals = null,
                               Dictionary<string,string> @encryptionContextSubset = null)
            {
                @EncryptionContextEquals = @encryptionContextEquals;
                @EncryptionContextSubset = @encryptionContextSubset;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "encryption_context_equals", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @EncryptionContextEquals { get; }

            [nterraform.TerraformProperty(name: "encryption_context_subset", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @EncryptionContextSubset { get; }
        }

        public aws_kms_grant(string @granteePrincipal,
                             string @keyId,
                             string[] @operations,
                             constraints[] @constraints = null,
                             string[] @grantCreationTokens = null,
                             string @name = null,
                             bool? @retireOnDelete = null,
                             string @retiringPrincipal = null)
        {
            @GranteePrincipal = @granteePrincipal;
            @KeyId = @keyId;
            @Operations = @operations;
            @Constraints = @constraints;
            @GrantCreationTokens = @grantCreationTokens;
            @Name = @name;
            @RetireOnDelete = @retireOnDelete;
            @RetiringPrincipal = @retiringPrincipal;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "grantee_principal", @out: false, min: 1, max: 1)]
        public string @GranteePrincipal { get; }

        [nterraform.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
        public string @KeyId { get; }

        [nterraform.TerraformProperty(name: "operations", @out: false, min: 1, max: 1)]
        public string[] @Operations { get; }

        [nterraform.TerraformProperty(name: "constraints", @out: false, min: 0, max: 0)]
        public constraints[] @Constraints { get; }

        [nterraform.TerraformProperty(name: "grant_creation_tokens", @out: false, min: 0, max: 1)]
        public string[] @GrantCreationTokens { get; }

        [nterraform.TerraformProperty(name: "grant_id", @out: true, min: 0, max: 1)]
        public string @GrantId { get; }

        [nterraform.TerraformProperty(name: "grant_token", @out: true, min: 0, max: 1)]
        public string @GrantToken { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "retire_on_delete", @out: false, min: 0, max: 1)]
        public bool? @RetireOnDelete { get; }

        [nterraform.TerraformProperty(name: "retiring_principal", @out: false, min: 0, max: 1)]
        public string @RetiringPrincipal { get; }
    }

}
