using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_organizations_organization")]
    public sealed class aws_organizations_organization : nterraform.Core.resource
    {
        public aws_organizations_organization(string @featureSet = null)
        {
            @FeatureSet = @featureSet;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "feature_set", @out: false, min: 0, max: 1)]
        public string @FeatureSet { get; }

        [nterraform.Core.TerraformProperty(name: "master_account_arn", @out: true, min: 0, max: 1)]
        public string @MasterAccountArn { get; }

        [nterraform.Core.TerraformProperty(name: "master_account_email", @out: true, min: 0, max: 1)]
        public string @MasterAccountEmail { get; }

        [nterraform.Core.TerraformProperty(name: "master_account_id", @out: true, min: 0, max: 1)]
        public string @MasterAccountId { get; }
    }

}
