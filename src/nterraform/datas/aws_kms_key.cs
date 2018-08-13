using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_kms_key")]
    public sealed class aws_kms_key : nterraform.Core.data
    {
        public aws_kms_key(string @keyId,
                           string[] @grantTokens = null)
        {
            @KeyId = @keyId;
            @GrantTokens = @grantTokens;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
        public string @KeyId { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "aws_account_id", @out: true, min: 0, max: 1)]
        public string @AwsAccountId { get; }

        [nterraform.Core.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.Core.TerraformProperty(name: "deletion_date", @out: true, min: 0, max: 1)]
        public string @DeletionDate { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "expiration_model", @out: true, min: 0, max: 1)]
        public string @ExpirationModel { get; }

        [nterraform.Core.TerraformProperty(name: "grant_tokens", @out: false, min: 0, max: 1)]
        public string[] @GrantTokens { get; }

        [nterraform.Core.TerraformProperty(name: "key_manager", @out: true, min: 0, max: 1)]
        public string @KeyManager { get; }

        [nterraform.Core.TerraformProperty(name: "key_state", @out: true, min: 0, max: 1)]
        public string @KeyState { get; }

        [nterraform.Core.TerraformProperty(name: "key_usage", @out: true, min: 0, max: 1)]
        public string @KeyUsage { get; }

        [nterraform.Core.TerraformProperty(name: "origin", @out: true, min: 0, max: 1)]
        public string @Origin { get; }

        [nterraform.Core.TerraformProperty(name: "valid_to", @out: true, min: 0, max: 1)]
        public string @ValidTo { get; }
    }

}
