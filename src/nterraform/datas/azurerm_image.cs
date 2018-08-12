using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_image")]
    public sealed class azurerm_image : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "os_disk")]
        public sealed class os_disk : nterraform.Core.structure
        {
            public os_disk()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "blob_uri", @out: true, min: 0, max: 1)]
            public string @BlobUri { get; }

            [nterraform.Core.TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public string @Caching { get; }

            [nterraform.Core.TerraformProperty(name: "managed_disk_id", @out: true, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [nterraform.Core.TerraformProperty(name: "os_state", @out: true, min: 0, max: 1)]
            public string @OsState { get; }

            [nterraform.Core.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
            public string @OsType { get; }

            [nterraform.Core.TerraformProperty(name: "size_gb", @out: true, min: 0, max: 1)]
            public int? @SizeGb { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "data_disk")]
        public sealed class data_disk : nterraform.Core.structure
        {
            public data_disk()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "blob_uri", @out: true, min: 0, max: 1)]
            public string @BlobUri { get; }

            [nterraform.Core.TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public string @Caching { get; }

            [nterraform.Core.TerraformProperty(name: "lun", @out: true, min: 0, max: 1)]
            public int? @Lun { get; }

            [nterraform.Core.TerraformProperty(name: "managed_disk_id", @out: true, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [nterraform.Core.TerraformProperty(name: "size_gb", @out: true, min: 0, max: 1)]
            public int? @SizeGb { get; }
        }

        public azurerm_image(string @resourceGroupName,
                             data_disk[] @dataDisk = null,
                             string @name = null,
                             string @nameRegex = null,
                             os_disk[] @osDisk = null,
                             bool? @sortDescending = null)
        {
            @ResourceGroupName = @resourceGroupName;
            @DataDisk = @dataDisk;
            @Name = @name;
            @NameRegex = @nameRegex;
            @OsDisk = @osDisk;
            @SortDescending = @sortDescending;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "data_disk", @out: false, min: 0, max: 0)]
        public data_disk[] @DataDisk { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_regex", @out: false, min: 0, max: 1)]
        public string @NameRegex { get; }

        [nterraform.Core.TerraformProperty(name: "os_disk", @out: false, min: 0, max: 0)]
        public os_disk[] @OsDisk { get; }

        [nterraform.Core.TerraformProperty(name: "sort_descending", @out: false, min: 0, max: 1)]
        public bool? @SortDescending { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
