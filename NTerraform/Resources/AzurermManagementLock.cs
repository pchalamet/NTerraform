using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_management_lock")]
    public sealed class azurerm_management_lock : NTerraform.resource
    {
        public azurerm_management_lock(string @lockLevel,
                                       string @name,
                                       string @scope,
                                       string @notes = null)
        {
            @LockLevel = @lockLevel;
            @Name = @name;
            @Scope = @scope;
            @Notes = @notes;
        }

        [TerraformProperty(name: "lock_level", @out: false, min: 1, max: 1)]
        public string @LockLevel { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [TerraformProperty(name: "notes", @out: false, min: 0, max: 1)]
        public string @Notes { get; }
    }

}
