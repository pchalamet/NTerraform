using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_config_aggregate_authorization")]
    public sealed class aws_config_aggregate_authorization : nterraform.resource
    {
        public aws_config_aggregate_authorization(string @accountId,
                                                  string @region)
        {
            @AccountId = @accountId;
            @Region = @region;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_id", @out: false, min: 1, max: 1)]
        public string @AccountId { get; }

        [nterraform.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
