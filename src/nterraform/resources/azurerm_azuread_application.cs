using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_azuread_application")]
    public sealed class azurerm_azuread_application : nterraform.resource
    {
        public azurerm_azuread_application(string @name,
                                           bool? @availableToOtherTenants = null,
                                           bool? @oauth2AllowImplicitFlow = null)
        {
            @Name = @name;
            @AvailableToOtherTenants = @availableToOtherTenants;
            @Oauth2AllowImplicitFlow = @oauth2AllowImplicitFlow;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "application_id", @out: true, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [nterraform.TerraformProperty(name: "available_to_other_tenants", @out: false, min: 0, max: 1)]
        public bool? @AvailableToOtherTenants { get; }

        [nterraform.TerraformProperty(name: "homepage", @out: true, min: 0, max: 1)]
        public string @Homepage { get; }

        [nterraform.TerraformProperty(name: "identifier_uris", @out: true, min: 0, max: 1)]
        public string[] @IdentifierUris { get; }

        [nterraform.TerraformProperty(name: "oauth2_allow_implicit_flow", @out: false, min: 0, max: 1)]
        public bool? @Oauth2AllowImplicitFlow { get; }

        [nterraform.TerraformProperty(name: "reply_urls", @out: true, min: 0, max: 1)]
        public string[] @ReplyUrls { get; }
    }

}
