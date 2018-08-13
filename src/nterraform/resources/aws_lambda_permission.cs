using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lambda_permission")]
    public sealed class aws_lambda_permission : nterraform.Core.resource
    {
        public aws_lambda_permission(string @action,
                                     string @functionName,
                                     string @principal,
                                     string @eventSourceToken = null,
                                     string @qualifier = null,
                                     string @sourceAccount = null,
                                     string @sourceArn = null,
                                     string @statementIdPrefix = null)
        {
            @Action = @action;
            @FunctionName = @functionName;
            @Principal = @principal;
            @EventSourceToken = @eventSourceToken;
            @Qualifier = @qualifier;
            @SourceAccount = @sourceAccount;
            @SourceArn = @sourceArn;
            @StatementIdPrefix = @statementIdPrefix;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
        public string @Action { get; }

        [nterraform.Core.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.Core.TerraformProperty(name: "principal", @out: false, min: 1, max: 1)]
        public string @Principal { get; }

        [nterraform.Core.TerraformProperty(name: "event_source_token", @out: false, min: 0, max: 1)]
        public string @EventSourceToken { get; }

        [nterraform.Core.TerraformProperty(name: "qualifier", @out: false, min: 0, max: 1)]
        public string @Qualifier { get; }

        [nterraform.Core.TerraformProperty(name: "source_account", @out: false, min: 0, max: 1)]
        public string @SourceAccount { get; }

        [nterraform.Core.TerraformProperty(name: "source_arn", @out: false, min: 0, max: 1)]
        public string @SourceArn { get; }

        [nterraform.Core.TerraformProperty(name: "statement_id", @out: true, min: 0, max: 1)]
        public string @StatementId { get; }

        [nterraform.Core.TerraformProperty(name: "statement_id_prefix", @out: false, min: 0, max: 1)]
        public string @StatementIdPrefix { get; }
    }

}
