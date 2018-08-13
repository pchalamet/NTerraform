using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_kms_ciphertext")]
    public sealed class aws_kms_ciphertext : nterraform.data
    {
        public aws_kms_ciphertext(string @keyId,
                                  string @plaintext,
                                  Dictionary<string,string> @context = null)
        {
            @KeyId = @keyId;
            @Plaintext = @plaintext;
            @Context = @context;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
        public string @KeyId { get; }

        [nterraform.TerraformProperty(name: "plaintext", @out: false, min: 1, max: 1)]
        public string @Plaintext { get; }

        [nterraform.TerraformProperty(name: "ciphertext_blob", @out: true, min: 0, max: 1)]
        public string @CiphertextBlob { get; }

        [nterraform.TerraformProperty(name: "context", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Context { get; }
    }

}
