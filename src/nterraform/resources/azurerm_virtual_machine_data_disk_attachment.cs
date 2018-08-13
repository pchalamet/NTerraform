using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_data_disk_attachment")]
    public sealed class azurerm_virtual_machine_data_disk_attachment : nterraform.resource
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

        [nterraform.TerraformProperty(name: "caching", @out: false, min: 1, max: 1)]
        public string @Caching { get; }

        [nterraform.TerraformProperty(name: "lun", @out: false, min: 1, max: 1)]
        public int @Lun { get; }

        [nterraform.TerraformProperty(name: "managed_disk_id", @out: false, min: 1, max: 1)]
        public string @ManagedDiskId { get; }

        [nterraform.TerraformProperty(name: "virtual_machine_id", @out: false, min: 1, max: 1)]
        public string @VirtualMachineId { get; }

        [nterraform.TerraformProperty(name: "create_option", @out: false, min: 0, max: 1)]
        public string @CreateOption { get; }

        [nterraform.TerraformProperty(name: "write_accelerator_enabled", @out: false, min: 0, max: 1)]
        public bool? @WriteAcceleratorEnabled { get; }
    }

}
