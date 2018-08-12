using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_data_disk_attachment")]
    public sealed class azurerm_virtual_machine_data_disk_attachment : nterraform.Core.resource
    {
        public azurerm_virtual_machine_data_disk_attachment(string @caching,
                                                            int @lun,
                                                            string @managedDiskId,
                                                            string @virtualMachineId,
                                                            string @createOption = null,
                                                            bool? @writeAcceleratorEnabled = null)
        {
            @Caching = @caching;
            @Lun = @lun;
            @ManagedDiskId = @managedDiskId;
            @VirtualMachineId = @virtualMachineId;
            @CreateOption = @createOption;
            @WriteAcceleratorEnabled = @writeAcceleratorEnabled;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "caching", @out: false, min: 1, max: 1)]
        public string @Caching { get; }

        [nterraform.Core.TerraformProperty(name: "lun", @out: false, min: 1, max: 1)]
        public int @Lun { get; }

        [nterraform.Core.TerraformProperty(name: "managed_disk_id", @out: false, min: 1, max: 1)]
        public string @ManagedDiskId { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_machine_id", @out: false, min: 1, max: 1)]
        public string @VirtualMachineId { get; }

        [nterraform.Core.TerraformProperty(name: "create_option", @out: false, min: 0, max: 1)]
        public string @CreateOption { get; }

        [nterraform.Core.TerraformProperty(name: "write_accelerator_enabled", @out: false, min: 0, max: 1)]
        public bool? @WriteAcceleratorEnabled { get; }
    }

}
