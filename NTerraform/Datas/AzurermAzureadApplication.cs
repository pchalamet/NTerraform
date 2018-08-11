using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_azuread_application")]
    public sealed class azurerm_azuread_application : NTerraform.data
    {
        public azurerm_azuread_application()
        {
            base._validate_();
        }

        [TerraformProperty(name: "application_id", @out: true, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [TerraformProperty(name: "available_to_other_tenants", @out: true, min: 0, max: 1)]
        public bool? @AvailableToOtherTenants { get; }

        [TerraformProperty(name: "homepage", @out: true, min: 0, max: 1)]
        public string @Homepage { get; }

        [TerraformProperty(name: "identifier_uris", @out: true, min: 0, max: 1)]
        public string[] @IdentifierUris { get; }

        [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "oauth2_allow_implicit_flow", @out: true, min: 0, max: 1)]
        public bool? @Oauth2AllowImplicitFlow { get; }

        [TerraformProperty(name: "object_id", @out: true, min: 0, max: 1)]
        public string @ObjectId { get; }

        [TerraformProperty(name: "reply_urls", @out: true, min: 0, max: 1)]
        public string[] @ReplyUrls { get; }
    }

}
