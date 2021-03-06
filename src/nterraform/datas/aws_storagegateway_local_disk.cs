using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_storagegateway_local_disk")]
    public sealed class aws_storagegateway_local_disk : nterraform.data
    {
        public aws_storagegateway_local_disk(string @diskPath,
                                             string @gatewayArn)
        {
            @DiskPath = @diskPath;
            @GatewayArn = @gatewayArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "disk_path", @out: false, min: 1, max: 1)]
        public string @DiskPath { get; }

        [nterraform.TerraformProperty(name: "gateway_arn", @out: false, min: 1, max: 1)]
        public string @GatewayArn { get; }

        [nterraform.TerraformProperty(name: "disk_id", @out: true, min: 0, max: 1)]
        public string @DiskId { get; }
    }

}
