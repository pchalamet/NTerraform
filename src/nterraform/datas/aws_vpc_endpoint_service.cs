using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_vpc_endpoint_service")]
    public sealed class aws_vpc_endpoint_service : nterraform.data
    {
        public aws_vpc_endpoint_service(string @service = null)
        {
            @Service = @service;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "acceptance_required", @out: true, min: 0, max: 1)]
        public bool? @AcceptanceRequired { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "base_endpoint_dns_names", @out: true, min: 0, max: 1)]
        public string[] @BaseEndpointDnsNames { get; }

        [nterraform.TerraformProperty(name: "owner", @out: true, min: 0, max: 1)]
        public string @Owner { get; }

        [nterraform.TerraformProperty(name: "private_dns_name", @out: true, min: 0, max: 1)]
        public string @PrivateDnsName { get; }

        [nterraform.TerraformProperty(name: "service", @out: false, min: 0, max: 1)]
        public string @Service { get; }

        [nterraform.TerraformProperty(name: "service_name", @out: true, min: 0, max: 1)]
        public string @ServiceName { get; }

        [nterraform.TerraformProperty(name: "service_type", @out: true, min: 0, max: 1)]
        public string @ServiceType { get; }

        [nterraform.TerraformProperty(name: "vpc_endpoint_policy_supported", @out: true, min: 0, max: 1)]
        public bool? @VpcEndpointPolicySupported { get; }
    }

}
