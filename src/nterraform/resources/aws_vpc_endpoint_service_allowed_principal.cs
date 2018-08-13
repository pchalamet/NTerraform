using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_endpoint_service_allowed_principal")]
    public sealed class aws_vpc_endpoint_service_allowed_principal : nterraform.resource
    {
        public aws_vpc_endpoint_service_allowed_principal(string @principalArn,
                                                          string @vpcEndpointServiceId)
        {
            @PrincipalArn = @principalArn;
            @VpcEndpointServiceId = @vpcEndpointServiceId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "principal_arn", @out: false, min: 1, max: 1)]
        public string @PrincipalArn { get; }

        [nterraform.TerraformProperty(name: "vpc_endpoint_service_id", @out: false, min: 1, max: 1)]
        public string @VpcEndpointServiceId { get; }
    }

}
