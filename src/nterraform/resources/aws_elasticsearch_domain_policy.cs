using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elasticsearch_domain_policy")]
    public sealed class aws_elasticsearch_domain_policy : nterraform.Core.resource
    {
        public aws_elasticsearch_domain_policy(string @accessPolicies,
                                               string @domainName)
        {
            @AccessPolicies = @accessPolicies;
            @DomainName = @domainName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "access_policies", @out: false, min: 1, max: 1)]
        public string @AccessPolicies { get; }

        [nterraform.Core.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }
    }

}
