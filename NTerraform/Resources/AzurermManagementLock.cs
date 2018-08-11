using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @LockLevel { get; }
        public string @Name { get; }
        public string @Scope { get; }
        public string @Notes { get; }
    }

}
