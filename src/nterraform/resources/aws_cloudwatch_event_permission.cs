using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_event_permission")]
    public sealed class aws_cloudwatch_event_permission : nterraform.Core.resource
    {
        public aws_cloudwatch_event_permission(string @principal,
                                               string @statementId,
                                               string @action = null)
        {
            @Principal = @principal;
            @StatementId = @statementId;
            @Action = @action;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "principal", @out: false, min: 1, max: 1)]
        public string @Principal { get; }

        [nterraform.Core.TerraformProperty(name: "statement_id", @out: false, min: 1, max: 1)]
        public string @StatementId { get; }

        [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
        public string @Action { get; }
    }

}