using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_saml_provider")]
    public sealed class aws_iam_saml_provider : nterraform.resource
    {
        public aws_iam_saml_provider(string @name,
                                     string @samlMetadataDocument)
        {
            @Name = @name;
            @SamlMetadataDocument = @samlMetadataDocument;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "saml_metadata_document", @out: false, min: 1, max: 1)]
        public string @SamlMetadataDocument { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "valid_until", @out: true, min: 0, max: 1)]
        public string @ValidUntil { get; }
    }

}
