using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_endpoint_service")]
    public sealed class aws_vpc_endpoint_service : nterraform.resource
    {
        public aws_vpc_endpoint_service(bool @acceptanceRequired,
                                        string[] @networkLoadBalancerArns)
        {
            @AcceptanceRequired = @acceptanceRequired;
            @NetworkLoadBalancerArns = @networkLoadBalancerArns;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "acceptance_required", @out: false, min: 1, max: 1)]
        public bool @AcceptanceRequired { get; }

        [nterraform.TerraformProperty(name: "network_load_balancer_arns", @out: false, min: 1, max: 1)]
        public string[] @NetworkLoadBalancerArns { get; }

        [nterraform.TerraformProperty(name: "allowed_principals", @out: true, min: 0, max: 1)]
        public string[] @AllowedPrincipals { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "base_endpoint_dns_names", @out: true, min: 0, max: 1)]
        public string[] @BaseEndpointDnsNames { get; }

        [nterraform.TerraformProperty(name: "private_dns_name", @out: true, min: 0, max: 1)]
        public string @PrivateDnsName { get; }

        [nterraform.TerraformProperty(name: "service_name", @out: true, min: 0, max: 1)]
        public string @ServiceName { get; }

        [nterraform.TerraformProperty(name: "service_type", @out: true, min: 0, max: 1)]
        public string @ServiceType { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }
    }

}
