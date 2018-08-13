using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_kms_key")]
    public sealed class aws_kms_key : nterraform.data
    {
        public aws_kms_key(string @keyId,
                           string[] @grantTokens = null)
        {
            @KeyId = @keyId;
            @GrantTokens = @grantTokens;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
        public string @KeyId { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "aws_account_id", @out: true, min: 0, max: 1)]
        public string @AwsAccountId { get; }

        [nterraform.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.TerraformProperty(name: "deletion_date", @out: true, min: 0, max: 1)]
        public string @DeletionDate { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "expiration_model", @out: true, min: 0, max: 1)]
        public string @ExpirationModel { get; }

        [nterraform.TerraformProperty(name: "grant_tokens", @out: false, min: 0, max: 1)]
        public string[] @GrantTokens { get; }

        [nterraform.TerraformProperty(name: "key_manager", @out: true, min: 0, max: 1)]
        public string @KeyManager { get; }

        [nterraform.TerraformProperty(name: "key_state", @out: true, min: 0, max: 1)]
        public string @KeyState { get; }

        [nterraform.TerraformProperty(name: "key_usage", @out: true, min: 0, max: 1)]
        public string @KeyUsage { get; }

        [nterraform.TerraformProperty(name: "origin", @out: true, min: 0, max: 1)]
        public string @Origin { get; }

        [nterraform.TerraformProperty(name: "valid_to", @out: true, min: 0, max: 1)]
        public string @ValidTo { get; }
    }

}
