using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_azuread_application")]
    public sealed class azurerm_azuread_application : nterraform.Core.data
    {
        public azurerm_azuread_application()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "application_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ApplicationId { get; }

        [nterraform.Core.TerraformProperty(name: "available_to_other_tenants", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AvailableToOtherTenants { get; }

        [nterraform.Core.TerraformProperty(name: "homepage", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Homepage { get; }

        [nterraform.Core.TerraformProperty(name: "identifier_uris", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @IdentifierUris { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Name { get; }

        [nterraform.Core.TerraformProperty(name: "oauth2_allow_implicit_flow", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @Oauth2AllowImplicitFlow { get; }

        [nterraform.Core.TerraformProperty(name: "object_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ObjectId { get; }

        [nterraform.Core.TerraformProperty(name: "reply_urls", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @ReplyUrls { get; }
    }

}
