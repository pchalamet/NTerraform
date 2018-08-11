using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_azuread_service_principal : NTerraform.data
    {
        public azurerm_azuread_service_principal()
        {
        }

        public string @ApplicationId { get; }
        public string @DisplayName { get; }
        public string @ObjectId { get; }
    }

}
