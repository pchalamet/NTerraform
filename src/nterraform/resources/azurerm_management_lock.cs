using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_management_lock")]
    public sealed class azurerm_management_lock : nterraform.Core.resource
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "lock_level", @out: false, min: 1, max: 1)]
        public string @LockLevel { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [nterraform.Core.TerraformProperty(name: "notes", @out: false, min: 0, max: 1)]
        public string @Notes { get; }
    }

}
