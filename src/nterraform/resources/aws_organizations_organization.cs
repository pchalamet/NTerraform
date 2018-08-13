using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_organizations_organization")]
    public sealed class aws_organizations_organization : nterraform.resource
    {
        public aws_organizations_organization(string @featureSet = null)
        {
            @FeatureSet = @featureSet;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "feature_set", @out: false, min: 0, max: 1)]
        public string @FeatureSet { get; }

        [nterraform.TerraformProperty(name: "master_account_arn", @out: true, min: 0, max: 1)]
        public string @MasterAccountArn { get; }

        [nterraform.TerraformProperty(name: "master_account_email", @out: true, min: 0, max: 1)]
        public string @MasterAccountEmail { get; }

        [nterraform.TerraformProperty(name: "master_account_id", @out: true, min: 0, max: 1)]
        public string @MasterAccountId { get; }
    }

}
