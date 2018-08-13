using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cognito_identity_provider")]
    public sealed class aws_cognito_identity_provider : nterraform.Core.resource
    {
        public aws_cognito_identity_provider(Dictionary<string,string> @providerDetails,
                                             string @providerName,
                                             string @providerType,
                                             string @userPoolId,
                                             Dictionary<string,string> @attributeMapping = null,
                                             string[] @idpIdentifiers = null)
        {
            @ProviderDetails = @providerDetails;
            @ProviderName = @providerName;
            @ProviderType = @providerType;
            @UserPoolId = @userPoolId;
            @AttributeMapping = @attributeMapping;
            @IdpIdentifiers = @idpIdentifiers;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "provider_details", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @ProviderDetails { get; }

        [nterraform.Core.TerraformProperty(name: "provider_name", @out: false, min: 1, max: 1)]
        public string @ProviderName { get; }

        [nterraform.Core.TerraformProperty(name: "provider_type", @out: false, min: 1, max: 1)]
        public string @ProviderType { get; }

        [nterraform.Core.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
        public string @UserPoolId { get; }

        [nterraform.Core.TerraformProperty(name: "attribute_mapping", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @AttributeMapping { get; }

        [nterraform.Core.TerraformProperty(name: "idp_identifiers", @out: false, min: 0, max: 1)]
        public string[] @IdpIdentifiers { get; }
    }

}