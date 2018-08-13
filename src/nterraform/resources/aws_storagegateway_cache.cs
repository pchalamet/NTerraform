using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_storagegateway_cache")]
    public sealed class aws_storagegateway_cache : nterraform.resource
    {
        public aws_storagegateway_cache(string @diskId,
                                        string @gatewayArn)
        {
            @DiskId = @diskId;
            @GatewayArn = @gatewayArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "disk_id", @out: false, min: 1, max: 1)]
        public string @DiskId { get; }

        [nterraform.TerraformProperty(name: "gateway_arn", @out: false, min: 1, max: 1)]
        public string @GatewayArn { get; }
    }

}
