using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_azuread_application : NTerraform.data
    {
        public azurerm_azuread_application()
        {
        }

        public string @ApplicationId { get; }
        public bool? @AvailableToOtherTenants { get; }
        public string @Homepage { get; }
        public string[] @IdentifierUris { get; }
        public string @Name { get; }
        public bool? @Oauth2AllowImplicitFlow { get; }
        public string @ObjectId { get; }
        public string[] @ReplyUrls { get; }
    }

}
