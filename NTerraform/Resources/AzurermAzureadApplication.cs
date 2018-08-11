using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_azuread_application : NTerraform.resource
    {
        public azurerm_azuread_application(string @name,
                                           bool? @availableToOtherTenants = null,
                                           bool? @oauth2AllowImplicitFlow = null)
        {
            @Name = @name;
            @AvailableToOtherTenants = @availableToOtherTenants;
            @Oauth2AllowImplicitFlow = @oauth2AllowImplicitFlow;
        }

        public string @Name { get; }
        public string @ApplicationId { get; }
        public bool? @AvailableToOtherTenants { get; }
        public string @Homepage { get; }
        public string[] @IdentifierUris { get; }
        public bool? @Oauth2AllowImplicitFlow { get; }
        public string[] @ReplyUrls { get; }
    }

}
