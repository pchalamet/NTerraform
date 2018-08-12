using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_container_registry")]
    public sealed class azurerm_container_registry : nterraform.Core.data
    {
        public azurerm_container_registry(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "admin_enabled", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AdminEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "admin_password", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AdminPassword { get; }

        [nterraform.Core.TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AdminUsername { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "login_server", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @LoginServer { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @StorageAccountId { get; }
    }

}
