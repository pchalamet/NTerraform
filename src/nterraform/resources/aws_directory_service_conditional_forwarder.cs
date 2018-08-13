using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_directory_service_conditional_forwarder")]
    public sealed class aws_directory_service_conditional_forwarder : nterraform.Core.resource
    {
        public aws_directory_service_conditional_forwarder(string @directoryId,
                                                           string[] @dnsIps,
                                                           string @remoteDomainName)
        {
            @DirectoryId = @directoryId;
            @DnsIps = @dnsIps;
            @RemoteDomainName = @remoteDomainName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "directory_id", @out: false, min: 1, max: 1)]
        public string @DirectoryId { get; }

        [nterraform.Core.TerraformProperty(name: "dns_ips", @out: false, min: 1, max: 1)]
        public string[] @DnsIps { get; }

        [nterraform.Core.TerraformProperty(name: "remote_domain_name", @out: false, min: 1, max: 1)]
        public string @RemoteDomainName { get; }
    }

}
