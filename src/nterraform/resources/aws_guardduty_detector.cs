using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_guardduty_detector")]
    public sealed class aws_guardduty_detector : nterraform.Core.resource
    {
        public aws_guardduty_detector(bool? @enable = null)
        {
            @Enable = @enable;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_id", @out: true, min: 0, max: 1)]
        public string @AccountId { get; }

        [nterraform.Core.TerraformProperty(name: "enable", @out: false, min: 0, max: 1)]
        public bool? @Enable { get; }
    }

}
